using System;
using UnityEngine;

// Token: 0x02000052 RID: 82
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/PinLight")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_PinLight : MonoBehaviour
{
	// Token: 0x0600172F RID: 5935 RVA: 0x00096DF0 File Offset: 0x00094FF0
	private void AGEJKLMJGDO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -114);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001730 RID: 5936 RVA: 0x00096E59 File Offset: 0x00095059
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001731 RID: 5937 RVA: 0x00096E90 File Offset: 0x00095090
	private void NNCCPEBIAKH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -99);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001732 RID: 5938 RVA: 0x00096EF9 File Offset: 0x000950F9
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001733 RID: 5939 RVA: 0x00096F34 File Offset: 0x00095134
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 776f)
			{
				this.HBJJOCHGOPH = 1185f;
			}
			if (this.Camera2 != null)
			{
				this.HNICHJCGJOC().SetTexture("_ScreenResolution", this.JDMCFBKJHDD);
			}
			this.HFBJAOFLCJI().SetFloat("return CheckCondition()", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("_Value6", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("_MainTex2", this.SwitchCameraToCamera2);
			this.HFBJAOFLCJI().SetVector("_Fade", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1227f, 1817f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001734 RID: 5940 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001735 RID: 5941 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06001736 RID: 5942 RVA: 0x00097030 File Offset: 0x00095230
	private void NBGIMIDICKE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 69);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001737 RID: 5943 RVA: 0x00096EF9 File Offset: 0x000950F9
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001738 RID: 5944 RVA: 0x00097099 File Offset: 0x00095299
	private void DPFOEBCADNP()
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

	// Token: 0x06001739 RID: 5945 RVA: 0x000970D4 File Offset: 0x000952D4
	private void NPLCENPNJBM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 97);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600173A RID: 5946 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x0600173B RID: 5947 RVA: 0x0009713D File Offset: 0x0009533D
	private void FDIJLKIIMLL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 110);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600173C RID: 5948 RVA: 0x00097178 File Offset: 0x00095378
	private void IFKNIHJCAFB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -10);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600173D RID: 5949 RVA: 0x00097099 File Offset: 0x00095299
	private void OCCGJMPAJIK()
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

	// Token: 0x0600173E RID: 5950 RVA: 0x00097099 File Offset: 0x00095299
	private void JOJFHFHOCHO()
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

	// Token: 0x0600173F RID: 5951 RVA: 0x000971B3 File Offset: 0x000953B3
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001740 RID: 5952 RVA: 0x000971EA File Offset: 0x000953EA
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001742 RID: 5954 RVA: 0x00097099 File Offset: 0x00095299
	private void ODAIMOJLJOF()
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

	// Token: 0x06001743 RID: 5955 RVA: 0x0009724A File Offset: 0x0009544A
	private void FCKIJIKNMCF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 99);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001744 RID: 5956 RVA: 0x00097288 File Offset: 0x00095488
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 768f)
			{
				this.HBJJOCHGOPH = 1801f;
			}
			if (this.Camera2 != null)
			{
				this.HFBJAOFLCJI().SetTexture("Vertical", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("_Glow", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.BlendFX);
			this.LDNADDJMIPK().SetFloat("_TimeX", this.SwitchCameraToCamera2);
			this.HNICHJCGJOC().SetVector(". Set PhotonNetwork.OnEventCall.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1977f, 1823f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001745 RID: 5957 RVA: 0x00097099 File Offset: 0x00095299
	private void CBIBDOIBJAI()
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

	// Token: 0x06001746 RID: 5958 RVA: 0x00097382 File Offset: 0x00095582
	private void GLGGNBOBFKE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 111);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001747 RID: 5959 RVA: 0x000973BD File Offset: 0x000955BD
	private void FCGHOKACFHL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -120);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001748 RID: 5960 RVA: 0x000973F8 File Offset: 0x000955F8
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

	// Token: 0x06001749 RID: 5961 RVA: 0x000974F2 File Offset: 0x000956F2
	private void GPJHPNGNEBP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -74);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600174A RID: 5962 RVA: 0x00097530 File Offset: 0x00095730
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

	// Token: 0x0600174B RID: 5963 RVA: 0x00097099 File Offset: 0x00095299
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

	// Token: 0x0600174C RID: 5964 RVA: 0x0009759C File Offset: 0x0009579C
	private void DIPDEHOOBPG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 116);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600174D RID: 5965 RVA: 0x00097605 File Offset: 0x00095805
	private void CNHEENCFCMF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 2);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600174E RID: 5966 RVA: 0x00097640 File Offset: 0x00095840
	private void MMOKKAPFGAK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 62);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600174F RID: 5967 RVA: 0x000976A9 File Offset: 0x000958A9
	private void GJPONJKJICG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 97);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001750 RID: 5968 RVA: 0x000976E4 File Offset: 0x000958E4
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1167f)
			{
				this.HBJJOCHGOPH = 1205f;
			}
			if (this.Camera2 != null)
			{
				this.LDNADDJMIPK().SetTexture("TwoHands", this.JDMCFBKJHDD);
			}
			this.HNICHJCGJOC().SetFloat("StartButton", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("BlockCount", this.BlendFX);
			this.HNICHJCGJOC().SetFloat("_VignetteColor", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("_TraceBehindObjects", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 908f, 1593f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001751 RID: 5969 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x17000038 RID: 56
	// (get) Token: 0x06001752 RID: 5970 RVA: 0x000977DE File Offset: 0x000959DE
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

	// Token: 0x06001753 RID: 5971 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06001754 RID: 5972 RVA: 0x00097815 File Offset: 0x00095A15
	private void OCHMKJKBAPI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -50);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001755 RID: 5973 RVA: 0x00097850 File Offset: 0x00095A50
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001756 RID: 5974 RVA: 0x00097887 File Offset: 0x00095A87
	private void OFBLDOCCBBN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 71);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001757 RID: 5975 RVA: 0x000978C4 File Offset: 0x00095AC4
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1045f)
			{
				this.HBJJOCHGOPH = 579f;
			}
			if (this.Camera2 != null)
			{
				this.LDNADDJMIPK().SetTexture("/Segment-[Down]", this.JDMCFBKJHDD);
			}
			this.IIJMIPBMMBF().SetFloat("_Circle", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("Default UI Material", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("connecting", this.SwitchCameraToCamera2);
			this.HNICHJCGJOC().SetVector("Set crosshair color", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1286f, 642f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001758 RID: 5976 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x0400033A RID: 826
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_PinLight";

	// Token: 0x0400033B RID: 827
	public Shader SCShader;

	// Token: 0x0400033C RID: 828
	public Camera Camera2;

	// Token: 0x0400033D RID: 829
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400033E RID: 830
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400033F RID: 831
	private Material BJFKDHHMLJH;

	// Token: 0x04000340 RID: 832
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x04000341 RID: 833
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x04000342 RID: 834
	private RenderTexture JDMCFBKJHDD;
}
