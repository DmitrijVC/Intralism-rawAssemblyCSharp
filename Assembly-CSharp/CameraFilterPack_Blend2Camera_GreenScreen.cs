using System;
using UnityEngine;

// Token: 0x02000044 RID: 68
[AddComponentMenu("Camera Filter Pack/Chroma Key/GreenScreen")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_GreenScreen : MonoBehaviour
{
	// Token: 0x06001275 RID: 4725 RVA: 0x0007C3CD File Offset: 0x0007A5CD
	private void JICMFFAOJJB()
	{
		this.DBEMDAJDDDA();
		this.JAAJECBCCFM();
	}

	// Token: 0x06001276 RID: 4726 RVA: 0x0007C3DB File Offset: 0x0007A5DB
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001277 RID: 4727 RVA: 0x0007C414 File Offset: 0x0007A614
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1716f)
			{
				this.HBJJOCHGOPH = 1112f;
			}
			if (this.Camera2 != null)
			{
				this.HJGEHJDMCGI().SetTexture("_TimeX", this.JDMCFBKJHDD);
			}
			this.DIOAAHJDMLK().SetFloat("CameraFilterPack/Edge_BlackLine", this.HBJJOCHGOPH);
			this.HHIAIGCAHDA().SetFloat("CameraFilterPack/Drawing_Paper3", this.BlendFX);
			this.OIBHFCLJKDB().SetFloat("JoinOrCreateRoom failed. In offline mode you still have to leave a room to enter another.", this.Adjust);
			this.OCMBHMLNCEK().SetFloat("_Luminance", this.Precision);
			this.DONENAMLFLF().SetFloat("UseFinalGlassColor", this.Luminosity);
			this.DKNJGHFLAIF().SetFloat("_ScreenResolution", this.Change_Red);
			this.KLKILLCHJHO().SetFloat("maps.", this.Change_Green);
			this.ADBKPGFMNKO().SetFloat("_Value5", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DABHAJNHOAL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001278 RID: 4728 RVA: 0x0007C54F File Offset: 0x0007A74F
	private void MHGPANIBBCM()
	{
		this.NPLCENPNJBM();
		this.EPJJDKJEDMM();
	}

	// Token: 0x06001279 RID: 4729 RVA: 0x0007C55D File Offset: 0x0007A75D
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600127A RID: 4730 RVA: 0x0007C594 File Offset: 0x0007A794
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1237f)
			{
				this.HBJJOCHGOPH = 1684f;
			}
			if (this.Camera2 != null)
			{
				this.BLMPMOIDGMG().SetTexture("CameraFilterPack/3D_Mirror", this.JDMCFBKJHDD);
			}
			this.DABHAJNHOAL().SetFloat("Joystick1Button4", this.HBJJOCHGOPH);
			this.MJJIEHANFJA().SetFloat(" has ", this.BlendFX);
			this.MJJIEHANFJA().SetFloat("CameraFilterPack/Blend2Camera_DarkerColor", this.Adjust);
			this.HBLDMJCOAHA().SetFloat("Value", this.Precision);
			this.IKAIDLJKLFC().SetFloat("_MatrixColor", this.Luminosity);
			this.HHIAIGCAHDA().SetFloat("_Value2", this.Change_Red);
			this.ADBKPGFMNKO().SetFloat("_Fade", this.Change_Green);
			this.JLHLHKPHDFO().SetFloat("Icon", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MNLKBFFKHIE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600127B RID: 4731 RVA: 0x0007C6D0 File Offset: 0x0007A8D0
	private void DPLLKHHLDBB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -14);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600127C RID: 4732 RVA: 0x0007C748 File Offset: 0x0007A948
	private void DLMPALHKMON()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600127D RID: 4733 RVA: 0x0007C7A4 File Offset: 0x0007A9A4
	private void ANBIJFCCANE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 414f)
			{
				this.HBJJOCHGOPH = 165f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("Noise shaders are not set up! Disabling noise effect.", this.JDMCFBKJHDD);
			}
			this.BLMPMOIDGMG().SetFloat("Set sun audio input", this.HBJJOCHGOPH);
			this.MNLKBFFKHIE().SetFloat("player.greenarc", this.BlendFX);
			this.HNFFHCLNBDN().SetFloat("_FilteredReflections", this.Adjust);
			this.FAIFBBGFAIB().SetFloat("_Value4", this.Precision);
			this.OKJOKHGJHGF().SetFloat("_ScreenResolution", this.Luminosity);
			this.BLMPMOIDGMG().SetFloat("Joystick1Button9", this.Change_Red);
			this.OKJOKHGJHGF().SetFloat("settings.arcsdestroydelay", this.Change_Green);
			this.MJJIEHANFJA().SetFloat("_Value2", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIBHFCLJKDB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600127E RID: 4734 RVA: 0x0007C8DF File Offset: 0x0007AADF
	private void LCDJFJIBADI()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x0600127F RID: 4735 RVA: 0x0007C90D File Offset: 0x0007AB0D
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001280 RID: 4736 RVA: 0x0007C944 File Offset: 0x0007AB44
	private void JBBCMAJIMCA()
	{
		this.ADPLHDFJFID();
		this.MBLDJEFBLFL();
	}

	// Token: 0x06001281 RID: 4737 RVA: 0x0007C952 File Offset: 0x0007AB52
	private void HNNKIOHCDKG()
	{
		this.DAHFFNNIGML();
		this.JAAJECBCCFM();
	}

	// Token: 0x06001282 RID: 4738 RVA: 0x0007C960 File Offset: 0x0007AB60
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1968f)
			{
				this.HBJJOCHGOPH = 204f;
			}
			if (this.Camera2 != null)
			{
				this.MJJIEHANFJA().SetTexture("settings.volume.editor", this.JDMCFBKJHDD);
			}
			this.HNFFHCLNBDN().SetFloat("Delete events", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("VisionBlur", this.BlendFX);
			this.JLHLHKPHDFO().SetFloat("_MainTex2", this.Adjust);
			this.DKNJGHFLAIF().SetFloat("cipherText", this.Precision);
			this.ADBKPGFMNKO().SetFloat("_TimeX", this.Luminosity);
			this.OIBHFCLJKDB().SetFloat("[SERVER] Selected map: ", this.Change_Red);
			this.IKAIDLJKLFC().SetFloat("_EmissionGain", this.Change_Green);
			this.ECCPAOBFDKP().SetFloat("[PlayerController] ", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001283 RID: 4739 RVA: 0x0007CA9C File Offset: 0x0007AC9C
	private void DBEMDAJDDDA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 27);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001284 RID: 4740 RVA: 0x0007CB13 File Offset: 0x0007AD13
	private void OCHCKGMIDND()
	{
		this.ALJEJJCIMJN();
		this.EPJJDKJEDMM();
	}

	// Token: 0x06001285 RID: 4741 RVA: 0x0007CB24 File Offset: 0x0007AD24
	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1775f)
			{
				this.HBJJOCHGOPH = 1308f;
			}
			if (this.Camera2 != null)
			{
				this.OOMFJGPAOKL().SetTexture("/", this.JDMCFBKJHDD);
			}
			this.OOMFJGPAOKL().SetFloat("Reset 21 achievement progress", this.HBJJOCHGOPH);
			this.HHIAIGCAHDA().SetFloat("_TimeX", this.BlendFX);
			this.IKAIDLJKLFC().SetFloat("CameraFilterPack/Blur_Dithering2x2", this.Adjust);
			this.PGPEMMBJOOG().SetFloat("SubmitUserVote:", this.Precision);
			this.DABHAJNHOAL().SetFloat("AskForPickupItemSpawnTimes", this.Luminosity);
			this.IKAIDLJKLFC().SetFloat(". Client should be in a room. Current connectionStateDetailed: ", this.Change_Red);
			this.OKJOKHGJHGF().SetFloat("</color>", this.Change_Green);
			this.HBLDMJCOAHA().SetFloat("LoadMapCanvas", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HBLDMJCOAHA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001286 RID: 4742 RVA: 0x0007C8DF File Offset: 0x0007AADF
	private void EPJJDKJEDMM()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06001287 RID: 4743 RVA: 0x0007CC60 File Offset: 0x0007AE60
	private void POENGNEMHJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 369f)
			{
				this.HBJJOCHGOPH = 273f;
			}
			if (this.Camera2 != null)
			{
				this.EJDPNJAEAKJ().SetTexture("Skipping region because it's not in PhotonServerSettings.EnabledRegions: ", this.JDMCFBKJHDD);
			}
			this.DBOLLHHMKKN().SetFloat("_MaxBlurRadius", this.HBJJOCHGOPH);
			this.BLMPMOIDGMG().SetFloat("accuracy", this.BlendFX);
			this.OOMFJGPAOKL().SetFloat("CameraFilterPack/FX_ZebraColor", this.Adjust);
			this.OCMBHMLNCEK().SetFloat("Prints list of all previous commands", this.Precision);
			this.IKAIDLJKLFC().SetFloat("/icon", this.Luminosity);
			this.DBOLLHHMKKN().SetFloat("_NoiseTex", this.Change_Red);
			this.FAIFBBGFAIB().SetFloat("LoadingStatusText", this.Change_Green);
			this.HBLDMJCOAHA().SetFloat(" Owner called.", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CBCNOEIALHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001288 RID: 4744 RVA: 0x0007CD9B File Offset: 0x0007AF9B
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)109;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001289 RID: 4745 RVA: 0x0007CDD2 File Offset: 0x0007AFD2
	private void OLDNINDEIKO()
	{
		this.BMOFEBKGLFI();
		this.IAIGNDMHFFG();
	}

	// Token: 0x0600128A RID: 4746 RVA: 0x0007CDE0 File Offset: 0x0007AFE0
	private void ALJEJJCIMJN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -52);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600128B RID: 4747 RVA: 0x0007CE57 File Offset: 0x0007B057
	private void MEJPBKFMAIG()
	{
		this.IBJIBLHJKMG();
		this.DPIPGGDNGHN();
	}

	// Token: 0x0600128C RID: 4748 RVA: 0x0007CE68 File Offset: 0x0007B068
	private void GBGAMCPNBCC()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600128D RID: 4749 RVA: 0x0007CEC4 File Offset: 0x0007B0C4
	private void LIEGJOHINGC()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600128E RID: 4750 RVA: 0x0007CF20 File Offset: 0x0007B120
	private void JMAJIOHDKCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1069f)
			{
				this.HBJJOCHGOPH = 1476f;
			}
			if (this.Camera2 != null)
			{
				this.ADBKPGFMNKO().SetTexture("_TimeX", this.JDMCFBKJHDD);
			}
			this.EJDPNJAEAKJ().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.ECCPAOBFDKP().SetFloat("_Value3", this.BlendFX);
			this.DBOLLHHMKKN().SetFloat("_Axis", this.Adjust);
			this.DKNJGHFLAIF().SetFloat("OpCreateRoom()", this.Precision);
			this.ECCPAOBFDKP().SetFloat("}", this.Luminosity);
			this.OIBHFCLJKDB().SetFloat("mapselector.filter.subscribedonly", this.Change_Red);
			this.DONENAMLFLF().SetFloat("MusicFileSelector", this.Change_Green);
			this.HEHKGPKLAKK().SetFloat("_ScreenResolution", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DABHAJNHOAL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600128F RID: 4751 RVA: 0x0007D05B File Offset: 0x0007B25B
	private void AJBHOEBKGDO()
	{
		this.OHFOLGANOLC();
		this.FJNJIHCLODK();
	}

	// Token: 0x06001290 RID: 4752 RVA: 0x0007C8DF File Offset: 0x0007AADF
	private void Update()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06001291 RID: 4753 RVA: 0x0007D06C File Offset: 0x0007B26C
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1990f)
			{
				this.HBJJOCHGOPH = 826f;
			}
			if (this.Camera2 != null)
			{
				this.BLMPMOIDGMG().SetTexture("_ScreenResolution", this.JDMCFBKJHDD);
			}
			this.DABHAJNHOAL().SetFloat("_AdditiveReflection", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("offsets", this.BlendFX);
			this.IKAIDLJKLFC().SetFloat("{0:0} minute{1}, ", this.Adjust);
			this.HJGEHJDMCGI().SetFloat("_Value2", this.Precision);
			this.NBPKMLMCHFN.SetFloat("english", this.Luminosity);
			this.DKNJGHFLAIF().SetFloat("_Distortion", this.Change_Red);
			this.IIJMIPBMMBF().SetFloat(" Gb", this.Change_Green);
			this.MNLKBFFKHIE().SetFloat("player.redarc", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001292 RID: 4754 RVA: 0x0007D1A8 File Offset: 0x0007B3A8
	private void ODAIMOJLJOF()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001293 RID: 4755 RVA: 0x0007D204 File Offset: 0x0007B404
	private void FANADGBGCPI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -19);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001294 RID: 4756 RVA: 0x0007D27C File Offset: 0x0007B47C
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1520f)
			{
				this.HBJJOCHGOPH = 428f;
			}
			if (this.Camera2 != null)
			{
				this.PGPEMMBJOOG().SetTexture(": ", this.JDMCFBKJHDD);
			}
			this.MNLKBFFKHIE().SetFloat("ResourceFileSelector", this.HBJJOCHGOPH);
			this.MNLKBFFKHIE().SetFloat("_ScreenResolution", this.BlendFX);
			this.ECCPAOBFDKP().SetFloat("Missing shader in ", this.Adjust);
			this.ABHDNGIHBKE().SetFloat("_AdaptationMin", this.Precision);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.Luminosity);
			this.OIBHFCLJKDB().SetFloat("winter2020_official", this.Change_Red);
			this.KLKILLCHJHO().SetFloat("_Value", this.Change_Green);
			this.DKNJGHFLAIF().SetFloat(".lastCheckpoint.powerupsScore", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001295 RID: 4757 RVA: 0x0007D3B7 File Offset: 0x0007B5B7
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001296 RID: 4758 RVA: 0x0007D3F0 File Offset: 0x0007B5F0
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1497f)
			{
				this.HBJJOCHGOPH = 648f;
			}
			if (this.Camera2 != null)
			{
				this.DBOLLHHMKKN().SetTexture("1278033234", this.JDMCFBKJHDD);
			}
			this.OCMBHMLNCEK().SetFloat("note.5", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("Left Stick Click", this.BlendFX);
			this.EJDPNJAEAKJ().SetFloat("CameraFilterPack/AAA_WaterDrop", this.Adjust);
			this.DABHAJNHOAL().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", this.Precision);
			this.DIOAAHJDMLK().SetFloat("settings.volume.menu", this.Luminosity);
			this.JLHLHKPHDFO().SetFloat("_FixDistance", this.Change_Red);
			this.KLKILLCHJHO().SetFloat("_NeighbourMaxTex", this.Change_Green);
			this.DABHAJNHOAL().SetFloat("SingleplayerButton", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001297 RID: 4759 RVA: 0x0007D52B File Offset: 0x0007B72B
	private void BDMCPMKDBDG()
	{
		this.ODMPMJPALID();
		this.AIJGAJIOJDJ();
	}

	// Token: 0x06001298 RID: 4760 RVA: 0x0007D53C File Offset: 0x0007B73C
	private void OnDisable()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001299 RID: 4761 RVA: 0x0007D597 File Offset: 0x0007B797
	private void OCHMKJKBAPI()
	{
		this.KCCIEMBMOBA();
		this.FJNJIHCLODK();
	}

	// Token: 0x0600129A RID: 4762 RVA: 0x0007D5A5 File Offset: 0x0007B7A5
	private Material OCMBHMLNCEK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600129B RID: 4763 RVA: 0x0007D5DC File Offset: 0x0007B7DC
	private void OLAGABIMGDA()
	{
		this.DBEMDAJDDDA();
		this.Update();
	}

	// Token: 0x0600129C RID: 4764 RVA: 0x0007D5EC File Offset: 0x0007B7EC
	private void OPIBJIMIOKE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1316f)
			{
				this.HBJJOCHGOPH = 1990f;
			}
			if (this.Camera2 != null)
			{
				this.NBMPPNFKFLB().SetTexture("settings.enablehitsoundsinrelax", this.JDMCFBKJHDD);
			}
			this.BLMPMOIDGMG().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("challenges", this.BlendFX);
			this.OIBHFCLJKDB().SetFloat("achievements.id", this.Adjust);
			this.IIJMIPBMMBF().SetFloat("_DiffuseColor", this.Precision);
			this.DONENAMLFLF().SetFloat("/GetNews/pinnednewsid", this.Luminosity);
			this.HEHKGPKLAKK().SetFloat("_FarCamera", this.Change_Red);
			this.NBPKMLMCHFN.SetFloat("skin.", this.Change_Green);
			this.HJGEHJDMCGI().SetFloat("GlassesColor", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600129D RID: 4765 RVA: 0x0007C8DF File Offset: 0x0007AADF
	private void DGCGGKMNPLD()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x0600129E RID: 4766 RVA: 0x0007D727 File Offset: 0x0007B927
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600129F RID: 4767 RVA: 0x0007D760 File Offset: 0x0007B960
	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1876f)
			{
				this.HBJJOCHGOPH = 1543f;
			}
			if (this.Camera2 != null)
			{
				this.NBMPPNFKFLB().SetTexture("<b>", this.JDMCFBKJHDD);
			}
			this.FAIFBBGFAIB().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.OIBHFCLJKDB().SetFloat("[CraftingPanel] Init", this.BlendFX);
			this.DKNJGHFLAIF().SetFloat("CheckpointsScoreText", this.Adjust);
			this.CBCNOEIALHB().SetFloat("#tryagain", this.Precision);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.Luminosity);
			this.ADGHJOHKEHG().SetFloat("CameraFilterPack/Blend2Camera_HardLight", this.Change_Red);
			this.DKNJGHFLAIF().SetFloat("_Value2", this.Change_Green);
			this.PGPEMMBJOOG().SetFloat("\\", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060012A0 RID: 4768 RVA: 0x0007D89C File Offset: 0x0007BA9C
	private void DAHFFNNIGML()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 125);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060012A1 RID: 4769 RVA: 0x0007D913 File Offset: 0x0007BB13
	private void HJDPEBAPBPN()
	{
		this.KCCIEMBMOBA();
		this.MJNPIDGNJMK();
	}

	// Token: 0x060012A2 RID: 4770 RVA: 0x0007D924 File Offset: 0x0007BB24
	private void JEBIBKLHFLB()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060012A3 RID: 4771 RVA: 0x0007D97F File Offset: 0x0007BB7F
	private Material CBCNOEIALHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-81);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060012A4 RID: 4772 RVA: 0x0007D9B6 File Offset: 0x0007BBB6
	private Material HBLDMJCOAHA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-70);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060012A5 RID: 4773 RVA: 0x0007D9F0 File Offset: 0x0007BBF0
	private void FEHCNJLLJMP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 77);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060012A6 RID: 4774 RVA: 0x0007DA68 File Offset: 0x0007BC68
	private void GPHPJIDGEPI()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060012A7 RID: 4775 RVA: 0x0007DAC3 File Offset: 0x0007BCC3
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060012A8 RID: 4776 RVA: 0x0007C8DF File Offset: 0x0007AADF
	private void DPIPGGDNGHN()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x060012A9 RID: 4777 RVA: 0x0007DAFC File Offset: 0x0007BCFC
	private void EKCKJLFFAID()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060012AA RID: 4778 RVA: 0x0007DB58 File Offset: 0x0007BD58
	private void HLHJBJGEEEA()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060012AB RID: 4779 RVA: 0x0007C8DF File Offset: 0x0007AADF
	private void FJNJIHCLODK()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x060012AC RID: 4780 RVA: 0x0007C8DF File Offset: 0x0007AADF
	private void KKLMPKLKAEM()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x060012AD RID: 4781 RVA: 0x0007C8DF File Offset: 0x0007AADF
	private void JAAJECBCCFM()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x060012AE RID: 4782 RVA: 0x0007DBB3 File Offset: 0x0007BDB3
	private void LLAJPKFNDIG()
	{
		this.DAHFFNNIGML();
		this.MJNPIDGNJMK();
	}

	// Token: 0x060012AF RID: 4783 RVA: 0x0007DBC1 File Offset: 0x0007BDC1
	private void HHODKHPIBLG()
	{
		this.IHLMNAGPKDA();
		this.AIJGAJIOJDJ();
	}

	// Token: 0x060012B0 RID: 4784 RVA: 0x0007DBCF File Offset: 0x0007BDCF
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060012B2 RID: 4786 RVA: 0x0007DC30 File Offset: 0x0007BE30
	private void NHHCGPAMLAJ()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060012B3 RID: 4787 RVA: 0x0007DC8B File Offset: 0x0007BE8B
	private Material KLKILLCHJHO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060012B4 RID: 4788 RVA: 0x0007C8DF File Offset: 0x0007AADF
	private void OCMKCBBCEFG()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x060012B5 RID: 4789 RVA: 0x0007DCC4 File Offset: 0x0007BEC4
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1150f)
			{
				this.HBJJOCHGOPH = 584f;
			}
			if (this.Camera2 != null)
			{
				this.ECCPAOBFDKP().SetTexture("_Value", this.JDMCFBKJHDD);
			}
			this.HNFFHCLNBDN().SetFloat("PhotonView with ID {0} wasn't properly unregistered! Please report this case to developer@photonengine.com", this.HBJJOCHGOPH);
			this.HJGEHJDMCGI().SetFloat("[PlayerController] ", this.BlendFX);
			this.MNLKBFFKHIE().SetFloat("_SweaterSize", this.Adjust);
			this.OCMBHMLNCEK().SetFloat(".a", this.Precision);
			this.DIOAAHJDMLK().SetFloat("_Bullet_3", this.Luminosity);
			this.OCMBHMLNCEK().SetFloat("id", this.Change_Red);
			this.OOMFJGPAOKL().SetFloat("PossibleMapPointsText", this.Change_Green);
			this.IIJMIPBMMBF().SetFloat("_MainTex2", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060012B6 RID: 4790 RVA: 0x0007DE00 File Offset: 0x0007C000
	private void EFJDNLGNACH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -61);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060012B7 RID: 4791 RVA: 0x0007DE78 File Offset: 0x0007C078
	private void EODOHEAKJFO()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060012B8 RID: 4792 RVA: 0x0007DED3 File Offset: 0x0007C0D3
	private void OAKONCDEPPI()
	{
		this.JFJLGJEPEAA();
		this.PKHPNHBEKHA();
	}

	// Token: 0x060012B9 RID: 4793 RVA: 0x0007DEE1 File Offset: 0x0007C0E1
	private void LGELACBDPEH()
	{
		this.Start();
		this.EPJJDKJEDMM();
	}

	// Token: 0x1700002B RID: 43
	// (get) Token: 0x060012BA RID: 4794 RVA: 0x0007DEEF File Offset: 0x0007C0EF
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

	// Token: 0x060012BB RID: 4795 RVA: 0x0007DF26 File Offset: 0x0007C126
	private void DIOLLANDDKJ()
	{
		this.PCHCFIOHIKK();
		this.AIJGAJIOJDJ();
	}

	// Token: 0x060012BC RID: 4796 RVA: 0x0007DF34 File Offset: 0x0007C134
	private void CAKNMILHHNE()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060012BD RID: 4797 RVA: 0x0007DF8F File Offset: 0x0007C18F
	private void LICOLMAOHKI()
	{
		this.NDBPCNICGLC();
		this.LCDJFJIBADI();
	}

	// Token: 0x060012BE RID: 4798 RVA: 0x0007DF9D File Offset: 0x0007C19D
	private Material MNLKBFFKHIE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060012BF RID: 4799 RVA: 0x0007C8DF File Offset: 0x0007AADF
	private void AIJGAJIOJDJ()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x060012C0 RID: 4800 RVA: 0x0007DFD4 File Offset: 0x0007C1D4
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1178f)
			{
				this.HBJJOCHGOPH = 1325f;
			}
			if (this.Camera2 != null)
			{
				this.ABHDNGIHBKE().SetTexture("_Value4", this.JDMCFBKJHDD);
			}
			this.ECCPAOBFDKP().SetFloat(" ", this.HBJJOCHGOPH);
			this.OOMFJGPAOKL().SetFloat("Currently, the limit of users is reached for this title. Try again later. Disconnecting", this.BlendFX);
			this.EJDPNJAEAKJ().SetFloat("custom", this.Adjust);
			this.FAIFBBGFAIB().SetFloat("UpdateNewsTileStart", this.Precision);
			this.DONENAMLFLF().SetFloat("Init", this.Luminosity);
			this.ECCPAOBFDKP().SetFloat("/", this.Change_Red);
			this.NBPKMLMCHFN.SetFloat("_FilteredReflections", this.Change_Green);
			this.CBCNOEIALHB().SetFloat("_Value3", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060012C1 RID: 4801 RVA: 0x0007E110 File Offset: 0x0007C310
	private void FPHLDMMAOEF()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060012C2 RID: 4802 RVA: 0x0007E16C File Offset: 0x0007C36C
	private void CMIBEOJGAIL()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060012C3 RID: 4803 RVA: 0x0007E1C8 File Offset: 0x0007C3C8
	private void IENKPJEBMFM()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060012C4 RID: 4804 RVA: 0x0007E224 File Offset: 0x0007C424
	private void JNALDALAJLG()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060012C5 RID: 4805 RVA: 0x0007E280 File Offset: 0x0007C480
	private void JFJLGJEPEAA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -123);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060012C6 RID: 4806 RVA: 0x0007E2F7 File Offset: 0x0007C4F7
	private void AONJNAGNLIH()
	{
		this.ADPLHDFJFID();
		this.PKHPNHBEKHA();
	}

	// Token: 0x060012C7 RID: 4807 RVA: 0x0007E308 File Offset: 0x0007C508
	private void FEKECCBFGMI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 26);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060012C8 RID: 4808 RVA: 0x0007E37F File Offset: 0x0007C57F
	private void CFMJMJOHJII()
	{
		this.DBEMDAJDDDA();
		this.MJNPIDGNJMK();
	}

	// Token: 0x060012C9 RID: 4809 RVA: 0x0007E38D File Offset: 0x0007C58D
	private void GBFPAEDPOPP()
	{
		this.FEHCNJLLJMP();
		this.LCDJFJIBADI();
	}

	// Token: 0x060012CA RID: 4810 RVA: 0x0007E39B File Offset: 0x0007C59B
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060012CB RID: 4811 RVA: 0x0007E3D4 File Offset: 0x0007C5D4
	private void BMOFEBKGLFI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -45);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060012CC RID: 4812 RVA: 0x0007E44C File Offset: 0x0007C64C
	private void IHHNCCOGLPN()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060012CD RID: 4813 RVA: 0x0007E4A8 File Offset: 0x0007C6A8
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1573f)
			{
				this.HBJJOCHGOPH = 1416f;
			}
			if (this.Camera2 != null)
			{
				this.HEHKGPKLAKK().SetTexture("player.goldabstract", this.JDMCFBKJHDD);
			}
			this.DKNJGHFLAIF().SetFloat("CameraFilterPack/Distortion_Half_Sphere", this.HBJJOCHGOPH);
			this.BLMPMOIDGMG().SetFloat("_TimeX", this.BlendFX);
			this.HNFFHCLNBDN().SetFloat("shader.future", this.Adjust);
			this.FAIFBBGFAIB().SetFloat("_Value3", this.Precision);
			this.HHIAIGCAHDA().SetFloat("menu.relaxinfo", this.Luminosity);
			this.HHIAIGCAHDA().SetFloat("_DistortionSize", this.Change_Red);
			this.ADBKPGFMNKO().SetFloat("_Blur", this.Change_Green);
			this.HEHKGPKLAKK().SetFloat("maxScore", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060012CE RID: 4814 RVA: 0x0007C8DF File Offset: 0x0007AADF
	private void PKGJJFIFLII()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x060012CF RID: 4815 RVA: 0x0007E5E3 File Offset: 0x0007C7E3
	private Material OOMFJGPAOKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060012D0 RID: 4816 RVA: 0x0007C8DF File Offset: 0x0007AADF
	private void MBLDJEFBLFL()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x060012D1 RID: 4817 RVA: 0x0007E61C File Offset: 0x0007C81C
	private void JONGNKNLLND()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -14);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060012D2 RID: 4818 RVA: 0x0007C8DF File Offset: 0x0007AADF
	private void MJNPIDGNJMK()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x060012D3 RID: 4819 RVA: 0x0007E694 File Offset: 0x0007C894
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
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Adjust);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Precision);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Luminosity);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Change_Red);
			this.NBPKMLMCHFN.SetFloat("_Value6", this.Change_Green);
			this.NBPKMLMCHFN.SetFloat("_Value7", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060012D4 RID: 4820 RVA: 0x0007E7D0 File Offset: 0x0007C9D0
	private void ELDMKIAPNGP()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060012D5 RID: 4821 RVA: 0x0007E82B File Offset: 0x0007CA2B
	private Material OIBHFCLJKDB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060012D6 RID: 4822 RVA: 0x0007E862 File Offset: 0x0007CA62
	private void OnEnable()
	{
		this.Start();
		this.Update();
	}

	// Token: 0x060012D7 RID: 4823 RVA: 0x0007E870 File Offset: 0x0007CA70
	private void NCNPAKFAFOE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 116);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060012D8 RID: 4824 RVA: 0x0007E8E8 File Offset: 0x0007CAE8
	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 924f)
			{
				this.HBJJOCHGOPH = 387f;
			}
			if (this.Camera2 != null)
			{
				this.ADGHJOHKEHG().SetTexture("_MainTexBlurred", this.JDMCFBKJHDD);
			}
			this.OOMFJGPAOKL().SetFloat("_Distortion", this.HBJJOCHGOPH);
			this.HJGEHJDMCGI().SetFloat("_Amount", this.BlendFX);
			this.IIJMIPBMMBF().SetFloat("...", this.Adjust);
			this.ADBKPGFMNKO().SetFloat("?", this.Precision);
			this.OOMFJGPAOKL().SetFloat("CameraFilterPack/FX_Screens", this.Luminosity);
			this.HEHKGPKLAKK().SetFloat("original.tutorial", this.Change_Red);
			this.DONENAMLFLF().SetFloat("InfoButton", this.Change_Green);
			this.BLMPMOIDGMG().SetFloat("BitsData", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060012D9 RID: 4825 RVA: 0x0007EA24 File Offset: 0x0007CC24
	private void NJHJHBOJKIC()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060012DA RID: 4826 RVA: 0x0007EA80 File Offset: 0x0007CC80
	private void MGFFNGEGFDC()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060012DB RID: 4827 RVA: 0x0007EADB File Offset: 0x0007CCDB
	private void PAHNKEGFGHB()
	{
		this.JONGNKNLLND();
		this.PFNFPINPCMH();
	}

	// Token: 0x060012DC RID: 4828 RVA: 0x0007C8DF File Offset: 0x0007AADF
	private void LCHBFNIPBHB()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x060012DD RID: 4829 RVA: 0x0007EAEC File Offset: 0x0007CCEC
	private void CNDACAHCCOI()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060012DE RID: 4830 RVA: 0x0007EB47 File Offset: 0x0007CD47
	private void LIFBFDKFMMH()
	{
		this.BMOFEBKGLFI();
		this.DPIPGGDNGHN();
	}

	// Token: 0x060012DF RID: 4831 RVA: 0x0007EB58 File Offset: 0x0007CD58
	private void MDNHCLKNCLE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 97);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060012E0 RID: 4832 RVA: 0x0007EBD0 File Offset: 0x0007CDD0
	private void PCHCFIOHIKK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 84);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060012E1 RID: 4833 RVA: 0x0007EC48 File Offset: 0x0007CE48
	private void KLDNGKBMDAN()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060012E2 RID: 4834 RVA: 0x0007ECA3 File Offset: 0x0007CEA3
	private void NGEGCLCPPCD()
	{
		this.BMOFEBKGLFI();
		this.PFNFPINPCMH();
	}

	// Token: 0x060012E3 RID: 4835 RVA: 0x0007ECB1 File Offset: 0x0007CEB1
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060012E4 RID: 4836 RVA: 0x0007ECE8 File Offset: 0x0007CEE8
	private Material MJJIEHANFJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060012E5 RID: 4837 RVA: 0x0007ED20 File Offset: 0x0007CF20
	private void NPLCENPNJBM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -124);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060012E6 RID: 4838 RVA: 0x0007ED97 File Offset: 0x0007CF97
	private Material HJGEHJDMCGI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060012E7 RID: 4839 RVA: 0x0007EDCE File Offset: 0x0007CFCE
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060012E8 RID: 4840 RVA: 0x0007EE05 File Offset: 0x0007D005
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-122);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060012E9 RID: 4841 RVA: 0x0007EE3C File Offset: 0x0007D03C
	private void MLEAHDDGEMJ()
	{
		this.JFJLGJEPEAA();
		this.PKGJJFIFLII();
	}

	// Token: 0x060012EA RID: 4842 RVA: 0x0007EE4A File Offset: 0x0007D04A
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060012EB RID: 4843 RVA: 0x0007EE84 File Offset: 0x0007D084
	private void FDPOFMCFBMF()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060012EC RID: 4844 RVA: 0x0007EEDF File Offset: 0x0007D0DF
	private Material DIOAAHJDMLK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060012ED RID: 4845 RVA: 0x0007EF18 File Offset: 0x0007D118
	private void NDBPCNICGLC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 88);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060012EE RID: 4846 RVA: 0x0007EF90 File Offset: 0x0007D190
	private void OHFOLGANOLC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -89);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060012EF RID: 4847 RVA: 0x0007F008 File Offset: 0x0007D208
	private void HDMDKOKOOJC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 46);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060012F0 RID: 4848 RVA: 0x0007F07F File Offset: 0x0007D27F
	private Material DABHAJNHOAL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060012F1 RID: 4849 RVA: 0x0007F0B6 File Offset: 0x0007D2B6
	private Material IKAIDLJKLFC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060012F2 RID: 4850 RVA: 0x0007F0F0 File Offset: 0x0007D2F0
	private void ADPLHDFJFID()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -1);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060012F3 RID: 4851 RVA: 0x0007F167 File Offset: 0x0007D367
	private Material ECCPAOBFDKP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060012F4 RID: 4852 RVA: 0x0007F19E File Offset: 0x0007D39E
	private void IBFHEDHJDLH()
	{
		this.KCCIEMBMOBA();
		this.PKGJJFIFLII();
	}

	// Token: 0x060012F5 RID: 4853 RVA: 0x0007F1AC File Offset: 0x0007D3AC
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060012F6 RID: 4854 RVA: 0x0007F1E4 File Offset: 0x0007D3E4
	private void KLILJHJNICK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 81);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060012F7 RID: 4855 RVA: 0x0007F25C File Offset: 0x0007D45C
	private void NLDKIPEMILC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 50);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060012F8 RID: 4856 RVA: 0x0007F2D3 File Offset: 0x0007D4D3
	private void LHGFCBDACBM()
	{
		this.IHLMNAGPKDA();
		this.LCDJFJIBADI();
	}

	// Token: 0x060012F9 RID: 4857 RVA: 0x0007C952 File Offset: 0x0007AB52
	private void ELHFAMLBLHM()
	{
		this.DAHFFNNIGML();
		this.JAAJECBCCFM();
	}

	// Token: 0x060012FA RID: 4858 RVA: 0x0007F2E1 File Offset: 0x0007D4E1
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060012FB RID: 4859 RVA: 0x0007C8DF File Offset: 0x0007AADF
	private void PFNFPINPCMH()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x060012FC RID: 4860 RVA: 0x0007F318 File Offset: 0x0007D518
	private void LADCJEIALMH()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060012FD RID: 4861 RVA: 0x0007F373 File Offset: 0x0007D573
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-123);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060012FE RID: 4862 RVA: 0x0007F3AC File Offset: 0x0007D5AC
	private void NMAOGOMAING()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -28);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060012FF RID: 4863 RVA: 0x0007F423 File Offset: 0x0007D623
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001300 RID: 4864 RVA: 0x0007C8DF File Offset: 0x0007AADF
	private void IAIGNDMHFFG()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x06001301 RID: 4865 RVA: 0x0007F45C File Offset: 0x0007D65C
	private void KODKKCOKEPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1443f)
			{
				this.HBJJOCHGOPH = 788f;
			}
			if (this.Camera2 != null)
			{
				this.HHIAIGCAHDA().SetTexture("MainButton", this.JDMCFBKJHDD);
			}
			this.ADBKPGFMNKO().SetFloat("settings.fps", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("menu.selectedplaymode", this.BlendFX);
			this.EJDPNJAEAKJ().SetFloat("[PlayerBase] ShowImage \"", this.Adjust);
			this.JLHLHKPHDFO().SetFloat("RoomDescriptionText", this.Precision);
			this.OCMBHMLNCEK().SetFloat("player.goldwatermelon", this.Luminosity);
			this.OOMFJGPAOKL().SetFloat("ChallengesButton", this.Change_Red);
			this.NBMPPNFKFLB().SetFloat("_NoiseTex", this.Change_Green);
			this.NBPKMLMCHFN.SetFloat("settings_bindings_", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001302 RID: 4866 RVA: 0x0007F598 File Offset: 0x0007D798
	private void IBJIBLHJKMG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -6);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001303 RID: 4867 RVA: 0x0007F610 File Offset: 0x0007D810
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 877f)
			{
				this.HBJJOCHGOPH = 597f;
			}
			if (this.Camera2 != null)
			{
				this.HNFFHCLNBDN().SetTexture("EnableRankedNotificationsToggle", this.JDMCFBKJHDD);
			}
			this.ADGHJOHKEHG().SetFloat("_Distortion", this.HBJJOCHGOPH);
			this.IKAIDLJKLFC().SetFloat("Player Disconnected", this.BlendFX);
			this.HBLDMJCOAHA().SetFloat("_ScreenResolution", this.Adjust);
			this.EJDPNJAEAKJ().SetFloat("EnableRankingToggle", this.Precision);
			this.MNLKBFFKHIE().SetFloat("_Radius", this.Luminosity);
			this.HNFFHCLNBDN().SetFloat(" now: ", this.Change_Red);
			this.OKJOKHGJHGF().SetFloat("_TimeX", this.Change_Green);
			this.ADBKPGFMNKO().SetFloat("GlassDistortion", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001304 RID: 4868 RVA: 0x0007F74C File Offset: 0x0007D94C
	private void JAFOCEDILNK()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001305 RID: 4869 RVA: 0x0007F7A8 File Offset: 0x0007D9A8
	private void HGDDCINLDAD()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001306 RID: 4870 RVA: 0x0007F804 File Offset: 0x0007DA04
	private void KMOCDAOKGLI()
	{
		if (this.Camera2 != null && this.Camera2.targetTexture != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001307 RID: 4871 RVA: 0x0007F860 File Offset: 0x0007DA60
	private void KCCIEMBMOBA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 21);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001308 RID: 4872 RVA: 0x0007F8D8 File Offset: 0x0007DAD8
	private void Start()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001309 RID: 4873 RVA: 0x0007F950 File Offset: 0x0007DB50
	private void FIKNBPAIFBI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 428f)
			{
				this.HBJJOCHGOPH = 701f;
			}
			if (this.Camera2 != null)
			{
				this.DBOLLHHMKKN().SetTexture("skin.", this.JDMCFBKJHDD);
			}
			this.IIJMIPBMMBF().SetFloat(">", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("#ok", this.BlendFX);
			this.ABHDNGIHBKE().SetFloat("_Value", this.Adjust);
			this.OOMFJGPAOKL().SetFloat("<command>", this.Precision);
			this.PGPEMMBJOOG().SetFloat("_LightIntensity", this.Luminosity);
			this.HEHKGPKLAKK().SetFloat("UseFinalGlassColor", this.Change_Red);
			this.DONENAMLFLF().SetFloat("SpawnObj", this.Change_Green);
			this.DIOAAHJDMLK().SetFloat("[", this.Change_Blue);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600130A RID: 4874 RVA: 0x0007C8DF File Offset: 0x0007AADF
	private void PKHPNHBEKHA()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
		if (Application.isPlaying)
		{
		}
	}

	// Token: 0x0600130B RID: 4875 RVA: 0x0007FA8C File Offset: 0x0007DC8C
	private void ODMPMJPALID()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -79);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600130C RID: 4876 RVA: 0x0007FB04 File Offset: 0x0007DD04
	private void IHLMNAGPKDA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 93);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x040002A4 RID: 676
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_GreenScreen";

	// Token: 0x040002A5 RID: 677
	public Shader SCShader;

	// Token: 0x040002A6 RID: 678
	public Camera Camera2;

	// Token: 0x040002A7 RID: 679
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040002A8 RID: 680
	private Material BJFKDHHMLJH;

	// Token: 0x040002A9 RID: 681
	[Range(0f, 1f)]
	public float BlendFX = 1f;

	// Token: 0x040002AA RID: 682
	[Range(-0.2f, 0.2f)]
	public float Adjust;

	// Token: 0x040002AB RID: 683
	[Range(-0.2f, 0.2f)]
	public float Precision;

	// Token: 0x040002AC RID: 684
	[Range(-0.2f, 0.2f)]
	public float Luminosity;

	// Token: 0x040002AD RID: 685
	[Range(-0.3f, 0.3f)]
	public float Change_Red;

	// Token: 0x040002AE RID: 686
	[Range(-0.3f, 0.3f)]
	public float Change_Green;

	// Token: 0x040002AF RID: 687
	[Range(-0.3f, 0.3f)]
	public float Change_Blue;

	// Token: 0x040002B0 RID: 688
	private RenderTexture JDMCFBKJHDD;

	// Token: 0x040002B1 RID: 689
	private Vector2 FPEMMGKMJGA;
}
