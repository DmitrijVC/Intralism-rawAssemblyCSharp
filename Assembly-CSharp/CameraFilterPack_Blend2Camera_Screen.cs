using System;
using UnityEngine;

// Token: 0x02000054 RID: 84
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Screen")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_Screen : MonoBehaviour
{
	// Token: 0x06001787 RID: 6023 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06001788 RID: 6024 RVA: 0x000983C7 File Offset: 0x000965C7
	private void GLGGNBOBFKE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 30);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001789 RID: 6025 RVA: 0x00098404 File Offset: 0x00096604
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

	// Token: 0x0600178A RID: 6026 RVA: 0x0009846D File Offset: 0x0009666D
	private void JBBCMAJIMCA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -79);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600178B RID: 6027 RVA: 0x000984A8 File Offset: 0x000966A8
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1224f)
			{
				this.HBJJOCHGOPH = 1983f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("maps.", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat(",", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("CameraFilterPack/Drawing_BluePrint", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("_DistortionSize", this.SwitchCameraToCamera2);
			this.OIMMPLPBLBK().SetVector("[ItemsHandler] Item not found:", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 137f, 444f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600178C RID: 6028 RVA: 0x000985A2 File Offset: 0x000967A2
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

	// Token: 0x0600178D RID: 6029 RVA: 0x000985DC File Offset: 0x000967DC
	private void GFLAINNLMBO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -75);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600178E RID: 6030 RVA: 0x00098617 File Offset: 0x00096817
	private void MFOOCOIIIJN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -85);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600178F RID: 6031 RVA: 0x00098652 File Offset: 0x00096852
	private void GLKJFIOCPLF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 63);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001790 RID: 6032 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001791 RID: 6033 RVA: 0x0009868D File Offset: 0x0009688D
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001792 RID: 6034 RVA: 0x000985A2 File Offset: 0x000967A2
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

	// Token: 0x06001793 RID: 6035 RVA: 0x000986C4 File Offset: 0x000968C4
	private void LJEDJDGPGFG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 107);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001794 RID: 6036 RVA: 0x000986FF File Offset: 0x000968FF
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001795 RID: 6037 RVA: 0x0009873A File Offset: 0x0009693A
	private void EJNKBOLGHJC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 100);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001796 RID: 6038 RVA: 0x00098775 File Offset: 0x00096975
	private void IFBKMAEMKNN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 126);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001797 RID: 6039 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06001798 RID: 6040 RVA: 0x000987B0 File Offset: 0x000969B0
	private void MEJPBKFMAIG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 110);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001799 RID: 6041 RVA: 0x000987EB File Offset: 0x000969EB
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600179A RID: 6042 RVA: 0x00098822 File Offset: 0x00096A22
	private void GJPONJKJICG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -126);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600179B RID: 6043 RVA: 0x00098860 File Offset: 0x00096A60
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

	// Token: 0x1700003A RID: 58
	// (get) Token: 0x0600179C RID: 6044 RVA: 0x0009895A File Offset: 0x00096B5A
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

	// Token: 0x0600179D RID: 6045 RVA: 0x00098991 File Offset: 0x00096B91
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600179E RID: 6046 RVA: 0x000989C8 File Offset: 0x00096BC8
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600179F RID: 6047 RVA: 0x000985A2 File Offset: 0x000967A2
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

	// Token: 0x060017A0 RID: 6048 RVA: 0x000985A2 File Offset: 0x000967A2
	private void JHJFBCFBKLD()
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

	// Token: 0x060017A1 RID: 6049 RVA: 0x00098A00 File Offset: 0x00096C00
	private void IHLMNAGPKDA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 2);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060017A2 RID: 6050 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x060017A3 RID: 6051 RVA: 0x00098A69 File Offset: 0x00096C69
	private void FELENDJEOGA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -99);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060017A5 RID: 6053 RVA: 0x000985A2 File Offset: 0x000967A2
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

	// Token: 0x060017A6 RID: 6054 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x060017A7 RID: 6055 RVA: 0x00098ACD File Offset: 0x00096CCD
	private void BDBKIEIIFPB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -55);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060017A8 RID: 6056 RVA: 0x00098B08 File Offset: 0x00096D08
	private void JKFDDNMPOJH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -107);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060017A9 RID: 6057 RVA: 0x000986FF File Offset: 0x000968FF
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0400034C RID: 844
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Screen";

	// Token: 0x0400034D RID: 845
	public Shader SCShader;

	// Token: 0x0400034E RID: 846
	public Camera Camera2;

	// Token: 0x0400034F RID: 847
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000350 RID: 848
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000351 RID: 849
	private Material BJFKDHHMLJH;

	// Token: 0x04000352 RID: 850
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x04000353 RID: 851
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x04000354 RID: 852
	private RenderTexture JDMCFBKJHDD;
}
