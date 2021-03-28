using System;
using UnityEngine;

// Token: 0x02000092 RID: 146
[AddComponentMenu("Camera Filter Pack/Distortion/ShockWave Manual")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_ShockWaveManual : MonoBehaviour
{
	// Token: 0x06002ABE RID: 10942 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06002ABF RID: 10943 RVA: 0x000E89A8 File Offset: 0x000E6BA8
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1377f)
			{
				this.HBJJOCHGOPH = 1878f;
			}
			this.KAFBNOBOIAJ().SetFloat("Tab1Content", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("#", this.PosX);
			this.ABHDNGIHBKE().SetFloat("[MapsData] Base maps loaded", this.PosY);
			this.GJHLADDCMFF().SetFloat("Anomaly_Intensity", this.Value);
			this.KJMECMIGJJA().SetFloat("_Value4", this.Size);
			this.NFMGLIKNOOC().SetVector("EXCEPTION:", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1750f, 226f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BBIMPFGLDCP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002AC0 RID: 10944 RVA: 0x000E8AA8 File Offset: 0x000E6CA8
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 455f)
			{
				this.HBJJOCHGOPH = 1568f;
			}
			this.OIBHFCLJKDB().SetFloat("CameraFilterPack/Drawing_Crosshatch", this.HBJJOCHGOPH);
			this.MLMKCOINOOH().SetFloat("PublishMapButton", this.PosX);
			this.IFMAPIDFNLI().SetFloat("No valid adaptive tonemapper type found!", this.PosY);
			this.KHCLIAMBBNC().SetFloat("_ScreenResolution", this.Value);
			this.IIBLJCKLGFG().SetFloat("BadgeText", this.Size);
			this.EJDPNJAEAKJ().SetVector("_RgbTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1472f, 1727f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002AC1 RID: 10945 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002AC2 RID: 10946 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002AC3 RID: 10947 RVA: 0x000E8BC4 File Offset: 0x000E6DC4
	private void DFFKKLAPHCC()
	{
		this.SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002AC4 RID: 10948 RVA: 0x000E8BE8 File Offset: 0x000E6DE8
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 848f)
			{
				this.HBJJOCHGOPH = 1584f;
			}
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/FX_DigitalMatrix", this.HBJJOCHGOPH);
			this.IGIAPKPKGPK().SetFloat("RecieveChatMessage", this.PosX);
			this.OIBHFCLJKDB().SetFloat("[FileSelector] Dialog canceled", this.PosY);
			this.MNLKBFFKHIE().SetFloat("player.arrow", this.Value);
			this.EHDJJANLINB().SetFloat("_Light", this.Size);
			this.KAFBNOBOIAJ().SetVector(".status", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 658f, 461f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002AC5 RID: 10949 RVA: 0x000E8CE7 File Offset: 0x000E6EE7
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002AC6 RID: 10950 RVA: 0x000E8D20 File Offset: 0x000E6F20
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 150f)
			{
				this.HBJJOCHGOPH = 1110f;
			}
			this.DONENAMLFLF().SetFloat("#yes", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("GlassesColor", this.PosX);
			this.IGIAPKPKGPK().SetFloat(": ", this.PosY);
			this.BBIMPFGLDCP().SetFloat("' has been reset to the fault value", this.Value);
			this.MLMKCOINOOH().SetFloat("Operation failed: ", this.Size);
			this.EHDJJANLINB().SetVector("float,1.5", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1791f, 665f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PLBEJJIHFPB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002AC7 RID: 10951 RVA: 0x000E8E20 File Offset: 0x000E7020
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 594f)
			{
				this.HBJJOCHGOPH = 948f;
			}
			this.IFMAPIDFNLI().SetFloat("{0} minutes ago", this.HBJJOCHGOPH);
			this.IGIAPKPKGPK().SetFloat("_FixDistance", this.PosX);
			this.GJHLADDCMFF().SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.PosY);
			this.ENKPNJMPDEB().SetFloat("float,1", this.Value);
			this.ABHDNGIHBKE().SetFloat("Set particles start speed", this.Size);
			this.KEMAALEODNH().SetVector(". Not Destroying GameObject or PhotonViews!", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1273f, 1683f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002AC8 RID: 10952 RVA: 0x000E8F20 File Offset: 0x000E7120
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 91f)
			{
				this.HBJJOCHGOPH = 1075f;
			}
			this.DNLMFEGJJDD().SetFloat("getbool", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("BadgeImage", this.PosX);
			this.AELJLBOJAIL().SetFloat("_Colorisation", this.PosY);
			this.EJDPNJAEAKJ().SetFloat("_TimeX", this.Value);
			this.EJDPNJAEAKJ().SetFloat("Reconnect() failed. It seems the client wasn't connected before?! Current state: ", this.Size);
			this.ENKPNJMPDEB().SetVector("_SizeY", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 810f, 1555f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002AC9 RID: 10953 RVA: 0x000E901F File Offset: 0x000E721F
	private void JONGNKNLLND()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002ACA RID: 10954 RVA: 0x000E9044 File Offset: 0x000E7244
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1341f)
			{
				this.HBJJOCHGOPH = 1624f;
			}
			this.EFMCNLELMDO().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.ENKPNJMPDEB().SetFloat("CameraFilterPack/TV_ARCADE_Fast", this.PosX);
			this.EFMCNLELMDO().SetFloat("_Noise", this.PosY);
			this.KEMAALEODNH().SetFloat("_Value7", this.Value);
			this.EHDJJANLINB().SetFloat("bad", this.Size);
			this.EFMCNLELMDO().SetVector("ItemNameText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 707f, 1384f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002ACB RID: 10955 RVA: 0x000E9144 File Offset: 0x000E7344
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1218f)
			{
				this.HBJJOCHGOPH = 1167f;
			}
			this.PLBEJJIHFPB().SetFloat("received</b>\n#reason: ", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("CameraFilterPack/Colors_Adjust_FullColors", this.PosX);
			this.OKJOKHGJHGF().SetFloat("Brightness", this.PosY);
			this.IONHGBPGCHK().SetFloat("mainMenu", this.Value);
			this.EJDPNJAEAKJ().SetFloat("Spawn ark to be pressed at this time", this.Size);
			this.NBPKMLMCHFN.SetVector("LoadingStatusText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1685f, 360f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002ACC RID: 10956 RVA: 0x0002523B File Offset: 0x0002343B
	private void ANKIJGCGCBF()
	{
	}

	// Token: 0x06002ACD RID: 10957 RVA: 0x000E9243 File Offset: 0x000E7443
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002ACE RID: 10958 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLDHEJIEDHO()
	{
	}

	// Token: 0x06002ACF RID: 10959 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06002AD0 RID: 10960 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void NDDNJNCINDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002AD1 RID: 10961 RVA: 0x000E9267 File Offset: 0x000E7467
	private Material KHCLIAMBBNC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002AD2 RID: 10962 RVA: 0x000E929E File Offset: 0x000E749E
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002AD3 RID: 10963 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06002AD4 RID: 10964 RVA: 0x000E92D5 File Offset: 0x000E74D5
	private void DOKAKEMDALN()
	{
		this.SCShader = Shader.Find("cancel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002AD5 RID: 10965 RVA: 0x000E92F9 File Offset: 0x000E74F9
	private void CCFEDENFNEF()
	{
		this.SCShader = Shader.Find("Scrollbar");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002AD6 RID: 10966 RVA: 0x000E9320 File Offset: 0x000E7520
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.PosX);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.PosY);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Value);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Size);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002AD7 RID: 10967 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void KLDNGKBMDAN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002AD8 RID: 10968 RVA: 0x000E941F File Offset: 0x000E761F
	private Material OIBHFCLJKDB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002AD9 RID: 10969 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002ADA RID: 10970 RVA: 0x000E9456 File Offset: 0x000E7656
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-68);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002ADB RID: 10971 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void EFECEKPFOEM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002ADC RID: 10972 RVA: 0x000E9490 File Offset: 0x000E7690
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 888f)
			{
				this.HBJJOCHGOPH = 200f;
			}
			this.NFMGLIKNOOC().SetFloat(": ", this.HBJJOCHGOPH);
			this.MLMKCOINOOH().SetFloat("_Value3", this.PosX);
			this.KHCLIAMBBNC().SetFloat("_Colored", this.PosY);
			this.NFMGLIKNOOC().SetFloat("SetSatelliteRadius", this.Value);
			this.AELJLBOJAIL().SetFloat("\n\n#", this.Size);
			this.KJMECMIGJJA().SetVector("#failed!", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1449f, 1619f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002ADD RID: 10973 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void AMHEJBMLFNM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002ADE RID: 10974 RVA: 0x000E958F File Offset: 0x000E778F
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002ADF RID: 10975 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x06002AE0 RID: 10976 RVA: 0x000E95C8 File Offset: 0x000E77C8
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1859f)
			{
				this.HBJJOCHGOPH = 94f;
			}
			this.KAFBNOBOIAJ().SetFloat("ItemNameBGImage", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("_NoiseScale", this.PosX);
			this.DONENAMLFLF().SetFloat("_ScreenResolution", this.PosY);
			this.EJDPNJAEAKJ().SetFloat("LastNewsButton", this.Value);
			this.ABHDNGIHBKE().SetFloat("max. lives color", this.Size);
			this.BBIMPFGLDCP().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1133f, 858f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002AE1 RID: 10977 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002AE2 RID: 10978 RVA: 0x000E96C7 File Offset: 0x000E78C7
	private void FLKEJJEGCFA()
	{
		this.SCShader = Shader.Find("_Brightness");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002AE3 RID: 10979 RVA: 0x000E96EB File Offset: 0x000E78EB
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x17000077 RID: 119
	// (get) Token: 0x06002AE4 RID: 10980 RVA: 0x000E9722 File Offset: 0x000E7922
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

	// Token: 0x06002AE5 RID: 10981 RVA: 0x000E975C File Offset: 0x000E795C
	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 39f)
			{
				this.HBJJOCHGOPH = 760f;
			}
			this.EFMCNLELMDO().SetFloat("Player Connected", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("_DotSize", this.PosX);
			this.IIBLJCKLGFG().SetFloat("_Value2", this.PosY);
			this.OIBHFCLJKDB().SetFloat("Bass", this.Value);
			this.MNLKBFFKHIE().SetFloat("BestScoreText", this.Size);
			this.KEMAALEODNH().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 814f, 750f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002AE6 RID: 10982 RVA: 0x000E985C File Offset: 0x000E7A5C
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1220f)
			{
				this.HBJJOCHGOPH = 592f;
			}
			this.KEMAALEODNH().SetFloat("_Val", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("UseScanLineSize", this.PosX);
			this.IONHGBPGCHK().SetFloat("_Extra2", this.PosY);
			this.EFMCNLELMDO().SetFloat("/", this.Value);
			this.AELJLBOJAIL().SetFloat("_SpawnHeuristic", this.Size);
			this.EHDJJANLINB().SetVector("GroupNameText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 361f, 1978f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002AE7 RID: 10983 RVA: 0x000E995B File Offset: 0x000E7B5B
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)72;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002AE9 RID: 10985 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x06002AEA RID: 10986 RVA: 0x000E99D4 File Offset: 0x000E7BD4
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 500f)
			{
				this.HBJJOCHGOPH = 1523f;
			}
			this.KJMECMIGJJA().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.MLMKCOINOOH().SetFloat("_Red_B", this.PosX);
			this.BBIMPFGLDCP().SetFloat("other.dust1", this.PosY);
			this.ENKPNJMPDEB().SetFloat("_ExposureAdjustment", this.Value);
			this.BBIMPFGLDCP().SetFloat("_TimeX", this.Size);
			this.IGIAPKPKGPK().SetVector("CameraFilterPack/Blur_Steam", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 474f, 1737f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ENKPNJMPDEB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002AEB RID: 10987 RVA: 0x000E9AD4 File Offset: 0x000E7CD4
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1311f)
			{
				this.HBJJOCHGOPH = 992f;
			}
			this.IGIAPKPKGPK().SetFloat("<size=24>", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.PosX);
			this.DONENAMLFLF().SetFloat("The observed monobehaviour (", this.PosY);
			this.BBIMPFGLDCP().SetFloat(".", this.Value);
			this.DNLMFEGJJDD().SetFloat("_ScreenResolution", this.Size);
			this.ABHDNGIHBKE().SetVector(".lastCheckpoint.powerupsScore", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 380f, 1714f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002AEC RID: 10988 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002AED RID: 10989 RVA: 0x000E9BD3 File Offset: 0x000E7DD3
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002AEE RID: 10990 RVA: 0x000E9BF7 File Offset: 0x000E7DF7
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002AEF RID: 10991 RVA: 0x000E9C30 File Offset: 0x000E7E30
	private void NPBDIMJDMGA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 817f)
			{
				this.HBJJOCHGOPH = 1723f;
			}
			this.IONHGBPGCHK().SetFloat("RoomDescriptionText", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat(" ", this.PosX);
			this.DNLMFEGJJDD().SetFloat("/../", this.PosY);
			this.MNLKBFFKHIE().SetFloat("_Value4", this.Value);
			this.IONHGBPGCHK().SetFloat("[Right-Left]", this.Size);
			this.IFMAPIDFNLI().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1839f, 1010f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002AF0 RID: 10992 RVA: 0x000E9D2F File Offset: 0x000E7F2F
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Lut_Simple");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002AF1 RID: 10993 RVA: 0x000E9D53 File Offset: 0x000E7F53
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002AF2 RID: 10994 RVA: 0x000E9D78 File Offset: 0x000E7F78
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 504f)
			{
				this.HBJJOCHGOPH = 527f;
			}
			this.NFMGLIKNOOC().SetFloat("icon", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("_Blue_R", this.PosX);
			this.PLBEJJIHFPB().SetFloat("settings_bindings_controller_type", this.PosY);
			this.KHCLIAMBBNC().SetFloat("r", this.Value);
			this.KHCLIAMBBNC().SetFloat("_Red_C", this.Size);
			this.EJDPNJAEAKJ().SetVector("Y", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 59f, 1722f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002AF3 RID: 10995 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x06002AF4 RID: 10996 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x06002AF5 RID: 10997 RVA: 0x000E9E77 File Offset: 0x000E8077
	private Material MLMKCOINOOH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002AF6 RID: 10998 RVA: 0x000E9EAE File Offset: 0x000E80AE
	private void LGHCJCFHEMF()
	{
		this.SCShader = Shader.Find("JoinButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002AF7 RID: 10999 RVA: 0x000E9ED4 File Offset: 0x000E80D4
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 315f)
			{
				this.HBJJOCHGOPH = 1463f;
			}
			this.KHCLIAMBBNC().SetFloat("LetterSpacing: Missing Text component", this.HBJJOCHGOPH);
			this.ENKPNJMPDEB().SetFloat("[PhotonMessageInfo: Sender='{1}' Senttime={0}]", this.PosX);
			this.OIBHFCLJKDB().SetFloat("/?player=", this.PosY);
			this.GJHLADDCMFF().SetFloat("_Value2", this.Value);
			this.MNLKBFFKHIE().SetFloat("Loading inventory", this.Size);
			this.PLBEJJIHFPB().SetVector("_BlurParams", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 394f, 216f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002AF8 RID: 11000 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void FMHOHGEAIEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002AF9 RID: 11001 RVA: 0x000E9FD3 File Offset: 0x000E81D3
	private void AIBNKIDADPI()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002AFA RID: 11002 RVA: 0x000E9FF8 File Offset: 0x000E81F8
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 867f)
			{
				this.HBJJOCHGOPH = 683f;
			}
			this.DNLMFEGJJDD().SetFloat("Texture2", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("Select", this.PosX);
			this.EJDPNJAEAKJ().SetFloat("_MainTex2", this.PosY);
			this.EHDJJANLINB().SetFloat("CameraFilterPack/TV_WideScreenCircle", this.Value);
			this.EJDPNJAEAKJ().SetFloat("ResourceIDInputField", this.Size);
			this.DONENAMLFLF().SetVector("y", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1432f, 73f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002AFB RID: 11003 RVA: 0x000EA0F7 File Offset: 0x000E82F7
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002AFC RID: 11004 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002AFD RID: 11005 RVA: 0x000EA12E File Offset: 0x000E832E
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002AFE RID: 11006 RVA: 0x000EA165 File Offset: 0x000E8365
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002AFF RID: 11007 RVA: 0x000EA19C File Offset: 0x000E839C
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B00 RID: 11008 RVA: 0x000EA1D4 File Offset: 0x000E83D4
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 489f)
			{
				this.HBJJOCHGOPH = 1263f;
			}
			this.MLMKCOINOOH().SetFloat("settings_bindings_sec_", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("Called GetNumberOfCurrentPlayers()", this.PosX);
			this.IONHGBPGCHK().SetFloat("grid", this.PosY);
			this.KHCLIAMBBNC().SetFloat("_Red_C", this.Value);
			this.EHDJJANLINB().SetFloat("_ProjInfo", this.Size);
			this.DNLMFEGJJDD().SetVector("\" that takes ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1782f, 1682f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B01 RID: 11009 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void BNCLKHOEGDK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B02 RID: 11010 RVA: 0x000EA2D4 File Offset: 0x000E84D4
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1153f)
			{
				this.HBJJOCHGOPH = 599f;
			}
			this.EFMCNLELMDO().SetFloat("icon", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("[Left]", this.PosX);
			this.EJDPNJAEAKJ().SetFloat(";", this.PosY);
			this.IIBLJCKLGFG().SetFloat("$ {0}", this.Value);
			this.MNLKBFFKHIE().SetFloat(" Time: ", this.Size);
			this.KAFBNOBOIAJ().SetVector("menu.selectedplaymode", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1078f, 13f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B03 RID: 11011 RVA: 0x000EA3D3 File Offset: 0x000E85D3
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_Drost");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002B04 RID: 11012 RVA: 0x000EA3F7 File Offset: 0x000E85F7
	private void MEBPBNLBECA()
	{
		this.SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002B05 RID: 11013 RVA: 0x000EA41C File Offset: 0x000E861C
	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1019f)
			{
				this.HBJJOCHGOPH = 510f;
			}
			this.DONENAMLFLF().SetFloat("InfoCanvas", this.HBJJOCHGOPH);
			this.OIBHFCLJKDB().SetFloat("_Value3", this.PosX);
			this.EJDPNJAEAKJ().SetFloat("MenuScene", this.PosY);
			this.KHCLIAMBBNC().SetFloat("_CenterX", this.Value);
			this.GJHLADDCMFF().SetFloat("_FixDistance", this.Size);
			this.ABHDNGIHBKE().SetVector("In Network lobby", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 566f, 1712f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B06 RID: 11014 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B07 RID: 11015 RVA: 0x000EA51B File Offset: 0x000E871B
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_ShockWaveManual");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002B08 RID: 11016 RVA: 0x000EA53F File Offset: 0x000E873F
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find("#md5submitionfailed: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002B09 RID: 11017 RVA: 0x000EA563 File Offset: 0x000E8763
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002B0A RID: 11018 RVA: 0x0002523B File Offset: 0x0002343B
	private void ODCJJFBJJNF()
	{
	}

	// Token: 0x06002B0B RID: 11019 RVA: 0x000EA587 File Offset: 0x000E8787
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("b");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002B0C RID: 11020 RVA: 0x000EA5AC File Offset: 0x000E87AC
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1619f)
			{
				this.HBJJOCHGOPH = 1151f;
			}
			this.KAFBNOBOIAJ().SetFloat("powerup.0", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("[PlayerController] ", this.PosX);
			this.KEMAALEODNH().SetFloat(" not exist", this.PosY);
			this.KAFBNOBOIAJ().SetFloat("Data/Editor/leveltemplate", this.Value);
			this.IIBLJCKLGFG().SetFloat("mapselector.orderby", this.Size);
			this.PLBEJJIHFPB().SetVector("Connecting", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1584f, 1445f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B0D RID: 11021 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x06002B0E RID: 11022 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B0F RID: 11023 RVA: 0x000EA6AB File Offset: 0x000E88AB
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("_Value6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002B10 RID: 11024 RVA: 0x000EA6CF File Offset: 0x000E88CF
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("_Overlay");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002B11 RID: 11025 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06002B12 RID: 11026 RVA: 0x000EA6F3 File Offset: 0x000E88F3
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find("_Green_R");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002B13 RID: 11027 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B14 RID: 11028 RVA: 0x000EA717 File Offset: 0x000E8917
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B15 RID: 11029 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B16 RID: 11030 RVA: 0x000EA74E File Offset: 0x000E894E
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B17 RID: 11031 RVA: 0x000EA785 File Offset: 0x000E8985
	private void NEFHGMNAPEP()
	{
		this.SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002B18 RID: 11032 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B19 RID: 11033 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B1A RID: 11034 RVA: 0x000EA7A9 File Offset: 0x000E89A9
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("/Segment-[Up]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002B1B RID: 11035 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBFJAOINHMK()
	{
	}

	// Token: 0x06002B1C RID: 11036 RVA: 0x000EA7CD File Offset: 0x000E89CD
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("settings_bindings_");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002B1D RID: 11037 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B1E RID: 11038 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B1F RID: 11039 RVA: 0x000EA7F1 File Offset: 0x000E89F1
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B20 RID: 11040 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void HLHJBJGEEEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B21 RID: 11041 RVA: 0x000EA828 File Offset: 0x000E8A28
	private void KHIGHFJKPFG()
	{
		this.SCShader = Shader.Find("Other");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002B22 RID: 11042 RVA: 0x0002523B File Offset: 0x0002343B
	private void KDJEJBBDILE()
	{
	}

	// Token: 0x06002B23 RID: 11043 RVA: 0x000EA84C File Offset: 0x000E8A4C
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1957f)
			{
				this.HBJJOCHGOPH = 1265f;
			}
			this.BBIMPFGLDCP().SetFloat("<b>#", this.HBJJOCHGOPH);
			this.BBIMPFGLDCP().SetFloat("#orderby:", this.PosX);
			this.ABHDNGIHBKE().SetFloat("\" gets executed locally only, if at all.", this.PosY);
			this.IONHGBPGCHK().SetFloat(".r", this.Value);
			this.NBPKMLMCHFN.SetFloat("???", this.Size);
			this.NFMGLIKNOOC().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 896f, 1068f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B24 RID: 11044 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void FAMLCFNDGNI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B25 RID: 11045 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFMEAMBLODG()
	{
	}

	// Token: 0x06002B26 RID: 11046 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B27 RID: 11047 RVA: 0x000EA94C File Offset: 0x000E8B4C
	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1134f)
			{
				this.HBJJOCHGOPH = 445f;
			}
			this.GJHLADDCMFF().SetFloat("Chat", this.HBJJOCHGOPH);
			this.KHCLIAMBBNC().SetFloat("Localization Servise\nWorking commands:\nset <language>\nlist\nkeys", this.PosX);
			this.KJMECMIGJJA().SetFloat("Multiplayer", this.PosY);
			this.OIBHFCLJKDB().SetFloat("CameraFilterPack_Broken_Screen1", this.Value);
			this.MLMKCOINOOH().SetFloat("RateButton", this.Size);
			this.MNLKBFFKHIE().SetVector("_Offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 926f, 1242f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B28 RID: 11048 RVA: 0x000EAA4B File Offset: 0x000E8C4B
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B29 RID: 11049 RVA: 0x000EAA84 File Offset: 0x000E8C84
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 556f)
			{
				this.HBJJOCHGOPH = 609f;
			}
			this.IFMAPIDFNLI().SetFloat(":</b> ", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("Up", this.PosX);
			this.DONENAMLFLF().SetFloat("#000000", this.PosY);
			this.OIBHFCLJKDB().SetFloat("id", this.Value);
			this.KEMAALEODNH().SetFloat("_Value4", this.Size);
			this.ABHDNGIHBKE().SetVector(" - LOCAL", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1029f, 1569f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BBIMPFGLDCP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B2A RID: 11050 RVA: 0x000EAB84 File Offset: 0x000E8D84
	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 90f)
			{
				this.HBJJOCHGOPH = 1568f;
			}
			this.ENKPNJMPDEB().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("CameraFilterPack/TV_Noise", this.PosX);
			this.KJMECMIGJJA().SetFloat("LoadPlayerEnvironment", this.PosY);
			this.IIBLJCKLGFG().SetFloat("RB", this.Value);
			this.PLBEJJIHFPB().SetFloat("_Value2", this.Size);
			this.GJHLADDCMFF().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1884f, 1851f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B2B RID: 11051 RVA: 0x000EAC83 File Offset: 0x000E8E83
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B2C RID: 11052 RVA: 0x000EACBA File Offset: 0x000E8EBA
	private void ECBILENEOOL()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002B2D RID: 11053 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x06002B2E RID: 11054 RVA: 0x000EACDE File Offset: 0x000E8EDE
	private Material MNLKBFFKHIE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B2F RID: 11055 RVA: 0x000EAD15 File Offset: 0x000E8F15
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("ClearEnvironment");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002B30 RID: 11056 RVA: 0x000EAD39 File Offset: 0x000E8F39
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-79);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B31 RID: 11057 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void OOGIHDLBBLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B32 RID: 11058 RVA: 0x000EAD70 File Offset: 0x000E8F70
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("Could not find RPC with index: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002B33 RID: 11059 RVA: 0x000EAD94 File Offset: 0x000E8F94
	private void KPOCGNOKNOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1032f)
			{
				this.HBJJOCHGOPH = 149f;
			}
			this.EHDJJANLINB().SetFloat("menuVolume", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("[MenuScene] Error: ", this.PosX);
			this.PLBEJJIHFPB().SetFloat("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", this.PosY);
			this.KJMECMIGJJA().SetFloat("bad", this.Value);
			this.DNLMFEGJJDD().SetFloat(".lastCheckpoint.powerupsScore", this.Size);
			this.EFMCNLELMDO().SetVector("[SERVER] Selected map: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1725f, 1930f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B34 RID: 11060 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B35 RID: 11061 RVA: 0x000EAE94 File Offset: 0x000E9094
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1150f)
			{
				this.HBJJOCHGOPH = 850f;
			}
			this.AELJLBOJAIL().SetFloat("_NoiseTex", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("ERROR: Preview file name in modName.workshop.json doesn't match any file", this.PosX);
			this.IONHGBPGCHK().SetFloat("JoinButton", this.PosY);
			this.IONHGBPGCHK().SetFloat("intensity", this.Value);
			this.NBPKMLMCHFN.SetFloat("/", this.Size);
			this.EFMCNLELMDO().SetVector("1", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1384f, 434f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B36 RID: 11062 RVA: 0x000EAF94 File Offset: 0x000E9194
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 961f)
			{
				this.HBJJOCHGOPH = 1070f;
			}
			this.KAFBNOBOIAJ().SetFloat("Lag ", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat(":", this.PosX);
			this.KJMECMIGJJA().SetFloat("workshop.txt", this.PosY);
			this.OIBHFCLJKDB().SetFloat("_AccumulationTex", this.Value);
			this.NBPKMLMCHFN.SetFloat("_HeightParams", this.Size);
			this.ABHDNGIHBKE().SetVector("Source: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1177f, 50f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B37 RID: 11063 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B38 RID: 11064 RVA: 0x000EB094 File Offset: 0x000E9294
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1516f)
			{
				this.HBJJOCHGOPH = 305f;
			}
			this.EFMCNLELMDO().SetFloat("SetParticlesParticleSpeed", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("_MatrixColor", this.PosX);
			this.KHCLIAMBBNC().SetFloat("_Offsets", this.PosY);
			this.DONENAMLFLF().SetFloat("_Value3", this.Value);
			this.MLMKCOINOOH().SetFloat("/", this.Size);
			this.AELJLBOJAIL().SetVector("RecieveChatActionMessage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1463f, 560f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B39 RID: 11065 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B3A RID: 11066 RVA: 0x000E8BA7 File Offset: 0x000E6DA7
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002B3B RID: 11067 RVA: 0x000EB193 File Offset: 0x000E9393
	private Material ENKPNJMPDEB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)112;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B3C RID: 11068 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002B3D RID: 11069 RVA: 0x000EB1CC File Offset: 0x000E93CC
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1041f)
			{
				this.HBJJOCHGOPH = 851f;
			}
			this.DNLMFEGJJDD().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.MNLKBFFKHIE().SetFloat("mainmenu", this.PosX);
			this.IIBLJCKLGFG().SetFloat("0,1,false", this.PosY);
			this.KEMAALEODNH().SetFloat("CameraFilterPack/Blend2Camera_Subtract", this.Value);
			this.KAFBNOBOIAJ().SetFloat("_ScreenResolution", this.Size);
			this.IIBLJCKLGFG().SetVector("LostLive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1318f, 554f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002B3E RID: 11070 RVA: 0x000EB2CB File Offset: 0x000E94CB
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B3F RID: 11071 RVA: 0x000EB302 File Offset: 0x000E9502
	private Material BBIMPFGLDCP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002B40 RID: 11072 RVA: 0x000EB33C File Offset: 0x000E953C
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1672f)
			{
				this.HBJJOCHGOPH = 1273f;
			}
			this.KEMAALEODNH().SetFloat(",", this.HBJJOCHGOPH);
			this.MNLKBFFKHIE().SetFloat("attempted to spawn a GameObject from recycle bin (", this.PosX);
			this.NFMGLIKNOOC().SetFloat(" BETA", this.PosY);
			this.IGIAPKPKGPK().SetFloat("_Value4", this.Value);
			this.EJDPNJAEAKJ().SetFloat("_ScreenResolution", this.Size);
			this.EFMCNLELMDO().SetVector("Uploading content", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1131f, 355f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0400051F RID: 1311
	public Shader SCShader;

	// Token: 0x04000520 RID: 1312
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000521 RID: 1313
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000522 RID: 1314
	private Material BJFKDHHMLJH;

	// Token: 0x04000523 RID: 1315
	[Range(-1.5f, 1.5f)]
	public float PosX = 0.5f;

	// Token: 0x04000524 RID: 1316
	[Range(-1.5f, 1.5f)]
	public float PosY = 0.5f;

	// Token: 0x04000525 RID: 1317
	[Range(-0.1f, 2f)]
	public float Value = 0.5f;

	// Token: 0x04000526 RID: 1318
	[Range(0f, 10f)]
	public float Size = 1f;
}
