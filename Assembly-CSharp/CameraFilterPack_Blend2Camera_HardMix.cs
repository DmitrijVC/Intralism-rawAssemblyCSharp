using System;
using UnityEngine;

// Token: 0x02000046 RID: 70
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/HardMix")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_HardMix : MonoBehaviour
{
	// Token: 0x0600135C RID: 4956 RVA: 0x00081359 File Offset: 0x0007F559
	private void GJPONJKJICG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 117);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600135D RID: 4957 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x0600135E RID: 4958 RVA: 0x00081394 File Offset: 0x0007F594
	private void JILOMOBDPIA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -97);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600135F RID: 4959 RVA: 0x00081400 File Offset: 0x0007F600
	private void HMPGIFBJFIK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 58);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001360 RID: 4960 RVA: 0x00081469 File Offset: 0x0007F669
	private void BDBKIEIIFPB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -20);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001361 RID: 4961 RVA: 0x000814A4 File Offset: 0x0007F6A4
	private void IHLMNAGPKDA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 22);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001362 RID: 4962 RVA: 0x0008150D File Offset: 0x0007F70D
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

	// Token: 0x06001363 RID: 4963 RVA: 0x00081548 File Offset: 0x0007F748
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1557f)
			{
				this.HBJJOCHGOPH = 393f;
			}
			if (this.Camera2 != null)
			{
				this.IGIAPKPKGPK().SetTexture("player.bluebat", this.JDMCFBKJHDD);
			}
			this.GKILCDHJFEG().SetFloat("CheckCombo", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("_MainTex2", this.BlendFX);
			this.GKILCDHJFEG().SetFloat("FPSToggle", this.SwitchCameraToCamera2);
			this.HFBJAOFLCJI().SetVector("#ok", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1261f, 1135f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001364 RID: 4964 RVA: 0x00081642 File Offset: 0x0007F842
	private void MBNMADBPDLL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -27);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001365 RID: 4965 RVA: 0x0008150D File Offset: 0x0007F70D
	private void PKBENONAOOL()
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

	// Token: 0x06001366 RID: 4966 RVA: 0x0008167D File Offset: 0x0007F87D
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001367 RID: 4967 RVA: 0x000816B4 File Offset: 0x0007F8B4
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1461f)
			{
				this.HBJJOCHGOPH = 648f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("_MainTex2", this.JDMCFBKJHDD);
			}
			this.PGPEMMBJOOG().SetFloat("deleteall", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("[Up-Left]", this.BlendFX);
			this.GKILCDHJFEG().SetFloat("QuickSave", this.SwitchCameraToCamera2);
			this.GKILCDHJFEG().SetVector(">", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 746f, 137f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001369 RID: 4969 RVA: 0x000817D7 File Offset: 0x0007F9D7
	private void MOEPJDOFBHA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 47);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600136A RID: 4970 RVA: 0x00081812 File Offset: 0x0007FA12
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600136B RID: 4971 RVA: 0x00081849 File Offset: 0x0007FA49
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600136C RID: 4972 RVA: 0x00081880 File Offset: 0x0007FA80
	private void CCLNNLCOPBL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 99);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600136D RID: 4973 RVA: 0x0008150D File Offset: 0x0007F70D
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

	// Token: 0x0600136E RID: 4974 RVA: 0x000818E9 File Offset: 0x0007FAE9
	private void OnValidate()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600136F RID: 4975 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06001370 RID: 4976 RVA: 0x00081924 File Offset: 0x0007FB24
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1526f)
			{
				this.HBJJOCHGOPH = 998f;
			}
			if (this.Camera2 != null)
			{
				this.JIBOKBCPDLC().SetTexture("BitsData", this.JDMCFBKJHDD);
			}
			this.DEFBJOCJJKF().SetFloat("/", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("shader.ghost", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.SwitchCameraToCamera2);
			this.IGIAPKPKGPK().SetVector("CheckCombo", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1049f, 1304f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001371 RID: 4977 RVA: 0x0008150D File Offset: 0x0007F70D
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

	// Token: 0x06001372 RID: 4978 RVA: 0x0008150D File Offset: 0x0007F70D
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

	// Token: 0x06001373 RID: 4979 RVA: 0x00081A1E File Offset: 0x0007FC1E
	private void LHBDPDOBNAK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 9);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001374 RID: 4980 RVA: 0x00081A5C File Offset: 0x0007FC5C
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

	// Token: 0x06001375 RID: 4981 RVA: 0x00081B56 File Offset: 0x0007FD56
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001376 RID: 4982 RVA: 0x0008150D File Offset: 0x0007F70D
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

	// Token: 0x06001377 RID: 4983 RVA: 0x00081B8D File Offset: 0x0007FD8D
	private void FBIIBKKCOKO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 41);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x1700002D RID: 45
	// (get) Token: 0x06001378 RID: 4984 RVA: 0x00081BC8 File Offset: 0x0007FDC8
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

	// Token: 0x06001379 RID: 4985 RVA: 0x00081C00 File Offset: 0x0007FE00
	private void EPEGAEGDJAM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -52);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600137A RID: 4986 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600137B RID: 4987 RVA: 0x00081C69 File Offset: 0x0007FE69
	private void FCKIJIKNMCF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 112);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600137C RID: 4988 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x0600137D RID: 4989 RVA: 0x00081CA4 File Offset: 0x0007FEA4
	private void GPJHPNGNEBP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -127);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600137E RID: 4990 RVA: 0x00081CDF File Offset: 0x0007FEDF
	private void ACBAHLCGNDD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -2);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600137F RID: 4991 RVA: 0x00081D1A File Offset: 0x0007FF1A
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001380 RID: 4992 RVA: 0x00081D51 File Offset: 0x0007FF51
	private void BNIIBNCLHFA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 59);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001381 RID: 4993 RVA: 0x0008150D File Offset: 0x0007F70D
	private void ODAIMOJLJOF()
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

	// Token: 0x06001382 RID: 4994 RVA: 0x00081D8C File Offset: 0x0007FF8C
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001383 RID: 4995 RVA: 0x0008150D File Offset: 0x0007F70D
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

	// Token: 0x06001384 RID: 4996 RVA: 0x00081DC4 File Offset: 0x0007FFC4
	private void NNCCPEBIAKH()
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

	// Token: 0x06001385 RID: 4997 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06001386 RID: 4998 RVA: 0x00081E30 File Offset: 0x00080030
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

	// Token: 0x06001387 RID: 4999 RVA: 0x00081E99 File Offset: 0x00080099
	private void ENDDDMALLBK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -30);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001388 RID: 5000 RVA: 0x00081ED4 File Offset: 0x000800D4
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001389 RID: 5001 RVA: 0x00081F0B File Offset: 0x0008010B
	private void FGIOPGGPLMB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 15);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600138A RID: 5002 RVA: 0x000818E9 File Offset: 0x0007FAE9
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600138B RID: 5003 RVA: 0x00081F48 File Offset: 0x00080148
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 203f)
			{
				this.HBJJOCHGOPH = 1f;
			}
			if (this.Camera2 != null)
			{
				this.GKILCDHJFEG().SetTexture("Set sun min/max size", this.JDMCFBKJHDD);
			}
			this.GKILCDHJFEG().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetFloat("BitsData", this.BlendFX);
			this.GKILCDHJFEG().SetFloat("workshop.", this.SwitchCameraToCamera2);
			this.IGIAPKPKGPK().SetVector("HandsCountSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 406f, 1008f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600138C RID: 5004 RVA: 0x00082042 File Offset: 0x00080242
	private void EJNKBOLGHJC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 27);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600138D RID: 5005 RVA: 0x0008150D File Offset: 0x0007F70D
	private void DPFOEBCADNP()
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

	// Token: 0x040002BB RID: 699
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_HardMix";

	// Token: 0x040002BC RID: 700
	public Shader SCShader;

	// Token: 0x040002BD RID: 701
	public Camera Camera2;

	// Token: 0x040002BE RID: 702
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040002BF RID: 703
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040002C0 RID: 704
	private Material BJFKDHHMLJH;

	// Token: 0x040002C1 RID: 705
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x040002C2 RID: 706
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x040002C3 RID: 707
	private RenderTexture JDMCFBKJHDD;
}
