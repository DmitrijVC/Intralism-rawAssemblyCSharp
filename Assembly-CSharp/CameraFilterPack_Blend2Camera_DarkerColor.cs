using System;
using UnityEngine;

// Token: 0x02000040 RID: 64
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/DarkerColor")]
public class CameraFilterPack_Blend2Camera_DarkerColor : MonoBehaviour
{
	// Token: 0x060011AB RID: 4523 RVA: 0x000786AF File Offset: 0x000768AF
	private void FELENDJEOGA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -108);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060011AC RID: 4524 RVA: 0x000786EA File Offset: 0x000768EA
	private void BMHFAMJELFH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -31);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060011AD RID: 4525 RVA: 0x00078725 File Offset: 0x00076925
	private void OFPPIKHNJOD()
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

	// Token: 0x060011AE RID: 4526 RVA: 0x00078760 File Offset: 0x00076960
	private void NCNPAKFAFOE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -112);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060011AF RID: 4527 RVA: 0x00078725 File Offset: 0x00076925
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

	// Token: 0x060011B0 RID: 4528 RVA: 0x000787CC File Offset: 0x000769CC
	private void NPLCENPNJBM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -34);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060011B1 RID: 4529 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x060011B2 RID: 4530 RVA: 0x00078725 File Offset: 0x00076925
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

	// Token: 0x060011B3 RID: 4531 RVA: 0x00078838 File Offset: 0x00076A38
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 648f)
			{
				this.HBJJOCHGOPH = 676f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("maps.", this.JDMCFBKJHDD);
			}
			this.DBOLLHHMKKN().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Drop_Near", this.BlendFX);
			this.DBOLLHHMKKN().SetFloat("All bindings reset to default values. PlayerPrefs have been removed for each key.", this.SwitchCameraToCamera2);
			this.DBOLLHHMKKN().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1946f, 845f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060011B4 RID: 4532 RVA: 0x00078932 File Offset: 0x00076B32
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060011B5 RID: 4533 RVA: 0x0007896C File Offset: 0x00076B6C
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1282f)
			{
				this.HBJJOCHGOPH = 1363f;
			}
			if (this.Camera2 != null)
			{
				this.DBOLLHHMKKN().SetTexture("player.bat", this.JDMCFBKJHDD);
			}
			this.DEFBJOCJJKF().SetFloat("CameraFilterPack/Blend2Camera_Luminosity", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Particles/Additive", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("/", this.SwitchCameraToCamera2);
			this.DBOLLHHMKKN().SetVector("_ConsoleSettings", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1049f, 989f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060011B6 RID: 4534 RVA: 0x00078A66 File Offset: 0x00076C66
	private void GLGGNBOBFKE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -30);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060011B7 RID: 4535 RVA: 0x00078AA1 File Offset: 0x00076CA1
	private void IBEAPBDAOCC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -124);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060011B8 RID: 4536 RVA: 0x00078ADC File Offset: 0x00076CDC
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

	// Token: 0x060011B9 RID: 4537 RVA: 0x00078BD6 File Offset: 0x00076DD6
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060011BA RID: 4538 RVA: 0x00078725 File Offset: 0x00076925
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

	// Token: 0x060011BB RID: 4539 RVA: 0x00078C14 File Offset: 0x00076E14
	private void IMCKJCHKMKB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 51);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060011BC RID: 4540 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060011BD RID: 4541 RVA: 0x00078725 File Offset: 0x00076925
	private void GAOOPEEBGJA()
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

	// Token: 0x060011BE RID: 4542 RVA: 0x00078C7D File Offset: 0x00076E7D
	private void EJNKBOLGHJC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -90);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060011BF RID: 4543 RVA: 0x00078BD6 File Offset: 0x00076DD6
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060011C0 RID: 4544 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x060011C1 RID: 4545 RVA: 0x00078CB8 File Offset: 0x00076EB8
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 991f)
			{
				this.HBJJOCHGOPH = 1287f;
			}
			if (this.Camera2 != null)
			{
				this.DBOLLHHMKKN().SetTexture("_Value", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("PointsScoreText", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("checkpoint", this.BlendFX);
			this.DEFBJOCJJKF().SetFloat("_CenterY", this.SwitchCameraToCamera2);
			this.DBOLLHHMKKN().SetVector("Object ID. Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 534f, 381f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060011C2 RID: 4546 RVA: 0x00078DB4 File Offset: 0x00076FB4
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

	// Token: 0x060011C3 RID: 4547 RVA: 0x00078725 File Offset: 0x00076925
	private void EAHCLIEEJOG()
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

	// Token: 0x060011C4 RID: 4548 RVA: 0x00078725 File Offset: 0x00076925
	private void PHJLHCMCCKE()
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

	// Token: 0x060011C5 RID: 4549 RVA: 0x00078E1D File Offset: 0x0007701D
	private void OLCOOJIONIL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 119);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060011C6 RID: 4550 RVA: 0x00078E58 File Offset: 0x00077058
	private void FEHCNJLLJMP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -63);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060011C7 RID: 4551 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x17000027 RID: 39
	// (get) Token: 0x060011C8 RID: 4552 RVA: 0x00078EC1 File Offset: 0x000770C1
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

	// Token: 0x060011C9 RID: 4553 RVA: 0x00078EF8 File Offset: 0x000770F8
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060011CB RID: 4555 RVA: 0x00078F58 File Offset: 0x00077158
	private void OFBLDOCCBBN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 46);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x04000280 RID: 640
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_DarkerColor";

	// Token: 0x04000281 RID: 641
	public Shader SCShader;

	// Token: 0x04000282 RID: 642
	public Camera Camera2;

	// Token: 0x04000283 RID: 643
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000284 RID: 644
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000285 RID: 645
	private Material BJFKDHHMLJH;

	// Token: 0x04000286 RID: 646
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x04000287 RID: 647
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x04000288 RID: 648
	private RenderTexture JDMCFBKJHDD;
}
