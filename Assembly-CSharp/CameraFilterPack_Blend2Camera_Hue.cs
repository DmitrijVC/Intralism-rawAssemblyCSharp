using System;
using UnityEngine;

// Token: 0x02000047 RID: 71
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Hue")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_Hue : MonoBehaviour
{
	// Token: 0x0600138E RID: 5006 RVA: 0x00082080 File Offset: 0x00080280
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

	// Token: 0x0600138F RID: 5007 RVA: 0x000820E9 File Offset: 0x000802E9
	private void MFBCLNAHEFO()
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

	// Token: 0x06001390 RID: 5008 RVA: 0x00082123 File Offset: 0x00080323
	private Material MPENCEIGLEH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001391 RID: 5009 RVA: 0x000820E9 File Offset: 0x000802E9
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

	// Token: 0x06001392 RID: 5010 RVA: 0x0008215A File Offset: 0x0008035A
	private void LHGFCBDACBM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 122);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001393 RID: 5011 RVA: 0x00082198 File Offset: 0x00080398
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1297f)
			{
				this.HBJJOCHGOPH = 710f;
			}
			if (this.Camera2 != null)
			{
				this.ACHNOHCLGOO().SetTexture("win", this.JDMCFBKJHDD);
			}
			this.ACHNOHCLGOO().SetFloat("CameraFilterPack/3D_Myst", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("_Parameter", this.BlendFX);
			this.ACHNOHCLGOO().SetFloat("Joystick1Button4", this.SwitchCameraToCamera2);
			this.MICHFGAOPKM().SetVector("No connection to item server!", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1498f, 620f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001394 RID: 5012 RVA: 0x00082292 File Offset: 0x00080492
	private void BBKMHAFFIMD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 93);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001395 RID: 5013 RVA: 0x000822D0 File Offset: 0x000804D0
	private void KDMANOEMOCA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -50);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001396 RID: 5014 RVA: 0x00082339 File Offset: 0x00080539
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001397 RID: 5015 RVA: 0x00082370 File Offset: 0x00080570
	private void KCDAFGECAIH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -67);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001398 RID: 5016 RVA: 0x000823AB File Offset: 0x000805AB
	private void JNACKHNNEPA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -107);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001399 RID: 5017 RVA: 0x000820E9 File Offset: 0x000802E9
	private void KFEKCJDEECK()
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

	// Token: 0x0600139A RID: 5018 RVA: 0x000823E6 File Offset: 0x000805E6
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600139B RID: 5019 RVA: 0x0008241D File Offset: 0x0008061D
	private void ACBAHLCGNDD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -102);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600139C RID: 5020 RVA: 0x00082458 File Offset: 0x00080658
	private void FEHCNJLLJMP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -60);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600139D RID: 5021 RVA: 0x000824C1 File Offset: 0x000806C1
	private void OAKONCDEPPI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -10);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600139E RID: 5022 RVA: 0x000824FC File Offset: 0x000806FC
	private void BMOFEBKGLFI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 63);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600139F RID: 5023 RVA: 0x00082568 File Offset: 0x00080768
	private void MDNHCLKNCLE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 75);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060013A0 RID: 5024 RVA: 0x000825D4 File Offset: 0x000807D4
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 804f)
			{
				this.HBJJOCHGOPH = 298f;
			}
			if (this.Camera2 != null)
			{
				this.MICHFGAOPKM().SetTexture("_DotSize", this.JDMCFBKJHDD);
			}
			this.MICHFGAOPKM().SetFloat("LevelNameInputField", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("x", this.BlendFX);
			this.ELBMIEOIABA().SetFloat(" ", this.SwitchCameraToCamera2);
			this.ACHNOHCLGOO().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 789f, 194f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HILDKDFEBPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060013A1 RID: 5025 RVA: 0x000826CE File Offset: 0x000808CE
	private Material BAGICADFBAB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060013A2 RID: 5026 RVA: 0x00082705 File Offset: 0x00080905
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060013A3 RID: 5027 RVA: 0x000820E9 File Offset: 0x000802E9
	private void KMOCDAOKGLI()
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

	// Token: 0x060013A4 RID: 5028 RVA: 0x0008273C File Offset: 0x0008093C
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060013A5 RID: 5029 RVA: 0x00082773 File Offset: 0x00080973
	private void BLDMINMDHPA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -3);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013A6 RID: 5030 RVA: 0x000820E9 File Offset: 0x000802E9
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

	// Token: 0x060013A7 RID: 5031 RVA: 0x000827AE File Offset: 0x000809AE
	private void MEJPBKFMAIG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 47);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013A8 RID: 5032 RVA: 0x000827E9 File Offset: 0x000809E9
	private Material OCMBHMLNCEK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060013A9 RID: 5033 RVA: 0x00082820 File Offset: 0x00080A20
	private void JCDPMLPNOOC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013AA RID: 5034 RVA: 0x0008285B File Offset: 0x00080A5B
	private void EBBMDDEFNKL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -17);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013AB RID: 5035 RVA: 0x00082896 File Offset: 0x00080A96
	private void IHPLMLBJELK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013AC RID: 5036 RVA: 0x000828D4 File Offset: 0x00080AD4
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1475f)
			{
				this.HBJJOCHGOPH = 831f;
			}
			if (this.Camera2 != null)
			{
				this.NFMGLIKNOOC().SetTexture("_Green_C", this.JDMCFBKJHDD);
			}
			this.KHCLIAMBBNC().SetFloat("inventory.selected.", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("[Down-Left]", this.BlendFX);
			this.KHCLIAMBBNC().SetFloat("Hex value #RRGGBB", this.SwitchCameraToCamera2);
			this.DKNJGHFLAIF().SetVector("caret", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1530f, 1959f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060013AD RID: 5037 RVA: 0x000829D0 File Offset: 0x00080BD0
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1856f)
			{
				this.HBJJOCHGOPH = 24f;
			}
			if (this.Camera2 != null)
			{
				this.KHCLIAMBBNC().SetTexture("_Value", this.JDMCFBKJHDD);
			}
			this.MICHFGAOPKM().SetFloat("_FgOverlap", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("settings.enableranking", this.BlendFX);
			this.PLBEJJIHFPB().SetFloat("_CenterX", this.SwitchCameraToCamera2);
			this.GCDFNHMJMIP().SetVector("ChangeSelectedLevel", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1626f, 1514f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BAGICADFBAB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060013AE RID: 5038 RVA: 0x00082ACA File Offset: 0x00080CCA
	private void MIAMLFNACAI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -127);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013AF RID: 5039 RVA: 0x00082B05 File Offset: 0x00080D05
	private void LKPBGHGCPKL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -12);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013B0 RID: 5040 RVA: 0x000820E9 File Offset: 0x000802E9
	private void OEIBFOHPOPD()
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

	// Token: 0x060013B1 RID: 5041 RVA: 0x00082B40 File Offset: 0x00080D40
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 825f)
			{
				this.HBJJOCHGOPH = 14f;
			}
			if (this.Camera2 != null)
			{
				this.GJHPODJOBHL().SetTexture("CameraFilterPack/Light_Water2", this.JDMCFBKJHDD);
			}
			this.KHCLIAMBBNC().SetFloat("#FFDA44CC", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("red", this.BlendFX);
			this.KHCLIAMBBNC().SetFloat("SetParticlesCountPerBeat", this.SwitchCameraToCamera2);
			this.KHCLIAMBBNC().SetVector("_Intensity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1036f, 51f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ELBMIEOIABA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060013B2 RID: 5042 RVA: 0x000820E9 File Offset: 0x000802E9
	private void FODKODGPPDA()
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

	// Token: 0x060013B3 RID: 5043 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x060013B4 RID: 5044 RVA: 0x00082C3C File Offset: 0x00080E3C
	private void KDMKDEKCELE()
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

	// Token: 0x060013B5 RID: 5045 RVA: 0x00082CA5 File Offset: 0x00080EA5
	private void EAOKCECGKAK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -113);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013B6 RID: 5046 RVA: 0x00082CE0 File Offset: 0x00080EE0
	private void HLIAEEMGBHN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 61);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060013B7 RID: 5047 RVA: 0x00082896 File Offset: 0x00080A96
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013B8 RID: 5048 RVA: 0x00082D49 File Offset: 0x00080F49
	private void PKNJBBDKJFK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 111);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013B9 RID: 5049 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOAGAKFBIGD()
	{
	}

	// Token: 0x060013BA RID: 5050 RVA: 0x000820E9 File Offset: 0x000802E9
	private void NNPBKKBFDHH()
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

	// Token: 0x060013BB RID: 5051 RVA: 0x00082D84 File Offset: 0x00080F84
	private void HNLPEJJPEGA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 64);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013BC RID: 5052 RVA: 0x00082DC0 File Offset: 0x00080FC0
	private void PMPKMGKAAJH()
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

	// Token: 0x060013BD RID: 5053 RVA: 0x00082E2C File Offset: 0x0008102C
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1416f)
			{
				this.HBJJOCHGOPH = 1763f;
			}
			if (this.Camera2 != null)
			{
				this.CFEDGDGBCHE().SetTexture("_Value2", this.JDMCFBKJHDD);
			}
			this.OIBHFCLJKDB().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat(".", this.BlendFX);
			this.BAGICADFBAB().SetFloat("Added event", this.SwitchCameraToCamera2);
			this.DKNJGHFLAIF().SetVector("checkpoint", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 446f, 1140f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060013BE RID: 5054 RVA: 0x00082F28 File Offset: 0x00081128
	private void NPLCENPNJBM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -103);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060013BF RID: 5055 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x060013C0 RID: 5056 RVA: 0x00082F91 File Offset: 0x00081191
	private void FCGHOKACFHL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 105);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013C1 RID: 5057 RVA: 0x00082FCC File Offset: 0x000811CC
	private void KKGMKGHFELO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -54);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013C2 RID: 5058 RVA: 0x00083008 File Offset: 0x00081208
	private void MKIMDFLBFOM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -109);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060013C3 RID: 5059 RVA: 0x00083074 File Offset: 0x00081274
	private void ICILLMAKLMI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 115);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060013C4 RID: 5060 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x060013C5 RID: 5061 RVA: 0x000830E0 File Offset: 0x000812E0
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1862f)
			{
				this.HBJJOCHGOPH = 173f;
			}
			if (this.Camera2 != null)
			{
				this.ELBMIEOIABA().SetTexture("(http|https)://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?\\.(jpg|jpeg|gif|png)", this.JDMCFBKJHDD);
			}
			this.OCMBHMLNCEK().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.OCMBHMLNCEK().SetFloat("shaders", this.BlendFX);
			this.KHCLIAMBBNC().SetFloat("Joystick1Button4", this.SwitchCameraToCamera2);
			this.ACHNOHCLGOO().SetVector("getbool", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 805f, 1809f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060013C6 RID: 5062 RVA: 0x000831DA File Offset: 0x000813DA
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060013C7 RID: 5063 RVA: 0x00083211 File Offset: 0x00081411
	private void ANKALNDLHEL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -30);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013C8 RID: 5064 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x060013C9 RID: 5065 RVA: 0x0008324C File Offset: 0x0008144C
	private void FINDGJLEHOL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 120);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013CA RID: 5066 RVA: 0x00083288 File Offset: 0x00081488
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 56f)
			{
				this.HBJJOCHGOPH = 1989f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("Source Object: ", this.JDMCFBKJHDD);
			}
			this.KOHGPKOFEJO().SetFloat("|", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("_Value8", this.BlendFX);
			this.ACHNOHCLGOO().SetFloat("SupportLogger OnConnectedToPhoton().", this.SwitchCameraToCamera2);
			this.PLBEJJIHFPB().SetVector("CameraFilterPack/FX_Ascii", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 102f, 973f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060013CB RID: 5067 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x060013CC RID: 5068 RVA: 0x00083384 File Offset: 0x00081584
	private void IBBFFKEAOCE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 358f)
			{
				this.HBJJOCHGOPH = 1342f;
			}
			if (this.Camera2 != null)
			{
				this.BAGICADFBAB().SetTexture("CameraFilterPack/Blend2Camera_LinearLight", this.JDMCFBKJHDD);
			}
			this.MICHFGAOPKM().SetFloat("settings.disablestoryboard", this.HBJJOCHGOPH);
			this.HILDKDFEBPF().SetFloat(") but there is no recycle bin setup for it", this.BlendFX);
			this.DBOLLHHMKKN().SetFloat("_TimeX", this.SwitchCameraToCamera2);
			this.OIBHFCLJKDB().SetVector("mapid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1844f, 475f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060013CD RID: 5069 RVA: 0x000820E9 File Offset: 0x000802E9
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

	// Token: 0x060013CE RID: 5070 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x060013CF RID: 5071 RVA: 0x0008347E File Offset: 0x0008167E
	private void DBIBFOINCKM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -96);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013D0 RID: 5072 RVA: 0x000834B9 File Offset: 0x000816B9
	private void HMKJFPBFOFI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -58);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013D1 RID: 5073 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x060013D2 RID: 5074 RVA: 0x000834F4 File Offset: 0x000816F4
	private Material KHCLIAMBBNC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060013D3 RID: 5075 RVA: 0x000820E9 File Offset: 0x000802E9
	private void JLNNHKPHMAB()
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

	// Token: 0x060013D4 RID: 5076 RVA: 0x0008352B File Offset: 0x0008172B
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060013D5 RID: 5077 RVA: 0x00083564 File Offset: 0x00081764
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 426f)
			{
				this.HBJJOCHGOPH = 459f;
			}
			if (this.Camera2 != null)
			{
				this.HNFFHCLNBDN().SetTexture("ScoreText", this.JDMCFBKJHDD);
			}
			this.PLBEJJIHFPB().SetFloat("CameraFilterPack/Colors_HUE_Rotate", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("1234332714", this.BlendFX);
			this.NFMGLIKNOOC().SetFloat("_Intensity", this.SwitchCameraToCamera2);
			this.HNFFHCLNBDN().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1178f, 313f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060013D6 RID: 5078 RVA: 0x00083660 File Offset: 0x00081860
	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 849f)
			{
				this.HBJJOCHGOPH = 269f;
			}
			if (this.Camera2 != null)
			{
				this.ELBMIEOIABA().SetTexture("maps.", this.JDMCFBKJHDD);
			}
			this.GCDFNHMJMIP().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", this.BlendFX);
			this.CFEDGDGBCHE().SetFloat("rd", this.SwitchCameraToCamera2);
			this.ACHNOHCLGOO().SetVector("true", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1086f, 751f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060013D7 RID: 5079 RVA: 0x0008375C File Offset: 0x0008195C
	private void AEDDNDHCLNN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 85);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060013D8 RID: 5080 RVA: 0x000820E9 File Offset: 0x000802E9
	private void LINKAMEPKGM()
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

	// Token: 0x060013D9 RID: 5081 RVA: 0x000837C8 File Offset: 0x000819C8
	private void HPFIHLMKIPF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -46);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060013DA RID: 5082 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x060013DB RID: 5083 RVA: 0x00083834 File Offset: 0x00081A34
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 66f)
			{
				this.HBJJOCHGOPH = 116f;
			}
			if (this.Camera2 != null)
			{
				this.MICHFGAOPKM().SetTexture("Bad parameters for setbool! Use <key> <value>", this.JDMCFBKJHDD);
			}
			this.ACHNOHCLGOO().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.OIBHFCLJKDB().SetFloat("_Visualize", this.BlendFX);
			this.GCDFNHMJMIP().SetFloat("_Value6", this.SwitchCameraToCamera2);
			this.DBOLLHHMKKN().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 420f, 253f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060013DC RID: 5084 RVA: 0x0008392E File Offset: 0x00081B2E
	private void JIPEMDLKAGO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -52);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013DD RID: 5085 RVA: 0x0008396C File Offset: 0x00081B6C
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1830f)
			{
				this.HBJJOCHGOPH = 1696f;
			}
			if (this.Camera2 != null)
			{
				this.MICHFGAOPKM().SetTexture(" ", this.JDMCFBKJHDD);
			}
			this.HILDKDFEBPF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.ELBMIEOIABA().SetFloat("mapselector.filter.rateduponly", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("ScreenResolutionPanel", this.SwitchCameraToCamera2);
			this.HNFFHCLNBDN().SetVector("action", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 539f, 1014f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060013DE RID: 5086 RVA: 0x00083A66 File Offset: 0x00081C66
	private Material OIBHFCLJKDB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060013DF RID: 5087 RVA: 0x000820E9 File Offset: 0x000802E9
	private void EDCMIPNCPLB()
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

	// Token: 0x060013E0 RID: 5088 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060013E1 RID: 5089 RVA: 0x00083A9D File Offset: 0x00081C9D
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060013E2 RID: 5090 RVA: 0x00083AD4 File Offset: 0x00081CD4
	private Material ELBMIEOIABA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060013E3 RID: 5091 RVA: 0x000820E9 File Offset: 0x000802E9
	private void FDMAEPOHDMK()
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

	// Token: 0x060013E4 RID: 5092 RVA: 0x0008215A File Offset: 0x0008035A
	private void LOLHKNKBNPF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 122);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013E5 RID: 5093 RVA: 0x00083B0C File Offset: 0x00081D0C
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 517f)
			{
				this.HBJJOCHGOPH = 1983f;
			}
			if (this.Camera2 != null)
			{
				this.PLBEJJIHFPB().SetTexture("_SecondTex", this.JDMCFBKJHDD);
			}
			this.OCMBHMLNCEK().SetFloat("YES", this.HBJJOCHGOPH);
			this.OIBHFCLJKDB().SetFloat("_Green_B", this.BlendFX);
			this.MICHFGAOPKM().SetFloat("_Intensity", this.SwitchCameraToCamera2);
			this.MICHFGAOPKM().SetVector("[CraftingPanel] Init", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1436f, 409f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060013E6 RID: 5094 RVA: 0x000820E9 File Offset: 0x000802E9
	private void IFIHBNJKEKD()
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

	// Token: 0x060013E7 RID: 5095 RVA: 0x00083C06 File Offset: 0x00081E06
	private Material GJHPODJOBHL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060013E8 RID: 5096 RVA: 0x000820E9 File Offset: 0x000802E9
	private void ODGMCJILIHF()
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

	// Token: 0x060013E9 RID: 5097 RVA: 0x00083C3D File Offset: 0x00081E3D
	private void MHHMIFHKEDH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 10);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013EA RID: 5098 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x060013EB RID: 5099 RVA: 0x00083C78 File Offset: 0x00081E78
	private void COCBPFHHLGI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -36);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013EC RID: 5100 RVA: 0x00083CB4 File Offset: 0x00081EB4
	private void JKFDDNMPOJH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -18);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060013ED RID: 5101 RVA: 0x00083D20 File Offset: 0x00081F20
	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1825f)
			{
				this.HBJJOCHGOPH = 1128f;
			}
			if (this.Camera2 != null)
			{
				this.KHCLIAMBBNC().SetTexture("Soundtrack", this.JDMCFBKJHDD);
			}
			this.ELBMIEOIABA().SetFloat("#getrewardfailed: ", this.HBJJOCHGOPH);
			this.HILDKDFEBPF().SetFloat("offsets", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("player.xp", this.SwitchCameraToCamera2);
			this.KHCLIAMBBNC().SetVector("#91CCFF", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 607f, 1796f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060013EE RID: 5102 RVA: 0x00083E1A File Offset: 0x0008201A
	private void BHBCNNIJECK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -7);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013EF RID: 5103 RVA: 0x00083E58 File Offset: 0x00082058
	private void KMCPMOGKDEH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 34);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060013F0 RID: 5104 RVA: 0x00083EC4 File Offset: 0x000820C4
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 424f)
			{
				this.HBJJOCHGOPH = 65f;
			}
			if (this.Camera2 != null)
			{
				this.ACHNOHCLGOO().SetTexture("_DotSize", this.JDMCFBKJHDD);
			}
			this.CFEDGDGBCHE().SetFloat("health", this.HBJJOCHGOPH);
			this.OIBHFCLJKDB().SetFloat("_Distortion", this.BlendFX);
			this.ACHNOHCLGOO().SetFloat("_Value", this.SwitchCameraToCamera2);
			this.BAGICADFBAB().SetVector("Back", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 409f, 1582f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060013F1 RID: 5105 RVA: 0x00083FBE File Offset: 0x000821BE
	private void FPBIGAKLKIG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -16);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013F2 RID: 5106 RVA: 0x000820E9 File Offset: 0x000802E9
	private void AOKOLPEGHDD()
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

	// Token: 0x060013F3 RID: 5107 RVA: 0x00083FF9 File Offset: 0x000821F9
	private void OOHJBHLKGDJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -83);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013F4 RID: 5108 RVA: 0x00084034 File Offset: 0x00082234
	private void LMKMEJMGDFO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 2);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013F5 RID: 5109 RVA: 0x00084070 File Offset: 0x00082270
	private void ALNNIDLFILB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 46);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060013F6 RID: 5110 RVA: 0x000840D9 File Offset: 0x000822D9
	private void HHODKHPIBLG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 5);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013F7 RID: 5111 RVA: 0x00084114 File Offset: 0x00082314
	private void EAFFHHCMLCG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 126);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013F8 RID: 5112 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x060013F9 RID: 5113 RVA: 0x0008414F File Offset: 0x0008234F
	private void NEGKFLLFLOK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 72);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060013FA RID: 5114 RVA: 0x000820E9 File Offset: 0x000802E9
	private void GNPDGBNDCPL()
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

	// Token: 0x060013FB RID: 5115 RVA: 0x0008418C File Offset: 0x0008238C
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1314f)
			{
				this.HBJJOCHGOPH = 1930f;
			}
			if (this.Camera2 != null)
			{
				this.KHCLIAMBBNC().SetTexture("PLAY [SPACE]", this.JDMCFBKJHDD);
			}
			this.ELBMIEOIABA().SetFloat("settings.fps", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("OpSetPropertiesOfActor()", this.BlendFX);
			this.PLBEJJIHFPB().SetFloat("You have added the SecondScrollRect to a scroll view that already has both directions selected", this.SwitchCameraToCamera2);
			this.MPENCEIGLEH().SetVector("CameraFilterPack/Blur_Blurry", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1842f, 738f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060013FC RID: 5116 RVA: 0x00084288 File Offset: 0x00082488
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 999f)
			{
				this.HBJJOCHGOPH = 1616f;
			}
			if (this.Camera2 != null)
			{
				this.KBOPGONOCNP().SetTexture("{0:0.0} ms ({1:0.} fps)", this.JDMCFBKJHDD);
			}
			this.KBOPGONOCNP().SetFloat("Joystick1Button8", this.HBJJOCHGOPH);
			this.MPENCEIGLEH().SetFloat("HPText", this.BlendFX);
			this.MICHFGAOPKM().SetFloat("_ScreenResolution", this.SwitchCameraToCamera2);
			this.GJHPODJOBHL().SetVector(".workshop", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 744f, 1369f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060013FD RID: 5117 RVA: 0x00084382 File Offset: 0x00082582
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060013FE RID: 5118 RVA: 0x000843B9 File Offset: 0x000825B9
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060013FF RID: 5119 RVA: 0x000843F0 File Offset: 0x000825F0
	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1509f)
			{
				this.HBJJOCHGOPH = 1583f;
			}
			if (this.Camera2 != null)
			{
				this.ACHNOHCLGOO().SetTexture("recipes", this.JDMCFBKJHDD);
			}
			this.ELBMIEOIABA().SetFloat("CameraFilterPack/Glow_Glow", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("_ChangeRed", this.BlendFX);
			this.NFMGLIKNOOC().SetFloat("#", this.SwitchCameraToCamera2);
			this.KOHGPKOFEJO().SetVector("InfoButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1265f, 594f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001400 RID: 5120 RVA: 0x000844EC File Offset: 0x000826EC
	private void CEAGPJBGBMH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -57);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001402 RID: 5122 RVA: 0x000820E9 File Offset: 0x000802E9
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

	// Token: 0x06001403 RID: 5123 RVA: 0x000820E9 File Offset: 0x000802E9
	private void FKEJGBFDCAH()
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

	// Token: 0x1700002E RID: 46
	// (get) Token: 0x06001404 RID: 5124 RVA: 0x0008457E File Offset: 0x0008277E
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

	// Token: 0x06001405 RID: 5125 RVA: 0x000845B5 File Offset: 0x000827B5
	private void AJENCHHLHKF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 98);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001406 RID: 5126 RVA: 0x000845F0 File Offset: 0x000827F0
	private void HOPAMNJIBHA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -92);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001407 RID: 5127 RVA: 0x000820E9 File Offset: 0x000802E9
	private void AMHEJBMLFNM()
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

	// Token: 0x06001408 RID: 5128 RVA: 0x0008462C File Offset: 0x0008282C
	private void AOGCKKLFGPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1013f)
			{
				this.HBJJOCHGOPH = 1525f;
			}
			if (this.Camera2 != null)
			{
				this.NFMGLIKNOOC().SetTexture("workshop.txt", this.JDMCFBKJHDD);
			}
			this.DBOLLHHMKKN().SetFloat("Status: ", this.HBJJOCHGOPH);
			this.ELBMIEOIABA().SetFloat("ResetButton", this.BlendFX);
			this.HNFFHCLNBDN().SetFloat("Creating new item...", this.SwitchCameraToCamera2);
			this.HNFFHCLNBDN().SetVector("_Val3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1460f, 542f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001409 RID: 5129 RVA: 0x00084728 File Offset: 0x00082928
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

	// Token: 0x0600140A RID: 5130 RVA: 0x00084034 File Offset: 0x00082234
	private void HIAICHPPGBP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 2);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600140B RID: 5131 RVA: 0x00084822 File Offset: 0x00082A22
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600140C RID: 5132 RVA: 0x00084859 File Offset: 0x00082A59
	private void LJEDJDGPGFG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 109);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600140D RID: 5133 RVA: 0x00084894 File Offset: 0x00082A94
	private Material HILDKDFEBPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600140E RID: 5134 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x0600140F RID: 5135 RVA: 0x00082896 File Offset: 0x00080A96
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001410 RID: 5136 RVA: 0x000848CC File Offset: 0x00082ACC
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 523f)
			{
				this.HBJJOCHGOPH = 1282f;
			}
			if (this.Camera2 != null)
			{
				this.KOHGPKOFEJO().SetTexture("_TimeX", this.JDMCFBKJHDD);
			}
			this.HNFFHCLNBDN().SetFloat("mapselector.filter.favoriteonly", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("{0}_{1}", this.BlendFX);
			this.DKNJGHFLAIF().SetFloat("Set the end of the map. Use this if you want to cut the long music.", this.SwitchCameraToCamera2);
			this.HILDKDFEBPF().SetVector("SendVacantViewIds()", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1594f, 1978f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001411 RID: 5137 RVA: 0x00082D49 File Offset: 0x00080F49
	private void GFELOCODMPJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 111);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001412 RID: 5138 RVA: 0x000820E9 File Offset: 0x000802E9
	private void EKPLGFAEOBE()
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

	// Token: 0x06001413 RID: 5139 RVA: 0x000849C8 File Offset: 0x00082BC8
	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 114f)
			{
				this.HBJJOCHGOPH = 863f;
			}
			if (this.Camera2 != null)
			{
				this.ACHNOHCLGOO().SetTexture("CameraFilterPack/3D_Binary", this.JDMCFBKJHDD);
			}
			this.HNFFHCLNBDN().SetFloat("Keypad ", this.HBJJOCHGOPH);
			this.MICHFGAOPKM().SetFloat("yyyy-MM-dd HH:mm:ss", this.BlendFX);
			this.ACHNOHCLGOO().SetFloat("^", this.SwitchCameraToCamera2);
			this.DKNJGHFLAIF().SetVector("z", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1125f, 915f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001414 RID: 5140 RVA: 0x00084AC2 File Offset: 0x00082CC2
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001415 RID: 5141 RVA: 0x00084AFC File Offset: 0x00082CFC
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 790f)
			{
				this.HBJJOCHGOPH = 613f;
			}
			if (this.Camera2 != null)
			{
				this.GJHPODJOBHL().SetTexture("speed", this.JDMCFBKJHDD);
			}
			this.KOHGPKOFEJO().SetFloat("_CurveParams", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat("CameraFilterPack_TV_Arcade1", this.BlendFX);
			this.DBOLLHHMKKN().SetFloat("player.rgb", this.SwitchCameraToCamera2);
			this.GCDFNHMJMIP().SetVector("ShadersToggle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1929f, 1957f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001416 RID: 5142 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x06001417 RID: 5143 RVA: 0x00084BF8 File Offset: 0x00082DF8
	private void DAHFFNNIGML()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -53);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001418 RID: 5144 RVA: 0x000820E9 File Offset: 0x000802E9
	private void GBGAMCPNBCC()
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

	// Token: 0x040002C4 RID: 708
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Hue";

	// Token: 0x040002C5 RID: 709
	public Shader SCShader;

	// Token: 0x040002C6 RID: 710
	public Camera Camera2;

	// Token: 0x040002C7 RID: 711
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040002C8 RID: 712
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040002C9 RID: 713
	private Material BJFKDHHMLJH;

	// Token: 0x040002CA RID: 714
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x040002CB RID: 715
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x040002CC RID: 716
	private RenderTexture JDMCFBKJHDD;
}
