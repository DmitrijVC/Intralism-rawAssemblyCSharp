using System;
using UnityEngine;

// Token: 0x02000127 RID: 295
[AddComponentMenu("Camera Filter Pack/TV/Videoflip")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_Videoflip : MonoBehaviour
{
	// Token: 0x06005D1C RID: 23836 RVA: 0x001C7E7C File Offset: 0x001C607C
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 641f)
			{
				this.HBJJOCHGOPH = 1058f;
			}
			this.IGIAPKPKGPK().SetFloat("settings.enablerankingnotifications", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetVector("RB", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 802f, 970f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D1D RID: 23837 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBDEJFCNOBF()
	{
	}

	// Token: 0x06005D1E RID: 23838 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06005D1F RID: 23839 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x06005D20 RID: 23840 RVA: 0x001C7F23 File Offset: 0x001C6123
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005D21 RID: 23841 RVA: 0x001C7F47 File Offset: 0x001C6147
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("/../");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005D22 RID: 23842 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x06005D23 RID: 23843 RVA: 0x001C7F6C File Offset: 0x001C616C
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1568f)
			{
				this.HBJJOCHGOPH = 1484f;
			}
			this.INOBFNCKFGK().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.IGIAPKPKGPK().SetVector("Edited unlock conditions", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1358f, 222f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MPENCEIGLEH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D24 RID: 23844 RVA: 0x001C8013 File Offset: 0x001C6213
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D26 RID: 23846 RVA: 0x001C8060 File Offset: 0x001C6260
	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1874f)
			{
				this.HBJJOCHGOPH = 1300f;
			}
			this.NBPKMLMCHFN.SetFloat("_Red_C", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetVector("SpectatingUserInfo", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1012f, 1096f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D27 RID: 23847 RVA: 0x001C8107 File Offset: 0x001C6307
	private void HNGHDAPKEJG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x1700010C RID: 268
	// (get) Token: 0x06005D28 RID: 23848 RVA: 0x001C8124 File Offset: 0x001C6324
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

	// Token: 0x06005D29 RID: 23849 RVA: 0x001C8107 File Offset: 0x001C6307
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D2A RID: 23850 RVA: 0x001C815C File Offset: 0x001C635C
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1051f)
			{
				this.HBJJOCHGOPH = 263f;
			}
			this.MMOODGIODPC().SetFloat("CameraFilterPack/TV_Chromatical2", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetVector("#tryagain", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 178f, 943f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFKFAAHHLLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D2B RID: 23851 RVA: 0x001C8203 File Offset: 0x001C6403
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_Videoflip");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005D2C RID: 23852 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x06005D2D RID: 23853 RVA: 0x001C8227 File Offset: 0x001C6427
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D2E RID: 23854 RVA: 0x001C8260 File Offset: 0x001C6460
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

	// Token: 0x06005D2F RID: 23855 RVA: 0x001C8307 File Offset: 0x001C6507
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D30 RID: 23856 RVA: 0x001C833E File Offset: 0x001C653E
	private void CEDFFAOOPOG()
	{
		this.SCShader = Shader.Find("_Extra");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005D31 RID: 23857 RVA: 0x001C8364 File Offset: 0x001C6564
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 621f)
			{
				this.HBJJOCHGOPH = 1128f;
			}
			this.INOBFNCKFGK().SetFloat("LastHighScoreText", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetVector("Exit to menu?", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 628f, 1494f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D32 RID: 23858 RVA: 0x001C840B File Offset: 0x001C660B
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D33 RID: 23859 RVA: 0x0002523B File Offset: 0x0002343B
	private void LKJMIODJGCM()
	{
	}

	// Token: 0x06005D34 RID: 23860 RVA: 0x001C8107 File Offset: 0x001C6307
	private void LINKAMEPKGM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D35 RID: 23861 RVA: 0x001C8442 File Offset: 0x001C6642
	private void JFJLGJEPEAA()
	{
		this.SCShader = Shader.Find("CameraFilterPack/AAA_Super_Hexagon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005D36 RID: 23862 RVA: 0x001C8468 File Offset: 0x001C6668
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1875f)
			{
				this.HBJJOCHGOPH = 1606f;
			}
			this.FGENHBKMPDA().SetFloat(" - StoreAuthURLResponse] - ", this.HBJJOCHGOPH);
			this.EOCCJGIGEGJ().SetVector("[MapEditor] Created new map: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 696f, 831f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JCPDCGIJKJD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D37 RID: 23863 RVA: 0x001C8510 File Offset: 0x001C6710
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 241f)
			{
				this.HBJJOCHGOPH = 1585f;
			}
			this.EOCCJGIGEGJ().SetFloat("player.linea", this.HBJJOCHGOPH);
			this.IFMAPIDFNLI().SetVector("PLEASE WAIT", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 570f, 570f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D38 RID: 23864 RVA: 0x001C85B7 File Offset: 0x001C67B7
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("failed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005D39 RID: 23865 RVA: 0x001C85DB File Offset: 0x001C67DB
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)88;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D3A RID: 23866 RVA: 0x001C8612 File Offset: 0x001C6812
	private void ALNNIDLFILB()
	{
		this.SCShader = Shader.Find("Set camera background color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005D3B RID: 23867 RVA: 0x001C8636 File Offset: 0x001C6836
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D3C RID: 23868 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06005D3D RID: 23869 RVA: 0x001C866D File Offset: 0x001C686D
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005D3E RID: 23870 RVA: 0x001C8694 File Offset: 0x001C6894
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 655f)
			{
				this.HBJJOCHGOPH = 1503f;
			}
			this.NFKFAAHHLLM().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1865f, 344f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D3F RID: 23871 RVA: 0x001C873B File Offset: 0x001C693B
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D40 RID: 23872 RVA: 0x001C8107 File Offset: 0x001C6307
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D41 RID: 23873 RVA: 0x001C8772 File Offset: 0x001C6972
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005D42 RID: 23874 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06005D43 RID: 23875 RVA: 0x0002523B File Offset: 0x0002343B
	private void GMELGGJOPBB()
	{
	}

	// Token: 0x06005D44 RID: 23876 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06005D45 RID: 23877 RVA: 0x001C8796 File Offset: 0x001C6996
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("  |  ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005D46 RID: 23878 RVA: 0x001C87BA File Offset: 0x001C69BA
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D47 RID: 23879 RVA: 0x001C8107 File Offset: 0x001C6307
	private void HCDBNAKGDJC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D48 RID: 23880 RVA: 0x001C87F4 File Offset: 0x001C69F4
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1513f)
			{
				this.HBJJOCHGOPH = 1588f;
			}
			this.DKNJGHFLAIF().SetFloat("_Value5", this.HBJJOCHGOPH);
			this.LMLENGFLEBD().SetVector("stretchWidth", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1680f, 156f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D49 RID: 23881 RVA: 0x001C889B File Offset: 0x001C6A9B
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("#no");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005D4A RID: 23882 RVA: 0x001C88C0 File Offset: 0x001C6AC0
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 416f)
			{
				this.HBJJOCHGOPH = 1582f;
			}
			this.PDEAHJPOMEF().SetFloat("move", this.HBJJOCHGOPH);
			this.PGPEMMBJOOG().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1718f, 1991f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D4B RID: 23883 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x06005D4C RID: 23884 RVA: 0x001C8968 File Offset: 0x001C6B68
	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 975f)
			{
				this.HBJJOCHGOPH = 1072f;
			}
			this.DKNJGHFLAIF().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetVector("ticket", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1026f, 1170f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D4D RID: 23885 RVA: 0x001C8107 File Offset: 0x001C6307
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D4E RID: 23886 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06005D4F RID: 23887 RVA: 0x001C8A10 File Offset: 0x001C6C10
	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1310f)
			{
				this.HBJJOCHGOPH = 410f;
			}
			this.INOBFNCKFGK().SetFloat("yyyy", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetVector("EventData0DropDownList", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 146f, 1446f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D50 RID: 23888 RVA: 0x001C8107 File Offset: 0x001C6307
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D51 RID: 23889 RVA: 0x001C8107 File Offset: 0x001C6307
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D52 RID: 23890 RVA: 0x001C8107 File Offset: 0x001C6307
	private void FKDEEJFNNJC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D53 RID: 23891 RVA: 0x001C8AB8 File Offset: 0x001C6CB8
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1052f)
			{
				this.HBJJOCHGOPH = 888f;
			}
			this.BFGNMFCNDBC().SetFloat("Tonemapper curve texture", this.HBJJOCHGOPH);
			this.JCPDCGIJKJD().SetVector("[LobbyPlayerElement] On ready click", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1648f, 391f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D54 RID: 23892 RVA: 0x001C8B5F File Offset: 0x001C6D5F
	private void HIPEHGNBJMN()
	{
		this.SCShader = Shader.Find("Reset");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005D55 RID: 23893 RVA: 0x001C8107 File Offset: 0x001C6307
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D56 RID: 23894 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06005D57 RID: 23895 RVA: 0x001C8B84 File Offset: 0x001C6D84
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 163f)
			{
				this.HBJJOCHGOPH = 1436f;
			}
			this.KEMAALEODNH().SetFloat("settings.hitvariation", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetVector("attempted to spawn a GameObject from recycle bin (", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1370f, 1448f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D58 RID: 23896 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06005D59 RID: 23897 RVA: 0x001C8C2B File Offset: 0x001C6E2B
	private Material JCPDCGIJKJD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D5A RID: 23898 RVA: 0x001C8C62 File Offset: 0x001C6E62
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("_Red_G");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005D5B RID: 23899 RVA: 0x001C8C86 File Offset: 0x001C6E86
	private Material ENKPNJMPDEB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D5C RID: 23900 RVA: 0x001C8CC0 File Offset: 0x001C6EC0
	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 716f)
			{
				this.HBJJOCHGOPH = 1280f;
			}
			this.INOBFNCKFGK().SetFloat(" not found", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetVector("settings_bindings_sec_", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1011f, 1865f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D5D RID: 23901 RVA: 0x001C8D67 File Offset: 0x001C6F67
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D5E RID: 23902 RVA: 0x001C8D9E File Offset: 0x001C6F9E
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-111);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D5F RID: 23903 RVA: 0x001C8DD5 File Offset: 0x001C6FD5
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005D60 RID: 23904 RVA: 0x0002523B File Offset: 0x0002343B
	private void COMNAPAAPDO()
	{
	}

	// Token: 0x06005D61 RID: 23905 RVA: 0x001C8DF9 File Offset: 0x001C6FF9
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)72;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D62 RID: 23906 RVA: 0x001C8E30 File Offset: 0x001C7030
	private void NEFHGMNAPEP()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005D63 RID: 23907 RVA: 0x001C8E54 File Offset: 0x001C7054
	private Material INOBFNCKFGK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D64 RID: 23908 RVA: 0x001C8E8B File Offset: 0x001C708B
	private void LFBGJIIECLD()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005D65 RID: 23909 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKMELABKBHO()
	{
	}

	// Token: 0x06005D66 RID: 23910 RVA: 0x001C8EAF File Offset: 0x001C70AF
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-70);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D67 RID: 23911 RVA: 0x001C8107 File Offset: 0x001C6307
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D68 RID: 23912 RVA: 0x001C8107 File Offset: 0x001C6307
	private void EKPLGFAEOBE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D69 RID: 23913 RVA: 0x001C8107 File Offset: 0x001C6307
	private void JAFOCEDILNK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D6A RID: 23914 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06005D6B RID: 23915 RVA: 0x001C8EE8 File Offset: 0x001C70E8
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1044f)
			{
				this.HBJJOCHGOPH = 1550f;
			}
			this.CECJJMKLEAK().SetFloat("ENABLE_EYE_ADAPTATION", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetVector("{0}_{1}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1767f, 118f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D6C RID: 23916 RVA: 0x001C8F90 File Offset: 0x001C7190
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1846f)
			{
				this.HBJJOCHGOPH = 1889f;
			}
			this.NFMGLIKNOOC().SetFloat(".g", this.HBJJOCHGOPH);
			this.MHBAIEKFBIJ().SetVector("settings.arcshitsoundtimedelay", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 149f, 506f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D6D RID: 23917 RVA: 0x001C9037 File Offset: 0x001C7237
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("mapselector.tags.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005D6E RID: 23918 RVA: 0x001C905B File Offset: 0x001C725B
	private Material MHBAIEKFBIJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D6F RID: 23919 RVA: 0x001C9092 File Offset: 0x001C7292
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D70 RID: 23920 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x06005D71 RID: 23921 RVA: 0x001C90C9 File Offset: 0x001C72C9
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D72 RID: 23922 RVA: 0x001C9100 File Offset: 0x001C7300
	private void MEBPBNLBECA()
	{
		this.SCShader = Shader.Find("{0} years ago");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005D73 RID: 23923 RVA: 0x001C9124 File Offset: 0x001C7324
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1242f)
			{
				this.HBJJOCHGOPH = 248f;
			}
			this.ADBKPGFMNKO().SetFloat("_CenterX", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetVector("EventData0DropDownList", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 26f, 1136f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D74 RID: 23924 RVA: 0x001C91CC File Offset: 0x001C73CC
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 379f)
			{
				this.HBJJOCHGOPH = 1927f;
			}
			this.MPENCEIGLEH().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetVector("CameraFilterPack_Atmosphere_Rain_FX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 803f, 301f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D75 RID: 23925 RVA: 0x001C9273 File Offset: 0x001C7473
	private void EIMNPCMHJLJ()
	{
		this.SCShader = Shader.Find("player.licenceaccepted");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005D76 RID: 23926 RVA: 0x001C9297 File Offset: 0x001C7497
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D77 RID: 23927 RVA: 0x001C92CE File Offset: 0x001C74CE
	private Material MPENCEIGLEH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D78 RID: 23928 RVA: 0x001C9308 File Offset: 0x001C7508
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1747f)
			{
				this.HBJJOCHGOPH = 1313f;
			}
			this.BFGNMFCNDBC().SetFloat("No font defined. Found font: ", this.HBJJOCHGOPH);
			this.IFMAPIDFNLI().SetVector("blue", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 922f, 619f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D79 RID: 23929 RVA: 0x001C8107 File Offset: 0x001C6307
	private void ELDMKIAPNGP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D7A RID: 23930 RVA: 0x001C8107 File Offset: 0x001C6307
	private void LAMEHAHJKMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D7B RID: 23931 RVA: 0x001C93B0 File Offset: 0x001C75B0
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 435f)
			{
				this.HBJJOCHGOPH = 806f;
			}
			this.PGPEMMBJOOG().SetFloat("[GameScene] Checkpoints count: ", this.HBJJOCHGOPH);
			this.LMLENGFLEBD().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1840f, 1896f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D7C RID: 23932 RVA: 0x001C8107 File Offset: 0x001C6307
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D7D RID: 23933 RVA: 0x001C8107 File Offset: 0x001C6307
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D7E RID: 23934 RVA: 0x0002523B File Offset: 0x0002343B
	private void FAKGFMFAPDG()
	{
	}

	// Token: 0x06005D7F RID: 23935 RVA: 0x001C9457 File Offset: 0x001C7657
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D80 RID: 23936 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06005D81 RID: 23937 RVA: 0x001C8107 File Offset: 0x001C6307
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D82 RID: 23938 RVA: 0x001C948E File Offset: 0x001C768E
	private Material NFKFAAHHLLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)83;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D83 RID: 23939 RVA: 0x001C94C5 File Offset: 0x001C76C5
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D84 RID: 23940 RVA: 0x001C94FC File Offset: 0x001C76FC
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)109;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D85 RID: 23941 RVA: 0x001C9533 File Offset: 0x001C7733
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D86 RID: 23942 RVA: 0x001C8107 File Offset: 0x001C6307
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D87 RID: 23943 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06005D88 RID: 23944 RVA: 0x001C8107 File Offset: 0x001C6307
	private void BNCLKHOEGDK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D89 RID: 23945 RVA: 0x001C956A File Offset: 0x001C776A
	private Material CECJJMKLEAK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005D8A RID: 23946 RVA: 0x001C8DD5 File Offset: 0x001C6FD5
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005D8B RID: 23947 RVA: 0x001C8107 File Offset: 0x001C6307
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D8C RID: 23948 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06005D8D RID: 23949 RVA: 0x001C95A1 File Offset: 0x001C77A1
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("TwoHands");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005D8E RID: 23950 RVA: 0x001C95C8 File Offset: 0x001C77C8
	private void JIHNFLGAMJE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1524f)
			{
				this.HBJJOCHGOPH = 1359f;
			}
			this.PDEAHJPOMEF().SetFloat("SaveButton", this.HBJJOCHGOPH);
			this.NFKFAAHHLLM().SetVector(".png", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 314f, 61f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D8F RID: 23951 RVA: 0x001C9670 File Offset: 0x001C7870
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 410f)
			{
				this.HBJJOCHGOPH = 255f;
			}
			this.DKNJGHFLAIF().SetFloat("_Value", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetVector(" GameServer:", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1348f, 917f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D90 RID: 23952 RVA: 0x001C9718 File Offset: 0x001C7918
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1918f)
			{
				this.HBJJOCHGOPH = 495f;
			}
			this.EOCCJGIGEGJ().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.INOBFNCKFGK().SetVector("AudioSampler", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 711f, 564f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D91 RID: 23953 RVA: 0x001C97C0 File Offset: 0x001C79C0
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1360f)
			{
				this.HBJJOCHGOPH = 154f;
			}
			this.FGENHBKMPDA().SetFloat("_BokehParams", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 750f, 543f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D92 RID: 23954 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06005D93 RID: 23955 RVA: 0x0002523B File Offset: 0x0002343B
	private void FJHFOBHJEHL()
	{
	}

	// Token: 0x06005D94 RID: 23956 RVA: 0x001C9868 File Offset: 0x001C7A68
	private void HNMIAKKBMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1748f)
			{
				this.HBJJOCHGOPH = 785f;
			}
			this.ENKPNJMPDEB().SetFloat("player.xp", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetVector("https://steamcommunity.com/sharedfiles/filedetails/?id=", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 454f, 1320f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D95 RID: 23957 RVA: 0x001C8107 File Offset: 0x001C6307
	private void HAHJJPLPOKB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D96 RID: 23958 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x06005D97 RID: 23959 RVA: 0x001C8107 File Offset: 0x001C6307
	private void FMHOHGEAIEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D98 RID: 23960 RVA: 0x001C9910 File Offset: 0x001C7B10
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1333f)
			{
				this.HBJJOCHGOPH = 551f;
			}
			this.LMLENGFLEBD().SetFloat("player.goldbat", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetVector("MaxLivesSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1492f, 1779f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D99 RID: 23961 RVA: 0x001C99B8 File Offset: 0x001C7BB8
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1202f)
			{
				this.HBJJOCHGOPH = 1883f;
			}
			this.LMLENGFLEBD().SetFloat("_EmissionGain", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetVector("Failed to InstantiateSceneObject prefab: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 423f, 768f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005D9A RID: 23962 RVA: 0x0002523B File Offset: 0x0002343B
	private void KDJEJBBDILE()
	{
	}

	// Token: 0x06005D9B RID: 23963 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDBBPKIFNJ()
	{
	}

	// Token: 0x06005D9C RID: 23964 RVA: 0x001C8107 File Offset: 0x001C6307
	private void BNLENEDAHHL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D9D RID: 23965 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06005D9E RID: 23966 RVA: 0x001C8107 File Offset: 0x001C6307
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005D9F RID: 23967 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005DA0 RID: 23968 RVA: 0x001C9A5F File Offset: 0x001C7C5F
	private void DBEMDAJDDDA()
	{
		this.SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005DA1 RID: 23969 RVA: 0x0002523B File Offset: 0x0002343B
	private void GFACKFCEIBC()
	{
	}

	// Token: 0x06005DA2 RID: 23970 RVA: 0x001C9A83 File Offset: 0x001C7C83
	private void JABNHMIHBHC()
	{
		this.SCShader = Shader.Find("0 - background, 1 - foreground");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0400096F RID: 2415
	public Shader SCShader;

	// Token: 0x04000970 RID: 2416
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000971 RID: 2417
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000972 RID: 2418
	private Material BJFKDHHMLJH;
}
