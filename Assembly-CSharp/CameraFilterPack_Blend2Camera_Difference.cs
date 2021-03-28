using System;
using UnityEngine;

// Token: 0x02000041 RID: 65
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Difference")]
public class CameraFilterPack_Blend2Camera_Difference : MonoBehaviour
{
	// Token: 0x060011CC RID: 4556 RVA: 0x00078F93 File Offset: 0x00077193
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-77);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060011CD RID: 4557 RVA: 0x00078FCA File Offset: 0x000771CA
	private void LIEGJOHINGC()
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

	// Token: 0x060011CE RID: 4558 RVA: 0x00079004 File Offset: 0x00077204
	private void GHICDLBKEJN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -61);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060011CF RID: 4559 RVA: 0x00079040 File Offset: 0x00077240
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 200f)
			{
				this.HBJJOCHGOPH = 293f;
			}
			if (this.Camera2 != null)
			{
				this.NDMPCDHADMJ().SetTexture("PunRespawn", this.JDMCFBKJHDD);
			}
			this.NFMGLIKNOOC().SetFloat("EnvironmentSlider", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("#rt", this.BlendFX);
			this.EPCGJFCCAFH().SetFloat("#ok", this.SwitchCameraToCamera2);
			this.KAFBNOBOIAJ().SetVector("[EditorEvent] Exception: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1330f, 668f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060011D0 RID: 4560 RVA: 0x0007913A File Offset: 0x0007733A
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060011D1 RID: 4561 RVA: 0x00079175 File Offset: 0x00077375
	private void DBIBFOINCKM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 26);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060011D2 RID: 4562 RVA: 0x00078FCA File Offset: 0x000771CA
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

	// Token: 0x060011D3 RID: 4563 RVA: 0x00078F93 File Offset: 0x00077193
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-77);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060011D4 RID: 4564 RVA: 0x000791B0 File Offset: 0x000773B0
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1462f)
			{
				this.HBJJOCHGOPH = 813f;
			}
			if (this.Camera2 != null)
			{
				this.EPCGJFCCAFH().SetTexture("CameraFilterPack/TV_ARCADE_2", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("_BlurredColor", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat(" Remote called.", this.BlendFX);
			this.NFMGLIKNOOC().SetFloat("X2", this.SwitchCameraToCamera2);
			this.NDMPCDHADMJ().SetVector("Up ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1496f, 1331f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060011D5 RID: 4565 RVA: 0x000792AA File Offset: 0x000774AA
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060011D6 RID: 4566 RVA: 0x000792E1 File Offset: 0x000774E1
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060011D7 RID: 4567 RVA: 0x00079318 File Offset: 0x00077518
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060011D8 RID: 4568 RVA: 0x00079350 File Offset: 0x00077550
	private void JILOMOBDPIA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 5);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060011D9 RID: 4569 RVA: 0x000793BC File Offset: 0x000775BC
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1124f)
			{
				this.HBJJOCHGOPH = 1913f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture(" not exist", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("</color>", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.BlendFX);
			this.OIMMPLPBLBK().SetFloat("RPCs can only be sent in rooms. Call of \"", this.SwitchCameraToCamera2);
			this.KBOPGONOCNP().SetVector("AudioSampler", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1166f, 1218f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060011DA RID: 4570 RVA: 0x000794B6 File Offset: 0x000776B6
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060011DB RID: 4571 RVA: 0x000794F0 File Offset: 0x000776F0
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

	// Token: 0x060011DC RID: 4572 RVA: 0x000795EA File Offset: 0x000777EA
	private void MPADDMNGJNC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -95);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060011DD RID: 4573 RVA: 0x00079628 File Offset: 0x00077828
	private void DAHFFNNIGML()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -121);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060011DE RID: 4574 RVA: 0x00078FCA File Offset: 0x000771CA
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

	// Token: 0x060011DF RID: 4575 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x060011E0 RID: 4576 RVA: 0x00079691 File Offset: 0x00077891
	private void OFBLDOCCBBN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 8);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060011E2 RID: 4578 RVA: 0x000796F5 File Offset: 0x000778F5
	private void LNIOFCGDDKP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 19);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060011E3 RID: 4579 RVA: 0x00079730 File Offset: 0x00077930
	private void BMIOFJFMCBG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -115);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060011E4 RID: 4580 RVA: 0x00078FCA File Offset: 0x000771CA
	private void PAEGLMEOKHP()
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

	// Token: 0x060011E5 RID: 4581 RVA: 0x0007979C File Offset: 0x0007799C
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 350f)
			{
				this.HBJJOCHGOPH = 903f;
			}
			if (this.Camera2 != null)
			{
				this.HCGJCMDJPGD().SetTexture("_Params3", this.JDMCFBKJHDD);
			}
			this.OIMMPLPBLBK().SetFloat("_Value", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("#rt", this.BlendFX);
			this.HCGJCMDJPGD().SetFloat("_TimeX", this.SwitchCameraToCamera2);
			this.KAFBNOBOIAJ().SetVector("VisionBlur", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1099f, 1939f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060011E6 RID: 4582 RVA: 0x00079896 File Offset: 0x00077A96
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-104);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060011E7 RID: 4583 RVA: 0x000798D0 File Offset: 0x00077AD0
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1537f)
			{
				this.HBJJOCHGOPH = 766f;
			}
			if (this.Camera2 != null)
			{
				this.KBOPGONOCNP().SetTexture("CameraFilterPack_AAA_Blood1", this.JDMCFBKJHDD);
			}
			this.HCGJCMDJPGD().SetFloat("_ChangeBlue", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", this.BlendFX);
			this.NDMPCDHADMJ().SetFloat("PLEASE WAIT", this.SwitchCameraToCamera2);
			this.KAFBNOBOIAJ().SetVector("Set sun directionVector - in which direction sun will grow on beat", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 282f, 939f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060011E8 RID: 4584 RVA: 0x000799CC File Offset: 0x00077BCC
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 311f)
			{
				this.HBJJOCHGOPH = 543f;
			}
			if (this.Camera2 != null)
			{
				this.OIMMPLPBLBK().SetTexture("note.1", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("_EmissionColor", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("shader.frost", this.BlendFX);
			this.KBOPGONOCNP().SetFloat("DPADVER", this.SwitchCameraToCamera2);
			this.PLBEJJIHFPB().SetVector("#yes", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 684f, 1887f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060011E9 RID: 4585 RVA: 0x00079AC6 File Offset: 0x00077CC6
	private void IJCBBIJOCAH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 96);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060011EA RID: 4586 RVA: 0x00079B04 File Offset: 0x00077D04
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 340f)
			{
				this.HBJJOCHGOPH = 1148f;
			}
			if (this.Camera2 != null)
			{
				this.KBOPGONOCNP().SetTexture("Reset 21 achievement progress", this.JDMCFBKJHDD);
			}
			this.EPCGJFCCAFH().SetFloat("SetSunMinSize", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("Can't connect: ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", this.BlendFX);
			this.HFBJAOFLCJI().SetFloat("Editor/", this.SwitchCameraToCamera2);
			this.OIMMPLPBLBK().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1545f, 1246f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060011EB RID: 4587 RVA: 0x00078FCA File Offset: 0x000771CA
	private void FDPOFMCFBMF()
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

	// Token: 0x060011EC RID: 4588 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x060011ED RID: 4589 RVA: 0x00079BFE File Offset: 0x00077DFE
	private void GEGDELOFIML()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -52);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060011EE RID: 4590 RVA: 0x00079C39 File Offset: 0x00077E39
	private void DCGFEIBKOBB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -118);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060011EF RID: 4591 RVA: 0x00079C74 File Offset: 0x00077E74
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060011F0 RID: 4592 RVA: 0x00079CAB File Offset: 0x00077EAB
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060011F1 RID: 4593 RVA: 0x0007913A File Offset: 0x0007733A
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060011F2 RID: 4594 RVA: 0x00079CE2 File Offset: 0x00077EE2
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x17000028 RID: 40
	// (get) Token: 0x060011F3 RID: 4595 RVA: 0x00079D19 File Offset: 0x00077F19
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

	// Token: 0x060011F4 RID: 4596 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x060011F5 RID: 4597 RVA: 0x00079D50 File Offset: 0x00077F50
	private void DLBODOFAJGM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 64);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060011F6 RID: 4598 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060011F7 RID: 4599 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x060011F8 RID: 4600 RVA: 0x00079DBC File Offset: 0x00077FBC
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

	// Token: 0x060011F9 RID: 4601 RVA: 0x00079E28 File Offset: 0x00078028
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1442f)
			{
				this.HBJJOCHGOPH = 1618f;
			}
			if (this.Camera2 != null)
			{
				this.NDMPCDHADMJ().SetTexture("Please specify either t or f.", this.JDMCFBKJHDD);
			}
			this.PLBEJJIHFPB().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("/icon", this.BlendFX);
			this.HFBJAOFLCJI().SetFloat("_Bullet_6", this.SwitchCameraToCamera2);
			this.EMDFHOKEGNG().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1306f, 849f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060011FA RID: 4602 RVA: 0x00079F22 File Offset: 0x00078122
	private void GFLAINNLMBO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -29);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060011FB RID: 4603 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x060011FC RID: 4604 RVA: 0x00078FCA File Offset: 0x000771CA
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

	// Token: 0x060011FD RID: 4605 RVA: 0x00078FCA File Offset: 0x000771CA
	private void BFEILOMHNPC()
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

	// Token: 0x060011FE RID: 4606 RVA: 0x00078FCA File Offset: 0x000771CA
	private void BNEJMABFKJE()
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

	// Token: 0x060011FF RID: 4607 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06001200 RID: 4608 RVA: 0x00078FCA File Offset: 0x000771CA
	private void NJHJHBOJKIC()
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

	// Token: 0x06001201 RID: 4609 RVA: 0x00079F60 File Offset: 0x00078160
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1244f)
			{
				this.HBJJOCHGOPH = 1999f;
			}
			if (this.Camera2 != null)
			{
				this.KAFBNOBOIAJ().SetTexture("_PColor2", this.JDMCFBKJHDD);
			}
			this.EMDFHOKEGNG().SetFloat("ChallengesButton", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("_ScreenResolution", this.BlendFX);
			this.OIMMPLPBLBK().SetFloat("GlassesColor", this.SwitchCameraToCamera2);
			this.EMDFHOKEGNG().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 399f, 1159f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001202 RID: 4610 RVA: 0x00078FCA File Offset: 0x000771CA
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

	// Token: 0x04000289 RID: 649
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Difference";

	// Token: 0x0400028A RID: 650
	public Shader SCShader;

	// Token: 0x0400028B RID: 651
	public Camera Camera2;

	// Token: 0x0400028C RID: 652
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400028D RID: 653
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400028E RID: 654
	private Material BJFKDHHMLJH;

	// Token: 0x0400028F RID: 655
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x04000290 RID: 656
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x04000291 RID: 657
	private RenderTexture JDMCFBKJHDD;
}
