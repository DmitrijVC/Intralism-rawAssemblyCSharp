using System;
using UnityEngine;

// Token: 0x02000126 RID: 294
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/TV/Video3D")]
public class CameraFilterPack_TV_Video3D : MonoBehaviour
{
	// Token: 0x06005CDB RID: 23771 RVA: 0x001C6FB6 File Offset: 0x001C51B6
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("AccuracyScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005CDC RID: 23772 RVA: 0x001C6FDA File Offset: 0x001C51DA
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("_Visualize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005CDD RID: 23773 RVA: 0x001C6FFE File Offset: 0x001C51FE
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005CDE RID: 23774 RVA: 0x001C7035 File Offset: 0x001C5235
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005CDF RID: 23775 RVA: 0x001C7035 File Offset: 0x001C5235
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005CE0 RID: 23776 RVA: 0x001C7035 File Offset: 0x001C5235
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005CE1 RID: 23777 RVA: 0x001C7054 File Offset: 0x001C5254
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1086f)
			{
				this.HBJJOCHGOPH = 596f;
			}
			this.IIJMIPBMMBF().SetFloat("Aimer Input Module is incompatible with the StandAloneInputSystem, please remove it from the Event System in this scene or disable it when this module is in use", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetVector("CameraFilterPack/Blend2Camera_Screen", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 972f, 1776f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005CE2 RID: 23778 RVA: 0x001C7035 File Offset: 0x001C5235
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005CE3 RID: 23779 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06005CE4 RID: 23780 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x06005CE5 RID: 23781 RVA: 0x001C70FB File Offset: 0x001C52FB
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("SubBass");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005CE6 RID: 23782 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x06005CE7 RID: 23783 RVA: 0x001C711F File Offset: 0x001C531F
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("/theme");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005CE8 RID: 23784 RVA: 0x001C7035 File Offset: 0x001C5235
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005CE9 RID: 23785 RVA: 0x001C7143 File Offset: 0x001C5343
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find("randomdrop");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005CEA RID: 23786 RVA: 0x001C7168 File Offset: 0x001C5368
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1265f)
			{
				this.HBJJOCHGOPH = 664f;
			}
			this.OIMMPLPBLBK().SetFloat("sounds/hit_perfect", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetVector(" PhotonNetwork.networkingPeer.AvailableRegions ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1890f, 573f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005CEB RID: 23787 RVA: 0x001C7210 File Offset: 0x001C5410
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 463f)
			{
				this.HBJJOCHGOPH = 1144f;
			}
			this.OIMMPLPBLBK().SetFloat("mapselector.filter.favoriteonly", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 609f, 1514f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005CEC RID: 23788 RVA: 0x001C72B7 File Offset: 0x001C54B7
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)82;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005CED RID: 23789 RVA: 0x001C72EE File Offset: 0x001C54EE
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("Speed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005CEE RID: 23790 RVA: 0x001C7314 File Offset: 0x001C5514
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1937f)
			{
				this.HBJJOCHGOPH = 274f;
			}
			this.IIJMIPBMMBF().SetFloat("Anime", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetVector("StartButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 608f, 261f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005CF0 RID: 23792 RVA: 0x001C73CE File Offset: 0x001C55CE
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("_ReflectionTexture3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005CF1 RID: 23793 RVA: 0x001C73F2 File Offset: 0x001C55F2
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005CF2 RID: 23794 RVA: 0x001C7429 File Offset: 0x001C5629
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005CF3 RID: 23795 RVA: 0x001C7460 File Offset: 0x001C5660
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 549f)
			{
				this.HBJJOCHGOPH = 61f;
			}
			this.KBOPGONOCNP().SetFloat("_Distortion", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetVector("CameraFilterPack/Blend2Camera_SplitScreen", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1286f, 1712f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005CF4 RID: 23796 RVA: 0x001C7508 File Offset: 0x001C5708
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1563f)
			{
				this.HBJJOCHGOPH = 488f;
			}
			this.NDMPCDHADMJ().SetFloat("No Camera attached!", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetVector("ChallengesButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 365f, 1447f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005CF5 RID: 23797 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06005CF6 RID: 23798 RVA: 0x001C75B0 File Offset: 0x001C57B0
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1849f)
			{
				this.HBJJOCHGOPH = 549f;
			}
			this.MICHFGAOPKM().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetVector("Can't change CrcCheckEnabled while being connected. CrcCheckEnabled stays ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 371f, 1412f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005CF7 RID: 23799 RVA: 0x001C7658 File Offset: 0x001C5858
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1475f)
			{
				this.HBJJOCHGOPH = 1959f;
			}
			this.KEMJNOMIPHN().SetFloat("Command not found!", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetVector("Moved event", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 862f, 1704f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005CF8 RID: 23800 RVA: 0x001C7035 File Offset: 0x001C5235
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005CF9 RID: 23801 RVA: 0x001C76FF File Offset: 0x001C58FF
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x1700010B RID: 267
	// (get) Token: 0x06005CFA RID: 23802 RVA: 0x001C7736 File Offset: 0x001C5936
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

	// Token: 0x06005CFB RID: 23803 RVA: 0x001C7770 File Offset: 0x001C5970
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1085f)
			{
				this.HBJJOCHGOPH = 1376f;
			}
			this.IIJMIPBMMBF().SetFloat(": ", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetVector("]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1052f, 97f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005CFC RID: 23804 RVA: 0x001C7035 File Offset: 0x001C5235
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005CFD RID: 23805 RVA: 0x001C7035 File Offset: 0x001C5235
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005CFE RID: 23806 RVA: 0x001C7818 File Offset: 0x001C5A18
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 259f)
			{
				this.HBJJOCHGOPH = 1267f;
			}
			this.JFDGLLEOPGB().SetFloat("mapselector.filter.subscribedonly", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetVector("Testing, the group has toggled [", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 166f, 790f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005CFF RID: 23807 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06005D00 RID: 23808 RVA: 0x001C78BF File Offset: 0x001C5ABF
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D01 RID: 23809 RVA: 0x001C78F6 File Offset: 0x001C5AF6
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("UseScanLine");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005D02 RID: 23810 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06005D03 RID: 23811 RVA: 0x001C791C File Offset: 0x001C5B1C
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1721f)
			{
				this.HBJJOCHGOPH = 1835f;
			}
			this.NDMPCDHADMJ().SetFloat("SetSatelliteColor", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetVector("TransferOwnership() view ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1712f, 1686f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D04 RID: 23812 RVA: 0x001C79C3 File Offset: 0x001C5BC3
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_Video3D");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005D05 RID: 23813 RVA: 0x001C79E7 File Offset: 0x001C5BE7
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)118;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D06 RID: 23814 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x06005D07 RID: 23815 RVA: 0x001C7A1E File Offset: 0x001C5C1E
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D08 RID: 23816 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06005D09 RID: 23817 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06005D0A RID: 23818 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005D0B RID: 23819 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06005D0C RID: 23820 RVA: 0x001C7A55 File Offset: 0x001C5C55
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D0D RID: 23821 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06005D0E RID: 23822 RVA: 0x001C7A8C File Offset: 0x001C5C8C
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D0F RID: 23823 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06005D10 RID: 23824 RVA: 0x001C7AC4 File Offset: 0x001C5CC4
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1879f)
			{
				this.HBJJOCHGOPH = 794f;
			}
			this.MICHFGAOPKM().SetFloat("_SpotSize", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetVector("BitsData", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1629f, 1579f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D11 RID: 23825 RVA: 0x001C7B6C File Offset: 0x001C5D6C
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 910f)
			{
				this.HBJJOCHGOPH = 460f;
			}
			this.OIMMPLPBLBK().SetFloat("Vertical", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("#ok", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1361f, 1637f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D12 RID: 23826 RVA: 0x001C7C14 File Offset: 0x001C5E14
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 182f)
			{
				this.HBJJOCHGOPH = 846f;
			}
			this.DNLMFEGJJDD().SetFloat("_History4ChromaTex", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetVector("_TileTexDebug", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 716f, 1006f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D13 RID: 23827 RVA: 0x001C7035 File Offset: 0x001C5235
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D14 RID: 23828 RVA: 0x001C7CBB File Offset: 0x001C5EBB
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D15 RID: 23829 RVA: 0x001C7CF2 File Offset: 0x001C5EF2
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D16 RID: 23830 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x06005D17 RID: 23831 RVA: 0x001C7D2C File Offset: 0x001C5F2C
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
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D18 RID: 23832 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06005D19 RID: 23833 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06005D1A RID: 23834 RVA: 0x001C7DD4 File Offset: 0x001C5FD4
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1375f)
			{
				this.HBJJOCHGOPH = 1824f;
			}
			this.IIJMIPBMMBF().SetFloat("settings.enablerankingnotifications", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 959f, 1555f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D1B RID: 23835 RVA: 0x001C7035 File Offset: 0x001C5235
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0400096B RID: 2411
	public Shader SCShader;

	// Token: 0x0400096C RID: 2412
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400096D RID: 2413
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400096E RID: 2414
	private Material BJFKDHHMLJH;
}
