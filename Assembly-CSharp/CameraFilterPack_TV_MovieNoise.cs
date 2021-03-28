using System;
using UnityEngine;

// Token: 0x0200011A RID: 282
[AddComponentMenu("Camera Filter Pack/TV/Movie Noise")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_MovieNoise : MonoBehaviour
{
	// Token: 0x06005893 RID: 22675 RVA: 0x001B7EEA File Offset: 0x001B60EA
	private void EDCMIPNCPLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005894 RID: 22676 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x06005895 RID: 22677 RVA: 0x001B7F07 File Offset: 0x001B6107
	private Material OOMFJGPAOKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005896 RID: 22678 RVA: 0x001B7F3E File Offset: 0x001B613E
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005897 RID: 22679 RVA: 0x001B7F64 File Offset: 0x001B6164
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1782f)
			{
				this.HBJJOCHGOPH = 1451f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("FreqVolume: ", this.Fade);
			this.LPCHMEKDCHI().SetVector("_Value4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1553f, 686f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005898 RID: 22680 RVA: 0x001B8024 File Offset: 0x001B6224
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1055f)
			{
				this.HBJJOCHGOPH = 934f;
			}
			this.KGOLDDBHIFN().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.OOMFJGPAOKL().SetFloat("t", this.Fade);
			this.KEMJNOMIPHN().SetVector("Reconnect() failed. Can only connect while in state 'Disconnected'. Current state: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1090f, 1683f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005899 RID: 22681 RVA: 0x001B80E1 File Offset: 0x001B62E1
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("SAVE FILE");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600589A RID: 22682 RVA: 0x001B8105 File Offset: 0x001B6305
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600589B RID: 22683 RVA: 0x001B813C File Offset: 0x001B633C
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("ns");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600589C RID: 22684 RVA: 0x001B7EEA File Offset: 0x001B60EA
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600589D RID: 22685 RVA: 0x001B8160 File Offset: 0x001B6360
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("Decibal");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600589E RID: 22686 RVA: 0x001B8184 File Offset: 0x001B6384
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("X2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600589F RID: 22687 RVA: 0x001B81A8 File Offset: 0x001B63A8
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("speed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060058A0 RID: 22688 RVA: 0x001B81CC File Offset: 0x001B63CC
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("_BorderColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060058A1 RID: 22689 RVA: 0x001B81F0 File Offset: 0x001B63F0
	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 236f)
			{
				this.HBJJOCHGOPH = 85f;
			}
			this.MFHPKGICPIO().SetFloat("/theme", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("_ScreenResolution", this.Fade);
			this.BLMPMOIDGMG().SetVector("maphash", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1694f, 1794f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060058A2 RID: 22690 RVA: 0x001B82AD File Offset: 0x001B64AD
	private void DFFKKLAPHCC()
	{
		this.SCShader = Shader.Find("Using constructor for new PingNativeStatic()");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060058A3 RID: 22691 RVA: 0x001B82D1 File Offset: 0x001B64D1
	private void AEOLJEIDMDB()
	{
		this.SCShader = Shader.Find("offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060058A4 RID: 22692 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x060058A5 RID: 22693 RVA: 0x001B82F8 File Offset: 0x001B64F8
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 593f)
			{
				this.HBJJOCHGOPH = 1513f;
			}
			this.LEIAFCPJMDP().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("EVENT CONFIG [Ctrl+E]", this.Fade);
			this.DONENAMLFLF().SetVector("float,50", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1318f, 92f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060058A6 RID: 22694 RVA: 0x001B83B5 File Offset: 0x001B65B5
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find(" ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060058A7 RID: 22695 RVA: 0x001B83D9 File Offset: 0x001B65D9
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060058A8 RID: 22696 RVA: 0x001B8410 File Offset: 0x001B6610
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060058A9 RID: 22697 RVA: 0x001B7EEA File Offset: 0x001B60EA
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060058AA RID: 22698 RVA: 0x001B7EEA File Offset: 0x001B60EA
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060058AB RID: 22699 RVA: 0x001B8447 File Offset: 0x001B6647
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060058AC RID: 22700 RVA: 0x001B846B File Offset: 0x001B666B
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060058AD RID: 22701 RVA: 0x001B7EEA File Offset: 0x001B60EA
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060058AE RID: 22702 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x060058AF RID: 22703 RVA: 0x001B84A4 File Offset: 0x001B66A4
	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 407f)
			{
				this.HBJJOCHGOPH = 311f;
			}
			this.DONENAMLFLF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.LEIAFCPJMDP().SetFloat("Custom Authentication failed (either due to user-input or configuration or AuthParameter string format). Calling: OnCustomAuthenticationFailed()", this.Fade);
			this.LPCHMEKDCHI().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1779f, 836f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060058B0 RID: 22704 RVA: 0x001B8561 File Offset: 0x001B6761
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060058B1 RID: 22705 RVA: 0x001B8598 File Offset: 0x001B6798
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1866f)
			{
				this.HBJJOCHGOPH = 1863f;
			}
			this.MFHPKGICPIO().SetFloat("player.goldwatermelon", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Threshhold", this.Fade);
			this.ADBKPGFMNKO().SetVector("Move environment object to the position", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1587f, 1725f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060058B2 RID: 22706 RVA: 0x001B8658 File Offset: 0x001B6858
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1835f)
			{
				this.HBJJOCHGOPH = 1651f;
			}
			this.EFMCNLELMDO().SetFloat("DontDestroy", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("1159514800", this.Fade);
			this.KEMJNOMIPHN().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1152f, 61f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060058B3 RID: 22707 RVA: 0x001B7EEA File Offset: 0x001B60EA
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060058B4 RID: 22708 RVA: 0x001B8715 File Offset: 0x001B6915
	private Material LEIAFCPJMDP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060058B5 RID: 22709 RVA: 0x001B874C File Offset: 0x001B694C
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060058B6 RID: 22710 RVA: 0x001B8783 File Offset: 0x001B6983
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("_DotSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060058B7 RID: 22711 RVA: 0x001B87A7 File Offset: 0x001B69A7
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060058B8 RID: 22712 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x060058B9 RID: 22713 RVA: 0x001B87E0 File Offset: 0x001B69E0
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1632f)
			{
				this.HBJJOCHGOPH = 1029f;
			}
			this.LPCHMEKDCHI().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.HKIMAANBGMJ().SetFloat("Tab1Content", this.Fade);
			this.DKNJGHFLAIF().SetVector("Editor/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 935f, 919f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060058BA RID: 22714 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x060058BB RID: 22715 RVA: 0x001B889D File Offset: 0x001B6A9D
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

	// Token: 0x060058BC RID: 22716 RVA: 0x001B88D4 File Offset: 0x001B6AD4
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060058BD RID: 22717 RVA: 0x001B890B File Offset: 0x001B6B0B
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("_MaxVelocity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060058BE RID: 22718 RVA: 0x001B8930 File Offset: 0x001B6B30
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1091f)
			{
				this.HBJJOCHGOPH = 1390f;
			}
			this.NLFJGMBCICG().SetFloat("Editor", this.HBJJOCHGOPH);
			this.BLMPMOIDGMG().SetFloat("ready", this.Fade);
			this.BFGNMFCNDBC().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1770f, 1056f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060058BF RID: 22719 RVA: 0x0002523B File Offset: 0x0002343B
	private void APKNAPHOFHC()
	{
	}

	// Token: 0x060058C0 RID: 22720 RVA: 0x001B89F0 File Offset: 0x001B6BF0
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 36f)
			{
				this.HBJJOCHGOPH = 937f;
			}
			this.EFMCNLELMDO().SetFloat("The process failed: ", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat(". We have no such PhotonView! Ignored this if you're leaving a room. State: ", this.Fade);
			this.NBPKMLMCHFN.SetVector("SetSatelliteEmission", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 605f, 1532f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060058C1 RID: 22721 RVA: 0x001B8AAD File Offset: 0x001B6CAD
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060058C2 RID: 22722 RVA: 0x001B8AE4 File Offset: 0x001B6CE4
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060058C3 RID: 22723 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x060058C4 RID: 22724 RVA: 0x001B8B1B File Offset: 0x001B6D1B
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060058C5 RID: 22725 RVA: 0x001B8B52 File Offset: 0x001B6D52
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060058C6 RID: 22726 RVA: 0x001B8B89 File Offset: 0x001B6D89
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("resource");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060058C7 RID: 22727 RVA: 0x001B7EEA File Offset: 0x001B60EA
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060058C8 RID: 22728 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x060058C9 RID: 22729 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x060058CA RID: 22730 RVA: 0x001B7EEA File Offset: 0x001B60EA
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060058CB RID: 22731 RVA: 0x001B83D9 File Offset: 0x001B65D9
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060058CC RID: 22732 RVA: 0x001B8BAD File Offset: 0x001B6DAD
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find(".highscore");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060058CD RID: 22733 RVA: 0x001B8BD4 File Offset: 0x001B6DD4
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1771f)
			{
				this.HBJJOCHGOPH = 99f;
			}
			this.BLMPMOIDGMG().SetFloat("menu.playedsolo", this.HBJJOCHGOPH);
			this.HKIMAANBGMJ().SetFloat("LowMid", this.Fade);
			this.PLBEJJIHFPB().SetVector("RateButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 963f, 1622f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060058CF RID: 22735 RVA: 0x001B8CAF File Offset: 0x001B6EAF
	private void FEKECCBFGMI()
	{
		this.SCShader = Shader.Find("_LightIntensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060058D0 RID: 22736 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x060058D1 RID: 22737 RVA: 0x001B8CD3 File Offset: 0x001B6ED3
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060058D2 RID: 22738 RVA: 0x001B8D0A File Offset: 0x001B6F0A
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("_Val3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060058D3 RID: 22739 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKMELABKBHO()
	{
	}

	// Token: 0x060058D4 RID: 22740 RVA: 0x001B8D2E File Offset: 0x001B6F2E
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060058D5 RID: 22741 RVA: 0x001B8D68 File Offset: 0x001B6F68
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 49f)
			{
				this.HBJJOCHGOPH = 1876f;
			}
			this.LPCHMEKDCHI().SetFloat(".status", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("settings.volume.game", this.Fade);
			this.OIMMPLPBLBK().SetVector("<b>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 433f, 912f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060058D6 RID: 22742 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x060058D7 RID: 22743 RVA: 0x001B8E28 File Offset: 0x001B7028
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1963f)
			{
				this.HBJJOCHGOPH = 1535f;
			}
			this.DONENAMLFLF().SetFloat("settings_bindings_sec_", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("LobbyCanvas", this.Fade);
			this.BFGNMFCNDBC().SetVector("_ColorLevel", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1820f, 764f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060058D8 RID: 22744 RVA: 0x001B7EEA File Offset: 0x001B60EA
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060058D9 RID: 22745 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060058DA RID: 22746 RVA: 0x001B8EE8 File Offset: 0x001B70E8
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1814f)
			{
				this.HBJJOCHGOPH = 639f;
			}
			this.BKKJJJGADLM().SetFloat("PointsScoreText", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("SpawnObj", this.Fade);
			this.EFMCNLELMDO().SetVector("_Amount", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1524f, 1231f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060058DB RID: 22747 RVA: 0x001B8FA5 File Offset: 0x001B71A5
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("LevelConfigButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060058DC RID: 22748 RVA: 0x001B8FCC File Offset: 0x001B71CC
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1006f)
			{
				this.HBJJOCHGOPH = 918f;
			}
			this.DONENAMLFLF().SetFloat("ns", this.HBJJOCHGOPH);
			this.IFMAPIDFNLI().SetFloat("_Value5", this.Fade);
			this.EFMCNLELMDO().SetVector("_Max", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1371f, 1636f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060058DD RID: 22749 RVA: 0x001B9089 File Offset: 0x001B7289
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060058DE RID: 22750 RVA: 0x001B90C0 File Offset: 0x001B72C0
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1030f)
			{
				this.HBJJOCHGOPH = 891f;
			}
			this.KDMBOKLMADJ().SetFloat("_Value", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("ViewMenu", this.Fade);
			this.EFMCNLELMDO().SetVector("MenuScene", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 536f, 106f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060058DF RID: 22751 RVA: 0x001B9180 File Offset: 0x001B7380
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 138f)
			{
				this.HBJJOCHGOPH = 634f;
			}
			this.OIMMPLPBLBK().SetFloat("note.5", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("_BlurArea", this.Fade);
			this.KEMJNOMIPHN().SetVector("SlidingArea", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 343f, 1915f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060058E0 RID: 22752 RVA: 0x001B7EEA File Offset: 0x001B60EA
	private void KLDNGKBMDAN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060058E1 RID: 22753 RVA: 0x001B923D File Offset: 0x001B743D
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("\" error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060058E2 RID: 22754 RVA: 0x001B9261 File Offset: 0x001B7461
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060058E3 RID: 22755 RVA: 0x001B9298 File Offset: 0x001B7498
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060058E4 RID: 22756 RVA: 0x001B92BC File Offset: 0x001B74BC
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1843f)
			{
				this.HBJJOCHGOPH = 1736f;
			}
			this.KEMJNOMIPHN().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.IFMAPIDFNLI().SetFloat("offsets", this.Fade);
			this.FEAEGGCNIAA().SetVector("SaveButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 182f, 1610f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060058E5 RID: 22757 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x060058E6 RID: 22758 RVA: 0x001B9379 File Offset: 0x001B7579
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060058E7 RID: 22759 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x060058E8 RID: 22760 RVA: 0x001B93B0 File Offset: 0x001B75B0
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_MovieNoise");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060058E9 RID: 22761 RVA: 0x0002523B File Offset: 0x0002343B
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x060058EA RID: 22762 RVA: 0x001B7EEA File Offset: 0x001B60EA
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060058EB RID: 22763 RVA: 0x001B7EEA File Offset: 0x001B60EA
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060058EC RID: 22764 RVA: 0x001B93D4 File Offset: 0x001B75D4
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
			this.NBPKMLMCHFN.SetFloat("_Fade", this.Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060058ED RID: 22765 RVA: 0x001B9491 File Offset: 0x001B7691
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060058EE RID: 22766 RVA: 0x001B94C8 File Offset: 0x001B76C8
	private void FLKEJJEGCFA()
	{
		this.SCShader = Shader.Find("Reset");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060058EF RID: 22767 RVA: 0x001B94EC File Offset: 0x001B76EC
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1470f)
			{
				this.HBJJOCHGOPH = 1375f;
			}
			this.BFGNMFCNDBC().SetFloat("_DotSize", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("_ColorBuffer", this.Fade);
			this.OIMMPLPBLBK().SetVector("_LightIntensity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 368f, 1179f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060058F0 RID: 22768 RVA: 0x001B7EEA File Offset: 0x001B60EA
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060058F1 RID: 22769 RVA: 0x001B95AC File Offset: 0x001B77AC
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 596f)
			{
				this.HBJJOCHGOPH = 1621f;
			}
			this.MFHPKGICPIO().SetFloat("maps.", this.HBJJOCHGOPH);
			this.BLMPMOIDGMG().SetFloat("_Near", this.Fade);
			this.OLHDPICFBOF().SetVector("true", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 743f, 1142f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060058F2 RID: 22770 RVA: 0x001B7EEA File Offset: 0x001B60EA
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060058F3 RID: 22771 RVA: 0x001B7EEA File Offset: 0x001B60EA
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060058F4 RID: 22772 RVA: 0x001B7EEA File Offset: 0x001B60EA
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060058F5 RID: 22773 RVA: 0x001B9669 File Offset: 0x001B7869
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060058F6 RID: 22774 RVA: 0x001B968D File Offset: 0x001B788D
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060058F7 RID: 22775 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x060058F8 RID: 22776 RVA: 0x001B96C4 File Offset: 0x001B78C4
	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 590f)
			{
				this.HBJJOCHGOPH = 886f;
			}
			this.KEMJNOMIPHN().SetFloat(" while connecting to: ", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("HandleEventLeave for player ID: ", this.Fade);
			this.KBOPGONOCNP().SetVector(":", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1983f, 1017f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060058F9 RID: 22777 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x060058FA RID: 22778 RVA: 0x001B9781 File Offset: 0x001B7981
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060058FB RID: 22779 RVA: 0x001B97B8 File Offset: 0x001B79B8
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1827f)
			{
				this.HBJJOCHGOPH = 173f;
			}
			this.BLMPMOIDGMG().SetFloat("maps.", this.HBJJOCHGOPH);
			this.LEIAFCPJMDP().SetFloat("_PrevViewProj", this.Fade);
			this.BFGNMFCNDBC().SetVector("_ColorKey", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 759f, 25f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LEIAFCPJMDP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060058FC RID: 22780 RVA: 0x001B7EEA File Offset: 0x001B60EA
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060058FD RID: 22781 RVA: 0x001B9875 File Offset: 0x001B7A75
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060058FE RID: 22782 RVA: 0x001B98AC File Offset: 0x001B7AAC
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1718f)
			{
				this.HBJJOCHGOPH = 380f;
			}
			this.FEAEGGCNIAA().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.BLMPMOIDGMG().SetFloat("Joystick1Button10", this.Fade);
			this.ADBKPGFMNKO().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1549f, 1914f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060058FF RID: 22783 RVA: 0x001B9969 File Offset: 0x001B7B69
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find("GameScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x04000923 RID: 2339
	public Shader SCShader;

	// Token: 0x04000924 RID: 2340
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000925 RID: 2341
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000926 RID: 2342
	private Material BJFKDHHMLJH;

	// Token: 0x04000927 RID: 2343
	[Range(0.0001f, 1f)]
	public float Fade = 0.01f;
}
