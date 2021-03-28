using System;
using UnityEngine;

// Token: 0x02000077 RID: 119
[AddComponentMenu("Camera Filter Pack/ColorsAdjust/ColorRGB")]
[ExecuteInEditMode]
public class CameraFilterPack_Colors_Adjust_ColorRGB : MonoBehaviour
{
	// Token: 0x060021D7 RID: 8663 RVA: 0x000C251C File Offset: 0x000C071C
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1619f)
			{
				this.HBJJOCHGOPH = 1659f;
			}
			this.GCDFNHMJMIP().SetFloat("key", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat(" not exist", this.Red);
			this.OGMEGHKECAH().SetFloat("_VignetteSettings", this.Green);
			this.MICHFGAOPKM().SetFloat("LoadingStatusText", this.Blue);
			this.MICHFGAOPKM().SetFloat("BitsData", this.Brightness);
			this.MFHPKGICPIO().SetVector(" but this PhotonView does not exist! View was/is ours.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1702f, 1920f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021D8 RID: 8664 RVA: 0x000C261C File Offset: 0x000C081C
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 762f)
			{
				this.HBJJOCHGOPH = 1051f;
			}
			this.EJDPNJAEAKJ().SetFloat("_DotSize", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("_Far", this.Red);
			this.FHFLKLMFHOI().SetFloat("???", this.Green);
			this.GCDFNHMJMIP().SetFloat("_Value2", this.Blue);
			this.DKKBFFHBHJE().SetFloat("Scene", this.Brightness);
			this.NLFJGMBCICG().SetVector("_EmissionGain", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 865f, 1117f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021D9 RID: 8665 RVA: 0x000C271B File Offset: 0x000C091B
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("_ColorB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060021DB RID: 8667 RVA: 0x000C2754 File Offset: 0x000C0954
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 992f)
			{
				this.HBJJOCHGOPH = 898f;
			}
			this.DKKBFFHBHJE().SetFloat("'{0}' \t{1}ms \t{2}", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Red);
			this.DONENAMLFLF().SetFloat("Jazz", this.Green);
			this.DONENAMLFLF().SetFloat("/", this.Blue);
			this.DKKBFFHBHJE().SetFloat("_MainTex2", this.Brightness);
			this.GCDFNHMJMIP().SetVector("EventTimeInputField", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1528f, 763f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021DC RID: 8668 RVA: 0x000C2853 File Offset: 0x000C0A53
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("\\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060021DD RID: 8669 RVA: 0x000C2877 File Offset: 0x000C0A77
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-104);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060021DE RID: 8670 RVA: 0x000C28AE File Offset: 0x000C0AAE
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060021DF RID: 8671 RVA: 0x000C28AE File Offset: 0x000C0AAE
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x1700005D RID: 93
	// (get) Token: 0x060021E0 RID: 8672 RVA: 0x000C28CB File Offset: 0x000C0ACB
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

	// Token: 0x060021E1 RID: 8673 RVA: 0x000C2904 File Offset: 0x000C0B04
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 302f)
			{
				this.HBJJOCHGOPH = 19f;
			}
			this.NBPKMLMCHFN.SetFloat("EventTimeInputField", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("Freq: ", this.Red);
			this.AELJLBOJAIL().SetFloat("_MainTex", this.Green);
			this.EJDPNJAEAKJ().SetFloat("AppID: {0}*** GameVersion: {1} PeerId: {2} ", this.Blue);
			this.OGMEGHKECAH().SetFloat("Alpha", this.Brightness);
			this.NBPKMLMCHFN.SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1691f, 632f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021E2 RID: 8674 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x060021E3 RID: 8675 RVA: 0x000C28AE File Offset: 0x000C0AAE
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060021E4 RID: 8676 RVA: 0x000C2A04 File Offset: 0x000C0C04
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 322f)
			{
				this.HBJJOCHGOPH = 813f;
			}
			this.AELJLBOJAIL().SetFloat("CameraFilterPack/AAA_Blood_Hit", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("Scale environment object by the values", this.Red);
			this.NBMPPNFKFLB().SetFloat("_TimeX", this.Green);
			this.FEAEGGCNIAA().SetFloat("settings_bindings_", this.Blue);
			this.NBMPPNFKFLB().SetFloat("[PhotonMessageInfo: Sender='{1}' Senttime={0}]", this.Brightness);
			this.NBPKMLMCHFN.SetVector("settings_bindings_controller_type", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 88f, 684f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021E5 RID: 8677 RVA: 0x000C28AE File Offset: 0x000C0AAE
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060021E6 RID: 8678 RVA: 0x000C2B04 File Offset: 0x000C0D04
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1009f)
			{
				this.HBJJOCHGOPH = 654f;
			}
			this.DKKBFFHBHJE().SetFloat("finished", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("LevelFolderInputField", this.Red);
			this.NBMPPNFKFLB().SetFloat("Texture2", this.Green);
			this.GCDFNHMJMIP().SetFloat("visible", this.Blue);
			this.NBPKMLMCHFN.SetFloat("#finished", this.Brightness);
			this.MFHPKGICPIO().SetVector("Down", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1350f, 1932f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021E7 RID: 8679 RVA: 0x000C28AE File Offset: 0x000C0AAE
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060021E8 RID: 8680 RVA: 0x000C2C04 File Offset: 0x000C0E04
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1781f)
			{
				this.HBJJOCHGOPH = 1752f;
			}
			this.OGMEGHKECAH().SetFloat("OK", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("CameraFilterPack/Distortion_Lens", this.Red);
			this.FEAEGGCNIAA().SetFloat("sounds/hit_normal", this.Green);
			this.NLFJGMBCICG().SetFloat("LT", this.Blue);
			this.DKKBFFHBHJE().SetFloat("[MapEditor] Loading map: ", this.Brightness);
			this.DKKBFFHBHJE().SetVector(" ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1431f, 621f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021E9 RID: 8681 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x060021EA RID: 8682 RVA: 0x000C2D03 File Offset: 0x000C0F03
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060021EB RID: 8683 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x060021EC RID: 8684 RVA: 0x000C2D3A File Offset: 0x000C0F3A
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("ConfigVersionSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060021ED RID: 8685 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x060021EE RID: 8686 RVA: 0x000C28AE File Offset: 0x000C0AAE
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060021EF RID: 8687 RVA: 0x000C2D5E File Offset: 0x000C0F5E
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060021F0 RID: 8688 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x060021F1 RID: 8689 RVA: 0x000C2D82 File Offset: 0x000C0F82
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("[ItemsHandler] No connection to item server: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060021F2 RID: 8690 RVA: 0x000C2DA6 File Offset: 0x000C0FA6
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("_BlurDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060021F3 RID: 8691 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x060021F4 RID: 8692 RVA: 0x000C28AE File Offset: 0x000C0AAE
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060021F5 RID: 8693 RVA: 0x000C2DCC File Offset: 0x000C0FCC
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1269f)
			{
				this.HBJJOCHGOPH = 676f;
			}
			this.NLFJGMBCICG().SetFloat("AmbientOcclusion", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("settings_bindings_", this.Red);
			this.MICHFGAOPKM().SetFloat("_Value5", this.Green);
			this.FLOHGDECHHH().SetFloat("_TimeX", this.Blue);
			this.NBMPPNFKFLB().SetFloat("value", this.Brightness);
			this.FLOHGDECHHH().SetVector("[PlayerBase] Loaded music", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1956f, 131f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021F6 RID: 8694 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x060021F7 RID: 8695 RVA: 0x000C2ECB File Offset: 0x000C10CB
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060021F8 RID: 8696 RVA: 0x000C2EF0 File Offset: 0x000C10F0
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1864f)
			{
				this.HBJJOCHGOPH = 1745f;
			}
			this.OGMEGHKECAH().SetFloat("_MatrixColor", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("0. SubBase 20-60 Hz\n1. Bass, 60-250 Hz\n2. LowMidrange 250-500 Hz\n3. Midrange 500-2,000 Hz\n4. UpperMidrange 2,000-4,000 Hz\n5. High 4,000-6000 Hz\n6. VeryHigh 6,000-20,000 Hz\n7. Decibal - use output data instead of frequency data", this.Red);
			this.DKKBFFHBHJE().SetFloat("SUBMIT", this.Green);
			this.FLOHGDECHHH().SetFloat("Set Satellite Radius", this.Blue);
			this.FEAEGGCNIAA().SetFloat("_CurrentMipLevel", this.Brightness);
			this.NBMPPNFKFLB().SetVector("Beat Detected", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 593f, 211f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021F9 RID: 8697 RVA: 0x000C2FF0 File Offset: 0x000C11F0
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 447f)
			{
				this.HBJJOCHGOPH = 702f;
			}
			this.AELJLBOJAIL().SetFloat("value", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat(".completedMaps", this.Red);
			this.ABHDNGIHBKE().SetFloat("failed", this.Green);
			this.EJDPNJAEAKJ().SetFloat("LoadingStatusText", this.Blue);
			this.NLFJGMBCICG().SetFloat("[", this.Brightness);
			this.MFHPKGICPIO().SetVector("CameraFilterPack/Blend2Camera_SplitScreen", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 910f, 428f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060021FA RID: 8698 RVA: 0x000C30EF File Offset: 0x000C12EF
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060021FB RID: 8699 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x060021FC RID: 8700 RVA: 0x000C28AE File Offset: 0x000C0AAE
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060021FD RID: 8701 RVA: 0x000C28AE File Offset: 0x000C0AAE
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060021FE RID: 8702 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x060021FF RID: 8703 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06002200 RID: 8704 RVA: 0x000C3126 File Offset: 0x000C1326
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002201 RID: 8705 RVA: 0x000C315D File Offset: 0x000C135D
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("player.rgb");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002202 RID: 8706 RVA: 0x000C3181 File Offset: 0x000C1381
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002203 RID: 8707 RVA: 0x000C28AE File Offset: 0x000C0AAE
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002204 RID: 8708 RVA: 0x000C31B8 File Offset: 0x000C13B8
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("/music");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002205 RID: 8709 RVA: 0x000C31DC File Offset: 0x000C13DC
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002206 RID: 8710 RVA: 0x000C3214 File Offset: 0x000C1414
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1465f)
			{
				this.HBJJOCHGOPH = 911f;
			}
			this.NBPKMLMCHFN.SetFloat("#,0.00", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("FrostCanvas", this.Red);
			this.FHFLKLMFHOI().SetFloat("_StretchWidth", this.Green);
			this.ABHDNGIHBKE().SetFloat("Failed to 'GetKeyCode' for key: ", this.Blue);
			this.NBPKMLMCHFN.SetFloat("float,10", this.Brightness);
			this.AELJLBOJAIL().SetVector("original.tutorial", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 539f, 129f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002207 RID: 8711 RVA: 0x000C3314 File Offset: 0x000C1514
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 0f)
			{
				this.HBJJOCHGOPH = 54f;
			}
			this.GCDFNHMJMIP().SetFloat("_Glow", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat(".g", this.Red);
			this.DKKBFFHBHJE().SetFloat("key", this.Green);
			this.OGMEGHKECAH().SetFloat("powerup.1", this.Blue);
			this.OGMEGHKECAH().SetFloat("HandleEventLeave for player ID: ", this.Brightness);
			this.NBPKMLMCHFN.SetVector("menutheme.hunter", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1087f, 1457f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002208 RID: 8712 RVA: 0x000C3413 File Offset: 0x000C1613
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("OnAwakeRPC");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002209 RID: 8713 RVA: 0x000C3437 File Offset: 0x000C1637
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600220A RID: 8714 RVA: 0x000C3470 File Offset: 0x000C1670
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.Red);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Green);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Blue);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Brightness);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600220B RID: 8715 RVA: 0x000C3570 File Offset: 0x000C1770
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 381f)
			{
				this.HBJJOCHGOPH = 961f;
			}
			this.NLFJGMBCICG().SetFloat("-showlogs", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("Most likely the game became empty during the switch to GameServer.", this.Red);
			this.ABHDNGIHBKE().SetFloat(" ", this.Green);
			this.ABHDNGIHBKE().SetFloat("PLEASE WAIT", this.Blue);
			this.NLFJGMBCICG().SetFloat("_TimeX", this.Brightness);
			this.LNLKMDPHDCC().SetVector("SpawnObj", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1795f, 759f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600220C RID: 8716 RVA: 0x000C366F File Offset: 0x000C186F
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("OPEN");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600220D RID: 8717 RVA: 0x000C3693 File Offset: 0x000C1893
	private void FLKEJJEGCFA()
	{
		this.SCShader = Shader.Find("AudioSampler");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600220E RID: 8718 RVA: 0x000C36B7 File Offset: 0x000C18B7
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Colors_Adjust_ColorRGB");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600220F RID: 8719 RVA: 0x000C36DB File Offset: 0x000C18DB
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002210 RID: 8720 RVA: 0x000C3712 File Offset: 0x000C1912
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002211 RID: 8721 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06002212 RID: 8722 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x06002213 RID: 8723 RVA: 0x000C28AE File Offset: 0x000C0AAE
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002214 RID: 8724 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06002215 RID: 8725 RVA: 0x000C3749 File Offset: 0x000C1949
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002216 RID: 8726 RVA: 0x000C3780 File Offset: 0x000C1980
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002217 RID: 8727 RVA: 0x000C37B8 File Offset: 0x000C19B8
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 951f)
			{
				this.HBJJOCHGOPH = 932f;
			}
			this.ABHDNGIHBKE().SetFloat("Tab2Content", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("PointerExit ", this.Red);
			this.OGMEGHKECAH().SetFloat("PointerExit ", this.Green);
			this.NLFJGMBCICG().SetFloat("_History3Weight", this.Blue);
			this.NBPKMLMCHFN.SetFloat("inventory.selected.", this.Brightness);
			this.EJDPNJAEAKJ().SetVector("float,50", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 504f, 235f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002218 RID: 8728 RVA: 0x000C38B8 File Offset: 0x000C1AB8
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 711f)
			{
				this.HBJJOCHGOPH = 1905f;
			}
			this.NLFJGMBCICG().SetFloat("_Value13", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("_PColor2", this.Red);
			this.MICHFGAOPKM().SetFloat("Set Object Rotation", this.Green);
			this.MICHFGAOPKM().SetFloat("PhotonView register is ignored, because viewID is 0. No id assigned yet to: ", this.Blue);
			this.MFHPKGICPIO().SetFloat("_Value2", this.Brightness);
			this.ABHDNGIHBKE().SetVector("TimeBGSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 956f, 1405f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002219 RID: 8729 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x0600221A RID: 8730 RVA: 0x000C39B7 File Offset: 0x000C1BB7
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600221B RID: 8731 RVA: 0x000C39EE File Offset: 0x000C1BEE
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("_BlurPass");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600221C RID: 8732 RVA: 0x000C3A14 File Offset: 0x000C1C14
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1858f)
			{
				this.HBJJOCHGOPH = 1060f;
			}
			this.GCDFNHMJMIP().SetFloat("_DotSize", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("\t", this.Red);
			this.AELJLBOJAIL().SetFloat("#ok", this.Green);
			this.GCDFNHMJMIP().SetFloat("Internal LUT", this.Blue);
			this.DONENAMLFLF().SetFloat("<color=white>", this.Brightness);
			this.LNLKMDPHDCC().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 142f, 304f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600221D RID: 8733 RVA: 0x000C3B13 File Offset: 0x000C1D13
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600221E RID: 8734 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x0600221F RID: 8735 RVA: 0x000C3B4A File Offset: 0x000C1D4A
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002220 RID: 8736 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002221 RID: 8737 RVA: 0x000C28AE File Offset: 0x000C0AAE
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002222 RID: 8738 RVA: 0x000C3B70 File Offset: 0x000C1D70
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1781f)
			{
				this.HBJJOCHGOPH = 781f;
			}
			this.MICHFGAOPKM().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("_TimeX", this.Red);
			this.FEAEGGCNIAA().SetFloat("_EmissionColor", this.Green);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.Blue);
			this.NLFJGMBCICG().SetFloat("EventMenu", this.Brightness);
			this.NBMPPNFKFLB().SetVector("\\[ *im.*\\](\\n\\n\\n|\\n\\n|\\n|)", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1873f, 475f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002223 RID: 8739 RVA: 0x000C28AE File Offset: 0x000C0AAE
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002224 RID: 8740 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06002225 RID: 8741 RVA: 0x000C3C6F File Offset: 0x000C1E6F
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002226 RID: 8742 RVA: 0x000C3CA8 File Offset: 0x000C1EA8
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1144f)
			{
				this.HBJJOCHGOPH = 741f;
			}
			this.AELJLBOJAIL().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("_Value3", this.Red);
			this.OGMEGHKECAH().SetFloat("delete", this.Green);
			this.FLOHGDECHHH().SetFloat("maps.", this.Blue);
			this.FEAEGGCNIAA().SetFloat("_Value2", this.Brightness);
			this.NBPKMLMCHFN.SetVector("Set the end of the map. Use this if you want to cut the long music.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1662f, 61f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002227 RID: 8743 RVA: 0x000C28AE File Offset: 0x000C0AAE
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002228 RID: 8744 RVA: 0x000C3DA7 File Offset: 0x000C1FA7
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002229 RID: 8745 RVA: 0x000C3DDE File Offset: 0x000C1FDE
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("]. Please verify you have this gameobject in a Resources folder.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0400044E RID: 1102
	public Shader SCShader;

	// Token: 0x0400044F RID: 1103
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000450 RID: 1104
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000451 RID: 1105
	private Material BJFKDHHMLJH;

	// Token: 0x04000452 RID: 1106
	[Range(-2f, 2f)]
	public float Red;

	// Token: 0x04000453 RID: 1107
	[Range(-2f, 2f)]
	public float Green;

	// Token: 0x04000454 RID: 1108
	[Range(-2f, 2f)]
	public float Blue;

	// Token: 0x04000455 RID: 1109
	[Range(-1f, 1f)]
	public float Brightness;
}
