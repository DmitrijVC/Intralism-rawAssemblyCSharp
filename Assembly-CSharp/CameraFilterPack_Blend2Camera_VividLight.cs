using System;
using UnityEngine;

// Token: 0x02000059 RID: 89
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/VividLight")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_VividLight : MonoBehaviour
{
	// Token: 0x06001922 RID: 6434 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06001923 RID: 6435 RVA: 0x0009FACA File Offset: 0x0009DCCA
	private void LOMDIOLNFHI()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001924 RID: 6436 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001925 RID: 6437 RVA: 0x0009FB04 File Offset: 0x0009DD04
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 800f)
			{
				this.HBJJOCHGOPH = 569f;
			}
			if (this.Camera2 != null)
			{
				this.PLBEJJIHFPB().SetTexture("OpGetGameList not sent. Lobby cannot be null.", this.JDMCFBKJHDD);
			}
			this.PLBEJJIHFPB().SetFloat("Distortion", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("_ScreenResolution", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("_PColor", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 246f, 42f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001926 RID: 6438 RVA: 0x0009FBFE File Offset: 0x0009DDFE
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001927 RID: 6439 RVA: 0x0009FC39 File Offset: 0x0009DE39
	private void OEAMLMGNFFC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 111);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001928 RID: 6440 RVA: 0x0009FC74 File Offset: 0x0009DE74
	private void FDIJLKIIMLL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -20);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001929 RID: 6441 RVA: 0x0009FCAF File Offset: 0x0009DEAF
	private void KOCPGJCINKD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -66);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600192A RID: 6442 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x0600192B RID: 6443 RVA: 0x0009FACA File Offset: 0x0009DCCA
	private void PLIKADJCEPO()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600192C RID: 6444 RVA: 0x0009FCEC File Offset: 0x0009DEEC
	private void Start()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600192D RID: 6445 RVA: 0x0009FD55 File Offset: 0x0009DF55
	private void OOBIMFILNED()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 23);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600192E RID: 6446 RVA: 0x0009FD90 File Offset: 0x0009DF90
	private void GPNAOAKCMHC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 79);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x1700003F RID: 63
	// (get) Token: 0x0600192F RID: 6447 RVA: 0x0009FDF9 File Offset: 0x0009DFF9
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

	// Token: 0x06001930 RID: 6448 RVA: 0x0009FE30 File Offset: 0x0009E030
	private void ENDDDMALLBK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 72);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001931 RID: 6449 RVA: 0x0009FD55 File Offset: 0x0009DF55
	private void OCHMKJKBAPI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 23);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001932 RID: 6450 RVA: 0x0009FACA File Offset: 0x0009DCCA
	private void EJJEDJIOFAB()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001933 RID: 6451 RVA: 0x0009FACA File Offset: 0x0009DCCA
	private void DHNGNHGDPLM()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001934 RID: 6452 RVA: 0x0009FE6C File Offset: 0x0009E06C
	private void NBGIMIDICKE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 33);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001935 RID: 6453 RVA: 0x0009FED5 File Offset: 0x0009E0D5
	private void MOMGJJDIFFI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 103);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001936 RID: 6454 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06001937 RID: 6455 RVA: 0x0009FACA File Offset: 0x0009DCCA
	private void DOEPOGLEGLE()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001938 RID: 6456 RVA: 0x0009FF10 File Offset: 0x0009E110
	private void IHPLMLBJELK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 18);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001939 RID: 6457 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x0600193A RID: 6458 RVA: 0x0009FF4C File Offset: 0x0009E14C
	private void FHPFJBFCOOF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -33);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600193B RID: 6459 RVA: 0x0009FFB5 File Offset: 0x0009E1B5
	private void FKDKJKCAHJC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -95);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600193C RID: 6460 RVA: 0x0009FACA File Offset: 0x0009DCCA
	private void DLMPALHKMON()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600193D RID: 6461 RVA: 0x0009FFF0 File Offset: 0x0009E1F0
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("_MainTex2", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600193E RID: 6462 RVA: 0x000A00EC File Offset: 0x0009E2EC
	private void PAKPHKPDKGE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -117);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001940 RID: 6464 RVA: 0x0009FBFE File Offset: 0x0009DDFE
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001941 RID: 6465 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06001942 RID: 6466 RVA: 0x000A0180 File Offset: 0x0009E380
	private void MKIMDFLBFOM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 38);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001943 RID: 6467 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x06001944 RID: 6468 RVA: 0x0009FACA File Offset: 0x0009DCCA
	private void OnDisable()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001945 RID: 6469 RVA: 0x000A01EC File Offset: 0x0009E3EC
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 754f)
			{
				this.HBJJOCHGOPH = 647f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("_Value", this.JDMCFBKJHDD);
			}
			this.HFBJAOFLCJI().SetFloat("_Value1", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("menu.resetlevelcheckpoint", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("Object ID. Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 479f, 395f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001946 RID: 6470 RVA: 0x000A02E6 File Offset: 0x0009E4E6
	private void IBEAPBDAOCC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 66);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001947 RID: 6471 RVA: 0x000A0324 File Offset: 0x0009E524
	private void CCLNNLCOPBL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 3);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001948 RID: 6472 RVA: 0x000A038D File Offset: 0x0009E58D
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001949 RID: 6473 RVA: 0x000A03C4 File Offset: 0x0009E5C4
	private void KDMKDEKCELE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 101);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600194A RID: 6474 RVA: 0x000A0430 File Offset: 0x0009E630
	private void AGEJKLMJGDO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 127);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600194B RID: 6475 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x0600194C RID: 6476 RVA: 0x000A0499 File Offset: 0x0009E699
	private void GLKJFIOCPLF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -53);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600194D RID: 6477 RVA: 0x0009FACA File Offset: 0x0009DCCA
	private void JHLGHODFJOO()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600194E RID: 6478 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x0600194F RID: 6479 RVA: 0x000A04D4 File Offset: 0x0009E6D4
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001950 RID: 6480 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06001951 RID: 6481 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x04000386 RID: 902
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_VividLight";

	// Token: 0x04000387 RID: 903
	public Shader SCShader;

	// Token: 0x04000388 RID: 904
	public Camera Camera2;

	// Token: 0x04000389 RID: 905
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400038A RID: 906
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400038B RID: 907
	private Material BJFKDHHMLJH;

	// Token: 0x0400038C RID: 908
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x0400038D RID: 909
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x0400038E RID: 910
	private RenderTexture JDMCFBKJHDD;
}
