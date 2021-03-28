using System;
using UnityEngine;

// Token: 0x02000053 RID: 83
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Saturation")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_Saturation : MonoBehaviour
{
	// Token: 0x06001759 RID: 5977 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x0600175A RID: 5978 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600175B RID: 5979 RVA: 0x000979BE File Offset: 0x00095BBE
	private void LLDBPKHDPKI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -27);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600175C RID: 5980 RVA: 0x000979FC File Offset: 0x00095BFC
	private void PAKPHKPDKGE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 80);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600175D RID: 5981 RVA: 0x00097A65 File Offset: 0x00095C65
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600175E RID: 5982 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x0600175F RID: 5983 RVA: 0x00097AA0 File Offset: 0x00095CA0
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-81);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001760 RID: 5984 RVA: 0x00097AD7 File Offset: 0x00095CD7
	private void LIFBFDKFMMH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 54);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001761 RID: 5985 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06001762 RID: 5986 RVA: 0x00097B12 File Offset: 0x00095D12
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001763 RID: 5987 RVA: 0x00097B49 File Offset: 0x00095D49
	private void MNHCBAKPBCF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -48);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001764 RID: 5988 RVA: 0x00097B84 File Offset: 0x00095D84
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

	// Token: 0x06001765 RID: 5989 RVA: 0x00097BBE File Offset: 0x00095DBE
	private void MFOOCOIIIJN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 18);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001766 RID: 5990 RVA: 0x00097BF9 File Offset: 0x00095DF9
	private void OKHGJFFIIBA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -75);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001767 RID: 5991 RVA: 0x00097C34 File Offset: 0x00095E34
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

	// Token: 0x06001768 RID: 5992 RVA: 0x00097D2E File Offset: 0x00095F2E
	private void IFBPAGFGDGD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 25);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001769 RID: 5993 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x0600176A RID: 5994 RVA: 0x00097D69 File Offset: 0x00095F69
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600176B RID: 5995 RVA: 0x00097B84 File Offset: 0x00095D84
	private void EDBEHEKMGFH()
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

	// Token: 0x0600176C RID: 5996 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x0600176D RID: 5997 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x0600176E RID: 5998 RVA: 0x00097DA0 File Offset: 0x00095FA0
	private void BNIIBNCLHFA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 39);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600176F RID: 5999 RVA: 0x00097B84 File Offset: 0x00095D84
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

	// Token: 0x06001770 RID: 6000 RVA: 0x00097DDB File Offset: 0x00095FDB
	private void GHMDNIFLGOB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 42);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001771 RID: 6001 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06001772 RID: 6002 RVA: 0x00097B84 File Offset: 0x00095D84
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

	// Token: 0x06001773 RID: 6003 RVA: 0x00097E16 File Offset: 0x00096016
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001774 RID: 6004 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06001775 RID: 6005 RVA: 0x00097A65 File Offset: 0x00095C65
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001776 RID: 6006 RVA: 0x00097B49 File Offset: 0x00095D49
	private void CNHEENCFCMF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -48);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001777 RID: 6007 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06001778 RID: 6008 RVA: 0x00097E4D File Offset: 0x0009604D
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001779 RID: 6009 RVA: 0x00097B84 File Offset: 0x00095D84
	private void JHJGJJKELJM()
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

	// Token: 0x0600177A RID: 6010 RVA: 0x00097E84 File Offset: 0x00096084
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 60f)
			{
				this.HBJJOCHGOPH = 530f;
			}
			if (this.Camera2 != null)
			{
				this.IIJMIPBMMBF().SetTexture("_MainTexBlurred", this.JDMCFBKJHDD);
			}
			this.JFDGLLEOPGB().SetFloat("_Offsets", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/FX_Glitch2", this.BlendFX);
			this.MMOODGIODPC().SetFloat("DISTORT", this.SwitchCameraToCamera2);
			this.DEFBJOCJJKF().SetVector("CameraFilterPack/Distortion_Twist_Square", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 999f, 454f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600177B RID: 6011 RVA: 0x00097B84 File Offset: 0x00095D84
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

	// Token: 0x17000039 RID: 57
	// (get) Token: 0x0600177C RID: 6012 RVA: 0x00097F7E File Offset: 0x0009617E
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

	// Token: 0x0600177D RID: 6013 RVA: 0x00097B84 File Offset: 0x00095D84
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

	// Token: 0x0600177E RID: 6014 RVA: 0x00097FB8 File Offset: 0x000961B8
	private void DAHFFNNIGML()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -37);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600177F RID: 6015 RVA: 0x00098021 File Offset: 0x00096221
	private void OOBIMFILNED()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 32);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001780 RID: 6016 RVA: 0x0009805C File Offset: 0x0009625C
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

	// Token: 0x06001781 RID: 6017 RVA: 0x000980C8 File Offset: 0x000962C8
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1606f)
			{
				this.HBJJOCHGOPH = 1419f;
			}
			if (this.Camera2 != null)
			{
				this.IIJMIPBMMBF().SetTexture("[MapEditor] Created new map: ", this.JDMCFBKJHDD);
			}
			this.JFDGLLEOPGB().SetFloat("SetSunColors", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("/../", this.BlendFX);
			this.JFDGLLEOPGB().SetFloat("checkpoint", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 455f, 583f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001782 RID: 6018 RVA: 0x000981C2 File Offset: 0x000963C2
	private void FGIOPGGPLMB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -127);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001783 RID: 6019 RVA: 0x000981FD File Offset: 0x000963FD
	private void NMNAEPIDENM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -54);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001784 RID: 6020 RVA: 0x00098238 File Offset: 0x00096438
	private void NBGIMIDICKE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -79);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001785 RID: 6021 RVA: 0x000982A4 File Offset: 0x000964A4
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1998f)
			{
				this.HBJJOCHGOPH = 1056f;
			}
			if (this.Camera2 != null)
			{
				this.DEFBJOCJJKF().SetTexture("[PlayerController] ", this.JDMCFBKJHDD);
			}
			this.MMOODGIODPC().SetFloat("Fade", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat(" {0}", this.BlendFX);
			this.MMOODGIODPC().SetFloat(" AuthMode ", this.SwitchCameraToCamera2);
			this.MMOODGIODPC().SetVector("_ChannelMixerBlue", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 545f, 1658f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x04000343 RID: 835
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Saturation";

	// Token: 0x04000344 RID: 836
	public Shader SCShader;

	// Token: 0x04000345 RID: 837
	public Camera Camera2;

	// Token: 0x04000346 RID: 838
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000347 RID: 839
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000348 RID: 840
	private Material BJFKDHHMLJH;

	// Token: 0x04000349 RID: 841
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x0400034A RID: 842
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x0400034B RID: 843
	private RenderTexture JDMCFBKJHDD;
}
