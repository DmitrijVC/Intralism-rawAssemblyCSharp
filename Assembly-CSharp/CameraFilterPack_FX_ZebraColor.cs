using System;
using UnityEngine;

// Token: 0x020000D7 RID: 215
[AddComponentMenu("Camera Filter Pack/FX/ZebraColor")]
[ExecuteInEditMode]
public class CameraFilterPack_FX_ZebraColor : MonoBehaviour
{
	// Token: 0x060041B3 RID: 16819 RVA: 0x00143917 File Offset: 0x00141B17
	private void BOPKKCAFODF()
	{
		this.SCShader = Shader.Find("OnPlayerGameMessage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060041B4 RID: 16820 RVA: 0x0014393B File Offset: 0x00141B3B
	private Material GBFOAHKAJEK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060041B5 RID: 16821 RVA: 0x00143972 File Offset: 0x00141B72
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060041B6 RID: 16822 RVA: 0x00143972 File Offset: 0x00141B72
	private void FJABOCDLCAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060041B7 RID: 16823 RVA: 0x00143990 File Offset: 0x00141B90
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1465f)
			{
				this.HBJJOCHGOPH = 69f;
			}
			this.INOBFNCKFGK().SetFloat("0,7,true,0", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("Set Sun Input", this.Value);
			this.LPCHMEKDCHI().SetVector("RecieveChatActionMessage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 232f, 831f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060041B8 RID: 16824 RVA: 0x00143A50 File Offset: 0x00141C50
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1901f)
			{
				this.HBJJOCHGOPH = 1008f;
			}
			this.CEKJODEAMGB().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.IKAIDLJKLFC().SetFloat("_SmoothEnd", this.Value);
			this.LPCHMEKDCHI().SetVector("Show Title", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1117f, 1266f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060041BA RID: 16826 RVA: 0x00143972 File Offset: 0x00141B72
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060041BB RID: 16827 RVA: 0x00143972 File Offset: 0x00141B72
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060041BC RID: 16828 RVA: 0x00143B2C File Offset: 0x00141D2C
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 813f)
			{
				this.HBJJOCHGOPH = 1849f;
			}
			this.HNFFHCLNBDN().SetFloat("achievements.21.progress", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("ZoomFade", this.Value);
			this.NLFJGMBCICG().SetVector("challenges/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1553f, 1831f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060041BD RID: 16829 RVA: 0x0002523B File Offset: 0x0002343B
	private void KPNKCNJBMKB()
	{
	}

	// Token: 0x060041BE RID: 16830 RVA: 0x00143BEC File Offset: 0x00141DEC
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 680f)
			{
				this.HBJJOCHGOPH = 1958f;
			}
			this.INOBFNCKFGK().SetFloat("icon", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("\n", this.Value);
			this.GJHLADDCMFF().SetVector("Connection error: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 349f, 1047f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060041BF RID: 16831 RVA: 0x00143CA9 File Offset: 0x00141EA9
	private void PCHCFIOHIKK()
	{
		this.SCShader = Shader.Find("Avoid using this directly. Thanks.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060041C0 RID: 16832 RVA: 0x00143CCD File Offset: 0x00141ECD
	private void PEDHPEMNHBF()
	{
		this.SCShader = Shader.Find("_Blend");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060041C1 RID: 16833 RVA: 0x00143CF1 File Offset: 0x00141EF1
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060041C2 RID: 16834 RVA: 0x00143D28 File Offset: 0x00141F28
	private Material IOHHLNAPGMA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060041C3 RID: 16835 RVA: 0x00143D5F File Offset: 0x00141F5F
	private Material HHLFDHNEIAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060041C4 RID: 16836 RVA: 0x00143972 File Offset: 0x00141B72
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060041C5 RID: 16837 RVA: 0x00143D96 File Offset: 0x00141F96
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060041C6 RID: 16838 RVA: 0x00143DCD File Offset: 0x00141FCD
	private void AEDDNDHCLNN()
	{
		this.SCShader = Shader.Find("offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060041C7 RID: 16839 RVA: 0x00143DF1 File Offset: 0x00141FF1
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060041C8 RID: 16840 RVA: 0x00143972 File Offset: 0x00141B72
	private void JMAIIENCEKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060041C9 RID: 16841 RVA: 0x00143E28 File Offset: 0x00142028
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 568f)
			{
				this.HBJJOCHGOPH = 1932f;
			}
			this.GBFOAHKAJEK().SetFloat("Set Crosshair Emission", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("FPSToggle", this.Value);
			this.ACHNOHCLGOO().SetVector(". Set PhotonNetwork.OnEventCall.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1394f, 173f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060041CA RID: 16842 RVA: 0x00143EE5 File Offset: 0x001420E5
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060041CB RID: 16843 RVA: 0x00143972 File Offset: 0x00141B72
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060041CC RID: 16844 RVA: 0x00143F1C File Offset: 0x0014211C
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1478f)
			{
				this.HBJJOCHGOPH = 1123f;
			}
			this.IOHHLNAPGMA().SetFloat("Floating point textures aren't supported on this device ({0})", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("Prints list of all previous commands", this.Value);
			this.HEINDEMCGIK().SetVector("AudioSampler", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 81f, 156f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060041CD RID: 16845 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x060041CE RID: 16846 RVA: 0x00143FD9 File Offset: 0x001421D9
	private Material DIOAAHJDMLK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060041CF RID: 16847 RVA: 0x00144010 File Offset: 0x00142210
	private void DOKAKEMDALN()
	{
		this.SCShader = Shader.Find(" while connecting to: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060041D0 RID: 16848 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x060041D1 RID: 16849 RVA: 0x00144034 File Offset: 0x00142234
	private void LFAFJKJAEEL()
	{
		this.SCShader = Shader.Find("_Saturation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060041D2 RID: 16850 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x060041D3 RID: 16851 RVA: 0x00144058 File Offset: 0x00142258
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 562f)
			{
				this.HBJJOCHGOPH = 782f;
			}
			this.NBPKMLMCHFN.SetFloat("y", this.HBJJOCHGOPH);
			this.IFMAPIDFNLI().SetFloat("SetBGColor", this.Value);
			this.CFCPHFMKHII().SetVector("_Near", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1363f, 817f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060041D4 RID: 16852 RVA: 0x00144115 File Offset: 0x00142315
	private void ECBILENEOOL()
	{
		this.SCShader = Shader.Find(" not exist");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060041D5 RID: 16853 RVA: 0x00144139 File Offset: 0x00142339
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("_LowRez");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060041D6 RID: 16854 RVA: 0x00143972 File Offset: 0x00141B72
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060041D7 RID: 16855 RVA: 0x00144160 File Offset: 0x00142360
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1344f)
			{
				this.HBJJOCHGOPH = 662f;
			}
			this.GBFOAHKAJEK().SetFloat("PossibleMapPointsText", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat("NEW_ACHIEVEMENT_1_", this.Value);
			this.IFMAPIDFNLI().SetVector("_Sensitivity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1161f, 1859f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060041D8 RID: 16856 RVA: 0x00144220 File Offset: 0x00142420
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 362f)
			{
				this.HBJJOCHGOPH = 984f;
			}
			this.HEINDEMCGIK().SetFloat("_FixDistance", this.HBJJOCHGOPH);
			this.ECCPAOBFDKP().SetFloat("Tab2Content", this.Value);
			this.MALMMJNPILJ().SetVector("input", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1680f, 1686f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060041D9 RID: 16857 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x060041DA RID: 16858 RVA: 0x001442DD File Offset: 0x001424DD
	private void JKBMKPDGCHG()
	{
		this.SCShader = Shader.Find("distance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060041DB RID: 16859 RVA: 0x00144301 File Offset: 0x00142501
	private Material INOBFNCKFGK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-98);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060041DC RID: 16860 RVA: 0x00144338 File Offset: 0x00142538
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_ZebraColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060041DD RID: 16861 RVA: 0x0014435C File Offset: 0x0014255C
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060041DE RID: 16862 RVA: 0x00144380 File Offset: 0x00142580
	private void FEKECCBFGMI()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060041DF RID: 16863 RVA: 0x001443A4 File Offset: 0x001425A4
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Value);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060041E0 RID: 16864 RVA: 0x00144461 File Offset: 0x00142661
	private void JFJLGJEPEAA()
	{
		this.SCShader = Shader.Find("mapselector.filter.rateduponly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060041E1 RID: 16865 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x060041E2 RID: 16866 RVA: 0x00144485 File Offset: 0x00142685
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("IconImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060041E3 RID: 16867 RVA: 0x001444A9 File Offset: 0x001426A9
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060041E4 RID: 16868 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x060041E5 RID: 16869 RVA: 0x001444E0 File Offset: 0x001426E0
	private void FMNPFCHBLJF()
	{
		this.SCShader = Shader.Find("menu.selectedplaymode");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060041E6 RID: 16870 RVA: 0x00144504 File Offset: 0x00142704
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 425f)
			{
				this.HBJJOCHGOPH = 435f;
			}
			this.KEMJNOMIPHN().SetFloat("CameraFilterPack/TV_Vignetting", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("_Radius", this.Value);
			this.CFCPHFMKHII().SetVector("y", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1068f, 1485f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060041E7 RID: 16871 RVA: 0x001445C4 File Offset: 0x001427C4
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 815f)
			{
				this.HBJJOCHGOPH = 100f;
			}
			this.MCDGIILBNIF().SetFloat("Bad parameters for set! Use <language>", this.HBJJOCHGOPH);
			this.IOHHLNAPGMA().SetFloat("_Offset", this.Value);
			this.HEINDEMCGIK().SetVector("[DiscordController] Init", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 146f, 181f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060041E8 RID: 16872 RVA: 0x00144681 File Offset: 0x00142881
	private void IKDNLHLBHID()
	{
		this.SCShader = Shader.Find("Joystick1Button6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060041E9 RID: 16873 RVA: 0x001446A5 File Offset: 0x001428A5
	private void MDNHCLKNCLE()
	{
		this.SCShader = Shader.Find("BitsData");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060041EA RID: 16874 RVA: 0x001446C9 File Offset: 0x001428C9
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060041EB RID: 16875 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x060041EC RID: 16876 RVA: 0x00144700 File Offset: 0x00142900
	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 977f)
			{
				this.HBJJOCHGOPH = 869f;
			}
			this.ACHNOHCLGOO().SetFloat("[PhotonMessageInfo: Sender='{1}' Senttime={0}]", this.HBJJOCHGOPH);
			this.IFMAPIDFNLI().SetFloat("_TimeX", this.Value);
			this.IKAIDLJKLFC().SetVector("\n", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 393f, 343f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GBFOAHKAJEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060041ED RID: 16877 RVA: 0x001447BD File Offset: 0x001429BD
	private void EIMNPCMHJLJ()
	{
		this.SCShader = Shader.Find("FullscreenToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060041EE RID: 16878 RVA: 0x00143972 File Offset: 0x00141B72
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060041EF RID: 16879 RVA: 0x00143972 File Offset: 0x00141B72
	private void OMFBGCMHNBM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060041F0 RID: 16880 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x060041F1 RID: 16881 RVA: 0x001447E1 File Offset: 0x001429E1
	private void HDMDKOKOOJC()
	{
		this.SCShader = Shader.Find("/icon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060041F2 RID: 16882 RVA: 0x00144808 File Offset: 0x00142A08
	private void EKCJHNJGGAB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 82f)
			{
				this.HBJJOCHGOPH = 221f;
			}
			this.NLFJGMBCICG().SetFloat("CameraFilterPack/EXTRA_SHOWFPS", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("RB", this.Value);
			this.CFCPHFMKHII().SetVector("menu.enableselectormusic", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1364f, 796f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IKAIDLJKLFC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060041F3 RID: 16883 RVA: 0x001448C5 File Offset: 0x00142AC5
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060041F4 RID: 16884 RVA: 0x001448E9 File Offset: 0x00142AE9
	private void IPJFFIDBPFE()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060041F5 RID: 16885 RVA: 0x0014490D File Offset: 0x00142B0D
	private Material MALMMJNPILJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)78;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060041F6 RID: 16886 RVA: 0x00144944 File Offset: 0x00142B44
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1351f)
			{
				this.HBJJOCHGOPH = 1585f;
			}
			this.CFEDGDGBCHE().SetFloat("/Segment-[Right]", this.HBJJOCHGOPH);
			this.MALMMJNPILJ().SetFloat("'{0}' \t{1}ms \t{2}", this.Value);
			this.IIJMIPBMMBF().SetVector("_Bloom0", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 375f, 1269f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060041F7 RID: 16887 RVA: 0x00143972 File Offset: 0x00141B72
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060041F8 RID: 16888 RVA: 0x00144A01 File Offset: 0x00142C01
	private Material IKAIDLJKLFC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)69;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060041F9 RID: 16889 RVA: 0x00144A38 File Offset: 0x00142C38
	private void IJMAPHMBFJI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1301f)
			{
				this.HBJJOCHGOPH = 1f;
			}
			this.GBFOAHKAJEK().SetFloat("settings.fps", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("#", this.Value);
			this.CFCPHFMKHII().SetVector("settings.gamemessagesduration", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1843f, 79f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IKAIDLJKLFC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060041FA RID: 16890 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x060041FB RID: 16891 RVA: 0x00144AF8 File Offset: 0x00142CF8
	private void AIKDNGCEDAB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 377f)
			{
				this.HBJJOCHGOPH = 1555f;
			}
			this.KEMAALEODNH().SetFloat("ItemNameText", this.HBJJOCHGOPH);
			this.CEKJODEAMGB().SetFloat(". Verify the Prefab is in a Resources folder (and not in a subfolder)", this.Value);
			this.OKJOKHGJHGF().SetVector("_Green_R", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1781f, 1230f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060041FC RID: 16892 RVA: 0x001448E9 File Offset: 0x00142AE9
	private void HPFIHLMKIPF()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060041FD RID: 16893 RVA: 0x00144BB5 File Offset: 0x00142DB5
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("ControllerRightY");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060041FE RID: 16894 RVA: 0x0002523B File Offset: 0x0002343B
	private void MKKJICPMPHK()
	{
	}

	// Token: 0x060041FF RID: 16895 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x170000BD RID: 189
	// (get) Token: 0x06004200 RID: 16896 RVA: 0x00144BD9 File Offset: 0x00142DD9
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

	// Token: 0x06004201 RID: 16897 RVA: 0x00143972 File Offset: 0x00141B72
	private void EKPLGFAEOBE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004202 RID: 16898 RVA: 0x00143972 File Offset: 0x00141B72
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004203 RID: 16899 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x06004204 RID: 16900 RVA: 0x00144C10 File Offset: 0x00142E10
	private void IGPCNCJIEOJ()
	{
		this.SCShader = Shader.Find("[SERVER] Player ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004205 RID: 16901 RVA: 0x00144C34 File Offset: 0x00142E34
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004206 RID: 16902 RVA: 0x00144C58 File Offset: 0x00142E58
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004207 RID: 16903 RVA: 0x00144C8F File Offset: 0x00142E8F
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)82;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004208 RID: 16904 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06004209 RID: 16905 RVA: 0x0002523B File Offset: 0x0002343B
	private void COMNAPAAPDO()
	{
	}

	// Token: 0x0600420A RID: 16906 RVA: 0x00144CC6 File Offset: 0x00142EC6
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600420B RID: 16907 RVA: 0x00144CFD File Offset: 0x00142EFD
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600420C RID: 16908 RVA: 0x00144D34 File Offset: 0x00142F34
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600420D RID: 16909 RVA: 0x00143972 File Offset: 0x00141B72
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600420E RID: 16910 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x0600420F RID: 16911 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCDLIKEDMCF()
	{
	}

	// Token: 0x06004210 RID: 16912 RVA: 0x00144D58 File Offset: 0x00142F58
	private void LGHCJCFHEMF()
	{
		this.SCShader = Shader.Find("_DiffuseColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004211 RID: 16913 RVA: 0x00143972 File Offset: 0x00141B72
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004212 RID: 16914 RVA: 0x00143972 File Offset: 0x00141B72
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004213 RID: 16915 RVA: 0x00144D7C File Offset: 0x00142F7C
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 940f)
			{
				this.HBJJOCHGOPH = 802f;
			}
			this.EGOGECOEONM().SetFloat("EndlessLoopsScoreText", this.HBJJOCHGOPH);
			this.EGOGECOEONM().SetFloat("{0:0} day{1}, ", this.Value);
			this.KEMJNOMIPHN().SetVector("Working commands:\nreset <challengeid>\nresetall", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1723f, 563f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IOHHLNAPGMA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004214 RID: 16916 RVA: 0x00144E39 File Offset: 0x00143039
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004215 RID: 16917 RVA: 0x00144E70 File Offset: 0x00143070
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004216 RID: 16918 RVA: 0x00144EA8 File Offset: 0x001430A8
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 523f)
			{
				this.HBJJOCHGOPH = 494f;
			}
			this.OKJOKHGJHGF().SetFloat("#discord{0}joinrequest", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("_MainTex", this.Value);
			this.CFCPHFMKHII().SetVector("_Amount", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1997f, 191f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004217 RID: 16919 RVA: 0x00143972 File Offset: 0x00141B72
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004218 RID: 16920 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06004219 RID: 16921 RVA: 0x00143972 File Offset: 0x00141B72
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600421A RID: 16922 RVA: 0x00144F68 File Offset: 0x00143168
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1876f)
			{
				this.HBJJOCHGOPH = 1833f;
			}
			this.INOBFNCKFGK().SetFloat("Prints the number of logs currently held by DebugLogs", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat("LoadingStatusText", this.Value);
			this.KEMAALEODNH().SetVector("_BlurPass", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1776f, 759f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600421B RID: 16923 RVA: 0x00143972 File Offset: 0x00141B72
	private void EFECEKPFOEM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600421C RID: 16924 RVA: 0x00145025 File Offset: 0x00143225
	private void ADPLHDFJFID()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600421D RID: 16925 RVA: 0x00143972 File Offset: 0x00141B72
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600421E RID: 16926 RVA: 0x0002523B File Offset: 0x0002343B
	private void JCGMGLMADEN()
	{
	}

	// Token: 0x0600421F RID: 16927 RVA: 0x0014504C File Offset: 0x0014324C
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 491f)
			{
				this.HBJJOCHGOPH = 961f;
			}
			this.KEMJNOMIPHN().SetFloat("\n\n#", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("MenuScene", this.Value);
			this.NLFJGMBCICG().SetVector("Joystick1Button11", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1383f, 1476f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004220 RID: 16928 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06004221 RID: 16929 RVA: 0x0014510C File Offset: 0x0014330C
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 480f)
			{
				this.HBJJOCHGOPH = 47f;
			}
			this.NLFJGMBCICG().SetFloat("levelcompleted", this.HBJJOCHGOPH);
			this.MALMMJNPILJ().SetFloat("SaveGameName is null or empty!", this.Value);
			this.KEMAALEODNH().SetVector("_MatrixSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 461f, 1976f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004222 RID: 16930 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06004223 RID: 16931 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKMELABKBHO()
	{
	}

	// Token: 0x06004224 RID: 16932 RVA: 0x001451CC File Offset: 0x001433CC
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 744f)
			{
				this.HBJJOCHGOPH = 1606f;
			}
			this.OKJOKHGJHGF().SetFloat("Joined room ", this.HBJJOCHGOPH);
			this.MALMMJNPILJ().SetFloat("_TimeX", this.Value);
			this.DIOAAHJDMLK().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1212f, 1567f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004225 RID: 16933 RVA: 0x00145289 File Offset: 0x00143489
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004226 RID: 16934 RVA: 0x001452C0 File Offset: 0x001434C0
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004227 RID: 16935 RVA: 0x001452F7 File Offset: 0x001434F7
	private void DPLLKHHLDBB()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Manga_Color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004228 RID: 16936 RVA: 0x0014531B File Offset: 0x0014351B
	private Material HJGEHJDMCGI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004229 RID: 16937 RVA: 0x00145352 File Offset: 0x00143552
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("{0} months ago");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600422A RID: 16938 RVA: 0x00143972 File Offset: 0x00141B72
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600422B RID: 16939 RVA: 0x00145378 File Offset: 0x00143578
	private void PODKOCOPGLC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 817f)
			{
				this.HBJJOCHGOPH = 578f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("(master)", this.Value);
			this.HEINDEMCGIK().SetVector("Joystick1Button7", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 54f, 969f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600422C RID: 16940 RVA: 0x00143972 File Offset: 0x00141B72
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600422D RID: 16941 RVA: 0x00144461 File Offset: 0x00142661
	private void CCFEDENFNEF()
	{
		this.SCShader = Shader.Find("mapselector.filter.rateduponly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600422E RID: 16942 RVA: 0x00145438 File Offset: 0x00143638
	private void OIKAPFGPLML(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1378f)
			{
				this.HBJJOCHGOPH = 127f;
			}
			this.LPCHMEKDCHI().SetFloat("_Params", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("_ScreenResolution", this.Value);
			this.EFDEIFCDAFG().SetVector("SpawnObj", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 721f, 300f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BKKJJJGADLM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600422F RID: 16943 RVA: 0x0002523B File Offset: 0x0002343B
	private void JFMIDILENDO()
	{
	}

	// Token: 0x06004230 RID: 16944 RVA: 0x001454F8 File Offset: 0x001436F8
	private void DHLCNIINMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1938f)
			{
				this.HBJJOCHGOPH = 327f;
			}
			this.GJHPODJOBHL().SetFloat("settings.volume.menu", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("DPADHOR", this.Value);
			this.OKJOKHGJHGF().SetVector("Joystick1Button2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1157f, 418f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004231 RID: 16945 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06004232 RID: 16946 RVA: 0x001455B8 File Offset: 0x001437B8
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1335f)
			{
				this.HBJJOCHGOPH = 754f;
			}
			this.GBFOAHKAJEK().SetFloat("\" for viewID ", this.HBJJOCHGOPH);
			this.IOHHLNAPGMA().SetFloat("[LevelEditorScene] Creating new item...", this.Value);
			this.EFDEIFCDAFG().SetVector("#", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1042f, 218f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004233 RID: 16947 RVA: 0x00143972 File Offset: 0x00141B72
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004234 RID: 16948 RVA: 0x00145678 File Offset: 0x00143878
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 641f)
			{
				this.HBJJOCHGOPH = 1409f;
			}
			this.HNFFHCLNBDN().SetFloat("OK", this.HBJJOCHGOPH);
			this.IKAIDLJKLFC().SetFloat("score", this.Value);
			this.HEINDEMCGIK().SetVector("tintColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 754f, 845f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GBFOAHKAJEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004235 RID: 16949 RVA: 0x00145738 File Offset: 0x00143938
	private void HNMIAKKBMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 157f)
			{
				this.HBJJOCHGOPH = 266f;
			}
			this.EFDEIFCDAFG().SetFloat("Coord", this.HBJJOCHGOPH);
			this.GBFOAHKAJEK().SetFloat("ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?", this.Value);
			this.ACHNOHCLGOO().SetVector("CameraFilterPack/Colors_DarkColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 411f, 293f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HJGEHJDMCGI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004236 RID: 16950 RVA: 0x00143972 File Offset: 0x00141B72
	private void ABHEJPAGNMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004237 RID: 16951 RVA: 0x001457F5 File Offset: 0x001439F5
	private Material GJHPODJOBHL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004238 RID: 16952 RVA: 0x0014582C File Offset: 0x00143A2C
	private Material CFCPHFMKHII()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004239 RID: 16953 RVA: 0x00145864 File Offset: 0x00143A64
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 183f)
			{
				this.HBJJOCHGOPH = 1773f;
			}
			this.DIOAAHJDMLK().SetFloat("Editor/", this.HBJJOCHGOPH);
			this.IFMAPIDFNLI().SetFloat("LetterSpacing: Missing Text component", this.Value);
			this.MALMMJNPILJ().SetVector("PLEASE WAIT", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 938f, 477f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600423A RID: 16954 RVA: 0x00143972 File Offset: 0x00141B72
	private void AMHEJBMLFNM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600423B RID: 16955 RVA: 0x00145921 File Offset: 0x00143B21
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("The given 2D texture ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600423C RID: 16956 RVA: 0x0002523B File Offset: 0x0002343B
	private void COGBDFKOHKK()
	{
	}

	// Token: 0x0600423D RID: 16957 RVA: 0x00143972 File Offset: 0x00141B72
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600423E RID: 16958 RVA: 0x00145948 File Offset: 0x00143B48
	private void HAAFIECGECG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 673f)
			{
				this.HBJJOCHGOPH = 1467f;
			}
			this.ACHNOHCLGOO().SetFloat("CameraFilterPack/FX_InverChromiLum", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("AllocateViewID() failed. Room (user {0}) is out of 'scene' viewIDs. It seems all available are in use.", this.Value);
			this.NBPKMLMCHFN.SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1709f, 434f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600423F RID: 16959 RVA: 0x00145A05 File Offset: 0x00143C05
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("_Value7");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06004240 RID: 16960 RVA: 0x00143972 File Offset: 0x00141B72
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004241 RID: 16961 RVA: 0x00145A29 File Offset: 0x00143C29
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004242 RID: 16962 RVA: 0x00145A60 File Offset: 0x00143C60
	private void FIKNBPAIFBI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1377f)
			{
				this.HBJJOCHGOPH = 1259f;
			}
			this.KEMJNOMIPHN().SetFloat("0.00", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("_EmissionColor", this.Value);
			this.DIOAAHJDMLK().SetVector("': ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 47f, 139f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004243 RID: 16963 RVA: 0x00143972 File Offset: 0x00141B72
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06004244 RID: 16964 RVA: 0x00145B1D File Offset: 0x00143D1D
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004245 RID: 16965 RVA: 0x00145B54 File Offset: 0x00143D54
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 180f)
			{
				this.HBJJOCHGOPH = 1262f;
			}
			this.IFMAPIDFNLI().SetFloat("(http|https)://([\\w+?\\.\\w+])+([a-zA-Z0-9\\~\\!\\@\\#\\$\\%\\^\\&amp;\\*\\(\\)_\\-\\=\\+\\\\\\/\\?\\.\\:\\;\\'\\,]*)?\\.(jpg|jpeg|gif|png)", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", this.Value);
			this.LPCHMEKDCHI().SetVector(" not exist", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 810f, 1170f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06004246 RID: 16966 RVA: 0x00145C11 File Offset: 0x00143E11
	private Material ECCPAOBFDKP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004247 RID: 16967 RVA: 0x00145C48 File Offset: 0x00143E48
	private Material EGOGECOEONM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)74;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06004248 RID: 16968 RVA: 0x00145C7F File Offset: 0x00143E7F
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("_Value5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06004249 RID: 16969 RVA: 0x00145CA3 File Offset: 0x00143EA3
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("Cant send PickupItem spawn times to unknown targetPlayer.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600424A RID: 16970 RVA: 0x00145CC7 File Offset: 0x00143EC7
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("UsernameText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600424B RID: 16971 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x040006ED RID: 1773
	public Shader SCShader;

	// Token: 0x040006EE RID: 1774
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040006EF RID: 1775
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040006F0 RID: 1776
	private Material BJFKDHHMLJH;

	// Token: 0x040006F1 RID: 1777
	[Range(1f, 10f)]
	public float Value = 3f;
}
