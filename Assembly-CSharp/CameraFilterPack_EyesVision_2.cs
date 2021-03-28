using System;
using UnityEngine;

// Token: 0x020000B9 RID: 185
[AddComponentMenu("Camera Filter Pack/Vision/Eyes 2")]
[ExecuteInEditMode]
public class CameraFilterPack_EyesVision_2 : MonoBehaviour
{
	// Token: 0x06003837 RID: 14391 RVA: 0x0011E0E3 File Offset: 0x0011C2E3
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003838 RID: 14392 RVA: 0x0011E11C File Offset: 0x0011C31C
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1741f)
			{
				this.HBJJOCHGOPH = 216f;
			}
			this.EJDPNJAEAKJ().SetFloat("_ColorRGB", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("CameraFilterPack_Glasses_On6", this._EyeWave);
			this.FEAEGGCNIAA().SetFloat("IconImage", this._EyeSpeed);
			this.FEAEGGCNIAA().SetFloat("PopulateMapsList", this._EyeMove);
			this.DOHGBNPMBKG().SetFloat("_ScreenResolution", this._EyeBlink);
			this.ABHDNGIHBKE().SetTexture("CameraFilterPack/Blend2Camera_Saturation", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003839 RID: 14393 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x0600383A RID: 14394 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x0600383B RID: 14395 RVA: 0x0011E204 File Offset: 0x0011C404
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600383C RID: 14396 RVA: 0x0011E204 File Offset: 0x0011C404
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600383D RID: 14397 RVA: 0x0011E221 File Offset: 0x0011C421
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600383E RID: 14398 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x0600383F RID: 14399 RVA: 0x0011E258 File Offset: 0x0011C458
	private void FHGKIOOMMOH()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/3D_Binary");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003840 RID: 14400 RVA: 0x0011E291 File Offset: 0x0011C491
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003841 RID: 14401 RVA: 0x0011E2C8 File Offset: 0x0011C4C8
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 643f)
			{
				this.HBJJOCHGOPH = 1787f;
			}
			this.MMOODGIODPC().SetFloat("default", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this._EyeWave);
			this.NBPKMLMCHFN.SetFloat("resource id", this._EyeSpeed);
			this.EJDPNJAEAKJ().SetFloat("_Value4", this._EyeMove);
			this.HKHBBBFLGJH().SetFloat("maps.", this._EyeBlink);
			this.LNLKMDPHDCC().SetTexture("Crosshair1", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003842 RID: 14402 RVA: 0x0011E204 File Offset: 0x0011C404
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003843 RID: 14403 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x06003844 RID: 14404 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06003845 RID: 14405 RVA: 0x0011E3B0 File Offset: 0x0011C5B0
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 858f)
			{
				this.HBJJOCHGOPH = 971f;
			}
			this.JLHLHKPHDFO().SetFloat("HighScaleShot", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("_Offsets", this._EyeWave);
			this.IFMAPIDFNLI().SetFloat(".ogg", this._EyeSpeed);
			this.FEAEGGCNIAA().SetFloat("offline", this._EyeMove);
			this.HNICHJCGJOC().SetFloat("InfoButton", this._EyeBlink);
			this.ABHDNGIHBKE().SetTexture("workshop.", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003846 RID: 14406 RVA: 0x0011E498 File Offset: 0x0011C698
	private void OKLAJINHPAN()
	{
		this.FPHEBLMINDA = (Resources.Load("EnvironmentSlider") as Texture2D);
		this.SCShader = Shader.Find("_Contrast");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003847 RID: 14407 RVA: 0x0011E4D1 File Offset: 0x0011C6D1
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003848 RID: 14408 RVA: 0x0011E508 File Offset: 0x0011C708
	private void PDHKMDBNGGN()
	{
		this.FPHEBLMINDA = (Resources.Load("_Offsets") as Texture2D);
		this.SCShader = Shader.Find("Gameplay/satellite");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003849 RID: 14409 RVA: 0x0011E204 File Offset: 0x0011C404
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600384A RID: 14410 RVA: 0x0011E541 File Offset: 0x0011C741
	private void CCLNNLCOPBL()
	{
		this.FPHEBLMINDA = (Resources.Load("_Blue_R") as Texture2D);
		this.SCShader = Shader.Find("_Far");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600384B RID: 14411 RVA: 0x0011E204 File Offset: 0x0011C404
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600384C RID: 14412 RVA: 0x0011E57A File Offset: 0x0011C77A
	private void JKFDDNMPOJH()
	{
		this.FPHEBLMINDA = (Resources.Load("IntraTime") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/Blur_DitherOffset");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600384D RID: 14413 RVA: 0x0011E204 File Offset: 0x0011C404
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600384E RID: 14414 RVA: 0x0011E5B4 File Offset: 0x0011C7B4
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 239f)
			{
				this.HBJJOCHGOPH = 1653f;
			}
			this.LONNIJMNKFB().SetFloat("It seems some instantiation is not completed, as instantiation data is used. You should make sure instantiations are paused when calling this method. Cleaning now, despite this.", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value3", this._EyeWave);
			this.FEAEGGCNIAA().SetFloat("z", this._EyeSpeed);
			this.DOHGBNPMBKG().SetFloat(" Kb", this._EyeMove);
			this.OKJOKHGJHGF().SetFloat(". Sent by actorNr: ", this._EyeBlink);
			this.OKJOKHGJHGF().SetTexture("Set Crosshair Color", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600384F RID: 14415 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06003850 RID: 14416 RVA: 0x0011E69C File Offset: 0x0011C89C
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1474f)
			{
				this.HBJJOCHGOPH = 12f;
			}
			this.DOHGBNPMBKG().SetFloat("_MainTex", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("_AxialAberration", this._EyeWave);
			this.EJDPNJAEAKJ().SetFloat("_Near", this._EyeSpeed);
			this.GKILCDHJFEG().SetFloat("maps.", this._EyeMove);
			this.HNICHJCGJOC().SetFloat("_Green_B", this._EyeBlink);
			this.GKILCDHJFEG().SetTexture(".completed", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003851 RID: 14417 RVA: 0x0011E204 File Offset: 0x0011C404
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003852 RID: 14418 RVA: 0x0011E204 File Offset: 0x0011C404
	private void AMHEJBMLFNM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003853 RID: 14419 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06003854 RID: 14420 RVA: 0x0011E784 File Offset: 0x0011C984
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)79;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003855 RID: 14421 RVA: 0x0011E7BC File Offset: 0x0011C9BC
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 306f)
			{
				this.HBJJOCHGOPH = 616f;
			}
			this.JLHLHKPHDFO().SetFloat("_Lift", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("HiddenToggle", this._EyeWave);
			this.OKJOKHGJHGF().SetFloat("AllocateViewID() failed. User {0} is out of subIds, as all viewIDs are used.", this._EyeSpeed);
			this.NBPKMLMCHFN.SetFloat("Can't set MaxPlayers when not in that room.", this._EyeMove);
			this.OCHJIMJNEMO().SetFloat("SetScale", this._EyeBlink);
			this.IFMAPIDFNLI().SetTexture("_EmissionGain", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKHBBBFLGJH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003856 RID: 14422 RVA: 0x0011E204 File Offset: 0x0011C404
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003857 RID: 14423 RVA: 0x0011E8A4 File Offset: 0x0011CAA4
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1747f)
			{
				this.HBJJOCHGOPH = 1904f;
			}
			this.HKHBBBFLGJH().SetFloat("UI Extensions/UIMultiply", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("Right Click", this._EyeWave);
			this.FEAEGGCNIAA().SetFloat("[PlayerController] ", this._EyeSpeed);
			this.DOHGBNPMBKG().SetFloat("Up ", this._EyeMove);
			this.OKJOKHGJHGF().SetFloat("Playing ", this._EyeBlink);
			this.ABHDNGIHBKE().SetTexture("_Value3", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003858 RID: 14424 RVA: 0x0011E204 File Offset: 0x0011C404
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003859 RID: 14425 RVA: 0x0011E98C File Offset: 0x0011CB8C
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1691f)
			{
				this.HBJJOCHGOPH = 975f;
			}
			this.FEAEGGCNIAA().SetFloat("ERROR: preview file name is empty in modName.workshop.json", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("_BaseTex", this._EyeWave);
			this.DOHGBNPMBKG().SetFloat("[MapsStats] Max score: ", this._EyeSpeed);
			this.FEAEGGCNIAA().SetFloat("_Value4", this._EyeMove);
			this.GKILCDHJFEG().SetFloat("_ScreenResolution", this._EyeBlink);
			this.JLHLHKPHDFO().SetTexture("Joystick1Button4", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600385A RID: 14426 RVA: 0x0011EA74 File Offset: 0x0011CC74
	private void EPEGAEGDJAM()
	{
		this.FPHEBLMINDA = (Resources.Load("list") as Texture2D);
		this.SCShader = Shader.Find("Reset 21 achievement progress");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600385B RID: 14427 RVA: 0x0011EAAD File Offset: 0x0011CCAD
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600385C RID: 14428 RVA: 0x0011E204 File Offset: 0x0011C404
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600385D RID: 14429 RVA: 0x0011EAE4 File Offset: 0x0011CCE4
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600385E RID: 14430 RVA: 0x0011E204 File Offset: 0x0011C404
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600385F RID: 14431 RVA: 0x0011EB1C File Offset: 0x0011CD1C
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1030f)
			{
				this.HBJJOCHGOPH = 1364f;
			}
			this.ACHNOHCLGOO().SetFloat(": ", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("_BlurParams", this._EyeWave);
			this.DOHGBNPMBKG().SetFloat("File not found: {0}", this._EyeSpeed);
			this.ACHNOHCLGOO().SetFloat("_SecondTex", this._EyeMove);
			this.LNLKMDPHDCC().SetFloat("[MapEditor] Loaded music file: ", this._EyeBlink);
			this.OKJOKHGJHGF().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003860 RID: 14432 RVA: 0x0011E204 File Offset: 0x0011C404
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003861 RID: 14433 RVA: 0x0011EC04 File Offset: 0x0011CE04
	private void Start()
	{
		this.FPHEBLMINDA = (Resources.Load("CameraFilterPack_eyes_vision_2") as Texture2D);
		this.SCShader = Shader.Find("CameraFilterPack/EyesVision_2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003862 RID: 14434 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003863 RID: 14435 RVA: 0x0011EC3D File Offset: 0x0011CE3D
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003864 RID: 14436 RVA: 0x0011E204 File Offset: 0x0011C404
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003865 RID: 14437 RVA: 0x0011E204 File Offset: 0x0011C404
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003866 RID: 14438 RVA: 0x0011EC74 File Offset: 0x0011CE74
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003867 RID: 14439 RVA: 0x0011ECAB File Offset: 0x0011CEAB
	private void ODBNMPGBCGO()
	{
		this.FPHEBLMINDA = (Resources.Load("#random #epic #item") as Texture2D);
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003868 RID: 14440 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x06003869 RID: 14441 RVA: 0x0011E204 File Offset: 0x0011C404
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600386A RID: 14442 RVA: 0x0011E204 File Offset: 0x0011C404
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600386B RID: 14443 RVA: 0x0011ECE4 File Offset: 0x0011CEE4
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1618f)
			{
				this.HBJJOCHGOPH = 1291f;
			}
			this.ABHDNGIHBKE().SetFloat("\n", this.HBJJOCHGOPH);
			this.IFMAPIDFNLI().SetFloat("StartTime already set: ", this._EyeWave);
			this.ABHDNGIHBKE().SetFloat("_TimeX", this._EyeSpeed);
			this.ABHDNGIHBKE().SetFloat(" Server: ", this._EyeMove);
			this.MMOODGIODPC().SetFloat("_Value2", this._EyeBlink);
			this.IFMAPIDFNLI().SetTexture("Right Stick Click", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600386C RID: 14444 RVA: 0x0011EDCC File Offset: 0x0011CFCC
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600386D RID: 14445 RVA: 0x0011EE03 File Offset: 0x0011D003
	private void KDMKDEKCELE()
	{
		this.FPHEBLMINDA = (Resources.Load("Loading inventory") as Texture2D);
		this.SCShader = Shader.Find("[NetworkManager] Updating rooms...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600386E RID: 14446 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x0600386F RID: 14447 RVA: 0x0011EE3C File Offset: 0x0011D03C
	private void BMIOFJFMCBG()
	{
		this.FPHEBLMINDA = (Resources.Load("_TimeX") as Texture2D);
		this.SCShader = Shader.Find("EndlessLoopsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003870 RID: 14448 RVA: 0x0011E204 File Offset: 0x0011C404
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003871 RID: 14449 RVA: 0x0011E204 File Offset: 0x0011C404
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003872 RID: 14450 RVA: 0x0011EE75 File Offset: 0x0011D075
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003873 RID: 14451 RVA: 0x0011EEAC File Offset: 0x0011D0AC
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003874 RID: 14452 RVA: 0x0011EEE3 File Offset: 0x0011D0E3
	private void DIPDEHOOBPG()
	{
		this.FPHEBLMINDA = (Resources.Load("[PlayerController] ") as Texture2D);
		this.SCShader = Shader.Find("open");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003875 RID: 14453 RVA: 0x0011EF1C File Offset: 0x0011D11C
	private void DBEMDAJDDDA()
	{
		this.FPHEBLMINDA = (Resources.Load("green") as Texture2D);
		this.SCShader = Shader.Find("player.blackcat");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003876 RID: 14454 RVA: 0x0011EF55 File Offset: 0x0011D155
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003877 RID: 14455 RVA: 0x0011E204 File Offset: 0x0011C404
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003878 RID: 14456 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06003879 RID: 14457 RVA: 0x0011EF8C File Offset: 0x0011D18C
	private void BMOFEBKGLFI()
	{
		this.FPHEBLMINDA = (Resources.Load("_HrDepthTex") as Texture2D);
		this.SCShader = Shader.Find("DPADVER");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600387A RID: 14458 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x0600387B RID: 14459 RVA: 0x0011E204 File Offset: 0x0011C404
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600387C RID: 14460 RVA: 0x0011EFC5 File Offset: 0x0011D1C5
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600387D RID: 14461 RVA: 0x0011EFFC File Offset: 0x0011D1FC
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1499f)
			{
				this.HBJJOCHGOPH = 1093f;
			}
			this.HFBJAOFLCJI().SetFloat("player.rgb", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("Case-Sensitive", this._EyeWave);
			this.DOHGBNPMBKG().SetFloat("float,1", this._EyeSpeed);
			this.ACHNOHCLGOO().SetFloat("_ScreenResolution", this._EyeMove);
			this.MMOODGIODPC().SetFloat("_VignettingColor", this._EyeBlink);
			this.MMOODGIODPC().SetTexture("_TimeX", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600387E RID: 14462 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x0600387F RID: 14463 RVA: 0x0011F0E4 File Offset: 0x0011D2E4
	private void JDKHBGDEONK()
	{
		this.FPHEBLMINDA = (Resources.Load("<b>Kick player by NetID</b>\nuse: /kick {NetID}\nUse \"/players\" command to get all NetIDs\nRoom owner only can kick the players") as Texture2D);
		this.SCShader = Shader.Find(". Sent by actorNr: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003880 RID: 14464 RVA: 0x0011F120 File Offset: 0x0011D320
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
			this.NBPKMLMCHFN.SetFloat("_Value", this._EyeWave);
			this.NBPKMLMCHFN.SetFloat("_Value2", this._EyeSpeed);
			this.NBPKMLMCHFN.SetFloat("_Value3", this._EyeMove);
			this.NBPKMLMCHFN.SetFloat("_Value4", this._EyeBlink);
			this.NBPKMLMCHFN.SetTexture("_MainTex2", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003881 RID: 14465 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06003882 RID: 14466 RVA: 0x0011E204 File Offset: 0x0011C404
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x1700009F RID: 159
	// (get) Token: 0x06003883 RID: 14467 RVA: 0x0011F208 File Offset: 0x0011D408
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

	// Token: 0x06003884 RID: 14468 RVA: 0x0011F240 File Offset: 0x0011D440
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 384f)
			{
				this.HBJJOCHGOPH = 404f;
			}
			this.HKHBBBFLGJH().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.IFMAPIDFNLI().SetFloat("Connection error: ", this._EyeWave);
			this.IIBLJCKLGFG().SetFloat("hand", this._EyeSpeed);
			this.JLHLHKPHDFO().SetFloat("UI Extensions/UILinearDodge", this._EyeMove);
			this.OCHJIMJNEMO().SetFloat("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results", this._EyeBlink);
			this.NBPKMLMCHFN.SetTexture("_WaveIntensity", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003885 RID: 14469 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06003886 RID: 14470 RVA: 0x0011F328 File Offset: 0x0011D528
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003887 RID: 14471 RVA: 0x0011F35F File Offset: 0x0011D55F
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003888 RID: 14472 RVA: 0x0011F396 File Offset: 0x0011D596
	private void GPNAOAKCMHC()
	{
		this.FPHEBLMINDA = (Resources.Load("skin.hit_perfect") as Texture2D);
		this.SCShader = Shader.Find("SetPlayerDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003889 RID: 14473 RVA: 0x0011E204 File Offset: 0x0011C404
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600388A RID: 14474 RVA: 0x0011F3CF File Offset: 0x0011D5CF
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600388B RID: 14475 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x0600388C RID: 14476 RVA: 0x0011F408 File Offset: 0x0011D608
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 686f)
			{
				this.HBJJOCHGOPH = 1890f;
			}
			this.HNICHJCGJOC().SetFloat("event", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("[GameScene] Checkpoints count: ", this._EyeWave);
			this.EJDPNJAEAKJ().SetFloat("Cross", this._EyeSpeed);
			this.MMOODGIODPC().SetFloat("UseScanLineSize", this._EyeMove);
			this.GKILCDHJFEG().SetFloat("GridDataStoryboard", this._EyeBlink);
			this.FEAEGGCNIAA().SetTexture("note.6", this.FPHEBLMINDA);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600388D RID: 14477 RVA: 0x0011E204 File Offset: 0x0011C404
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600388E RID: 14478 RVA: 0x0011E204 File Offset: 0x0011C404
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600388F RID: 14479 RVA: 0x0011F4F0 File Offset: 0x0011D6F0
	private void JOPCCCCHNLI()
	{
		this.FPHEBLMINDA = (Resources.Load("B") as Texture2D);
		this.SCShader = Shader.Find("steamid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003890 RID: 14480 RVA: 0x0011F529 File Offset: 0x0011D729
	private void COOHIILCOCO()
	{
		this.FPHEBLMINDA = (Resources.Load("menutheme.hunter") as Texture2D);
		this.SCShader = Shader.Find("mapselector.filter.subscribedonly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003891 RID: 14481 RVA: 0x0011F562 File Offset: 0x0011D762
	private void HJPCJGOEKMF()
	{
		this.FPHEBLMINDA = (Resources.Load("Scene") as Texture2D);
		this.SCShader = Shader.Find("CompletedLevel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003892 RID: 14482 RVA: 0x0011F59B File Offset: 0x0011D79B
	private void KLILJHJNICK()
	{
		this.FPHEBLMINDA = (Resources.Load("_MainTex2") as Texture2D);
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003893 RID: 14483 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x06003894 RID: 14484 RVA: 0x0011F5D4 File Offset: 0x0011D7D4
	private void MJEFMIPLFAB()
	{
		this.FPHEBLMINDA = (Resources.Load("0") as Texture2D);
		this.SCShader = Shader.Find("EventSystem");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003895 RID: 14485 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06003896 RID: 14486 RVA: 0x0011F60D File Offset: 0x0011D80D
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)101;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0400062B RID: 1579
	public Shader SCShader;

	// Token: 0x0400062C RID: 1580
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400062D RID: 1581
	[Range(1f, 32f)]
	public float _EyeWave = 15f;

	// Token: 0x0400062E RID: 1582
	[Range(0f, 10f)]
	public float _EyeSpeed = 1f;

	// Token: 0x0400062F RID: 1583
	[Range(0f, 8f)]
	public float _EyeMove = 2f;

	// Token: 0x04000630 RID: 1584
	[Range(0f, 1f)]
	public float _EyeBlink = 1f;

	// Token: 0x04000631 RID: 1585
	private Material BJFKDHHMLJH;

	// Token: 0x04000632 RID: 1586
	private Texture2D FPHEBLMINDA;
}
