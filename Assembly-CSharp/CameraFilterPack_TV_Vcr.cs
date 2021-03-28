using System;
using UnityEngine;

// Token: 0x02000123 RID: 291
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/VHS/VCR Distortion")]
public class CameraFilterPack_TV_Vcr : MonoBehaviour
{
	// Token: 0x06005BAF RID: 23471 RVA: 0x001C3235 File Offset: 0x001C1435
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005BB0 RID: 23472 RVA: 0x001C326C File Offset: 0x001C146C
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 262f)
			{
				this.HBJJOCHGOPH = 890f;
			}
			this.IFMAPIDFNLI().SetFloat("randomdrop", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat(":", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005BB1 RID: 23473 RVA: 0x001C32FC File Offset: 0x001C14FC
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005BB2 RID: 23474 RVA: 0x001C3333 File Offset: 0x001C1533
	private void AIBNKIDADPI()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005BB3 RID: 23475 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMKBLLMIKAB()
	{
	}

	// Token: 0x06005BB4 RID: 23476 RVA: 0x001C3357 File Offset: 0x001C1557
	private Material IOHHLNAPGMA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005BB5 RID: 23477 RVA: 0x001C338E File Offset: 0x001C158E
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005BB6 RID: 23478 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBIGHNGAAID()
	{
	}

	// Token: 0x06005BB7 RID: 23479 RVA: 0x001C33C5 File Offset: 0x001C15C5
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005BB8 RID: 23480 RVA: 0x001C33EC File Offset: 0x001C15EC
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1219f)
			{
				this.HBJJOCHGOPH = 644f;
			}
			this.FAIFBBGFAIB().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetFloat("workshop.", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005BB9 RID: 23481 RVA: 0x001C347C File Offset: 0x001C167C
	private void DFFKKLAPHCC()
	{
		this.SCShader = Shader.Find(").");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005BBA RID: 23482 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void ODLMOJDBPPG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005BBB RID: 23483 RVA: 0x001C34BD File Offset: 0x001C16BD
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_Vcr");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005BBC RID: 23484 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005BBD RID: 23485 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005BBE RID: 23486 RVA: 0x001C34E1 File Offset: 0x001C16E1
	private void MMPHNFPPEHO()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_Chromatical2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005BBF RID: 23487 RVA: 0x001C3505 File Offset: 0x001C1705
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005BC0 RID: 23488 RVA: 0x001C353C File Offset: 0x001C173C
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005BC1 RID: 23489 RVA: 0x001C3574 File Offset: 0x001C1774
	private void KPOCGNOKNOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 911f)
			{
				this.HBJJOCHGOPH = 334f;
			}
			this.EGOGECOEONM().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("/icon", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPPEPKGFOEM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005BC2 RID: 23490 RVA: 0x0002523B File Offset: 0x0002343B
	private void HEBOIFKBLGD()
	{
	}

	// Token: 0x06005BC3 RID: 23491 RVA: 0x001C3604 File Offset: 0x001C1804
	private void JONGNKNLLND()
	{
		this.SCShader = Shader.Find("IncorrectHitsScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005BC4 RID: 23492 RVA: 0x001C3628 File Offset: 0x001C1828
	private void IKKOIKKIDEG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1052f)
			{
				this.HBJJOCHGOPH = 261f;
			}
			this.MMOODGIODPC().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("#ok", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005BC5 RID: 23493 RVA: 0x001C36B8 File Offset: 0x001C18B8
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("_PrevViewProj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005BC6 RID: 23494 RVA: 0x001C36DC File Offset: 0x001C18DC
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("OK");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005BC7 RID: 23495 RVA: 0x0002523B File Offset: 0x0002343B
	private void GNCIOPKPLLA()
	{
	}

	// Token: 0x06005BC8 RID: 23496 RVA: 0x001C3700 File Offset: 0x001C1900
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005BC9 RID: 23497 RVA: 0x001C3737 File Offset: 0x001C1937
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005BCA RID: 23498 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005BCB RID: 23499 RVA: 0x001C3770 File Offset: 0x001C1970
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 985f)
			{
				this.HBJJOCHGOPH = 693f;
			}
			this.ADBKPGFMNKO().SetFloat("other.dust2", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("_TimeX", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005BCC RID: 23500 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void HLHJBJGEEEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005BCD RID: 23501 RVA: 0x001C3800 File Offset: 0x001C1A00
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005BCE RID: 23502 RVA: 0x001C3838 File Offset: 0x001C1A38
	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1540f)
			{
				this.HBJJOCHGOPH = 1026f;
			}
			this.ADBKPGFMNKO().SetFloat("float,0", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetFloat("_Vignette", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IOHHLNAPGMA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005BCF RID: 23503 RVA: 0x001C38C8 File Offset: 0x001C1AC8
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1243f)
			{
				this.HBJJOCHGOPH = 1141f;
			}
			this.CECJJMKLEAK().SetFloat("maps.", this.HBJJOCHGOPH);
			this.FLOHGDECHHH().SetFloat("Tab1Content", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ENKPNJMPDEB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005BD0 RID: 23504 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void MFBCLNAHEFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005BD1 RID: 23505 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06005BD2 RID: 23506 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x06005BD3 RID: 23507 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x06005BD4 RID: 23508 RVA: 0x001C3958 File Offset: 0x001C1B58
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 61f)
			{
				this.HBJJOCHGOPH = 953f;
			}
			this.BFGNMFCNDBC().SetFloat("The observed monobehaviour (", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("Set satellite beat detection sensitivity", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005BD5 RID: 23509 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005BD6 RID: 23510 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBPCODPOJAH()
	{
	}

	// Token: 0x06005BD7 RID: 23511 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06005BD8 RID: 23512 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOAGAKFBIGD()
	{
	}

	// Token: 0x06005BD9 RID: 23513 RVA: 0x001C39E8 File Offset: 0x001C1BE8
	private void DPGEHNHFHJE()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005BDA RID: 23514 RVA: 0x001C3A0C File Offset: 0x001C1C0C
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("MainCamera");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005BDB RID: 23515 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005BDC RID: 23516 RVA: 0x001C3A30 File Offset: 0x001C1C30
	private Material EGOGECOEONM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005BDD RID: 23517 RVA: 0x0002523B File Offset: 0x0002343B
	private void EDDPLJGKLKJ()
	{
	}

	// Token: 0x06005BDE RID: 23518 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void KLDNGKBMDAN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005BDF RID: 23519 RVA: 0x0002523B File Offset: 0x0002343B
	private void HCIPECAOGIA()
	{
	}

	// Token: 0x06005BE0 RID: 23520 RVA: 0x001C3A67 File Offset: 0x001C1C67
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005BE1 RID: 23521 RVA: 0x001C3A9E File Offset: 0x001C1C9E
	private Material ECCPAOBFDKP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005BE2 RID: 23522 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06005BE3 RID: 23523 RVA: 0x001C3AD5 File Offset: 0x001C1CD5
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("ArcsHitsoundTimeDelaySlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005BE4 RID: 23524 RVA: 0x001C3AF9 File Offset: 0x001C1CF9
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)86;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005BE5 RID: 23525 RVA: 0x001C3B30 File Offset: 0x001C1D30
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 699f)
			{
				this.HBJJOCHGOPH = 619f;
			}
			this.MCDGIILBNIF().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.KDMBOKLMADJ().SetFloat("MapperNameText", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005BE6 RID: 23526 RVA: 0x001C36DC File Offset: 0x001C18DC
	private void MKOMIDCPCDC()
	{
		this.SCShader = Shader.Find("OK");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005BE7 RID: 23527 RVA: 0x001C3BC0 File Offset: 0x001C1DC0
	private void JDKHBGDEONK()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blur_DitherOffset");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005BE8 RID: 23528 RVA: 0x001C3BE4 File Offset: 0x001C1DE4
	private Material PEIMCBBHLBJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005BE9 RID: 23529 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void IHHNCCOGLPN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005BEA RID: 23530 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x06005BEB RID: 23531 RVA: 0x001C3C1C File Offset: 0x001C1E1C
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1739f)
			{
				this.HBJJOCHGOPH = 1810f;
			}
			this.KDMBOKLMADJ().SetFloat("#scoresubmitionfailed: ", this.HBJJOCHGOPH);
			this.PEIMCBBHLBJ().SetFloat("/", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005BEC RID: 23532 RVA: 0x0002523B File Offset: 0x0002343B
	private void GKENNHBFBLA()
	{
	}

	// Token: 0x06005BED RID: 23533 RVA: 0x0002523B File Offset: 0x0002343B
	private void GFACKFCEIBC()
	{
	}

	// Token: 0x06005BEE RID: 23534 RVA: 0x001C3CAC File Offset: 0x001C1EAC
	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1894f)
			{
				this.HBJJOCHGOPH = 1433f;
			}
			this.JFDGLLEOPGB().SetFloat("Maps Editor v.", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("SpawnObj", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005BEF RID: 23535 RVA: 0x001C3D3C File Offset: 0x001C1F3C
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005BF0 RID: 23536 RVA: 0x0002523B File Offset: 0x0002343B
	private void INLDEHPAMJC()
	{
	}

	// Token: 0x06005BF1 RID: 23537 RVA: 0x001C3D73 File Offset: 0x001C1F73
	private void IPJFFIDBPFE()
	{
		this.SCShader = Shader.Find("shader.none");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005BF2 RID: 23538 RVA: 0x001C3D97 File Offset: 0x001C1F97
	private Material LPPEPKGFOEM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005BF3 RID: 23539 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005BF4 RID: 23540 RVA: 0x001C3DCE File Offset: 0x001C1FCE
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("Tab1Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005BF6 RID: 23542 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005BF7 RID: 23543 RVA: 0x001C3E10 File Offset: 0x001C2010
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005BF8 RID: 23544 RVA: 0x001C3E47 File Offset: 0x001C2047
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005BF9 RID: 23545 RVA: 0x0002523B File Offset: 0x0002343B
	private void MKKJICPMPHK()
	{
	}

	// Token: 0x06005BFA RID: 23546 RVA: 0x001C3E7E File Offset: 0x001C207E
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005BFB RID: 23547 RVA: 0x0002523B File Offset: 0x0002343B
	private void MBLDJEFBLFL()
	{
	}

	// Token: 0x06005BFC RID: 23548 RVA: 0x001C3EB8 File Offset: 0x001C20B8
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 407f)
			{
				this.HBJJOCHGOPH = 269f;
			}
			this.IONHGBPGCHK().SetFloat("JoystickButton13", this.HBJJOCHGOPH);
			this.CECJJMKLEAK().SetFloat("_CenterRadius", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005BFD RID: 23549 RVA: 0x001C3F48 File Offset: 0x001C2148
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005BFE RID: 23550 RVA: 0x001C3F7F File Offset: 0x001C217F
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("-");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005BFF RID: 23551 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void JNALDALAJLG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C00 RID: 23552 RVA: 0x001C3FA3 File Offset: 0x001C21A3
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find(" is not supported on this platform!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C01 RID: 23553 RVA: 0x001C3FC7 File Offset: 0x001C21C7
	private void NLDKIPEMILC()
	{
		this.SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005C02 RID: 23554 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005C03 RID: 23555 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C04 RID: 23556 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C05 RID: 23557 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C06 RID: 23558 RVA: 0x001C3FEB File Offset: 0x001C21EB
	private void LFBGJIIECLD()
	{
		this.SCShader = Shader.Find("_InvViewProj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C07 RID: 23559 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06005C08 RID: 23560 RVA: 0x001C4010 File Offset: 0x001C2210
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 208f)
			{
				this.HBJJOCHGOPH = 843f;
			}
			this.ECCPAOBFDKP().SetFloat("#or", this.HBJJOCHGOPH);
			this.IFMAPIDFNLI().SetFloat(" Owner called.", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C09 RID: 23561 RVA: 0x001C40A0 File Offset: 0x001C22A0
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005C0A RID: 23562 RVA: 0x0002523B File Offset: 0x0002343B
	private void JGMEKCFHGLE()
	{
	}

	// Token: 0x06005C0B RID: 23563 RVA: 0x001C40D7 File Offset: 0x001C22D7
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("<b>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C0C RID: 23564 RVA: 0x001C40FB File Offset: 0x001C22FB
	private void PJHBFAFOEEN()
	{
		this.SCShader = Shader.Find("LevelInfoInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005C0D RID: 23565 RVA: 0x001C4120 File Offset: 0x001C2320
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1302f)
			{
				this.HBJJOCHGOPH = 389f;
			}
			this.OIMMPLPBLBK().SetFloat("steamid", this.HBJJOCHGOPH);
			this.OJMHIMIPKME().SetFloat("2hands", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C0E RID: 23566 RVA: 0x001C41B0 File Offset: 0x001C23B0
	private void MODENHKMKOC()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C0F RID: 23567 RVA: 0x001C41D4 File Offset: 0x001C23D4
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C10 RID: 23568 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C11 RID: 23569 RVA: 0x001C41F8 File Offset: 0x001C23F8
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("COMPLETED");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C12 RID: 23570 RVA: 0x001C421C File Offset: 0x001C241C
	private void EIMNPCMHJLJ()
	{
		this.SCShader = Shader.Find(" base map(s)");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005C13 RID: 23571 RVA: 0x001C4240 File Offset: 0x001C2440
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 170f)
			{
				this.HBJJOCHGOPH = 1767f;
			}
			this.CECJJMKLEAK().SetFloat("_Speed", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("_TimeX", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C14 RID: 23572 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x06005C15 RID: 23573 RVA: 0x001C3505 File Offset: 0x001C1705
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005C16 RID: 23574 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06005C17 RID: 23575 RVA: 0x001C3E10 File Offset: 0x001C2010
	private Material CFCPHFMKHII()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005C18 RID: 23576 RVA: 0x001C42D0 File Offset: 0x001C24D0
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005C19 RID: 23577 RVA: 0x001C4308 File Offset: 0x001C2508
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1193f)
			{
				this.HBJJOCHGOPH = 239f;
			}
			this.ENKPNJMPDEB().SetFloat("z", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetFloat("Reconnect() failed. Can only connect while in state 'Disconnected'. Current state: ", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OJMHIMIPKME());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C1A RID: 23578 RVA: 0x001C4398 File Offset: 0x001C2598
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("_PosY");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C1B RID: 23579 RVA: 0x001C43BC File Offset: 0x001C25BC
	private void ALNNIDLFILB()
	{
		this.SCShader = Shader.Find("InputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C1C RID: 23580 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void DIGHKAJILJH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C1D RID: 23581 RVA: 0x001C43E0 File Offset: 0x001C25E0
	private Material OJMHIMIPKME()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-80);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005C1E RID: 23582 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void CNPINCHINJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C1F RID: 23583 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C20 RID: 23584 RVA: 0x001C4417 File Offset: 0x001C2617
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x17000108 RID: 264
	// (get) Token: 0x06005C21 RID: 23585 RVA: 0x001C444E File Offset: 0x001C264E
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

	// Token: 0x06005C22 RID: 23586 RVA: 0x001C4485 File Offset: 0x001C2685
	private void AEDDNDHCLNN()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C23 RID: 23587 RVA: 0x0002523B File Offset: 0x0002343B
	private void IAIGNDMHFFG()
	{
	}

	// Token: 0x06005C24 RID: 23588 RVA: 0x0002523B File Offset: 0x0002343B
	private void ANKIJGCGCBF()
	{
	}

	// Token: 0x06005C25 RID: 23589 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C26 RID: 23590 RVA: 0x001C44AC File Offset: 0x001C26AC
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 721f)
			{
				this.HBJJOCHGOPH = 647f;
			}
			this.BKKJJJGADLM().SetFloat(".lastCheckpoint.correctScore", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("maps.", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PEIMCBBHLBJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C27 RID: 23591 RVA: 0x001C453C File Offset: 0x001C273C
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005C28 RID: 23592 RVA: 0x001C4574 File Offset: 0x001C2774
	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1384f)
			{
				this.HBJJOCHGOPH = 913f;
			}
			this.FLOHGDECHHH().SetFloat("skin.hit_normal", this.HBJJOCHGOPH);
			this.EGOGECOEONM().SetFloat("\n", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C29 RID: 23593 RVA: 0x001C4604 File Offset: 0x001C2804
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("ERROR: Preview file name in modName.workshop.json doesn't match any file");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C2A RID: 23594 RVA: 0x001C3A67 File Offset: 0x001C1C67
	private Material GJHPODJOBHL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005C2B RID: 23595 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06005C2C RID: 23596 RVA: 0x001C4628 File Offset: 0x001C2828
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("automaticallyRecycleParticleSystems is true but there is no ParticleSystem on this GameObject!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C2D RID: 23597 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06005C2E RID: 23598 RVA: 0x001C464C File Offset: 0x001C284C
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005C2F RID: 23599 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06005C30 RID: 23600 RVA: 0x001C4684 File Offset: 0x001C2884
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 595f)
			{
				this.HBJJOCHGOPH = 520f;
			}
			this.ENKPNJMPDEB().SetFloat(":", this.HBJJOCHGOPH);
			this.IFMAPIDFNLI().SetFloat("PenaltyScoreText", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C31 RID: 23601 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void FJABOCDLCAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C32 RID: 23602 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C33 RID: 23603 RVA: 0x001C33C5 File Offset: 0x001C15C5
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005C34 RID: 23604 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLDHEJIEDHO()
	{
	}

	// Token: 0x06005C35 RID: 23605 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x06005C36 RID: 23606 RVA: 0x0002523B File Offset: 0x0002343B
	private void PCIMPDNLCHH()
	{
	}

	// Token: 0x06005C37 RID: 23607 RVA: 0x001C4714 File Offset: 0x001C2914
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
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C38 RID: 23608 RVA: 0x001C47A4 File Offset: 0x001C29A4
	private void PODKOCOPGLC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 693f)
			{
				this.HBJJOCHGOPH = 1736f;
			}
			this.BKKJJJGADLM().SetFloat("_Value", this.HBJJOCHGOPH);
			this.OJMHIMIPKME().SetFloat("LoadingStatusText", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C39 RID: 23609 RVA: 0x001C4834 File Offset: 0x001C2A34
	private void MABCDJDPGNA()
	{
		this.SCShader = Shader.Find("restart");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C3A RID: 23610 RVA: 0x001C444E File Offset: 0x001C264E
	private Material ENKPNJMPDEB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005C3B RID: 23611 RVA: 0x001C4858 File Offset: 0x001C2A58
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005C3C RID: 23612 RVA: 0x001C488F File Offset: 0x001C2A8F
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005C3D RID: 23613 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C3E RID: 23614 RVA: 0x001C48C6 File Offset: 0x001C2AC6
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("mapselector.filter.officialsortmode");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C3F RID: 23615 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIPBNBKNICE()
	{
	}

	// Token: 0x06005C40 RID: 23616 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBFJAOINHMK()
	{
	}

	// Token: 0x06005C41 RID: 23617 RVA: 0x001C40FB File Offset: 0x001C22FB
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("LevelInfoInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005C42 RID: 23618 RVA: 0x001C48EC File Offset: 0x001C2AEC
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1646f)
			{
				this.HBJJOCHGOPH = 780f;
			}
			this.KEMAALEODNH().SetFloat("/", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat("CameraFilterPack_RainFX_Anm", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PEIMCBBHLBJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C43 RID: 23619 RVA: 0x001C497C File Offset: 0x001C2B7C
	private void MDNHCLKNCLE()
	{
		this.SCShader = Shader.Find("No info");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C44 RID: 23620 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06005C45 RID: 23621 RVA: 0x001C34A0 File Offset: 0x001C16A0
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C46 RID: 23622 RVA: 0x001C49A0 File Offset: 0x001C2BA0
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1001f)
			{
				this.HBJJOCHGOPH = 316f;
			}
			this.HNICHJCGJOC().SetFloat("880078120", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("_Bloom2", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C47 RID: 23623 RVA: 0x001C4A30 File Offset: 0x001C2C30
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C48 RID: 23624 RVA: 0x001C4A54 File Offset: 0x001C2C54
	private void IJMAPHMBFJI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 226f)
			{
				this.HBJJOCHGOPH = 1279f;
			}
			this.ECCPAOBFDKP().SetFloat("y", this.HBJJOCHGOPH);
			this.ECCPAOBFDKP().SetFloat("DPADHOR", this.Distortion);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C49 RID: 23625 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x06005C4A RID: 23626 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x04000957 RID: 2391
	public Shader SCShader;

	// Token: 0x04000958 RID: 2392
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000959 RID: 2393
	[Range(1f, 10f)]
	public float Distortion = 1f;

	// Token: 0x0400095A RID: 2394
	private Material BJFKDHHMLJH;
}
