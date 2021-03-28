using System;
using UnityEngine;

// Token: 0x0200004D RID: 77
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/Luminosity")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_Luminosity : MonoBehaviour
{
	// Token: 0x0600159D RID: 5533 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600159E RID: 5534 RVA: 0x0008C5E8 File Offset: 0x0008A7E8
	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1809f)
			{
				this.HBJJOCHGOPH = 933f;
			}
			if (this.Camera2 != null)
			{
				this.LPMLLJKMAMP().SetTexture("_Value2", this.JDMCFBKJHDD);
			}
			this.KDMBOKLMADJ().SetFloat("lobby '{0}'[{1}]", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("_Value", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("SlidingArea", this.SwitchCameraToCamera2);
			this.DOMEEFLPEPJ().SetVector("#failed: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1526f, 1698f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600159F RID: 5535 RVA: 0x0008C6E4 File Offset: 0x0008A8E4
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 814f)
			{
				this.HBJJOCHGOPH = 344f;
			}
			if (this.Camera2 != null)
			{
				this.EJDPNJAEAKJ().SetTexture("Crosshair1", this.JDMCFBKJHDD);
			}
			this.GHHPOGODBHB().SetFloat("finished", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Items", this.BlendFX);
			this.EJDPNJAEAKJ().SetFloat("CameraFilterPack/Edge_Sobel", this.SwitchCameraToCamera2);
			this.IIJMIPBMMBF().SetVector("_Lift", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1107f, 1811f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060015A0 RID: 5536 RVA: 0x0008C7E0 File Offset: 0x0008A9E0
	private void JDKHBGDEONK()
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

	// Token: 0x060015A1 RID: 5537 RVA: 0x0008C84C File Offset: 0x0008AA4C
	private void CNGAJDBOCLJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -72);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060015A2 RID: 5538 RVA: 0x0008C8B5 File Offset: 0x0008AAB5
	private void HPOHJDJIADD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 43);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015A3 RID: 5539 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
	private void LBPHCAMMAPB()
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

	// Token: 0x060015A4 RID: 5540 RVA: 0x0008C92C File Offset: 0x0008AB2C
	private void OHFOLGANOLC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 12);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060015A5 RID: 5541 RVA: 0x0008C995 File Offset: 0x0008AB95
	private void NLGDPIBFHMK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 73);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015A6 RID: 5542 RVA: 0x0008C9D0 File Offset: 0x0008ABD0
	private Material DOMEEFLPEPJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060015A7 RID: 5543 RVA: 0x0008CA07 File Offset: 0x0008AC07
	private void FBIIBKKCOKO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 107);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015A8 RID: 5544 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x060015A9 RID: 5545 RVA: 0x0008CA42 File Offset: 0x0008AC42
	private void GPJHPNGNEBP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -81);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015AA RID: 5546 RVA: 0x0002523B File Offset: 0x0002343B
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x060015AB RID: 5547 RVA: 0x0008CA7D File Offset: 0x0008AC7D
	private void JIPEMDLKAGO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 13);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015AC RID: 5548 RVA: 0x0008CAB8 File Offset: 0x0008ACB8
	private void NNONKGKCKKE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -127);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015AE RID: 5550 RVA: 0x0008CB1C File Offset: 0x0008AD1C
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060015AF RID: 5551 RVA: 0x0008CB54 File Offset: 0x0008AD54
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1837f)
			{
				this.HBJJOCHGOPH = 312f;
			}
			if (this.Camera2 != null)
			{
				this.GHHPOGODBHB().SetTexture("\n\n#", this.JDMCFBKJHDD);
			}
			this.MFHPKGICPIO().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("LevelEditor/patterns", this.BlendFX);
			this.INOBFNCKFGK().SetFloat("0", this.SwitchCameraToCamera2);
			this.DNLMFEGJJDD().SetVector("menu.selectedlevelid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 105f, 1433f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060015B0 RID: 5552 RVA: 0x0008CC4E File Offset: 0x0008AE4E
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060015B1 RID: 5553 RVA: 0x0008CC88 File Offset: 0x0008AE88
	private void GLEJGFLCLPJ()
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

	// Token: 0x060015B2 RID: 5554 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
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

	// Token: 0x060015B3 RID: 5555 RVA: 0x0008CCF1 File Offset: 0x0008AEF1
	private void LMKMEJMGDFO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -104);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015B4 RID: 5556 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
	private void PLBOFEPBPKC()
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

	// Token: 0x060015B5 RID: 5557 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
	private void LAMEHAHJKMI()
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

	// Token: 0x060015B6 RID: 5558 RVA: 0x0008CD2C File Offset: 0x0008AF2C
	private void FELENDJEOGA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -71);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015B7 RID: 5559 RVA: 0x0008CD67 File Offset: 0x0008AF67
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015B8 RID: 5560 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x060015B9 RID: 5561 RVA: 0x0008CDA2 File Offset: 0x0008AFA2
	private void GFHPLCFNACM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -109);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015BA RID: 5562 RVA: 0x0008CDDD File Offset: 0x0008AFDD
	private void ILBFODEAOKE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -8);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015BB RID: 5563 RVA: 0x0008CE18 File Offset: 0x0008B018
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060015BC RID: 5564 RVA: 0x0008CE50 File Offset: 0x0008B050
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 845f)
			{
				this.HBJJOCHGOPH = 1131f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("maps.", this.JDMCFBKJHDD);
			}
			this.LPMLLJKMAMP().SetFloat("settings.shaders", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("Current xp: ", this.BlendFX);
			this.INOBFNCKFGK().SetFloat("_Bullet_6", this.SwitchCameraToCamera2);
			this.EJDPNJAEAKJ().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 691f, 1395f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060015BD RID: 5565 RVA: 0x0008CF4C File Offset: 0x0008B14C
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 612f)
			{
				this.HBJJOCHGOPH = 1487f;
			}
			if (this.Camera2 != null)
			{
				this.DOMEEFLPEPJ().SetTexture("_MatrixColor", this.JDMCFBKJHDD);
			}
			this.LPMLLJKMAMP().SetFloat("FrostCanvas", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("settings.hitvariation", this.BlendFX);
			this.KEMJNOMIPHN().SetFloat("[NetworkManager] Join failed", this.SwitchCameraToCamera2);
			this.INOBFNCKFGK().SetVector("player.greenarc", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1326f, 1019f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060015BE RID: 5566 RVA: 0x0008D046 File Offset: 0x0008B246
	private void DLOAJEFNKDA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 105);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015BF RID: 5567 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
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

	// Token: 0x060015C0 RID: 5568 RVA: 0x0008D081 File Offset: 0x0008B281
	private void LOLHKNKBNPF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -50);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015C1 RID: 5569 RVA: 0x0008CE18 File Offset: 0x0008B018
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060015C2 RID: 5570 RVA: 0x0008D0BC File Offset: 0x0008B2BC
	private void CGDMLHLJIDK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 68);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060015C3 RID: 5571 RVA: 0x0008D125 File Offset: 0x0008B325
	private void AENIGCONKBD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 46);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015C4 RID: 5572 RVA: 0x0008D160 File Offset: 0x0008B360
	private void KFCCKOBOLAH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 44);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015C5 RID: 5573 RVA: 0x0008D19C File Offset: 0x0008B39C
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1620f)
			{
				this.HBJJOCHGOPH = 886f;
			}
			if (this.Camera2 != null)
			{
				this.DOMEEFLPEPJ().SetTexture(" not exist", this.JDMCFBKJHDD);
			}
			this.IIJMIPBMMBF().SetFloat("LevelInfoInputField", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("CameraFilterPack/Glasses_OnX", this.BlendFX);
			this.MFHPKGICPIO().SetFloat("EnvironmentSlider", this.SwitchCameraToCamera2);
			this.IIJMIPBMMBF().SetVector("MapFolderInputField", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 589f, 755f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060015C6 RID: 5574 RVA: 0x0008D298 File Offset: 0x0008B498
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

	// Token: 0x060015C7 RID: 5575 RVA: 0x0008D394 File Offset: 0x0008B594
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 801f)
			{
				this.HBJJOCHGOPH = 690f;
			}
			if (this.Camera2 != null)
			{
				this.LPMLLJKMAMP().SetTexture(".", this.JDMCFBKJHDD);
			}
			this.KEMJNOMIPHN().SetFloat("x", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("[EditorEvent] Exception: ", this.BlendFX);
			this.DOMEEFLPEPJ().SetFloat("[ERROR KEY {0}]", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("LevelNameInputField", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1292f, 1700f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060015C8 RID: 5576 RVA: 0x0008D48E File Offset: 0x0008B68E
	private void MLLPGPANCHI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -35);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015C9 RID: 5577 RVA: 0x0008D4C9 File Offset: 0x0008B6C9
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060015CA RID: 5578 RVA: 0x0008D500 File Offset: 0x0008B700
	private void LGHCJCFHEMF()
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

	// Token: 0x060015CB RID: 5579 RVA: 0x0008D569 File Offset: 0x0008B769
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060015CC RID: 5580 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBPCODPOJAH()
	{
	}

	// Token: 0x060015CD RID: 5581 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
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

	// Token: 0x060015CE RID: 5582 RVA: 0x0008D5A0 File Offset: 0x0008B7A0
	private void FIJHDKIPENG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 96);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060015CF RID: 5583 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
	private void ONPFGCEFMML()
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

	// Token: 0x060015D0 RID: 5584 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
	private void HLLHJIDOOGA()
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

	// Token: 0x060015D1 RID: 5585 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
	private void ICDBMJKMIKC()
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

	// Token: 0x060015D2 RID: 5586 RVA: 0x0008D60C File Offset: 0x0008B80C
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1731f)
			{
				this.HBJJOCHGOPH = 1919f;
			}
			if (this.Camera2 != null)
			{
				this.DNLMFEGJJDD().SetTexture("ItemsUploader", this.JDMCFBKJHDD);
			}
			this.DNLMFEGJJDD().SetFloat("EnableRankedNotificationsToggle", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("#close", this.BlendFX);
			this.EJDPNJAEAKJ().SetFloat("_ScreenResolution", this.SwitchCameraToCamera2);
			this.LPMLLJKMAMP().SetVector("x", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1284f, 1590f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000034 RID: 52
	// (get) Token: 0x060015D3 RID: 5587 RVA: 0x0008D706 File Offset: 0x0008B906
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

	// Token: 0x060015D4 RID: 5588 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x060015D5 RID: 5589 RVA: 0x0002523B File Offset: 0x0002343B
	private void HCIPECAOGIA()
	{
	}

	// Token: 0x060015D6 RID: 5590 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
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

	// Token: 0x060015D7 RID: 5591 RVA: 0x0008D740 File Offset: 0x0008B940
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 619f)
			{
				this.HBJJOCHGOPH = 393f;
			}
			if (this.Camera2 != null)
			{
				this.GHHPOGODBHB().SetTexture(".workshop.json", this.JDMCFBKJHDD);
			}
			this.GHHPOGODBHB().SetFloat("settings.arcshitsoundtimedelay", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("_EmissionColor", this.BlendFX);
			this.EJDPNJAEAKJ().SetFloat("z", this.SwitchCameraToCamera2);
			this.ADGHJOHKEHG().SetVector("_MatrixSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 162f, 1863f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060015D8 RID: 5592 RVA: 0x0008D83A File Offset: 0x0008BA3A
	private void AMIMHHGLPIN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -89);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015D9 RID: 5593 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
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

	// Token: 0x060015DA RID: 5594 RVA: 0x0008D875 File Offset: 0x0008BA75
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060015DB RID: 5595 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x060015DC RID: 5596 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLDHEJIEDHO()
	{
	}

	// Token: 0x060015DD RID: 5597 RVA: 0x0008D8AC File Offset: 0x0008BAAC
	private void IJCBBIJOCAH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -90);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015DE RID: 5598 RVA: 0x0008D8E7 File Offset: 0x0008BAE7
	private void MFOOCOIIIJN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -12);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015DF RID: 5599 RVA: 0x0008D924 File Offset: 0x0008BB24
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 622f)
			{
				this.HBJJOCHGOPH = 1449f;
			}
			if (this.Camera2 != null)
			{
				this.JLHLHKPHDFO().SetTexture("_TimeX", this.JDMCFBKJHDD);
			}
			this.MFHPKGICPIO().SetFloat("_VelTex", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("set environment id", this.BlendFX);
			this.LPMLLJKMAMP().SetFloat("_TimeX", this.SwitchCameraToCamera2);
			this.KEMJNOMIPHN().SetVector("stats on", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1125f, 125f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060015E0 RID: 5600 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x060015E1 RID: 5601 RVA: 0x0008DA1E File Offset: 0x0008BC1E
	private void EAFFHHCMLCG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -98);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015E2 RID: 5602 RVA: 0x0008DA59 File Offset: 0x0008BC59
	private void JNKFOLNDNFP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -111);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015E3 RID: 5603 RVA: 0x0008DA94 File Offset: 0x0008BC94
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060015E4 RID: 5604 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
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

	// Token: 0x060015E5 RID: 5605 RVA: 0x0008DACC File Offset: 0x0008BCCC
	private void PMPKMGKAAJH()
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

	// Token: 0x060015E6 RID: 5606 RVA: 0x0008C9D0 File Offset: 0x0008ABD0
	private Material INOBFNCKFGK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060015E7 RID: 5607 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
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

	// Token: 0x060015E8 RID: 5608 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
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

	// Token: 0x060015E9 RID: 5609 RVA: 0x0008DB38 File Offset: 0x0008BD38
	private void BGDPIHMAACO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 89);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060015EA RID: 5610 RVA: 0x0008DBA4 File Offset: 0x0008BDA4
	private void FHPFJBFCOOF()
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

	// Token: 0x060015EB RID: 5611 RVA: 0x0008DC0D File Offset: 0x0008BE0D
	private void MCJMEKODMPA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -84);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015EC RID: 5612 RVA: 0x0008DC48 File Offset: 0x0008BE48
	private void DKOPKPBLDHH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 10);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060015ED RID: 5613 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
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

	// Token: 0x060015EE RID: 5614 RVA: 0x0002523B File Offset: 0x0002343B
	private void ODCJJFBJJNF()
	{
	}

	// Token: 0x060015EF RID: 5615 RVA: 0x0008DCB1 File Offset: 0x0008BEB1
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060015F0 RID: 5616 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x060015F1 RID: 5617 RVA: 0x0008DCE8 File Offset: 0x0008BEE8
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060015F2 RID: 5618 RVA: 0x0008DD1F File Offset: 0x0008BF1F
	private void MNHCBAKPBCF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 4);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015F3 RID: 5619 RVA: 0x0008DD5A File Offset: 0x0008BF5A
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060015F4 RID: 5620 RVA: 0x0008DD94 File Offset: 0x0008BF94
	private void KMCPMOGKDEH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -110);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060015F5 RID: 5621 RVA: 0x0002523B File Offset: 0x0002343B
	private void FAKGFMFAPDG()
	{
	}

	// Token: 0x060015F6 RID: 5622 RVA: 0x0008DDFD File Offset: 0x0008BFFD
	private void NBHKHEPDCHP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 121);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015F7 RID: 5623 RVA: 0x0008DE38 File Offset: 0x0008C038
	private void LNCFCGGJJOB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 117);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015F8 RID: 5624 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
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

	// Token: 0x060015F9 RID: 5625 RVA: 0x0008DE74 File Offset: 0x0008C074
	private void PKLOBJHKFEO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 97);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060015FA RID: 5626 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x060015FB RID: 5627 RVA: 0x0008DEDD File Offset: 0x0008C0DD
	private void HGJKBDGABKM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 29);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015FC RID: 5628 RVA: 0x0008DF18 File Offset: 0x0008C118
	private void EAOKCECGKAK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -107);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060015FD RID: 5629 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
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

	// Token: 0x060015FE RID: 5630 RVA: 0x0008DF54 File Offset: 0x0008C154
	private void CIPKEPDELJB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 74);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060015FF RID: 5631 RVA: 0x0008DFC0 File Offset: 0x0008C1C0
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 887f)
			{
				this.HBJJOCHGOPH = 1857f;
			}
			if (this.Camera2 != null)
			{
				this.JLHLHKPHDFO().SetTexture("_V", this.JDMCFBKJHDD);
			}
			this.DNLMFEGJJDD().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.KDMBOKLMADJ().SetFloat("Joystick1Button5", this.BlendFX);
			this.IIBLJCKLGFG().SetFloat("sprite", this.SwitchCameraToCamera2);
			this.MFHPKGICPIO().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 543f, 1549f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001600 RID: 5632 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
	private void BLKGOMCPEKI()
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

	// Token: 0x06001601 RID: 5633 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
	private void JEBIBKLHFLB()
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

	// Token: 0x06001602 RID: 5634 RVA: 0x0008E0BA File Offset: 0x0008C2BA
	private void BNJEFIBPJLO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -88);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001603 RID: 5635 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06001604 RID: 5636 RVA: 0x0008E0F8 File Offset: 0x0008C2F8
	private void IGPCNCJIEOJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 14);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001605 RID: 5637 RVA: 0x0008E161 File Offset: 0x0008C361
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001606 RID: 5638 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
	private void MCKCCPLJIFE()
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

	// Token: 0x06001607 RID: 5639 RVA: 0x0008E198 File Offset: 0x0008C398
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 408f)
			{
				this.HBJJOCHGOPH = 1948f;
			}
			if (this.Camera2 != null)
			{
				this.IIBLJCKLGFG().SetTexture("DPADVER", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("a", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("CameraFilterPack/Blend2Camera_LinearBurn", this.BlendFX);
			this.INOBFNCKFGK().SetFloat("_MainTex2", this.SwitchCameraToCamera2);
			this.EMDFHOKEGNG().SetVector("_Intensity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 825f, 238f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001608 RID: 5640 RVA: 0x0008E292 File Offset: 0x0008C492
	private void EMAMCDFBGOA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -2);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001609 RID: 5641 RVA: 0x0008E2CD File Offset: 0x0008C4CD
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600160A RID: 5642 RVA: 0x0008E304 File Offset: 0x0008C504
	private void KDBKBPCIHBL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 0);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600160B RID: 5643 RVA: 0x0008E340 File Offset: 0x0008C540
	private void DLBODOFAJGM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -110);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600160C RID: 5644 RVA: 0x0008E3A9 File Offset: 0x0008C5A9
	private void DAIPOKLLFLD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 90);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600160D RID: 5645 RVA: 0x0008E3E4 File Offset: 0x0008C5E4
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1487f)
			{
				this.HBJJOCHGOPH = 1251f;
			}
			if (this.Camera2 != null)
			{
				this.INOBFNCKFGK().SetTexture("_Value3", this.JDMCFBKJHDD);
			}
			this.JLHLHKPHDFO().SetFloat("Set Player Distance", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("DPADHOR", this.BlendFX);
			this.DOMEEFLPEPJ().SetFloat("EventSystem", this.SwitchCameraToCamera2);
			this.KDMBOKLMADJ().SetVector("Out {0,4} | In {1,4} | Sum {2,4}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 468f, 1855f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600160E RID: 5646 RVA: 0x0008E4E0 File Offset: 0x0008C6E0
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

	// Token: 0x0600160F RID: 5647 RVA: 0x0008E54C File Offset: 0x0008C74C
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 577f)
			{
				this.HBJJOCHGOPH = 1556f;
			}
			if (this.Camera2 != null)
			{
				this.IIJMIPBMMBF().SetTexture("STICKRVER", this.JDMCFBKJHDD);
			}
			this.EMDFHOKEGNG().SetFloat("deleteall", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("#", this.BlendFX);
			this.JLHLHKPHDFO().SetFloat("Hex value #RRGGBB", this.SwitchCameraToCamera2);
			this.KEMJNOMIPHN().SetVector("Objects in List: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 326f, 1445f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001610 RID: 5648 RVA: 0x0008E646 File Offset: 0x0008C846
	private void HHODKHPIBLG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -54);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001611 RID: 5649 RVA: 0x0008E681 File Offset: 0x0008C881
	private void KKDDHFJOAAD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -119);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001612 RID: 5650 RVA: 0x0008CD67 File Offset: 0x0008AF67
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001613 RID: 5651 RVA: 0x0008E6BC File Offset: 0x0008C8BC
	private void MMOKKAPFGAK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -13);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001614 RID: 5652 RVA: 0x0008E728 File Offset: 0x0008C928
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 829f)
			{
				this.HBJJOCHGOPH = 782f;
			}
			if (this.Camera2 != null)
			{
				this.MFHPKGICPIO().SetTexture("offsets", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("f", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("_Value2", this.BlendFX);
			this.IIBLJCKLGFG().SetFloat("error", this.SwitchCameraToCamera2);
			this.JLHLHKPHDFO().SetVector("CameraFilterPack/Blur_Movie", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 603f, 664f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001615 RID: 5653 RVA: 0x0008E824 File Offset: 0x0008CA24
	private void BMOFEBKGLFI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 30);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001616 RID: 5654 RVA: 0x0008C8F0 File Offset: 0x0008AAF0
	private void OFIMMFHFHDD()
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

	// Token: 0x040002FA RID: 762
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Luminosity";

	// Token: 0x040002FB RID: 763
	public Shader SCShader;

	// Token: 0x040002FC RID: 764
	public Camera Camera2;

	// Token: 0x040002FD RID: 765
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040002FE RID: 766
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040002FF RID: 767
	private Material BJFKDHHMLJH;

	// Token: 0x04000300 RID: 768
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x04000301 RID: 769
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x04000302 RID: 770
	private RenderTexture JDMCFBKJHDD;
}
