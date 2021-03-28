using System;
using UnityEngine;

// Token: 0x0200004F RID: 79
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Overlay")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_Overlay : MonoBehaviour
{
	// Token: 0x0600166C RID: 5740 RVA: 0x00090641 File Offset: 0x0008E841
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)109;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600166D RID: 5741 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x0600166E RID: 5742 RVA: 0x00090678 File Offset: 0x0008E878
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600166F RID: 5743 RVA: 0x000906AF File Offset: 0x0008E8AF
	private void LLDBPKHDPKI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 7);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001670 RID: 5744 RVA: 0x000906EC File Offset: 0x0008E8EC
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

	// Token: 0x06001671 RID: 5745 RVA: 0x00090755 File Offset: 0x0008E955
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001672 RID: 5746 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06001673 RID: 5747 RVA: 0x00090790 File Offset: 0x0008E990
	private void LOOGLMFBJHK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 67);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001674 RID: 5748 RVA: 0x000907CB File Offset: 0x0008E9CB
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001675 RID: 5749 RVA: 0x00090802 File Offset: 0x0008EA02
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

	// Token: 0x06001676 RID: 5750 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06001677 RID: 5751 RVA: 0x0009083C File Offset: 0x0008EA3C
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 290f)
			{
				this.HBJJOCHGOPH = 944f;
			}
			if (this.Camera2 != null)
			{
				this.IONHGBPGCHK().SetTexture("gameVolume", this.JDMCFBKJHDD);
			}
			this.LNLKMDPHDCC().SetFloat("mapselector.filter.rateduponly", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("color", this.BlendFX);
			this.IIBLJCKLGFG().SetFloat("editorVolume", this.SwitchCameraToCamera2);
			this.NFMGLIKNOOC().SetVector("Editor/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1535f, 1003f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001678 RID: 5752 RVA: 0x00090938 File Offset: 0x0008EB38
	private void NCNPAKFAFOE()
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

	// Token: 0x06001679 RID: 5753 RVA: 0x000909A4 File Offset: 0x0008EBA4
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1917f)
			{
				this.HBJJOCHGOPH = 1127f;
			}
			if (this.Camera2 != null)
			{
				this.IIBLJCKLGFG().SetTexture("[MapsStats] Length: ", this.JDMCFBKJHDD);
			}
			this.LNLKMDPHDCC().SetFloat("Fill Area", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("OK", this.BlendFX);
			this.OIMMPLPBLBK().SetFloat("Rotate environment object to the rotation", this.SwitchCameraToCamera2);
			this.OIMMPLPBLBK().SetVector("Curve texture", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 419f, 863f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600167A RID: 5754 RVA: 0x00090A9E File Offset: 0x0008EC9E
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600167B RID: 5755 RVA: 0x00090755 File Offset: 0x0008E955
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600167C RID: 5756 RVA: 0x00090AD5 File Offset: 0x0008ECD5
	private void OCHMKJKBAPI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 46);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600167D RID: 5757 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x0600167E RID: 5758 RVA: 0x00090B10 File Offset: 0x0008ED10
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600167F RID: 5759 RVA: 0x00090B47 File Offset: 0x0008ED47
	private void CCKABCDEOJC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 23);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001680 RID: 5760 RVA: 0x00090802 File Offset: 0x0008EA02
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

	// Token: 0x06001681 RID: 5761 RVA: 0x00090802 File Offset: 0x0008EA02
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

	// Token: 0x06001682 RID: 5762 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001683 RID: 5763 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06001684 RID: 5764 RVA: 0x00090B84 File Offset: 0x0008ED84
	private void DIPDEHOOBPG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -47);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001686 RID: 5766 RVA: 0x00090C18 File Offset: 0x0008EE18
	private void DAHFFNNIGML()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -128);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001687 RID: 5767 RVA: 0x00090C81 File Offset: 0x0008EE81
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-82);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001688 RID: 5768 RVA: 0x00090CB8 File Offset: 0x0008EEB8
	private void KDMANOEMOCA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -100);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001689 RID: 5769 RVA: 0x00090D21 File Offset: 0x0008EF21
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600168A RID: 5770 RVA: 0x00090D58 File Offset: 0x0008EF58
	private void BMHFAMJELFH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -33);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600168B RID: 5771 RVA: 0x00090D93 File Offset: 0x0008EF93
	private void MDMDGKHDPKP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -124);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600168C RID: 5772 RVA: 0x00090DCE File Offset: 0x0008EFCE
	private void MFOOCOIIIJN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 2);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600168D RID: 5773 RVA: 0x00090E0C File Offset: 0x0008F00C
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

	// Token: 0x0600168E RID: 5774 RVA: 0x00090802 File Offset: 0x0008EA02
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

	// Token: 0x0600168F RID: 5775 RVA: 0x00090F08 File Offset: 0x0008F108
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 281f)
			{
				this.HBJJOCHGOPH = 1849f;
			}
			if (this.Camera2 != null)
			{
				this.JFDGLLEOPGB().SetTexture("_TimeX", this.JDMCFBKJHDD);
			}
			this.NFMGLIKNOOC().SetFloat("&page=", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("ACCEPT", this.BlendFX);
			this.OIMMPLPBLBK().SetFloat("[LocalizationService] All languages: ", this.SwitchCameraToCamera2);
			this.LNLKMDPHDCC().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 512f, 1804f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001690 RID: 5776 RVA: 0x00091002 File Offset: 0x0008F202
	private void MLAGEPNCCGM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 25);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x17000036 RID: 54
	// (get) Token: 0x06001691 RID: 5777 RVA: 0x0009103D File Offset: 0x0008F23D
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

	// Token: 0x0400030C RID: 780
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Overlay";

	// Token: 0x0400030D RID: 781
	public Shader SCShader;

	// Token: 0x0400030E RID: 782
	public Camera Camera2;

	// Token: 0x0400030F RID: 783
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000310 RID: 784
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000311 RID: 785
	private Material BJFKDHHMLJH;

	// Token: 0x04000312 RID: 786
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x04000313 RID: 787
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x04000314 RID: 788
	private RenderTexture JDMCFBKJHDD;
}
