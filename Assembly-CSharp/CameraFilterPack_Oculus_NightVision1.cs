using System;
using UnityEngine;

// Token: 0x020000FA RID: 250
[AddComponentMenu("Camera Filter Pack/Night Vision/Night Vision 1")]
[ExecuteInEditMode]
public class CameraFilterPack_Oculus_NightVision1 : MonoBehaviour
{
	// Token: 0x170000DF RID: 223
	// (get) Token: 0x06004DBB RID: 19899 RVA: 0x00182FAE File Offset: 0x001811AE
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

	// Token: 0x06004DBC RID: 19900 RVA: 0x00182FE8 File Offset: 0x001811E8
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1589f)
			{
				this.HBJJOCHGOPH = 1695f;
			}
			this.CFEDGDGBCHE().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat("\" gets executed locally only, if at all.", this.GAMMLIDAPPF);
			this.IGIAPKPKGPK().SetVector("\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 901f, 362f));
			this.MMOODGIODPC().SetFloat("curScn", this.Vignette);
			this.OIIDAKBILMI().SetFloat("workshop.", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DBD RID: 19901 RVA: 0x001830D1 File Offset: 0x001812D1
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("'{0}' \t{1}ms \t{2}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004DBE RID: 19902 RVA: 0x001830F5 File Offset: 0x001812F5
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004DBF RID: 19903 RVA: 0x0018312C File Offset: 0x0018132C
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("Hidden/DepthOfField/DepthOfField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004DC0 RID: 19904 RVA: 0x00183150 File Offset: 0x00181350
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004DC1 RID: 19905 RVA: 0x00183170 File Offset: 0x00181370
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1759f)
			{
				this.HBJJOCHGOPH = 1989f;
			}
			this.LONNIJMNKFB().SetFloat("http", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetFloat("[PlayerBase] Ready", this.GAMMLIDAPPF);
			this.OIMMPLPBLBK().SetVector("#random #rare #item", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 593f, 1843f));
			this.IGIAPKPKGPK().SetFloat("Missing shader for image effect {0}", this.Vignette);
			this.NBPKMLMCHFN.SetFloat("Left Stick Click", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DC2 RID: 19906 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06004DC3 RID: 19907 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06004DC4 RID: 19908 RVA: 0x00183150 File Offset: 0x00181350
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004DC5 RID: 19909 RVA: 0x00183259 File Offset: 0x00181459
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Multiply");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004DC6 RID: 19910 RVA: 0x0018327D File Offset: 0x0018147D
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004DC7 RID: 19911 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06004DC8 RID: 19912 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x06004DC9 RID: 19913 RVA: 0x001832B4 File Offset: 0x001814B4
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 144f)
			{
				this.HBJJOCHGOPH = 158f;
			}
			this.FAIFBBGFAIB().SetFloat("_Value", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Drawing_Comics", this.GAMMLIDAPPF);
			this.CFEDGDGBCHE().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1775f, 987f));
			this.MMOODGIODPC().SetFloat("[MenuScene] Error: ", this.Vignette);
			this.LONNIJMNKFB().SetFloat("InfoCanvas", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DCA RID: 19914 RVA: 0x0018339D File Offset: 0x0018159D
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004DCB RID: 19915 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06004DCC RID: 19916 RVA: 0x001833D4 File Offset: 0x001815D4
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("Crosshair1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004DCD RID: 19917 RVA: 0x001833F8 File Offset: 0x001815F8
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1765f)
			{
				this.HBJJOCHGOPH = 1692f;
			}
			this.CFEDGDGBCHE().SetFloat(" cannot be used as a 3D LUT.", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("_Value6", this.GAMMLIDAPPF);
			this.MMOODGIODPC().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 413f, 925f));
			this.IGIAPKPKGPK().SetFloat("#,0.00", this.Vignette);
			this.DBOLLHHMKKN().SetFloat("MusicFileSelector", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DCE RID: 19918 RVA: 0x001834E4 File Offset: 0x001816E4
	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1827f)
			{
				this.HBJJOCHGOPH = 757f;
			}
			this.DNLMFEGJJDD().SetFloat("_Axis", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("pointBuffer", this.GAMMLIDAPPF);
			this.OIMMPLPBLBK().SetVector("_FixDistance", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 139f, 11f));
			this.MMOODGIODPC().SetFloat(" canvas not found", this.Vignette);
			this.NFMGLIKNOOC().SetFloat("_Value2", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DCF RID: 19919 RVA: 0x001835CD File Offset: 0x001817CD
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("Item ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004DD0 RID: 19920 RVA: 0x001835F4 File Offset: 0x001817F4
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 45f)
			{
				this.HBJJOCHGOPH = 1243f;
			}
			this.HCGJCMDJPGD().SetFloat("Case-Sensitive", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("isVisible", this.GAMMLIDAPPF);
			this.OIMMPLPBLBK().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1910f, 1594f));
			this.KBOPGONOCNP().SetFloat("en", this.Vignette);
			this.OIIDAKBILMI().SetFloat("Add Environment Object", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DD1 RID: 19921 RVA: 0x001836E0 File Offset: 0x001818E0
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1360f)
			{
				this.HBJJOCHGOPH = 145f;
			}
			this.LONNIJMNKFB().SetFloat("_Offsets", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("maxScore", this.GAMMLIDAPPF);
			this.MLMKCOINOOH().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1915f, 1229f));
			this.OIMMPLPBLBK().SetFloat("ItemNameText", this.Vignette);
			this.NJDIODJNGGA().SetFloat("RequestForPickupItems", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DD2 RID: 19922 RVA: 0x00183150 File Offset: 0x00181350
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004DD3 RID: 19923 RVA: 0x001837CC File Offset: 0x001819CC
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 598f)
			{
				this.HBJJOCHGOPH = 1182f;
			}
			this.MCDGIILBNIF().SetFloat("BackButton", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("PLEASE WAIT", this.GAMMLIDAPPF);
			this.DNLMFEGJJDD().SetVector("CameraFilterPack/Blend2Camera_Darken", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1927f, 893f));
			this.MLMKCOINOOH().SetFloat("_Green_G", this.Vignette);
			this.MLMKCOINOOH().SetFloat("No player left to ask", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DD5 RID: 19925 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x06004DD6 RID: 19926 RVA: 0x001838EC File Offset: 0x00181AEC
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1761f)
			{
				this.HBJJOCHGOPH = 1822f;
			}
			this.CFEDGDGBCHE().SetFloat("Children", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("CameraFilterPack/Distortion_BlackHole", this.GAMMLIDAPPF);
			this.IGIAPKPKGPK().SetVector("Authentication failed: '{0}' Code: {1}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1679f, 102f));
			this.MMOODGIODPC().SetFloat("open", this.Vignette);
			this.CFEDGDGBCHE().SetFloat("_Value7", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DD7 RID: 19927 RVA: 0x001839D5 File Offset: 0x00181BD5
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004DD8 RID: 19928 RVA: 0x001839F9 File Offset: 0x00181BF9
	private void HDMDKOKOOJC()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004DD9 RID: 19929 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06004DDA RID: 19930 RVA: 0x00183A1D File Offset: 0x00181C1D
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("challenges.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004DDB RID: 19931 RVA: 0x00183A41 File Offset: 0x00181C41
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004DDC RID: 19932 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x06004DDD RID: 19933 RVA: 0x00183A78 File Offset: 0x00181C78
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004DDE RID: 19934 RVA: 0x00183150 File Offset: 0x00181350
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004DDF RID: 19935 RVA: 0x00183AB0 File Offset: 0x00181CB0
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 128f)
			{
				this.HBJJOCHGOPH = 437f;
			}
			this.IGIAPKPKGPK().SetFloat("[MapsData] Bad map: ", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("_Blue_R", this.GAMMLIDAPPF);
			this.MLMKCOINOOH().SetVector("JoinTeam was called in state: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 131f, 45f));
			this.LONNIJMNKFB().SetFloat("ok", this.Vignette);
			this.MLMKCOINOOH().SetFloat("_BlurRadius4", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DE0 RID: 19936 RVA: 0x00183B99 File Offset: 0x00181D99
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004DE1 RID: 19937 RVA: 0x00183150 File Offset: 0x00181350
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004DE2 RID: 19938 RVA: 0x00183150 File Offset: 0x00181350
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004DE3 RID: 19939 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06004DE4 RID: 19940 RVA: 0x00183BD0 File Offset: 0x00181DD0
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004DE5 RID: 19941 RVA: 0x00183C07 File Offset: 0x00181E07
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("_FixDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004DE6 RID: 19942 RVA: 0x00183150 File Offset: 0x00181350
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004DE7 RID: 19943 RVA: 0x00183C2C File Offset: 0x00181E2C
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1231f)
			{
				this.HBJJOCHGOPH = 868f;
			}
			this.MMOODGIODPC().SetFloat(".lastCheckpoint.penaltyScore", this.HBJJOCHGOPH);
			this.FAIFBBGFAIB().SetFloat(" has no method \"", this.GAMMLIDAPPF);
			this.LONNIJMNKFB().SetVector(".completed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1554f, 325f));
			this.IGIAPKPKGPK().SetFloat("#tryagain", this.Vignette);
			this.MMOODGIODPC().SetFloat("#onrankchangeuptext", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DE8 RID: 19944 RVA: 0x00183150 File Offset: 0x00181350
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004DE9 RID: 19945 RVA: 0x00183D15 File Offset: 0x00181F15
	private void JECMJNFGBGC()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004DEA RID: 19946 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x06004DEB RID: 19947 RVA: 0x00183D39 File Offset: 0x00181F39
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Oculus_NightVision1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004DEC RID: 19948 RVA: 0x00183D60 File Offset: 0x00181F60
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1871f)
			{
				this.HBJJOCHGOPH = 40f;
			}
			this.NBPKMLMCHFN.SetFloat("MapperNameText", this.HBJJOCHGOPH);
			this.MLMKCOINOOH().SetFloat("_TimeX", this.GAMMLIDAPPF);
			this.CFEDGDGBCHE().SetVector("_DiffuseColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 194f, 650f));
			this.IGIAPKPKGPK().SetFloat("No Description", this.Vignette);
			this.KBOPGONOCNP().SetFloat("CameraFilterPack_OldFilm2", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DED RID: 19949 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x06004DEE RID: 19950 RVA: 0x00183E4C File Offset: 0x0018204C
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1453f)
			{
				this.HBJJOCHGOPH = 463f;
			}
			this.MCDGIILBNIF().SetFloat("Items", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("_MainTex", this.GAMMLIDAPPF);
			this.DBOLLHHMKKN().SetVector("Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1128f, 1619f));
			this.OIMMPLPBLBK().SetFloat("_Value2", this.Vignette);
			this.NFMGLIKNOOC().SetFloat("[MapEditor] Item creation successful! Published Item ID: ", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DEF RID: 19951 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06004DF0 RID: 19952 RVA: 0x00183F35 File Offset: 0x00182135
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004DF1 RID: 19953 RVA: 0x00183F6C File Offset: 0x0018216C
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 545f)
			{
				this.HBJJOCHGOPH = 1311f;
			}
			this.NJDIODJNGGA().SetFloat("challengeid", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("_TimeX", this.GAMMLIDAPPF);
			this.HCGJCMDJPGD().SetVector("Room: '{0}' {1},{2} {4}/{3} players.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 126f, 516f));
			this.DBOLLHHMKKN().SetFloat("#{0:X2}{1:X2}{2:X2}", this.Vignette);
			this.CFEDGDGBCHE().SetFloat("_FixDistance", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DF2 RID: 19954 RVA: 0x00184055 File Offset: 0x00182255
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004DF3 RID: 19955 RVA: 0x0018407C File Offset: 0x0018227C
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 361f)
			{
				this.HBJJOCHGOPH = 1018f;
			}
			this.NBPKMLMCHFN.SetFloat("GhostFade", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("Please define the RectTransform for the Center viewport of the scrollable area", this.GAMMLIDAPPF);
			this.LONNIJMNKFB().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 532f, 221f));
			this.HCGJCMDJPGD().SetFloat("_MainTex2", this.Vignette);
			this.KBOPGONOCNP().SetFloat("#close", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DF4 RID: 19956 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06004DF5 RID: 19957 RVA: 0x00184168 File Offset: 0x00182368
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1025f)
			{
				this.HBJJOCHGOPH = 1135f;
			}
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Glasses_On", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("SetParticlesInput", this.GAMMLIDAPPF);
			this.IGIAPKPKGPK().SetVector("_Green_C", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1657f, 294f));
			this.GKILCDHJFEG().SetFloat("Items", this.Vignette);
			this.MCDGIILBNIF().SetFloat(" ", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DF6 RID: 19958 RVA: 0x00184251 File Offset: 0x00182451
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004DF7 RID: 19959 RVA: 0x00184288 File Offset: 0x00182488
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("[ItemsHandler] Found ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004DF8 RID: 19960 RVA: 0x001842AC File Offset: 0x001824AC
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("Tab1Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004DF9 RID: 19961 RVA: 0x001842D0 File Offset: 0x001824D0
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004DFA RID: 19962 RVA: 0x00183150 File Offset: 0x00181350
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004DFB RID: 19963 RVA: 0x00184308 File Offset: 0x00182508
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 486f)
			{
				this.HBJJOCHGOPH = 1491f;
			}
			this.FAIFBBGFAIB().SetFloat("targetColor", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("_Value6", this.GAMMLIDAPPF);
			this.NJDIODJNGGA().SetVector("Bad parameters for reset! Use \"reset <challengeid>\"", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1094f, 632f));
			this.NBPKMLMCHFN.SetFloat("Mouse1", this.Vignette);
			this.OIMMPLPBLBK().SetFloat("_MatrixColor", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DFC RID: 19964 RVA: 0x001843F1 File Offset: 0x001825F1
	private void HJPCJGOEKMF()
	{
		this.SCShader = Shader.Find("menutheme.deleted");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004DFD RID: 19965 RVA: 0x00184418 File Offset: 0x00182618
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1967f)
			{
				this.HBJJOCHGOPH = 609f;
			}
			this.CFEDGDGBCHE().SetFloat("_ColoredChange", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetFloat("SaveButton", this.GAMMLIDAPPF);
			this.MMOODGIODPC().SetVector("CameraFilterPack_TV_HorrorFX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1487f, 238f));
			this.DBOLLHHMKKN().SetFloat("CameraFilterPack/FX_Scan", this.Vignette);
			this.OIMMPLPBLBK().SetFloat("SearchTex", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DFE RID: 19966 RVA: 0x00184504 File Offset: 0x00182704
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1939f)
			{
				this.HBJJOCHGOPH = 212f;
			}
			this.IGIAPKPKGPK().SetFloat("float", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("setbool", this.GAMMLIDAPPF);
			this.OIMMPLPBLBK().SetVector(" Message: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 233f, 86f));
			this.MLMKCOINOOH().SetFloat("_Value12", this.Vignette);
			this.DNLMFEGJJDD().SetFloat("#availablechallenges", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004DFF RID: 19967 RVA: 0x001845ED File Offset: 0x001827ED
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find("Tab1Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004E00 RID: 19968 RVA: 0x00184611 File Offset: 0x00182811
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004E01 RID: 19969 RVA: 0x00184638 File Offset: 0x00182838
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1636f)
			{
				this.HBJJOCHGOPH = 1334f;
			}
			this.IGIAPKPKGPK().SetFloat("_Amount", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("System.Int32", this.GAMMLIDAPPF);
			this.NBPKMLMCHFN.SetVector("[ImageLoader] Loaded image from ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1333f, 917f));
			this.IGIAPKPKGPK().SetFloat("settings.hitvariation", this.Vignette);
			this.GKILCDHJFEG().SetFloat("#scoresubmitionfailed: ", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E02 RID: 19970 RVA: 0x00184721 File Offset: 0x00182921
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E03 RID: 19971 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06004E04 RID: 19972 RVA: 0x00184758 File Offset: 0x00182958
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 485f)
			{
				this.HBJJOCHGOPH = 214f;
			}
			this.LONNIJMNKFB().SetFloat("maps.", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("Failed!", this.GAMMLIDAPPF);
			this.MCDGIILBNIF().SetVector("Add Environment Sprite", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 419f, 533f));
			this.MMOODGIODPC().SetFloat("_Amount", this.Vignette);
			this.NFMGLIKNOOC().SetFloat("float,1", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E05 RID: 19973 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06004E06 RID: 19974 RVA: 0x00184841 File Offset: 0x00182A41
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("shader.frost");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004E07 RID: 19975 RVA: 0x00183150 File Offset: 0x00181350
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004E08 RID: 19976 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06004E09 RID: 19977 RVA: 0x00184868 File Offset: 0x00182A68
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1924f)
			{
				this.HBJJOCHGOPH = 535f;
			}
			this.DNLMFEGJJDD().SetFloat("[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetFloat("Please specify either t or f.", this.GAMMLIDAPPF);
			this.MLMKCOINOOH().SetVector("[", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 342f, 1583f));
			this.IGIAPKPKGPK().SetFloat("ComboScoreText", this.Vignette);
			this.FAIFBBGFAIB().SetFloat("Cant ask anyone else for PickupItem spawn times.", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E0A RID: 19978 RVA: 0x00184951 File Offset: 0x00182B51
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find("#E14FFF");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004E0B RID: 19979 RVA: 0x00184978 File Offset: 0x00182B78
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
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.GAMMLIDAPPF);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			this.NBPKMLMCHFN.SetFloat("_Vignette", this.Vignette);
			this.NBPKMLMCHFN.SetFloat("_Linecount", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E0C RID: 19980 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06004E0D RID: 19981 RVA: 0x00184A64 File Offset: 0x00182C64
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 979f)
			{
				this.HBJJOCHGOPH = 1584f;
			}
			this.HCGJCMDJPGD().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("_TimeX", this.GAMMLIDAPPF);
			this.DNLMFEGJJDD().SetVector("_DistortionSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 915f, 792f));
			this.NFMGLIKNOOC().SetFloat("_Value2", this.Vignette);
			this.IGIAPKPKGPK().SetFloat("_Distortion", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E0E RID: 19982 RVA: 0x00184B4D File Offset: 0x00182D4D
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E0F RID: 19983 RVA: 0x00184B84 File Offset: 0x00182D84
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E10 RID: 19984 RVA: 0x00184BBB File Offset: 0x00182DBB
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E11 RID: 19985 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x06004E12 RID: 19986 RVA: 0x00184BF2 File Offset: 0x00182DF2
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("cancel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004E13 RID: 19987 RVA: 0x00183150 File Offset: 0x00181350
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004E14 RID: 19988 RVA: 0x00184C16 File Offset: 0x00182E16
	private Material MLMKCOINOOH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E15 RID: 19989 RVA: 0x00183D39 File Offset: 0x00181F39
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Oculus_NightVision1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004E16 RID: 19990 RVA: 0x00184C50 File Offset: 0x00182E50
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 184f)
			{
				this.HBJJOCHGOPH = 1017f;
			}
			this.DBOLLHHMKKN().SetFloat("BitsData", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("/", this.GAMMLIDAPPF);
			this.DBOLLHHMKKN().SetVector("setAF", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1490f, 638f));
			this.OIMMPLPBLBK().SetFloat("icon_border", this.Vignette);
			this.NBPKMLMCHFN.SetFloat("_Fade", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E17 RID: 19991 RVA: 0x00184D3C File Offset: 0x00182F3C
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 936f)
			{
				this.HBJJOCHGOPH = 969f;
			}
			this.OIIDAKBILMI().SetFloat("HitVariationSlider", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("_ChromaticAberration", this.GAMMLIDAPPF);
			this.OIMMPLPBLBK().SetVector("SupportLogger OnApplicationPause: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1317f, 1362f));
			this.OIIDAKBILMI().SetFloat("_GrainTex", this.Vignette);
			this.NJDIODJNGGA().SetFloat("$ {0}", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004E18 RID: 19992 RVA: 0x00183150 File Offset: 0x00181350
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004E19 RID: 19993 RVA: 0x00184E25 File Offset: 0x00183025
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004E1A RID: 19994 RVA: 0x00183150 File Offset: 0x00181350
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004E1B RID: 19995 RVA: 0x00184E5C File Offset: 0x0018305C
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1003f)
			{
				this.HBJJOCHGOPH = 515f;
			}
			this.NFMGLIKNOOC().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("2", this.GAMMLIDAPPF);
			this.KBOPGONOCNP().SetVector("ItemNameText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 615f, 1793f));
			this.MMOODGIODPC().SetFloat("In Network lobby", this.Vignette);
			this.OIMMPLPBLBK().SetFloat("_TimeX", this.Linecount);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x04000833 RID: 2099
	public Shader SCShader;

	// Token: 0x04000834 RID: 2100
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000835 RID: 2101
	private float GAMMLIDAPPF = 1f;

	// Token: 0x04000836 RID: 2102
	private Material BJFKDHHMLJH;

	// Token: 0x04000837 RID: 2103
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000838 RID: 2104
	[Range(0f, 100f)]
	public float Vignette = 1.3f;

	// Token: 0x04000839 RID: 2105
	[Range(1f, 150f)]
	public float Linecount = 90f;
}
