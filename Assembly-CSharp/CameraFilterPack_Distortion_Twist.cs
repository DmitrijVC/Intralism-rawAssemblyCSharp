using System;
using UnityEngine;

// Token: 0x02000093 RID: 147
[AddComponentMenu("Camera Filter Pack/Distortion/Twist")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_Twist : MonoBehaviour
{
	// Token: 0x06002B41 RID: 11073 RVA: 0x000EB43B File Offset: 0x000E963B
	private void CIHGFHNNFEE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B42 RID: 11074 RVA: 0x0002523B File Offset: 0x0002343B
	private void IAJKLKJJKEJ()
	{
	}

	// Token: 0x06002B43 RID: 11075 RVA: 0x000EB458 File Offset: 0x000E9658
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find("Image effects aren't supported on this device ({0})");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002B44 RID: 11076 RVA: 0x000EB47C File Offset: 0x000E967C
	private void NDBPCNICGLC()
	{
		this.SCShader = Shader.Find(".b");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002B45 RID: 11077 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06002B46 RID: 11078 RVA: 0x000EB4A0 File Offset: 0x000E96A0
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002B47 RID: 11079 RVA: 0x000EB4C4 File Offset: 0x000E96C4
	private Material MLMKCOINOOH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B48 RID: 11080 RVA: 0x000EB43B File Offset: 0x000E963B
	private void FJABOCDLCAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B49 RID: 11081 RVA: 0x000EB4FC File Offset: 0x000E96FC
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1342f)
			{
				this.HBJJOCHGOPH = 1857f;
			}
			this.KEMJNOMIPHN().SetFloat("offsets", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("SetPosition", this.CenterX);
			this.KAFBNOBOIAJ().SetFloat("HandleEventLeave for player ID: ", this.CenterY);
			this.KAFBNOBOIAJ().SetFloat("Texture2", this.Distortion);
			this.ACHNOHCLGOO().SetFloat("settings.selectormapsperpage", this.Size);
			this.MNLKBFFKHIE().SetVector("G:", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EBJKJPAIAAM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B4A RID: 11082 RVA: 0x000EB5F4 File Offset: 0x000E97F4
	private Material GBFOAHKAJEK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-125);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B4B RID: 11083 RVA: 0x000EB62B File Offset: 0x000E982B
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B4C RID: 11084 RVA: 0x000EB662 File Offset: 0x000E9862
	private void MKOMIDCPCDC()
	{
		this.SCShader = Shader.Find("Mouse Wheel Down");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002B4D RID: 11085 RVA: 0x000EB686 File Offset: 0x000E9886
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B4E RID: 11086 RVA: 0x000EB6C0 File Offset: 0x000E98C0
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1922f)
			{
				this.HBJJOCHGOPH = 1694f;
			}
			this.DBOLLHHMKKN().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.MNLKBFFKHIE().SetFloat(": ", this.CenterX);
			this.OKJOKHGJHGF().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", this.CenterY);
			this.IIJMIPBMMBF().SetFloat("/512px-512px.png", this.Distortion);
			this.FEAEGGCNIAA().SetFloat("menu.playedpage", this.Size);
			this.LENEJAGLCNL().SetVector("_TimeX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B4F RID: 11087 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x06002B51 RID: 11089 RVA: 0x000EB43B File Offset: 0x000E963B
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B52 RID: 11090 RVA: 0x000EB7F7 File Offset: 0x000E99F7
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)127;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B53 RID: 11091 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06002B54 RID: 11092 RVA: 0x000EB830 File Offset: 0x000E9A30
	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1883f)
			{
				this.HBJJOCHGOPH = 391f;
			}
			this.OKJOKHGJHGF().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.GBFOAHKAJEK().SetFloat("CameraFilterPack/3D_Inverse", this.CenterX);
			this.LENEJAGLCNL().SetFloat("_TimeX", this.CenterY);
			this.EMDFHOKEGNG().SetFloat("_DotSize", this.Distortion);
			this.MHBAIEKFBIJ().SetFloat("_FarCamera", this.Size);
			this.OGMEGHKECAH().SetVector("#close", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B55 RID: 11093 RVA: 0x000EB928 File Offset: 0x000E9B28
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 88f)
			{
				this.HBJJOCHGOPH = 980f;
			}
			this.ADAFMBOGPLN().SetFloat("Data/Skins/", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("'{0}'{1}{2}", this.CenterX);
			this.LELKBCALFCF().SetFloat("_ScreenEdgeFading", this.CenterY);
			this.LENEJAGLCNL().SetFloat("_Amount", this.Distortion);
			this.OGMEGHKECAH().SetFloat("CameraFilterPack/Blend2Camera_GreenScreen", this.Size);
			this.OKJOKHGJHGF().SetVector("_Value2", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HJGEHJDMCGI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B56 RID: 11094 RVA: 0x0002523B File Offset: 0x0002343B
	private void HEBOIFKBLGD()
	{
	}

	// Token: 0x06002B57 RID: 11095 RVA: 0x000EBA20 File Offset: 0x000E9C20
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002B58 RID: 11096 RVA: 0x000EBA44 File Offset: 0x000E9C44
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1563f)
			{
				this.HBJJOCHGOPH = 657f;
			}
			this.EGOGECOEONM().SetFloat("Received RPC: ", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("(master)", this.CenterX);
			this.HCGJCMDJPGD().SetFloat("Mouse2", this.CenterY);
			this.IIJMIPBMMBF().SetFloat("\n", this.Distortion);
			this.LENEJAGLCNL().SetFloat("RecieveChatActionMessage", this.Size);
			this.HCGJCMDJPGD().SetVector("Image", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B59 RID: 11097 RVA: 0x000EBB3C File Offset: 0x000E9D3C
	private void AOGCKKLFGPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1657f)
			{
				this.HBJJOCHGOPH = 1994f;
			}
			this.ACHNOHCLGOO().SetFloat("BestScoreText", this.HBJJOCHGOPH);
			this.MNLKBFFKHIE().SetFloat("Fade", this.CenterX);
			this.GBFOAHKAJEK().SetFloat("_ScreenResolution", this.CenterY);
			this.FKEOGPDLBDD().SetFloat("Joystick1Button3", this.Distortion);
			this.MFHPKGICPIO().SetFloat("failed", this.Size);
			this.PEIMCBBHLBJ().SetVector("#pleasewait", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B5A RID: 11098 RVA: 0x000EB43B File Offset: 0x000E963B
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B5B RID: 11099 RVA: 0x000EBC34 File Offset: 0x000E9E34
	private void DFFKKLAPHCC()
	{
		this.SCShader = Shader.Find(".workshop.json");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002B5C RID: 11100 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIFLPHLGLFG()
	{
	}

	// Token: 0x06002B5D RID: 11101 RVA: 0x000EBC58 File Offset: 0x000E9E58
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("[ItemsHandler] No connection to item server: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002B5E RID: 11102 RVA: 0x000EBC7C File Offset: 0x000E9E7C
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1083f)
			{
				this.HBJJOCHGOPH = 1333f;
			}
			this.KAFBNOBOIAJ().SetFloat("_Offsets", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat(" not exist", this.CenterX);
			this.EMDFHOKEGNG().SetFloat("_Parameter", this.CenterY);
			this.KEMJNOMIPHN().SetFloat(" beatThreshold: ", this.Distortion);
			this.HJGEHJDMCGI().SetFloat("[Up]", this.Size);
			this.MHBAIEKFBIJ().SetVector("/config", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B5F RID: 11103 RVA: 0x000EB43B File Offset: 0x000E963B
	private void MKFLBEGJJDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B60 RID: 11104 RVA: 0x000EBD74 File Offset: 0x000E9F74
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B61 RID: 11105 RVA: 0x000EBDAB File Offset: 0x000E9FAB
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002B62 RID: 11106 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06002B63 RID: 11107 RVA: 0x000EBDD0 File Offset: 0x000E9FD0
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 78f)
			{
				this.HBJJOCHGOPH = 14f;
			}
			this.DBOLLHHMKKN().SetFloat("STICKRVER", this.HBJJOCHGOPH);
			this.PEIMCBBHLBJ().SetFloat("_ScreenResolution", this.CenterX);
			this.ADAFMBOGPLN().SetFloat("cipherText", this.CenterY);
			this.EPCGJFCCAFH().SetFloat("_TimeX", this.Distortion);
			this.EGOGECOEONM().SetFloat("[GameScene] Events count: ", this.Size);
			this.MNLKBFFKHIE().SetVector("_Red_G", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B64 RID: 11108 RVA: 0x000EB43B File Offset: 0x000E963B
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B65 RID: 11109 RVA: 0x000EBDAB File Offset: 0x000E9FAB
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002B66 RID: 11110 RVA: 0x000EBEC8 File Offset: 0x000EA0C8
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B67 RID: 11111 RVA: 0x000EBF00 File Offset: 0x000EA100
	private void NJBMCJOOMMP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 505f)
			{
				this.HBJJOCHGOPH = 773f;
			}
			this.FEAEGGCNIAA().SetFloat("float,0", this.HBJJOCHGOPH);
			this.PEIMCBBHLBJ().SetFloat("id", this.CenterX);
			this.NBPKMLMCHFN.SetFloat("_NoisePerChannel", this.CenterY);
			this.MLMKCOINOOH().SetFloat("CameraFilterPack/Blend2Camera_ColorDodge", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("COMPLETED", this.Size);
			this.MNLKBFFKHIE().SetVector("menuthemes", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B68 RID: 11112 RVA: 0x000EBFF8 File Offset: 0x000EA1F8
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B69 RID: 11113 RVA: 0x000EB43B File Offset: 0x000E963B
	private void JMAIIENCEKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B6A RID: 11114 RVA: 0x000EB43B File Offset: 0x000E963B
	private void HNGHDAPKEJG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B6B RID: 11115 RVA: 0x000EC02F File Offset: 0x000EA22F
	private Material DOMEEFLPEPJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B6C RID: 11116 RVA: 0x000EC068 File Offset: 0x000EA268
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 480f)
			{
				this.HBJJOCHGOPH = 1958f;
			}
			this.ADAFMBOGPLN().SetFloat("Editor/", this.HBJJOCHGOPH);
			this.LELKBCALFCF().SetFloat("original.tutorial", this.CenterX);
			this.GJHLADDCMFF().SetFloat("#combo", this.CenterY);
			this.KEMJNOMIPHN().SetFloat("Needs to be attached to the Event System component in the scene", this.Distortion);
			this.NFKFAAHHLLM().SetFloat("_ScreenResolution", this.Size);
			this.MFHPKGICPIO().SetVector("settings.fps", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B6D RID: 11117 RVA: 0x000EC160 File Offset: 0x000EA360
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("Room: '{0}' {1},{2} {4}/{3} players.\ncustomProps: {5}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002B6E RID: 11118 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06002B6F RID: 11119 RVA: 0x000EC184 File Offset: 0x000EA384
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002B70 RID: 11120 RVA: 0x000EC1A8 File Offset: 0x000EA3A8
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B71 RID: 11121 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06002B72 RID: 11122 RVA: 0x000EC1DF File Offset: 0x000EA3DF
	private void AIBNKIDADPI()
	{
		this.SCShader = Shader.Find("HandsCountSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002B73 RID: 11123 RVA: 0x000EC203 File Offset: 0x000EA403
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002B74 RID: 11124 RVA: 0x000EC227 File Offset: 0x000EA427
	private void ECBILENEOOL()
	{
		this.SCShader = Shader.Find("Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002B75 RID: 11125 RVA: 0x000EC24B File Offset: 0x000EA44B
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B76 RID: 11126 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x06002B77 RID: 11127 RVA: 0x000EC282 File Offset: 0x000EA482
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find("_LightIntensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002B78 RID: 11128 RVA: 0x000EB43B File Offset: 0x000E963B
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B79 RID: 11129 RVA: 0x000EB43B File Offset: 0x000E963B
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B7A RID: 11130 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x06002B7B RID: 11131 RVA: 0x000EB43B File Offset: 0x000E963B
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B7C RID: 11132 RVA: 0x000EC2A8 File Offset: 0x000EA4A8
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1411f)
			{
				this.HBJJOCHGOPH = 1858f;
			}
			this.ADAFMBOGPLN().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.ADAFMBOGPLN().SetFloat("OnStatusChanged: {0} current State: {1}", this.CenterX);
			this.KAFBNOBOIAJ().SetFloat("_MainTex2", this.CenterY);
			this.LELKBCALFCF().SetFloat("_MaxVelocity", this.Distortion);
			this.HCGJCMDJPGD().SetFloat(" not exist", this.Size);
			this.KEMJNOMIPHN().SetVector("Received RPC: ", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B7D RID: 11133 RVA: 0x000EC3A0 File Offset: 0x000EA5A0
	private void MDNHCLKNCLE()
	{
		this.SCShader = Shader.Find(" x ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002B7E RID: 11134 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06002B7F RID: 11135 RVA: 0x000EB43B File Offset: 0x000E963B
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B80 RID: 11136 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06002B81 RID: 11137 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06002B82 RID: 11138 RVA: 0x000EC3C4 File Offset: 0x000EA5C4
	private void PEDHPEMNHBF()
	{
		this.SCShader = Shader.Find("#accuracy");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002B83 RID: 11139 RVA: 0x000EC3E8 File Offset: 0x000EA5E8
	private void IGJPPFJOFKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 686f)
			{
				this.HBJJOCHGOPH = 381f;
			}
			this.MNLKBFFKHIE().SetFloat("/../", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("{0}", this.CenterX);
			this.OGMEGHKECAH().SetFloat("Vertical", this.CenterY);
			this.MHBAIEKFBIJ().SetFloat("CorrectHitsScoreText", this.Distortion);
			this.FEAEGGCNIAA().SetFloat("_Value4", this.Size);
			this.IONHGBPGCHK().SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B84 RID: 11140 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06002B85 RID: 11141 RVA: 0x000EC4E0 File Offset: 0x000EA6E0
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("settings_bindings_controller_type");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002B86 RID: 11142 RVA: 0x000EC504 File Offset: 0x000EA704
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002B87 RID: 11143 RVA: 0x000EB43B File Offset: 0x000E963B
	private void GNPDGBNDCPL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B88 RID: 11144 RVA: 0x000EB43B File Offset: 0x000E963B
	private void NHHCGPAMLAJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B89 RID: 11145 RVA: 0x000EC528 File Offset: 0x000EA728
	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 562f)
			{
				this.HBJJOCHGOPH = 361f;
			}
			this.DBOLLHHMKKN().SetFloat("CameraFilterPack/Blizzard", this.HBJJOCHGOPH);
			this.EBJKJPAIAAM().SetFloat("_MainTex2", this.CenterX);
			this.NBPKMLMCHFN.SetFloat("Malformed RPC; this should never occur. Content: ", this.CenterY);
			this.KAFBNOBOIAJ().SetFloat("LostLive", this.Distortion);
			this.EMDFHOKEGNG().SetFloat("stretchWidth", this.Size);
			this.NLFJGMBCICG().SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GBFOAHKAJEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B8A RID: 11146 RVA: 0x000EB43B File Offset: 0x000E963B
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B8B RID: 11147 RVA: 0x000EC620 File Offset: 0x000EA820
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1107f)
			{
				this.HBJJOCHGOPH = 1483f;
			}
			this.OKJOKHGJHGF().SetFloat(" now: ", this.HBJJOCHGOPH);
			this.MNLKBFFKHIE().SetFloat("Done!", this.CenterX);
			this.FEAEGGCNIAA().SetFloat("_Value10", this.CenterY);
			this.OGMEGHKECAH().SetFloat("UseScanLineSize", this.Distortion);
			this.ADAFMBOGPLN().SetFloat("restrictions\n\n#until: ", this.Size);
			this.EBJKJPAIAAM().SetVector("_TimeX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ILKALHDJBFE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B8C RID: 11148 RVA: 0x0002523B File Offset: 0x0002343B
	private void JCGMGLMADEN()
	{
	}

	// Token: 0x06002B8D RID: 11149 RVA: 0x000EC718 File Offset: 0x000EA918
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B8E RID: 11150 RVA: 0x000EB43B File Offset: 0x000E963B
	private void BNCLKHOEGDK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B8F RID: 11151 RVA: 0x000EC750 File Offset: 0x000EA950
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1787f)
			{
				this.HBJJOCHGOPH = 293f;
			}
			this.ADAFMBOGPLN().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.HJGEHJDMCGI().SetFloat("_Value", this.CenterX);
			this.MFHPKGICPIO().SetFloat("_ScreenResolution", this.CenterY);
			this.OKJOKHGJHGF().SetFloat("Observed type is not serializable: ", this.Distortion);
			this.DBOLLHHMKKN().SetFloat("float,1.5", this.Size);
			this.NBPKMLMCHFN.SetVector("CameraFilterPack/Pixelisation_Sweater", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HJGEHJDMCGI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B90 RID: 11152 RVA: 0x000EC848 File Offset: 0x000EAA48
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B91 RID: 11153 RVA: 0x000EC87F File Offset: 0x000EAA7F
	private Material EBJKJPAIAAM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B92 RID: 11154 RVA: 0x000EC8B6 File Offset: 0x000EAAB6
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002B93 RID: 11155 RVA: 0x000EC8DC File Offset: 0x000EAADC
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1736f)
			{
				this.HBJJOCHGOPH = 228f;
			}
			this.LELKBCALFCF().SetFloat("achievements.id", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("challenges.", this.CenterX);
			this.KEMJNOMIPHN().SetFloat("[LevelEditorScene] Error: I/O Failure! :(", this.CenterY);
			this.HJGEHJDMCGI().SetFloat("\"", this.Distortion);
			this.HCGJCMDJPGD().SetFloat(" is not part of the Unity 3.2+ effects suite anymore. For best performance and quality, please ensure you are using the latest Standard Assets Image Effects (Pro only) package.", this.Size);
			this.MHBAIEKFBIJ().SetVector("X", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B94 RID: 11156 RVA: 0x000EC9D4 File Offset: 0x000EABD4
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_Twist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002B95 RID: 11157 RVA: 0x000EC9F8 File Offset: 0x000EABF8
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002B96 RID: 11158 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x06002B97 RID: 11159 RVA: 0x000ECA1C File Offset: 0x000EAC1C
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B98 RID: 11160 RVA: 0x000ECA54 File Offset: 0x000EAC54
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1912f)
			{
				this.HBJJOCHGOPH = 1721f;
			}
			this.NFKFAAHHLLM().SetFloat("float,1", this.HBJJOCHGOPH);
			this.ILKALHDJBFE().SetFloat("_Distortion", this.CenterX);
			this.FEAEGGCNIAA().SetFloat("[#clicktoacceptchallenge]", this.CenterY);
			this.MLMKCOINOOH().SetFloat("CameraFilterPack/Deep_OilPaintHQ", this.Distortion);
			this.ACHNOHCLGOO().SetFloat("EventData0DropDownList", this.Size);
			this.MLMKCOINOOH().SetVector("_Offsets", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B99 RID: 11161 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06002B9A RID: 11162 RVA: 0x000ECB4C File Offset: 0x000EAD4C
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find("ArcsDestroyDelaySlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002B9B RID: 11163 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x06002B9C RID: 11164 RVA: 0x000ECB70 File Offset: 0x000EAD70
	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 769f)
			{
				this.HBJJOCHGOPH = 60f;
			}
			this.IONHGBPGCHK().SetFloat("Set Satellite Color", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetFloat(".lastCheckpoint.maxLongestCombo", this.CenterX);
			this.DBOLLHHMKKN().SetFloat("RecieveChatMessage", this.CenterY);
			this.EMDFHOKEGNG().SetFloat("Tab1Content", this.Distortion);
			this.EBJKJPAIAAM().SetFloat("_TimeX", this.Size);
			this.KEMJNOMIPHN().SetVector("w", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B9D RID: 11165 RVA: 0x000ECC68 File Offset: 0x000EAE68
	private void BKIGIIINEDH()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_VHS");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002B9E RID: 11166 RVA: 0x000ECC8C File Offset: 0x000EAE8C
	private void CEDFFAOOPOG()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002B9F RID: 11167 RVA: 0x000ECCB0 File Offset: 0x000EAEB0
	private Material ADAFMBOGPLN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BA0 RID: 11168 RVA: 0x000ECCE7 File Offset: 0x000EAEE7
	private void FEGJMDDIDIC()
	{
		this.SCShader = Shader.Find(";");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002BA1 RID: 11169 RVA: 0x000ECD0C File Offset: 0x000EAF0C
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1056f)
			{
				this.HBJJOCHGOPH = 1617f;
			}
			this.KEMJNOMIPHN().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("The given 2D texture ", this.CenterX);
			this.FEAEGGCNIAA().SetFloat("ItemNameText", this.CenterY);
			this.DBOLLHHMKKN().SetFloat("ticket", this.Distortion);
			this.OGMEGHKECAH().SetFloat("offline room", this.Size);
			this.ADAFMBOGPLN().SetVector("CameraFilterPack/Blend2Camera_Lighten", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002BA2 RID: 11170 RVA: 0x000ECE04 File Offset: 0x000EB004
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1072f)
			{
				this.HBJJOCHGOPH = 421f;
			}
			this.LENEJAGLCNL().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.MLMKCOINOOH().SetFloat("[SaveSystem] Outdated savefile found", this.CenterX);
			this.ILKALHDJBFE().SetFloat("Set satellite trail width", this.CenterY);
			this.NLFJGMBCICG().SetFloat("SfxVolumeSlider", this.Distortion);
			this.NFKFAAHHLLM().SetFloat("_TimeX", this.Size);
			this.IIJMIPBMMBF().SetVector("[Down]", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002BA3 RID: 11171 RVA: 0x000EBD74 File Offset: 0x000E9F74
	private Material LELKBCALFCF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BA4 RID: 11172 RVA: 0x000ECEFC File Offset: 0x000EB0FC
	private void DOKAKEMDALN()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002BA5 RID: 11173 RVA: 0x000ECF20 File Offset: 0x000EB120
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("elapsed: {0:0.000}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002BA6 RID: 11174 RVA: 0x000EB43B File Offset: 0x000E963B
	private void HLHJBJGEEEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002BA7 RID: 11175 RVA: 0x000ECF44 File Offset: 0x000EB144
	private void MABCDJDPGNA()
	{
		this.SCShader = Shader.Find("#creatingnewitem");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002BA8 RID: 11176 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06002BA9 RID: 11177 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002BAA RID: 11178 RVA: 0x000ECF68 File Offset: 0x000EB168
	private Material ILKALHDJBFE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BAB RID: 11179 RVA: 0x000ECFA0 File Offset: 0x000EB1A0
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1546f)
			{
				this.HBJJOCHGOPH = 1618f;
			}
			this.EPCGJFCCAFH().SetFloat("MenuScene", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat(" to: ", this.CenterX);
			this.MHBAIEKFBIJ().SetFloat("RecordButton", this.CenterY);
			this.HJGEHJDMCGI().SetFloat("inventory.selected.", this.Distortion);
			this.LELKBCALFCF().SetFloat(".highscore", this.Size);
			this.GJHLADDCMFF().SetVector("/Saved Games/", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002BAC RID: 11180 RVA: 0x000ED098 File Offset: 0x000EB298
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BAD RID: 11181 RVA: 0x000EBD74 File Offset: 0x000E9F74
	private Material EGOGECOEONM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BAE RID: 11182 RVA: 0x000ED0D0 File Offset: 0x000EB2D0
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
			this.NBPKMLMCHFN.SetFloat("_CenterX", this.CenterX);
			this.NBPKMLMCHFN.SetFloat("_CenterY", this.CenterY);
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Distortion);
			this.NBPKMLMCHFN.SetFloat("_Size", this.Size);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002BAF RID: 11183 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06002BB0 RID: 11184 RVA: 0x000ED1C8 File Offset: 0x000EB3C8
	private Material HJGEHJDMCGI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BB1 RID: 11185 RVA: 0x000ED1FF File Offset: 0x000EB3FF
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BB2 RID: 11186 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06002BB3 RID: 11187 RVA: 0x000EB43B File Offset: 0x000E963B
	private void CNPINCHINJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002BB4 RID: 11188 RVA: 0x000ED236 File Offset: 0x000EB436
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("GroupNameText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002BB5 RID: 11189 RVA: 0x000ED25C File Offset: 0x000EB45C
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 598f)
			{
				this.HBJJOCHGOPH = 1189f;
			}
			this.OGMEGHKECAH().SetFloat("id", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("kick", this.CenterX);
			this.EGOGECOEONM().SetFloat("DPADVER", this.CenterY);
			this.MLMKCOINOOH().SetFloat("PointerExit ", this.Distortion);
			this.KAFBNOBOIAJ().SetFloat("CameraFilterPack/Blend2Camera_LinearDodge", this.Size);
			this.MNLKBFFKHIE().SetVector("settings.volume.sfx", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002BB6 RID: 11190 RVA: 0x000ECEFC File Offset: 0x000EB0FC
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002BB7 RID: 11191 RVA: 0x000ED354 File Offset: 0x000EB554
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 313f)
			{
				this.HBJJOCHGOPH = 305f;
			}
			this.HCGJCMDJPGD().SetFloat("LevelInfoInputField", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("DPADHOR", this.CenterX);
			this.IIJMIPBMMBF().SetFloat("_FadeFromBinary", this.CenterY);
			this.PEIMCBBHLBJ().SetFloat("_ScreenResolution", this.Distortion);
			this.HJGEHJDMCGI().SetFloat("_ScreenResolution", this.Size);
			this.MHBAIEKFBIJ().SetVector("RecieveChatActionMessage", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EBJKJPAIAAM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002BB8 RID: 11192 RVA: 0x000ED44C File Offset: 0x000EB64C
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("st");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002BB9 RID: 11193 RVA: 0x000ED470 File Offset: 0x000EB670
	private void OIKAPFGPLML(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1847f)
			{
				this.HBJJOCHGOPH = 556f;
			}
			this.OKJOKHGJHGF().SetFloat("_FadeFX", this.HBJJOCHGOPH);
			this.ADAFMBOGPLN().SetFloat("_TimeX", this.CenterX);
			this.DBOLLHHMKKN().SetFloat("\nCreated by Oxy949", this.CenterY);
			this.EPCGJFCCAFH().SetFloat("#tryagain", this.Distortion);
			this.MLMKCOINOOH().SetFloat("_FarCamera", this.Size);
			this.DOMEEFLPEPJ().SetVector("player.goldarc", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002BBA RID: 11194 RVA: 0x0002523B File Offset: 0x0002343B
	private void APKNAPHOFHC()
	{
	}

	// Token: 0x06002BBB RID: 11195 RVA: 0x000ED568 File Offset: 0x000EB768
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BBC RID: 11196 RVA: 0x000ED59F File Offset: 0x000EB79F
	private Material PEIMCBBHLBJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)124;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BBD RID: 11197 RVA: 0x000EB43B File Offset: 0x000E963B
	private void ODLMOJDBPPG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000078 RID: 120
	// (get) Token: 0x06002BBE RID: 11198 RVA: 0x000ED5D6 File Offset: 0x000EB7D6
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

	// Token: 0x06002BBF RID: 11199 RVA: 0x000EB43B File Offset: 0x000E963B
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002BC0 RID: 11200 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKMELABKBHO()
	{
	}

	// Token: 0x06002BC1 RID: 11201 RVA: 0x000ED610 File Offset: 0x000EB810
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 130f)
			{
				this.HBJJOCHGOPH = 1233f;
			}
			this.HJGEHJDMCGI().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("_Value2", this.CenterX);
			this.FEAEGGCNIAA().SetFloat("Closes the app", this.CenterY);
			this.ILKALHDJBFE().SetFloat("CameraFilterPack/TV_WideScreenHV", this.Distortion);
			this.EMDFHOKEGNG().SetFloat("_FixDistance", this.Size);
			this.ILKALHDJBFE().SetVector("masterSteamID", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002BC2 RID: 11202 RVA: 0x000ED708 File Offset: 0x000EB908
	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1269f)
			{
				this.HBJJOCHGOPH = 1040f;
			}
			this.EGOGECOEONM().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("#failed!", this.CenterX);
			this.NFKFAAHHLLM().SetFloat("_ColorRGB", this.CenterY);
			this.ADAFMBOGPLN().SetFloat("_CenterX", this.Distortion);
			this.FKEOGPDLBDD().SetFloat("_TimeX", this.Size);
			this.KAFBNOBOIAJ().SetVector("\n", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002BC3 RID: 11203 RVA: 0x000ED800 File Offset: 0x000EBA00
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BC4 RID: 11204 RVA: 0x000EB43B File Offset: 0x000E963B
	private void ELKELFCGMPE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002BC5 RID: 11205 RVA: 0x000ED837 File Offset: 0x000EBA37
	private Material MHBAIEKFBIJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BC6 RID: 11206 RVA: 0x000ED870 File Offset: 0x000EBA70
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1746f)
			{
				this.HBJJOCHGOPH = 1144f;
			}
			this.KAFBNOBOIAJ().SetFloat("_SizeY", this.HBJJOCHGOPH);
			this.LELKBCALFCF().SetFloat("_Value3", this.CenterX);
			this.EPCGJFCCAFH().SetFloat("[MapEditor] Prepairing map editor...", this.CenterY);
			this.ADAFMBOGPLN().SetFloat("_MainTex2", this.Distortion);
			this.ACHNOHCLGOO().SetFloat("_Value3", this.Size);
			this.IONHGBPGCHK().SetVector("y", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002BC7 RID: 11207 RVA: 0x000ECCB0 File Offset: 0x000EAEB0
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BC8 RID: 11208 RVA: 0x000ED968 File Offset: 0x000EBB68
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1913f)
			{
				this.HBJJOCHGOPH = 677f;
			}
			this.MNLKBFFKHIE().SetFloat("\n\n#", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("CameraFilterPack/TV_Video3D", this.CenterX);
			this.IONHGBPGCHK().SetFloat("_Gain", this.CenterY);
			this.ILKALHDJBFE().SetFloat("#restart", this.Distortion);
			this.MHBAIEKFBIJ().SetFloat("Vertical", this.Size);
			this.FKEOGPDLBDD().SetVector("[ItemsHandler] Inventory has changed", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002BC9 RID: 11209 RVA: 0x000EDA60 File Offset: 0x000EBC60
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1084f)
			{
				this.HBJJOCHGOPH = 1880f;
			}
			this.IIJMIPBMMBF().SetFloat("GlassColor", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("MenuRecordButton", this.CenterX);
			this.MLMKCOINOOH().SetFloat("_Value5", this.CenterY);
			this.PEIMCBBHLBJ().SetFloat("ConfigVersionSlider", this.Distortion);
			this.HJGEHJDMCGI().SetFloat("The number of objects sent via a PhotonStreamQueue has to be the same each frame", this.Size);
			this.EPCGJFCCAFH().SetVector("note.5", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002BCA RID: 11210 RVA: 0x000EDB58 File Offset: 0x000EBD58
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BCB RID: 11211 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x06002BCC RID: 11212 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x06002BCD RID: 11213 RVA: 0x000EDB90 File Offset: 0x000EBD90
	private void IHAMJLJFFLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 413f)
			{
				this.HBJJOCHGOPH = 280f;
			}
			this.GJHLADDCMFF().SetFloat("ns", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("maps.", this.CenterX);
			this.MNLKBFFKHIE().SetFloat("CameraFilterPack/FX_Dot_Circle", this.CenterY);
			this.NLFJGMBCICG().SetFloat("[MapEditor] Loaded music file: ", this.Distortion);
			this.HJGEHJDMCGI().SetFloat("PlayMapGoal", this.Size);
			this.LELKBCALFCF().SetVector("value", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002BCE RID: 11214 RVA: 0x000ED800 File Offset: 0x000EBA00
	private Material MNLKBFFKHIE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BCF RID: 11215 RVA: 0x000EDC88 File Offset: 0x000EBE88
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002BD0 RID: 11216 RVA: 0x0002523B File Offset: 0x0002343B
	private void JGMEKCFHGLE()
	{
	}

	// Token: 0x06002BD1 RID: 11217 RVA: 0x000EB43B File Offset: 0x000E963B
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002BD2 RID: 11218 RVA: 0x000EDCC0 File Offset: 0x000EBEC0
	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1621f)
			{
				this.HBJJOCHGOPH = 476f;
			}
			this.ADAFMBOGPLN().SetFloat("Joystick1Button0", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("_Value3", this.CenterX);
			this.ACHNOHCLGOO().SetFloat("_Value3", this.CenterY);
			this.FKEOGPDLBDD().SetFloat("CameraFilterPack/Blend2Camera_Multiply", this.Distortion);
			this.LENEJAGLCNL().SetFloat("MouseY", this.Size);
			this.DOMEEFLPEPJ().SetVector("Horizontal", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002BD3 RID: 11219 RVA: 0x000EB43B File Offset: 0x000E963B
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002BD4 RID: 11220 RVA: 0x000EDDB8 File Offset: 0x000EBFB8
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 561f)
			{
				this.HBJJOCHGOPH = 190f;
			}
			this.IIJMIPBMMBF().SetFloat("0,7,true,0", this.HBJJOCHGOPH);
			this.LELKBCALFCF().SetFloat("Dec", this.CenterX);
			this.NLFJGMBCICG().SetFloat("[Right]", this.CenterY);
			this.ACHNOHCLGOO().SetFloat("player.xp", this.Distortion);
			this.MHBAIEKFBIJ().SetFloat("closed", this.Size);
			this.MLMKCOINOOH().SetVector("No font defined. Found font: ", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002BD5 RID: 11221 RVA: 0x000EB43B File Offset: 0x000E963B
	private void PJGFBHOKMIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002BD6 RID: 11222 RVA: 0x0002523B File Offset: 0x0002343B
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x06002BD7 RID: 11223 RVA: 0x000EDEB0 File Offset: 0x000EC0B0
	private void IGPCNCJIEOJ()
	{
		this.SCShader = Shader.Find("RarityImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002BD8 RID: 11224 RVA: 0x000EDED4 File Offset: 0x000EC0D4
	private void OKLAJINHPAN()
	{
		this.SCShader = Shader.Find("Drop_Floor_Fluid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002BD9 RID: 11225 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x04000527 RID: 1319
	public Shader SCShader;

	// Token: 0x04000528 RID: 1320
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000529 RID: 1321
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400052A RID: 1322
	private Material BJFKDHHMLJH;

	// Token: 0x0400052B RID: 1323
	[Range(-2f, 2f)]
	public float CenterX = 0.5f;

	// Token: 0x0400052C RID: 1324
	[Range(-2f, 2f)]
	public float CenterY = 0.5f;

	// Token: 0x0400052D RID: 1325
	[Range(-3.14f, 3.14f)]
	public float Distortion = 1f;

	// Token: 0x0400052E RID: 1326
	[Range(-2f, 2f)]
	public float Size = 1f;
}
