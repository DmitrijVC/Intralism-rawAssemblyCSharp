using System;
using UnityEngine;

// Token: 0x0200009C RID: 156
[AddComponentMenu("Camera Filter Pack/Drawing/Curve")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_Curve : MonoBehaviour
{
	// Token: 0x06002F19 RID: 12057 RVA: 0x000FB215 File Offset: 0x000F9415
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F1A RID: 12058 RVA: 0x000FB232 File Offset: 0x000F9432
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F1B RID: 12059 RVA: 0x000FB269 File Offset: 0x000F9469
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F1C RID: 12060 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x06002F1D RID: 12061 RVA: 0x000FB2A0 File Offset: 0x000F94A0
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("127.0.0.1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002F1E RID: 12062 RVA: 0x000FB2C4 File Offset: 0x000F94C4
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F1F RID: 12063 RVA: 0x000FB2FB File Offset: 0x000F94FB
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find("[Down]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002F20 RID: 12064 RVA: 0x000FB320 File Offset: 0x000F9520
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 550f)
			{
				this.HBJJOCHGOPH = 1575f;
			}
			this.EFMCNLELMDO().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("menutheme.fragout", this.Size);
			this.FEAEGGCNIAA().SetVector("[PlayerBase] Checkpoint error: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 870f, 1319f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F21 RID: 12065 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06002F22 RID: 12066 RVA: 0x000FB3DD File Offset: 0x000F95DD
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F23 RID: 12067 RVA: 0x0002523B File Offset: 0x0002343B
	private void APKNAPHOFHC()
	{
	}

	// Token: 0x06002F24 RID: 12068 RVA: 0x000FB414 File Offset: 0x000F9614
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1123f)
			{
				this.HBJJOCHGOPH = 1089f;
			}
			this.ACHNOHCLGOO().SetFloat("Classical", this.HBJJOCHGOPH);
			this.CFCPHFMKHII().SetFloat("CameraFilterPack/Blend2Camera_Difference", this.Size);
			this.NFMGLIKNOOC().SetVector("OK", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1268f, 976f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKGAONMOBMH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F25 RID: 12069 RVA: 0x000FB4D1 File Offset: 0x000F96D1
	private void FDNONDCGGCG()
	{
		this.SCShader = Shader.Find(".g");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002F26 RID: 12070 RVA: 0x000FB4F5 File Offset: 0x000F96F5
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F27 RID: 12071 RVA: 0x000FB52C File Offset: 0x000F972C
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("_LightIntensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002F28 RID: 12072 RVA: 0x000FB550 File Offset: 0x000F9750
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F29 RID: 12073 RVA: 0x000FB215 File Offset: 0x000F9415
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F2A RID: 12074 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06002F2B RID: 12075 RVA: 0x000FB587 File Offset: 0x000F9787
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("seconds");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002F2C RID: 12076 RVA: 0x000FB5AC File Offset: 0x000F97AC
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Size);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F2D RID: 12077 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06002F2E RID: 12078 RVA: 0x000FB669 File Offset: 0x000F9869
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("/GetNews/pinnednewsid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002F2F RID: 12079 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06002F30 RID: 12080 RVA: 0x000FB68D File Offset: 0x000F988D
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F31 RID: 12081 RVA: 0x000FB215 File Offset: 0x000F9415
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F32 RID: 12082 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKMELABKBHO()
	{
	}

	// Token: 0x06002F33 RID: 12083 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06002F34 RID: 12084 RVA: 0x000FB6C4 File Offset: 0x000F98C4
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F35 RID: 12085 RVA: 0x000FB6FB File Offset: 0x000F98FB
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("_HdrParams");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002F36 RID: 12086 RVA: 0x000FB71F File Offset: 0x000F991F
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F37 RID: 12087 RVA: 0x000FB756 File Offset: 0x000F9956
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F38 RID: 12088 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06002F39 RID: 12089 RVA: 0x000FB215 File Offset: 0x000F9415
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F3A RID: 12090 RVA: 0x000FB78D File Offset: 0x000F998D
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F3B RID: 12091 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002F3C RID: 12092 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x06002F3D RID: 12093 RVA: 0x000FB7C4 File Offset: 0x000F99C4
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 304f)
			{
				this.HBJJOCHGOPH = 397f;
			}
			this.LPDOGGFOBDH().SetFloat(".workshop.json", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("BestScoreText", this.Size);
			this.MMOODGIODPC().SetVector("SetSunDirectionVector", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 645f, 1714f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECJJMKLEAK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F3E RID: 12094 RVA: 0x000FB884 File Offset: 0x000F9A84
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 652f)
			{
				this.HBJJOCHGOPH = 1033f;
			}
			this.AELJLBOJAIL().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("Stream did not contain properly formatted byte array", this.Size);
			this.NFMGLIKNOOC().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 246f, 1347f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F3F RID: 12095 RVA: 0x000FB941 File Offset: 0x000F9B41
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F40 RID: 12096 RVA: 0x000FB978 File Offset: 0x000F9B78
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 536f)
			{
				this.HBJJOCHGOPH = 214f;
			}
			this.LNLKMDPHDCC().SetFloat(" SecondsBeforeRespawn: ", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("_TimeX", this.Size);
			this.KOHGPKOFEJO().SetVector("menu.selectedplaymode", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 264f, 1405f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F41 RID: 12097 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x06002F42 RID: 12098 RVA: 0x000FBA35 File Offset: 0x000F9C35
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("menutheme.idunno");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002F43 RID: 12099 RVA: 0x000FB215 File Offset: 0x000F9415
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F44 RID: 12100 RVA: 0x000FBA59 File Offset: 0x000F9C59
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F45 RID: 12101 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x06002F46 RID: 12102 RVA: 0x000FBA90 File Offset: 0x000F9C90
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F47 RID: 12103 RVA: 0x000FB3DD File Offset: 0x000F95DD
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F48 RID: 12104 RVA: 0x000FBAC8 File Offset: 0x000F9CC8
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1285f)
			{
				this.HBJJOCHGOPH = 93f;
			}
			this.HKGAONMOBMH().SetFloat("offsets", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("menutheme.fragout", this.Size);
			this.ACHNOHCLGOO().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 706f, 755f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F49 RID: 12105 RVA: 0x000FBB85 File Offset: 0x000F9D85
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Curve");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002F4A RID: 12106 RVA: 0x000FBBA9 File Offset: 0x000F9DA9
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("float,1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002F4B RID: 12107 RVA: 0x000FBBD0 File Offset: 0x000F9DD0
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 910f)
			{
				this.HBJJOCHGOPH = 919f;
			}
			this.KJMECMIGJJA().SetFloat("HiddenToggle", this.HBJJOCHGOPH);
			this.IGIAPKPKGPK().SetFloat(" not exist", this.Size);
			this.FEAEGGCNIAA().SetVector("UNDISTORT", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1377f, 716f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F4C RID: 12108 RVA: 0x000FBC8D File Offset: 0x000F9E8D
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002F4D RID: 12109 RVA: 0x000FBCB4 File Offset: 0x000F9EB4
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1760f)
			{
				this.HBJJOCHGOPH = 742f;
			}
			this.HNFFHCLNBDN().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("_TimeX", this.Size);
			this.MMOODGIODPC().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1299f, 838f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F4E RID: 12110 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06002F4F RID: 12111 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x06002F50 RID: 12112 RVA: 0x000FB215 File Offset: 0x000F9415
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F51 RID: 12113 RVA: 0x000FBD74 File Offset: 0x000F9F74
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1980f)
			{
				this.HBJJOCHGOPH = 1263f;
			}
			this.NFMGLIKNOOC().SetFloat("_SearchTex", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat(" not exist", this.Size);
			this.LONNIJMNKFB().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 813f, 451f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F52 RID: 12114 RVA: 0x000FBE31 File Offset: 0x000FA031
	private Material KOHGPKOFEJO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F53 RID: 12115 RVA: 0x000FBE68 File Offset: 0x000FA068
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("_Red_R");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002F54 RID: 12116 RVA: 0x000FB215 File Offset: 0x000F9415
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F55 RID: 12117 RVA: 0x000FB215 File Offset: 0x000F9415
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F56 RID: 12118 RVA: 0x000FBE8C File Offset: 0x000FA08C
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1278f)
			{
				this.HBJJOCHGOPH = 1436f;
			}
			this.EFMCNLELMDO().SetFloat("menu.tabid", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("[Singleton] Using instance of '", this.Size);
			this.IIBLJCKLGFG().SetVector("HandleEventLeave for player ID: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 762f, 1961f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F57 RID: 12119 RVA: 0x000FBF4C File Offset: 0x000FA14C
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 991f)
			{
				this.HBJJOCHGOPH = 1797f;
			}
			this.IGIAPKPKGPK().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("maps.", this.Size);
			this.HNFFHCLNBDN().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 86f, 1962f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F58 RID: 12120 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06002F59 RID: 12121 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06002F5A RID: 12122 RVA: 0x000FB215 File Offset: 0x000F9415
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F5B RID: 12123 RVA: 0x000FC009 File Offset: 0x000FA209
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-90);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F5C RID: 12124 RVA: 0x000FC040 File Offset: 0x000FA240
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F5D RID: 12125 RVA: 0x000FC077 File Offset: 0x000FA277
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F5E RID: 12126 RVA: 0x000FB215 File Offset: 0x000F9415
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F60 RID: 12128 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06002F61 RID: 12129 RVA: 0x000FC0CC File Offset: 0x000FA2CC
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 762f)
			{
				this.HBJJOCHGOPH = 1026f;
			}
			this.EJDPNJAEAKJ().SetFloat("RPC: 'OnAwakeRPC' Parameter: ", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("_Blue_B", this.Size);
			this.GKILCDHJFEG().SetVector(" respawn: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1878f, 1828f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F62 RID: 12130 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x06002F63 RID: 12131 RVA: 0x000FC189 File Offset: 0x000FA389
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F64 RID: 12132 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06002F65 RID: 12133 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x06002F66 RID: 12134 RVA: 0x000FC1C0 File Offset: 0x000FA3C0
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 892f)
			{
				this.HBJJOCHGOPH = 913f;
			}
			this.BLMPMOIDGMG().SetFloat("IconImage", this.HBJJOCHGOPH);
			this.CFCPHFMKHII().SetFloat("_EmissionGain", this.Size);
			this.OKJOKHGJHGF().SetVector(" beatThreshold: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 396f, 894f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F67 RID: 12135 RVA: 0x000FC27D File Offset: 0x000FA47D
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-99);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F68 RID: 12136 RVA: 0x000FC2B4 File Offset: 0x000FA4B4
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 631f)
			{
				this.HBJJOCHGOPH = 956f;
			}
			this.ACHNOHCLGOO().SetFloat("CameraFilterPack/Color_BrightContrastSaturation", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("STOP [R]", this.Size);
			this.LPDOGGFOBDH().SetVector("/Saved Games/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 165f, 1794f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHLADDCMFF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F69 RID: 12137 RVA: 0x000FC371 File Offset: 0x000FA571
	private Material CFCPHFMKHII()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F6A RID: 12138 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x06002F6B RID: 12139 RVA: 0x000FC3A8 File Offset: 0x000FA5A8
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 332f)
			{
				this.HBJJOCHGOPH = 41f;
			}
			this.HNFFHCLNBDN().SetFloat("?", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat(" | ", this.Size);
			this.CFCPHFMKHII().SetVector("_SoftZDistance", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1451f, 1032f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F6C RID: 12140 RVA: 0x000FB215 File Offset: 0x000F9415
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F6D RID: 12141 RVA: 0x000FC465 File Offset: 0x000FA665
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F6E RID: 12142 RVA: 0x000FC49C File Offset: 0x000FA69C
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F6F RID: 12143 RVA: 0x000FC4D3 File Offset: 0x000FA6D3
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-77);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F70 RID: 12144 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x06002F71 RID: 12145 RVA: 0x000FC50A File Offset: 0x000FA70A
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F72 RID: 12146 RVA: 0x000FC541 File Offset: 0x000FA741
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find("Tab1Content");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002F73 RID: 12147 RVA: 0x000FC565 File Offset: 0x000FA765
	private void JECMJNFGBGC()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002F74 RID: 12148 RVA: 0x000FC589 File Offset: 0x000FA789
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002F75 RID: 12149 RVA: 0x000FC5B0 File Offset: 0x000FA7B0
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 777f)
			{
				this.HBJJOCHGOPH = 752f;
			}
			this.CFCPHFMKHII().SetFloat("LevelEditor/CustomEventEditor-Text", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("_Value4", this.Size);
			this.MMOODGIODPC().SetVector("EnableRankedNotificationsToggle", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 715f, 1782f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F76 RID: 12150 RVA: 0x000FB215 File Offset: 0x000F9415
	private void EDCMIPNCPLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F77 RID: 12151 RVA: 0x000FC66D File Offset: 0x000FA86D
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F78 RID: 12152 RVA: 0x000FC6A4 File Offset: 0x000FA8A4
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("OpJoinRoom()");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002F79 RID: 12153 RVA: 0x000FB215 File Offset: 0x000F9415
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F7A RID: 12154 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06002F7B RID: 12155 RVA: 0x000FB215 File Offset: 0x000F9415
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000081 RID: 129
	// (get) Token: 0x06002F7C RID: 12156 RVA: 0x000FC6C8 File Offset: 0x000FA8C8
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

	// Token: 0x06002F7D RID: 12157 RVA: 0x000FC6FF File Offset: 0x000FA8FF
	private void ODBNMPGBCGO()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Oculus_NightVision1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x04000567 RID: 1383
	public Shader SCShader;

	// Token: 0x04000568 RID: 1384
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000569 RID: 1385
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400056A RID: 1386
	private Material BJFKDHHMLJH;

	// Token: 0x0400056B RID: 1387
	[Range(3f, 5f)]
	public float Size = 1f;
}
