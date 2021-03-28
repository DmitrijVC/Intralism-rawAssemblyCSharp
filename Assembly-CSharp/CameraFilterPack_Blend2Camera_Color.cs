using System;
using UnityEngine;

// Token: 0x0200003B RID: 59
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Color")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_Color : MonoBehaviour
{
	// Token: 0x06001011 RID: 4113 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06001012 RID: 4114 RVA: 0x0006F687 File Offset: 0x0006D887
	private void LJEDJDGPGFG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 41);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001013 RID: 4115 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06001014 RID: 4116 RVA: 0x0006F6C2 File Offset: 0x0006D8C2
	private void MOEPJDOFBHA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -93);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001015 RID: 4117 RVA: 0x0006F6FD File Offset: 0x0006D8FD
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001016 RID: 4118 RVA: 0x0006F734 File Offset: 0x0006D934
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001017 RID: 4119 RVA: 0x0006F76B File Offset: 0x0006D96B
	private void BMHFAMJELFH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 98);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001018 RID: 4120 RVA: 0x0006F7A6 File Offset: 0x0006D9A6
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001019 RID: 4121 RVA: 0x0006F7DD File Offset: 0x0006D9DD
	private void KOCPGJCINKD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 117);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600101A RID: 4122 RVA: 0x0006F818 File Offset: 0x0006DA18
	private void DAHFFNNIGML()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 106);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600101B RID: 4123 RVA: 0x0006F881 File Offset: 0x0006DA81
	private void DLOAJEFNKDA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600101C RID: 4124 RVA: 0x0006F8BC File Offset: 0x0006DABC
	private void MKIMDFLBFOM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -118);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600101D RID: 4125 RVA: 0x0006F928 File Offset: 0x0006DB28
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 197f)
			{
				this.HBJJOCHGOPH = 726f;
			}
			if (this.Camera2 != null)
			{
				this.MMOODGIODPC().SetTexture("x", this.JDMCFBKJHDD);
			}
			this.EMDFHOKEGNG().SetFloat("R1", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("LB", this.BlendFX);
			this.DNLMFEGJJDD().SetFloat("</color>", this.SwitchCameraToCamera2);
			this.EMDFHOKEGNG().SetVector("_SmoothStart", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1632f, 492f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600101E RID: 4126 RVA: 0x0006FA22 File Offset: 0x0006DC22
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

	// Token: 0x0600101F RID: 4127 RVA: 0x0006FA5C File Offset: 0x0006DC5C
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 189f)
			{
				this.HBJJOCHGOPH = 27f;
			}
			if (this.Camera2 != null)
			{
				this.EMDFHOKEGNG().SetTexture("Connection failed: ", this.JDMCFBKJHDD);
			}
			this.BFGNMFCNDBC().SetFloat("[MapsSystem] Unloading maps resources...", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("settings.enablerankingnotifications", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("_Extra", this.SwitchCameraToCamera2);
			this.AELJLBOJAIL().SetVector("#,0.00", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 4f, 705f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001020 RID: 4128 RVA: 0x0006FB56 File Offset: 0x0006DD56
	private void HJDPEBAPBPN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 27);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001021 RID: 4129 RVA: 0x0006FA22 File Offset: 0x0006DC22
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

	// Token: 0x06001022 RID: 4130 RVA: 0x0006FB91 File Offset: 0x0006DD91
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001023 RID: 4131 RVA: 0x0006FBC8 File Offset: 0x0006DDC8
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1383f)
			{
				this.HBJJOCHGOPH = 372f;
			}
			if (this.Camera2 != null)
			{
				this.DNLMFEGJJDD().SetTexture("Please attach component to a Graphical UI component", this.JDMCFBKJHDD);
			}
			this.DNLMFEGJJDD().SetFloat("/", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("Set satellite lerp speed", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.SwitchCameraToCamera2);
			this.IONHGBPGCHK().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1568f, 754f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001024 RID: 4132 RVA: 0x0006FCC2 File Offset: 0x0006DEC2
	private void CCKABCDEOJC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 82);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001025 RID: 4133 RVA: 0x0006FCFD File Offset: 0x0006DEFD
	private void GHMDNIFLGOB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -71);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001026 RID: 4134 RVA: 0x0006FD38 File Offset: 0x0006DF38
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

	// Token: 0x06001027 RID: 4135 RVA: 0x0006FDA4 File Offset: 0x0006DFA4
	private void DKOPKPBLDHH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 52);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x06001028 RID: 4136 RVA: 0x0006FE0D File Offset: 0x0006E00D
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

	// Token: 0x06001029 RID: 4137 RVA: 0x0006FE44 File Offset: 0x0006E044
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600102A RID: 4138 RVA: 0x0006FE7B File Offset: 0x0006E07B
	private void BDBKIEIIFPB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 112);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600102B RID: 4139 RVA: 0x0006FEB8 File Offset: 0x0006E0B8
	private void NNCCPEBIAKH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -20);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600102C RID: 4140 RVA: 0x0006FF24 File Offset: 0x0006E124
	private void EFJDNLGNACH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -126);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600102D RID: 4141 RVA: 0x0006FA22 File Offset: 0x0006DC22
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

	// Token: 0x0600102E RID: 4142 RVA: 0x0006FF8D File Offset: 0x0006E18D
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600102F RID: 4143 RVA: 0x0006FFC4 File Offset: 0x0006E1C4
	private void DNNFHBOOPIN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -64);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001030 RID: 4144 RVA: 0x0007002D File Offset: 0x0006E22D
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001031 RID: 4145 RVA: 0x00070064 File Offset: 0x0006E264
	private void HGIMCCHIPCP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 85);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001032 RID: 4146 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001033 RID: 4147 RVA: 0x000700A0 File Offset: 0x0006E2A0
	private void BEBNOKFLJPH()
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

	// Token: 0x06001034 RID: 4148 RVA: 0x0006FA22 File Offset: 0x0006DC22
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

	// Token: 0x06001035 RID: 4149 RVA: 0x00070109 File Offset: 0x0006E309
	private void JNACKHNNEPA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 56);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001036 RID: 4150 RVA: 0x00070144 File Offset: 0x0006E344
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001037 RID: 4151 RVA: 0x00070180 File Offset: 0x0006E380
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1746f)
			{
				this.HBJJOCHGOPH = 1786f;
			}
			if (this.Camera2 != null)
			{
				this.AELJLBOJAIL().SetTexture("[LocalizationService] Localization: ", this.JDMCFBKJHDD);
			}
			this.DNLMFEGJJDD().SetFloat(" not exist", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("mapselector.filter.favoriteonly", this.BlendFX);
			this.DNLMFEGJJDD().SetFloat("Joystick1Button3", this.SwitchCameraToCamera2);
			this.EMDFHOKEGNG().SetVector("_Value9", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1143f, 1600f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001038 RID: 4152 RVA: 0x0007027C File Offset: 0x0006E47C
	private void GPNAOAKCMHC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -40);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001039 RID: 4153 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x0600103B RID: 4155 RVA: 0x0007030E File Offset: 0x0006E50E
	private void ACBAHLCGNDD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 50);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600103C RID: 4156 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x0600103D RID: 4157 RVA: 0x00070349 File Offset: 0x0006E549
	private void NMNAEPIDENM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -54);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600103E RID: 4158 RVA: 0x0006FF8D File Offset: 0x0006E18D
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600103F RID: 4159 RVA: 0x00070384 File Offset: 0x0006E584
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)108;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001040 RID: 4160 RVA: 0x000703BC File Offset: 0x0006E5BC
	private void FEHCNJLLJMP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 51);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001041 RID: 4161 RVA: 0x00070428 File Offset: 0x0006E628
	private void FANADGBGCPI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 118);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001042 RID: 4162 RVA: 0x00070144 File Offset: 0x0006E344
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001043 RID: 4163 RVA: 0x00070494 File Offset: 0x0006E694
	private void MMMDPANNAIO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 8);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001044 RID: 4164 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06001045 RID: 4165 RVA: 0x000704FD File Offset: 0x0006E6FD
	private void GLKJFIOCPLF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -55);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001046 RID: 4166 RVA: 0x00070538 File Offset: 0x0006E738
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

	// Token: 0x0400024D RID: 589
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Color";

	// Token: 0x0400024E RID: 590
	public Shader SCShader;

	// Token: 0x0400024F RID: 591
	public Camera Camera2;

	// Token: 0x04000250 RID: 592
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000251 RID: 593
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000252 RID: 594
	private Material BJFKDHHMLJH;

	// Token: 0x04000253 RID: 595
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x04000254 RID: 596
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x04000255 RID: 597
	private RenderTexture JDMCFBKJHDD;
}
