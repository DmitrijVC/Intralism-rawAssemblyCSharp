using System;
using UnityEngine;

// Token: 0x020000C9 RID: 201
[AddComponentMenu("Camera Filter Pack/Glitch/Glitch2")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_Glitch2 : MonoBehaviour
{
	// Token: 0x06003CAC RID: 15532 RVA: 0x00130E78 File Offset: 0x0012F078
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1141f)
			{
				this.HBJJOCHGOPH = 1108f;
			}
			this.DONENAMLFLF().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.KDMBOKLMADJ().SetFloat("Joystick1Button12", this.Glitch);
			this.KBOPGONOCNP().SetVector("_DepthLevel", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 618f, 1392f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003CAD RID: 15533 RVA: 0x00130F35 File Offset: 0x0012F135
	private void CCFEDENFNEF()
	{
		this.SCShader = Shader.Find("Apr");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003CAE RID: 15534 RVA: 0x00130F5C File Offset: 0x0012F15C
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 506f)
			{
				this.HBJJOCHGOPH = 487f;
			}
			this.MHBAIEKFBIJ().SetFloat("Set Crosshair Color", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("_Near", this.Glitch);
			this.JLHLHKPHDFO().SetVector("[PlayerController] ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 940f, 1260f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003CAF RID: 15535 RVA: 0x00131019 File Offset: 0x0012F219
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("May");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003CB0 RID: 15536 RVA: 0x00131040 File Offset: 0x0012F240
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1803f)
			{
				this.HBJJOCHGOPH = 1284f;
			}
			this.HCGJCMDJPGD().SetFloat("DPADVER", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("inventory.selected.", this.Glitch);
			this.LNLKMDPHDCC().SetVector("\\\\", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 429f, 1478f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003CB1 RID: 15537 RVA: 0x001310FD File Offset: 0x0012F2FD
	private Material GJHPODJOBHL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003CB2 RID: 15538 RVA: 0x00131134 File Offset: 0x0012F334
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_LighterColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003CB3 RID: 15539 RVA: 0x00131158 File Offset: 0x0012F358
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CB4 RID: 15540 RVA: 0x00131175 File Offset: 0x0012F375
	private void GLEJGFLCLPJ()
	{
		this.SCShader = Shader.Find("shader.future");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003CB5 RID: 15541 RVA: 0x0013119C File Offset: 0x0012F39C
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1192f)
			{
				this.HBJJOCHGOPH = 1962f;
			}
			this.BFGNMFCNDBC().SetFloat("DisableStoryboardToggle", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("<b>HP</b>:", this.Glitch);
			this.CIAFLBFJLEJ().SetVector("Text", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 429f, 256f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003CB6 RID: 15542 RVA: 0x00131158 File Offset: 0x0012F358
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CB7 RID: 15543 RVA: 0x0013125C File Offset: 0x0012F45C
	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1650f)
			{
				this.HBJJOCHGOPH = 93f;
			}
			this.CFEDGDGBCHE().SetFloat("offline", this.HBJJOCHGOPH);
			this.KHCLIAMBBNC().SetFloat("OnAwakeRPC", this.Glitch);
			this.FGENHBKMPDA().SetVector("[NetworkManager] Join failed", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1360f, 1958f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003CB8 RID: 15544 RVA: 0x00131158 File Offset: 0x0012F358
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CB9 RID: 15545 RVA: 0x00131319 File Offset: 0x0012F519
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-125);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003CBA RID: 15546 RVA: 0x00131350 File Offset: 0x0012F550
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1438f)
			{
				this.HBJJOCHGOPH = 1377f;
			}
			this.BFGNMFCNDBC().SetFloat("CameraFilterPack/Vision_Rainbow", this.HBJJOCHGOPH);
			this.KHCLIAMBBNC().SetFloat("D-Pad Left", this.Glitch);
			this.BFGNMFCNDBC().SetVector("s", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1694f, 1920f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003CBB RID: 15547 RVA: 0x00131158 File Offset: 0x0012F358
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CBC RID: 15548 RVA: 0x00131158 File Offset: 0x0012F358
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CBD RID: 15549 RVA: 0x00131410 File Offset: 0x0012F610
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 885f)
			{
				this.HBJJOCHGOPH = 821f;
			}
			this.KBOPGONOCNP().SetFloat("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp-firstpass", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("Received RPC \"", this.Glitch);
			this.IIJMIPBMMBF().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 393f, 1935f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003CBE RID: 15550 RVA: 0x001314CD File Offset: 0x0012F6CD
	private void HIPEHGNBJMN()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003CBF RID: 15551 RVA: 0x001314F1 File Offset: 0x0012F6F1
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("HighScaleShot");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003CC0 RID: 15552 RVA: 0x00131158 File Offset: 0x0012F358
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CC1 RID: 15553 RVA: 0x00131515 File Offset: 0x0012F715
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003CC2 RID: 15554 RVA: 0x0013154C File Offset: 0x0012F74C
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003CC3 RID: 15555 RVA: 0x00131583 File Offset: 0x0012F783
	private void MJEFMIPLFAB()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003CC5 RID: 15557 RVA: 0x00131158 File Offset: 0x0012F358
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CC6 RID: 15558 RVA: 0x001315C8 File Offset: 0x0012F7C8
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 760f)
			{
				this.HBJJOCHGOPH = 1242f;
			}
			this.KDMBOKLMADJ().SetFloat("NEW_ACHIEVEMENT_1_26", this.HBJJOCHGOPH);
			this.KOHGPKOFEJO().SetFloat("_DistortionLevel", this.Glitch);
			this.OIIDAKBILMI().SetVector("_Value11", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1551f, 1492f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003CC7 RID: 15559 RVA: 0x00131685 File Offset: 0x0012F885
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("_DistortionSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003CC8 RID: 15560 RVA: 0x00131158 File Offset: 0x0012F358
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CC9 RID: 15561 RVA: 0x001316A9 File Offset: 0x0012F8A9
	private void AEDDNDHCLNN()
	{
		this.SCShader = Shader.Find(".mp3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003CCA RID: 15562 RVA: 0x001316D0 File Offset: 0x0012F8D0
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1525f)
			{
				this.HBJJOCHGOPH = 329f;
			}
			this.MCDGIILBNIF().SetFloat("_Offsets", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("Object ID. Case-Sensitive", this.Glitch);
			this.DONENAMLFLF().SetVector("(scene)", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 963f, 1951f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003CCB RID: 15563 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06003CCC RID: 15564 RVA: 0x0013178D File Offset: 0x0012F98D
	private void MDNHCLKNCLE()
	{
		this.SCShader = Shader.Find("STICKRVER");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003CCD RID: 15565 RVA: 0x00131158 File Offset: 0x0012F358
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CCE RID: 15566 RVA: 0x001317B1 File Offset: 0x0012F9B1
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003CCF RID: 15567 RVA: 0x001317E8 File Offset: 0x0012F9E8
	private void ALJEJJCIMJN()
	{
		this.SCShader = Shader.Find("event");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003CD0 RID: 15568 RVA: 0x0002523B File Offset: 0x0002343B
	private void MANDOGNJJBD()
	{
	}

	// Token: 0x06003CD1 RID: 15569 RVA: 0x0013180C File Offset: 0x0012FA0C
	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1139f)
			{
				this.HBJJOCHGOPH = 1010f;
			}
			this.KHCLIAMBBNC().SetFloat("GameModeText", this.HBJJOCHGOPH);
			this.MHBAIEKFBIJ().SetFloat("LivesSlider", this.Glitch);
			this.OIIDAKBILMI().SetVector("settings_bindings_sec_", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 319f, 214f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003CD2 RID: 15570 RVA: 0x00131158 File Offset: 0x0012F358
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CD3 RID: 15571 RVA: 0x001318C9 File Offset: 0x0012FAC9
	private void ODBNMPGBCGO()
	{
		this.SCShader = Shader.Find("settings.arcsdestroydelay");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003CD4 RID: 15572 RVA: 0x001318F0 File Offset: 0x0012FAF0
	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1090f)
			{
				this.HBJJOCHGOPH = 1007f;
			}
			this.OIIDAKBILMI().SetFloat("_ReflectionTexture3", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("Edited unlock conditions", this.Glitch);
			this.KDMBOKLMADJ().SetVector("_Value1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 175f, 1431f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003CD5 RID: 15573 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06003CD6 RID: 15574 RVA: 0x001319AD File Offset: 0x0012FBAD
	private Material KHCLIAMBBNC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003CD7 RID: 15575 RVA: 0x001319E4 File Offset: 0x0012FBE4
	private void EIMNPCMHJLJ()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003CD8 RID: 15576 RVA: 0x00131158 File Offset: 0x0012F358
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CD9 RID: 15577 RVA: 0x00131A08 File Offset: 0x0012FC08
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 785f)
			{
				this.HBJJOCHGOPH = 760f;
			}
			this.OIIDAKBILMI().SetFloat("_Value", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("reset", this.Glitch);
			this.HNICHJCGJOC().SetVector("mapselector.filter.subscribedonly", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 96f, 1609f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003CDA RID: 15578 RVA: 0x0002523B File Offset: 0x0002343B
	private void MBLDJEFBLFL()
	{
	}

	// Token: 0x06003CDB RID: 15579 RVA: 0x00131AC8 File Offset: 0x0012FCC8
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 658f)
			{
				this.HBJJOCHGOPH = 1851f;
			}
			this.FGENHBKMPDA().SetFloat(": ", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat("\" to target: ", this.Glitch);
			this.IIJMIPBMMBF().SetVector("88f00bdf0ad61b16b803971ebe071962", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 761f, 672f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003CDC RID: 15580 RVA: 0x00131B88 File Offset: 0x0012FD88
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 56f)
			{
				this.HBJJOCHGOPH = 1052f;
			}
			this.DKNJGHFLAIF().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.MHBAIEKFBIJ().SetFloat("_TimeX", this.Glitch);
			this.FGENHBKMPDA().SetVector("https://steamcdn-a.akamaihd.net/steamcommunity/public/images/clans/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1917f, 1205f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003CDD RID: 15581 RVA: 0x00131C45 File Offset: 0x0012FE45
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003CDE RID: 15582 RVA: 0x00131C7C File Offset: 0x0012FE7C
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003CDF RID: 15583 RVA: 0x00131158 File Offset: 0x0012F358
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CE0 RID: 15584 RVA: 0x00131CB3 File Offset: 0x0012FEB3
	private void MKOMIDCPCDC()
	{
		this.SCShader = Shader.Find("settings.disablestoryboard");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003CE1 RID: 15585 RVA: 0x00131158 File Offset: 0x0012F358
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CE2 RID: 15586 RVA: 0x00131CD8 File Offset: 0x0012FED8
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 244f)
			{
				this.HBJJOCHGOPH = 696f;
			}
			this.MHBAIEKFBIJ().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat("[SoundManager] Loaded skin audio", this.Glitch);
			this.DBOLLHHMKKN().SetVector("Drop_With_Obj", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1379f, 1853f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003CE3 RID: 15587 RVA: 0x0002523B File Offset: 0x0002343B
	private void HEBOIFKBLGD()
	{
	}

	// Token: 0x06003CE4 RID: 15588 RVA: 0x00131D98 File Offset: 0x0012FF98
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1992f)
			{
				this.HBJJOCHGOPH = 839f;
			}
			this.IIJMIPBMMBF().SetFloat("_CurveTex", this.HBJJOCHGOPH);
			this.LMLENGFLEBD().SetFloat("{0:0} day{1}, ", this.Glitch);
			this.IIJMIPBMMBF().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 295f, 281f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003CE5 RID: 15589 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06003CE6 RID: 15590 RVA: 0x00131158 File Offset: 0x0012F358
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CE7 RID: 15591 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x170000AF RID: 175
	// (get) Token: 0x06003CE8 RID: 15592 RVA: 0x00131E55 File Offset: 0x00130055
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

	// Token: 0x06003CE9 RID: 15593 RVA: 0x00131E8C File Offset: 0x0013008C
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1575f)
			{
				this.HBJJOCHGOPH = 1656f;
			}
			this.LNLKMDPHDCC().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat("_Value8", this.Glitch);
			this.LNLKMDPHDCC().SetVector("{0}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1742f, 730f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003CEA RID: 15594 RVA: 0x00131F49 File Offset: 0x00130149
	private void HPFOFGJPNCI()
	{
		this.SCShader = Shader.Find("EventTimeInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003CEB RID: 15595 RVA: 0x001314CD File Offset: 0x0012F6CD
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003CEC RID: 15596 RVA: 0x00131F6D File Offset: 0x0013016D
	private void JONGNKNLLND()
	{
		this.SCShader = Shader.Find("Change Note:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003CED RID: 15597 RVA: 0x00131158 File Offset: 0x0012F358
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CEE RID: 15598 RVA: 0x00131F94 File Offset: 0x00130194
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
			this.NBPKMLMCHFN.SetFloat("_Glitch", this.Glitch);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003CEF RID: 15599 RVA: 0x00132051 File Offset: 0x00130251
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003CF0 RID: 15600 RVA: 0x00131158 File Offset: 0x0012F358
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CF1 RID: 15601 RVA: 0x00132088 File Offset: 0x00130288
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003CF2 RID: 15602 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x06003CF3 RID: 15603 RVA: 0x0002523B File Offset: 0x0002343B
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x06003CF4 RID: 15604 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x06003CF5 RID: 15605 RVA: 0x00131158 File Offset: 0x0012F358
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CF6 RID: 15606 RVA: 0x00131158 File Offset: 0x0012F358
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CF7 RID: 15607 RVA: 0x001320BF File Offset: 0x001302BF
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)64;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003CF8 RID: 15608 RVA: 0x001320F6 File Offset: 0x001302F6
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("[MenuScene] Error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003CF9 RID: 15609 RVA: 0x0013211A File Offset: 0x0013031A
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("[NetworkScene] Exited");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003CFA RID: 15610 RVA: 0x0013213E File Offset: 0x0013033E
	private void DPLLKHHLDBB()
	{
		this.SCShader = Shader.Find(". Should be just one?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003CFB RID: 15611 RVA: 0x00131158 File Offset: 0x0012F358
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CFC RID: 15612 RVA: 0x00131158 File Offset: 0x0012F358
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CFD RID: 15613 RVA: 0x00131158 File Offset: 0x0012F358
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CFE RID: 15614 RVA: 0x00132162 File Offset: 0x00130362
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003CFF RID: 15615 RVA: 0x00132199 File Offset: 0x00130399
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003D00 RID: 15616 RVA: 0x001321BD File Offset: 0x001303BD
	private void ECBILENEOOL()
	{
		this.SCShader = Shader.Find("settings.gamemessagesduration");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003D01 RID: 15617 RVA: 0x001321E4 File Offset: 0x001303E4
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 611f)
			{
				this.HBJJOCHGOPH = 1873f;
			}
			this.KDMBOKLMADJ().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.KHCLIAMBBNC().SetFloat("Malformed RPC; this should never occur. Content: ", this.Glitch);
			this.IIJMIPBMMBF().SetVector("steamid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1647f, 1857f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D02 RID: 15618 RVA: 0x001322A1 File Offset: 0x001304A1
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D03 RID: 15619 RVA: 0x00131158 File Offset: 0x0012F358
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D04 RID: 15620 RVA: 0x001322D8 File Offset: 0x001304D8
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D05 RID: 15621 RVA: 0x00132310 File Offset: 0x00130510
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 277f)
			{
				this.HBJJOCHGOPH = 1275f;
			}
			this.GJHPODJOBHL().SetFloat("MusicFileSelector", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("\\", this.Glitch);
			this.LMLENGFLEBD().SetVector("_OcclusionTexture", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 836f, 1281f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D06 RID: 15622 RVA: 0x00131158 File Offset: 0x0012F358
	private void JNALDALAJLG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D07 RID: 15623 RVA: 0x001323CD File Offset: 0x001305CD
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D08 RID: 15624 RVA: 0x00131158 File Offset: 0x0012F358
	private void IENKPJEBMFM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D09 RID: 15625 RVA: 0x00132404 File Offset: 0x00130604
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 760f)
			{
				this.HBJJOCHGOPH = 1305f;
			}
			this.CFEDGDGBCHE().SetFloat("Case-Sensitive", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat("<b>#", this.Glitch);
			this.KHCLIAMBBNC().SetVector("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp-firstpass", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 690f, 1722f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D0A RID: 15626 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003D0B RID: 15627 RVA: 0x001324C1 File Offset: 0x001306C1
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D0C RID: 15628 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x06003D0D RID: 15629 RVA: 0x001324F8 File Offset: 0x001306F8
	private void FIJHDKIPENG()
	{
		this.SCShader = Shader.Find("#{0:X2}{1:X2}{2:X2}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003D0E RID: 15630 RVA: 0x0002523B File Offset: 0x0002343B
	private void BFGIMALGMAJ()
	{
	}

	// Token: 0x06003D0F RID: 15631 RVA: 0x0013251C File Offset: 0x0013071C
	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 624f)
			{
				this.HBJJOCHGOPH = 213f;
			}
			this.HCGJCMDJPGD().SetFloat("/?player=", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("ShowSprite", this.Glitch);
			this.NBPKMLMCHFN.SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 686f, 29f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KOHGPKOFEJO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D10 RID: 15632 RVA: 0x001325D9 File Offset: 0x001307D9
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003D11 RID: 15633 RVA: 0x001325FD File Offset: 0x001307FD
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003D12 RID: 15634 RVA: 0x00131158 File Offset: 0x0012F358
	private void HLHJBJGEEEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D13 RID: 15635 RVA: 0x00132621 File Offset: 0x00130821
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003D14 RID: 15636 RVA: 0x00132645 File Offset: 0x00130845
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D15 RID: 15637 RVA: 0x0013267C File Offset: 0x0013087C
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Glitch2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003D16 RID: 15638 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06003D17 RID: 15639 RVA: 0x001326A0 File Offset: 0x001308A0
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D18 RID: 15640 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06003D19 RID: 15641 RVA: 0x001326D7 File Offset: 0x001308D7
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003D1A RID: 15642 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06003D1B RID: 15643 RVA: 0x001326FB File Offset: 0x001308FB
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("???");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003D1C RID: 15644 RVA: 0x0013271F File Offset: 0x0013091F
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003D1D RID: 15645 RVA: 0x00132743 File Offset: 0x00130943
	private Material MHBAIEKFBIJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D1E RID: 15646 RVA: 0x00131158 File Offset: 0x0012F358
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D1F RID: 15647 RVA: 0x00132051 File Offset: 0x00130251
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D20 RID: 15648 RVA: 0x0013277A File Offset: 0x0013097A
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003D21 RID: 15649 RVA: 0x001327B4 File Offset: 0x001309B4
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1299f)
			{
				this.HBJJOCHGOPH = 623f;
			}
			this.LMLENGFLEBD().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.MHBAIEKFBIJ().SetFloat("_ColorKey", this.Glitch);
			this.HCGJCMDJPGD().SetVector("_Value1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 137f, 1607f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D22 RID: 15650 RVA: 0x00131158 File Offset: 0x0012F358
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003D23 RID: 15651 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06003D24 RID: 15652 RVA: 0x0002523B File Offset: 0x0002343B
	private void INLDEHPAMJC()
	{
	}

	// Token: 0x06003D25 RID: 15653 RVA: 0x00132874 File Offset: 0x00130A74
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 128f)
			{
				this.HBJJOCHGOPH = 445f;
			}
			this.KBOPGONOCNP().SetFloat("\" call.", this.HBJJOCHGOPH);
			this.FGENHBKMPDA().SetFloat("null", this.Glitch);
			this.OIIDAKBILMI().SetVector("curScn", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 877f, 385f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003D26 RID: 15654 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06003D27 RID: 15655 RVA: 0x00132934 File Offset: 0x00130B34
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1901f)
			{
				this.HBJJOCHGOPH = 1884f;
			}
			this.KDMBOKLMADJ().SetFloat("_Speed", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("type", this.Glitch);
			this.DBOLLHHMKKN().SetVector("Populate Mesh Data", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1111f, 1665f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x040006A0 RID: 1696
	public Shader SCShader;

	// Token: 0x040006A1 RID: 1697
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040006A2 RID: 1698
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040006A3 RID: 1699
	private Material BJFKDHHMLJH;

	// Token: 0x040006A4 RID: 1700
	[Range(0f, 1f)]
	public float Glitch = 1f;
}
