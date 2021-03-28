using System;
using UnityEngine;

// Token: 0x0200004B RID: 75
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/LinearDodge")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_LinearDodge : MonoBehaviour
{
	// Token: 0x060014E0 RID: 5344 RVA: 0x000884D5 File Offset: 0x000866D5
	private void LONLHFLPEJD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -19);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014E1 RID: 5345 RVA: 0x00088510 File Offset: 0x00086710
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014E2 RID: 5346 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x060014E3 RID: 5347 RVA: 0x0008854C File Offset: 0x0008674C
	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1416f)
			{
				this.HBJJOCHGOPH = 114f;
			}
			if (this.Camera2 != null)
			{
				this.KOHGPKOFEJO().SetTexture("0,1,false", this.JDMCFBKJHDD);
			}
			this.OOMFJGPAOKL().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("R:", this.BlendFX);
			this.HNICHJCGJOC().SetFloat("May", this.SwitchCameraToCamera2);
			this.NFKFAAHHLLM().SetVector("settings_bindings_", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1125f, 103f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060014E4 RID: 5348 RVA: 0x00088648 File Offset: 0x00086848
	private void LIBGAKMKHJJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -38);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060014E5 RID: 5349 RVA: 0x000886B4 File Offset: 0x000868B4
	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1735f)
			{
				this.HBJJOCHGOPH = 458f;
			}
			if (this.Camera2 != null)
			{
				this.HNICHJCGJOC().SetTexture("_Offsets", this.JDMCFBKJHDD);
			}
			this.KOHGPKOFEJO().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetFloat(". Verify the Prefab is in a Resources folder (and not in a subfolder)", this.BlendFX);
			this.FOOCJIDNGBB().SetFloat("_LightIntensity", this.SwitchCameraToCamera2);
			this.HCGJCMDJPGD().SetVector("DifficultyBG", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 110f, 675f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060014E6 RID: 5350 RVA: 0x000887B0 File Offset: 0x000869B0
	private void KCCIEMBMOBA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -61);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060014E7 RID: 5351 RVA: 0x0008881C File Offset: 0x00086A1C
	private void BGDPIHMAACO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 42);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060014E8 RID: 5352 RVA: 0x00088885 File Offset: 0x00086A85
	private void HGJKBDGABKM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -79);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014E9 RID: 5353 RVA: 0x000888C0 File Offset: 0x00086AC0
	private void MOMGJJDIFFI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 32);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014EA RID: 5354 RVA: 0x000888FB File Offset: 0x00086AFB
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060014EB RID: 5355 RVA: 0x00088932 File Offset: 0x00086B32
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060014ED RID: 5357 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x060014EE RID: 5358 RVA: 0x00088992 File Offset: 0x00086B92
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

	// Token: 0x060014EF RID: 5359 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x060014F0 RID: 5360 RVA: 0x000889CC File Offset: 0x00086BCC
	private void EMAMCDFBGOA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 21);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014F1 RID: 5361 RVA: 0x00088A08 File Offset: 0x00086C08
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 595f)
			{
				this.HBJJOCHGOPH = 790f;
			}
			if (this.Camera2 != null)
			{
				this.FLOHGDECHHH().SetTexture("CameraFilterPack_VHS2", this.JDMCFBKJHDD);
			}
			this.KOHGPKOFEJO().SetFloat("PunSupportLogger", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("Can't find key ", this.BlendFX);
			this.NFKFAAHHLLM().SetFloat("setAF", this.SwitchCameraToCamera2);
			this.HNICHJCGJOC().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 362f, 457f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060014F2 RID: 5362 RVA: 0x00088992 File Offset: 0x00086B92
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

	// Token: 0x060014F3 RID: 5363 RVA: 0x00088B04 File Offset: 0x00086D04
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1132f)
			{
				this.HBJJOCHGOPH = 1414f;
			}
			if (this.Camera2 != null)
			{
				this.EMDFHOKEGNG().SetTexture("y", this.JDMCFBKJHDD);
			}
			this.OOMFJGPAOKL().SetFloat("_Axis", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("_FarCamera", this.BlendFX);
			this.JIBOKBCPDLC().SetFloat("SetSunInput", this.SwitchCameraToCamera2);
			this.OOMFJGPAOKL().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1515f, 1036f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060014F4 RID: 5364 RVA: 0x00088BFE File Offset: 0x00086DFE
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060014F5 RID: 5365 RVA: 0x00088992 File Offset: 0x00086B92
	private void OOGIHDLBBLM()
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

	// Token: 0x060014F6 RID: 5366 RVA: 0x00088C38 File Offset: 0x00086E38
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 415f)
			{
				this.HBJJOCHGOPH = 1647f;
			}
			if (this.Camera2 != null)
			{
				this.DKNJGHFLAIF().SetTexture("' ping: ", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Sharpen_Sharpen", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("Joystick1Button4", this.BlendFX);
			this.FOOCJIDNGBB().SetFloat("{0} years ago", this.SwitchCameraToCamera2);
			this.OIIDAKBILMI().SetVector("&search=", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1129f, 379f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FOOCJIDNGBB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060014F7 RID: 5367 RVA: 0x00088D32 File Offset: 0x00086F32
	private void HIDOPHINPAL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -25);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014F8 RID: 5368 RVA: 0x00088D70 File Offset: 0x00086F70
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 277f)
			{
				this.HBJJOCHGOPH = 1168f;
			}
			if (this.Camera2 != null)
			{
				this.HEHKGPKLAKK().SetTexture(":", this.JDMCFBKJHDD);
			}
			this.HCGJCMDJPGD().SetFloat("SetParticlesCountPerBeat", this.HBJJOCHGOPH);
			this.FOOCJIDNGBB().SetFloat("CameraFilterPack/Drawing_Curve", this.BlendFX);
			this.NFKFAAHHLLM().SetFloat("Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ", this.SwitchCameraToCamera2);
			this.NFKFAAHHLLM().SetVector(" Server: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 341f, 709f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060014F9 RID: 5369 RVA: 0x00088E6C File Offset: 0x0008706C
	private void CIPKEPDELJB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 88);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060014FA RID: 5370 RVA: 0x00088992 File Offset: 0x00086B92
	private void MGFFNGEGFDC()
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

	// Token: 0x060014FB RID: 5371 RVA: 0x00088ED5 File Offset: 0x000870D5
	private void MEJPBKFMAIG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 23);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060014FC RID: 5372 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x060014FD RID: 5373 RVA: 0x00088F10 File Offset: 0x00087110
	private Material FOOCJIDNGBB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060014FE RID: 5374 RVA: 0x00088F48 File Offset: 0x00087148
	private void NPLCENPNJBM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -74);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060014FF RID: 5375 RVA: 0x00088FB1 File Offset: 0x000871B1
	private void FELENDJEOGA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -8);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001500 RID: 5376 RVA: 0x00088FEC File Offset: 0x000871EC
	private void JOLKPPEBILA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -125);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001501 RID: 5377 RVA: 0x00089027 File Offset: 0x00087227
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001502 RID: 5378 RVA: 0x0008905E File Offset: 0x0008725E
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001503 RID: 5379 RVA: 0x00089095 File Offset: 0x00087295
	private void LMKMEJMGDFO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -54);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001504 RID: 5380 RVA: 0x0002523B File Offset: 0x0002343B
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x06001505 RID: 5381 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06001506 RID: 5382 RVA: 0x000890D0 File Offset: 0x000872D0
	private void PAHNKEGFGHB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 77);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001507 RID: 5383 RVA: 0x0008910C File Offset: 0x0008730C
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 719f)
			{
				this.HBJJOCHGOPH = 908f;
			}
			if (this.Camera2 != null)
			{
				this.JIBOKBCPDLC().SetTexture("LoadMapCanvas", this.JDMCFBKJHDD);
			}
			this.JIBOKBCPDLC().SetFloat(".", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("_ScreenResolution", this.BlendFX);
			this.OIIDAKBILMI().SetFloat("_LutTex", this.SwitchCameraToCamera2);
			this.HCGJCMDJPGD().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1944f, 514f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001508 RID: 5384 RVA: 0x00089208 File Offset: 0x00087408
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1965f)
			{
				this.HBJJOCHGOPH = 880f;
			}
			if (this.Camera2 != null)
			{
				this.OIIDAKBILMI().SetTexture("[MapsStats] Length: ", this.JDMCFBKJHDD);
			}
			this.KOHGPKOFEJO().SetFloat("InfoCanvas", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("float,2", this.BlendFX);
			this.JIBOKBCPDLC().SetFloat("StartButton", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("[MapEditor] Updating top menu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1805f, 644f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001509 RID: 5385 RVA: 0x00088510 File Offset: 0x00086710
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600150A RID: 5386 RVA: 0x00089304 File Offset: 0x00087504
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1763f)
			{
				this.HBJJOCHGOPH = 816f;
			}
			if (this.Camera2 != null)
			{
				this.OOMFJGPAOKL().SetTexture("Joystick1Button10", this.JDMCFBKJHDD);
			}
			this.MICHFGAOPKM().SetFloat("/", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("keep aspect ratio", this.BlendFX);
			this.MMOODGIODPC().SetFloat(" ", this.SwitchCameraToCamera2);
			this.JIBOKBCPDLC().SetVector("Commands for challenges", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 230f, 1355f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600150B RID: 5387 RVA: 0x00089400 File Offset: 0x00087600
	private void JDKHBGDEONK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 63);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600150C RID: 5388 RVA: 0x0008946C File Offset: 0x0008766C
	private void FHPFJBFCOOF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 68);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600150D RID: 5389 RVA: 0x000894D8 File Offset: 0x000876D8
	private void FDNONDCGGCG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 6);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600150E RID: 5390 RVA: 0x00089544 File Offset: 0x00087744
	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1816f)
			{
				this.HBJJOCHGOPH = 1767f;
			}
			if (this.Camera2 != null)
			{
				this.EMDFHOKEGNG().SetTexture("Set satellite beat detection sensitivity", this.JDMCFBKJHDD);
			}
			this.MMOODGIODPC().SetFloat("_Value", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("y", this.BlendFX);
			this.EMDFHOKEGNG().SetFloat("_SphereSize", this.SwitchCameraToCamera2);
			this.HNICHJCGJOC().SetVector("y", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 509f, 490f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600150F RID: 5391 RVA: 0x00089640 File Offset: 0x00087840
	private void KDMANOEMOCA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 105);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001510 RID: 5392 RVA: 0x000896AC File Offset: 0x000878AC
	private void DFFKKLAPHCC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -31);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001511 RID: 5393 RVA: 0x00089718 File Offset: 0x00087918
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 565f)
			{
				this.HBJJOCHGOPH = 428f;
			}
			if (this.Camera2 != null)
			{
				this.MMOODGIODPC().SetTexture("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results", this.JDMCFBKJHDD);
			}
			this.MICHFGAOPKM().SetFloat("CameraFilterPack/OldFilm_Cutting1", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("_Value5", this.BlendFX);
			this.HEHKGPKLAKK().SetFloat("JoinRoom failed. In offline mode you still have to leave a room to enter another.", this.SwitchCameraToCamera2);
			this.HCGJCMDJPGD().SetVector("Tab2Content", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 912f, 827f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001512 RID: 5394 RVA: 0x00089812 File Offset: 0x00087A12
	private void JBAPHFIBANG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -42);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001513 RID: 5395 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06001514 RID: 5396 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06001515 RID: 5397 RVA: 0x0008984D File Offset: 0x00087A4D
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001516 RID: 5398 RVA: 0x00089884 File Offset: 0x00087A84
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1366f)
			{
				this.HBJJOCHGOPH = 269f;
			}
			if (this.Camera2 != null)
			{
				this.HEHKGPKLAKK().SetTexture("CameraFilterPack/Gradients_FireGradient", this.JDMCFBKJHDD);
			}
			this.FLOHGDECHHH().SetFloat("LB", this.HBJJOCHGOPH);
			this.FOOCJIDNGBB().SetFloat("_TimeX", this.BlendFX);
			this.EMDFHOKEGNG().SetFloat("R:", this.SwitchCameraToCamera2);
			this.KOHGPKOFEJO().SetVector("Object ID. Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 515f, 1868f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001517 RID: 5399 RVA: 0x0008997E File Offset: 0x00087B7E
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001518 RID: 5400 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06001519 RID: 5401 RVA: 0x000899B5 File Offset: 0x00087BB5
	private void EONOOEJDNEF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 105);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600151A RID: 5402 RVA: 0x000899F0 File Offset: 0x00087BF0
	private void MGMLGCNLMKN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 124);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600151B RID: 5403 RVA: 0x00089A2C File Offset: 0x00087C2C
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1785f)
			{
				this.HBJJOCHGOPH = 7f;
			}
			if (this.Camera2 != null)
			{
				this.HCGJCMDJPGD().SetTexture("CameraFilterPack/3D_Shield", this.JDMCFBKJHDD);
			}
			this.MMOODGIODPC().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("_ScreenResolution", this.BlendFX);
			this.MMOODGIODPC().SetFloat(". Our prefix is ", this.SwitchCameraToCamera2);
			this.OIIDAKBILMI().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 611f, 379f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600151C RID: 5404 RVA: 0x00089B28 File Offset: 0x00087D28
	private void NBGIMIDICKE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -58);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600151D RID: 5405 RVA: 0x00088992 File Offset: 0x00086B92
	private void IENKPJEBMFM()
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

	// Token: 0x0600151E RID: 5406 RVA: 0x00089B91 File Offset: 0x00087D91
	private void AJBHOEBKGDO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 41);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x17000032 RID: 50
	// (get) Token: 0x0600151F RID: 5407 RVA: 0x00089BCC File Offset: 0x00087DCC
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

	// Token: 0x06001520 RID: 5408 RVA: 0x00089C04 File Offset: 0x00087E04
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1659f)
			{
				this.HBJJOCHGOPH = 1409f;
			}
			if (this.Camera2 != null)
			{
				this.DKNJGHFLAIF().SetTexture("_Sensitivity", this.JDMCFBKJHDD);
			}
			this.DKNJGHFLAIF().SetFloat("Ok", this.HBJJOCHGOPH);
			this.OOMFJGPAOKL().SetFloat(",", this.BlendFX);
			this.FOOCJIDNGBB().SetFloat("LB", this.SwitchCameraToCamera2);
			this.DKNJGHFLAIF().SetVector("offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1288f, 484f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001521 RID: 5409 RVA: 0x00088992 File Offset: 0x00086B92
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

	// Token: 0x06001522 RID: 5410 RVA: 0x00089D00 File Offset: 0x00087F00
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

	// Token: 0x06001523 RID: 5411 RVA: 0x00089D69 File Offset: 0x00087F69
	private void JNACKHNNEPA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -91);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001524 RID: 5412 RVA: 0x00089DA4 File Offset: 0x00087FA4
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 581f)
			{
				this.HBJJOCHGOPH = 177f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("GlassColor", this.JDMCFBKJHDD);
			}
			this.OOMFJGPAOKL().SetFloat("_SpherePositionX", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat(" to: ", this.BlendFX);
			this.FOOCJIDNGBB().SetFloat(".png", this.SwitchCameraToCamera2);
			this.EMDFHOKEGNG().SetVector("Using WebSocket to connect NameServer (AuthMode is AuthOnceWss).", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 56f, 260f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001525 RID: 5413 RVA: 0x00089E9E File Offset: 0x0008809E
	private void AAPKKMKDOFO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 102);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001526 RID: 5414 RVA: 0x00088992 File Offset: 0x00086B92
	private void NAALCEPIHCH()
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

	// Token: 0x06001527 RID: 5415 RVA: 0x00089ED9 File Offset: 0x000880D9
	private Material OOMFJGPAOKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001528 RID: 5416 RVA: 0x00089F10 File Offset: 0x00088110
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1118f)
			{
				this.HBJJOCHGOPH = 1164f;
			}
			if (this.Camera2 != null)
			{
				this.MMOODGIODPC().SetTexture("<b>#", this.JDMCFBKJHDD);
			}
			this.EMDFHOKEGNG().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("SaveButton", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("Scrollbar", this.SwitchCameraToCamera2);
			this.MICHFGAOPKM().SetVector("Achievement 21 progress reseted", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 378f, 1495f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001529 RID: 5417 RVA: 0x0008A00A File Offset: 0x0008820A
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600152A RID: 5418 RVA: 0x0008A044 File Offset: 0x00088244
	private void IDJKNBDKHBD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 20);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600152B RID: 5419 RVA: 0x0008A0B0 File Offset: 0x000882B0
	private void DIPDEHOOBPG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -70);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600152C RID: 5420 RVA: 0x0008A11C File Offset: 0x0008831C
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1505f)
			{
				this.HBJJOCHGOPH = 75f;
			}
			if (this.Camera2 != null)
			{
				this.OOMFJGPAOKL().SetTexture("_MainTex2", this.JDMCFBKJHDD);
			}
			this.FOOCJIDNGBB().SetFloat(".lastCheckpoint.incorrectScore", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("_ChannelMixerGreen", this.BlendFX);
			this.OIIDAKBILMI().SetFloat("Drop_Far", this.SwitchCameraToCamera2);
			this.HCGJCMDJPGD().SetVector("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 876f, 492f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600152D RID: 5421 RVA: 0x0008A218 File Offset: 0x00088418
	private void HMPGIFBJFIK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -88);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600152E RID: 5422 RVA: 0x0008A281 File Offset: 0x00088481
	private void ANKALNDLHEL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -40);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600152F RID: 5423 RVA: 0x0008A2BC File Offset: 0x000884BC
	private void NEGKFLLFLOK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 99);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001530 RID: 5424 RVA: 0x0008A2F8 File Offset: 0x000884F8
	private void DNNFHBOOPIN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -32);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001531 RID: 5425 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06001532 RID: 5426 RVA: 0x0008A364 File Offset: 0x00088564
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1683f)
			{
				this.HBJJOCHGOPH = 1517f;
			}
			if (this.Camera2 != null)
			{
				this.KOHGPKOFEJO().SetTexture("public", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("Operation ", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("ItemNameText", this.BlendFX);
			this.MICHFGAOPKM().SetFloat("x", this.SwitchCameraToCamera2);
			this.HEHKGPKLAKK().SetVector("mapselector.tags.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 475f, 1616f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001533 RID: 5427 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001534 RID: 5428 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIFLPHLGLFG()
	{
	}

	// Token: 0x06001535 RID: 5429 RVA: 0x0008A460 File Offset: 0x00088660
	private void BMOFEBKGLFI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 94);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001536 RID: 5430 RVA: 0x0008A4CC File Offset: 0x000886CC
	private void KDMKDEKCELE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -93);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001537 RID: 5431 RVA: 0x0008A538 File Offset: 0x00088738
	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1459f)
			{
				this.HBJJOCHGOPH = 1922f;
			}
			if (this.Camera2 != null)
			{
				this.HEHKGPKLAKK().SetTexture("inventory.selected.", this.JDMCFBKJHDD);
			}
			this.MMOODGIODPC().SetFloat("Create failed on GameServer. Changing back to MasterServer. Msg: ", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("SetParticlesColor", this.BlendFX);
			this.NFKFAAHHLLM().SetFloat("#tryagain", this.SwitchCameraToCamera2);
			this.HEHKGPKLAKK().SetVector("wss://", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1945f, 475f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001538 RID: 5432 RVA: 0x0008A634 File Offset: 0x00088834
	private void LBAJLLFMMMP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -7);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001539 RID: 5433 RVA: 0x0008A69D File Offset: 0x0008889D
	private void MLEAHDDGEMJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 27);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600153A RID: 5434 RVA: 0x0008A6D8 File Offset: 0x000888D8
	private void PKLOBJHKFEO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -89);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600153B RID: 5435 RVA: 0x0008A744 File Offset: 0x00088944
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 28f)
			{
				this.HBJJOCHGOPH = 1392f;
			}
			if (this.Camera2 != null)
			{
				this.MMOODGIODPC().SetTexture("_Visualize", this.JDMCFBKJHDD);
			}
			this.JIBOKBCPDLC().SetFloat("If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat("...", this.BlendFX);
			this.HEHKGPKLAKK().SetFloat("bad", this.SwitchCameraToCamera2);
			this.MMOODGIODPC().SetVector("}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1045f, 1501f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600153C RID: 5436 RVA: 0x00088992 File Offset: 0x00086B92
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

	// Token: 0x0600153D RID: 5437 RVA: 0x00088992 File Offset: 0x00086B92
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

	// Token: 0x0600153E RID: 5438 RVA: 0x0002523B File Offset: 0x0002343B
	private void KDJEJBBDILE()
	{
	}

	// Token: 0x0600153F RID: 5439 RVA: 0x00088D32 File Offset: 0x00086F32
	private void LKPBGHGCPKL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -25);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001540 RID: 5440 RVA: 0x0008A83E File Offset: 0x00088A3E
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001541 RID: 5441 RVA: 0x0008A875 File Offset: 0x00088A75
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001542 RID: 5442 RVA: 0x0008A8AC File Offset: 0x00088AAC
	private void PAKPHKPDKGE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -12);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001543 RID: 5443 RVA: 0x0008A915 File Offset: 0x00088B15
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001544 RID: 5444 RVA: 0x0008A94C File Offset: 0x00088B4C
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 183f)
			{
				this.HBJJOCHGOPH = 1450f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("_MainTex2", this.JDMCFBKJHDD);
			}
			this.OOMFJGPAOKL().SetFloat("Inside cells:\n", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("No child content found, exiting..", this.BlendFX);
			this.NFKFAAHHLLM().SetFloat("Spawn ark to be pressed at this time", this.SwitchCameraToCamera2);
			this.NFKFAAHHLLM().SetVector("_VignetteDesat", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1328f, 915f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001545 RID: 5445 RVA: 0x00088992 File Offset: 0x00086B92
	private void MFLBEJHMEMO()
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

	// Token: 0x06001546 RID: 5446 RVA: 0x00088992 File Offset: 0x00086B92
	private void GNMGIHFKJIJ()
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

	// Token: 0x06001547 RID: 5447 RVA: 0x0008AA48 File Offset: 0x00088C48
	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1059f)
			{
				this.HBJJOCHGOPH = 600f;
			}
			if (this.Camera2 != null)
			{
				this.DKNJGHFLAIF().SetTexture("shader.sunny", this.JDMCFBKJHDD);
			}
			this.FOOCJIDNGBB().SetFloat("GameScene", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("map.data", this.BlendFX);
			this.MMOODGIODPC().SetFloat("player.gamecompleted", this.SwitchCameraToCamera2);
			this.HCGJCMDJPGD().SetVector("#score", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 423f, 1769f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001548 RID: 5448 RVA: 0x00088992 File Offset: 0x00086B92
	private void HONBLGFDMLL()
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

	// Token: 0x06001549 RID: 5449 RVA: 0x0008AB42 File Offset: 0x00088D42
	private void INGOODALACO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -108);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600154A RID: 5450 RVA: 0x00088992 File Offset: 0x00086B92
	private void EKCKJLFFAID()
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

	// Token: 0x0600154B RID: 5451 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x0600154C RID: 5452 RVA: 0x0008AB7D File Offset: 0x00088D7D
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600154D RID: 5453 RVA: 0x0008ABB4 File Offset: 0x00088DB4
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

	// Token: 0x0600154E RID: 5454 RVA: 0x0008ACB0 File Offset: 0x00088EB0
	private void NCNPAKFAFOE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 108);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600154F RID: 5455 RVA: 0x0008AD1C File Offset: 0x00088F1C
	private void IMCKJCHKMKB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 100);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001550 RID: 5456 RVA: 0x0008AD85 File Offset: 0x00088F85
	private void BHBCNNIJECK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 17);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001551 RID: 5457 RVA: 0x0008ADC0 File Offset: 0x00088FC0
	private void NKFDNIAKGEO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -14);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001552 RID: 5458 RVA: 0x00089812 File Offset: 0x00087A12
	private void KHDANGFKIGL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -42);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x040002E8 RID: 744
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_LinearDodge";

	// Token: 0x040002E9 RID: 745
	public Shader SCShader;

	// Token: 0x040002EA RID: 746
	public Camera Camera2;

	// Token: 0x040002EB RID: 747
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040002EC RID: 748
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040002ED RID: 749
	private Material BJFKDHHMLJH;

	// Token: 0x040002EE RID: 750
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x040002EF RID: 751
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x040002F0 RID: 752
	private RenderTexture JDMCFBKJHDD;
}
