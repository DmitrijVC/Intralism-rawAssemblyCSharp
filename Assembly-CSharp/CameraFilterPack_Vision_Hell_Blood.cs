using System;
using UnityEngine;

// Token: 0x02000135 RID: 309
[AddComponentMenu("Camera Filter Pack/Vision/Hell_Blood")]
[ExecuteInEditMode]
public class CameraFilterPack_Vision_Hell_Blood : MonoBehaviour
{
	// Token: 0x06006187 RID: 24967 RVA: 0x001DA5F1 File Offset: 0x001D87F1
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x1700011A RID: 282
	// (get) Token: 0x06006188 RID: 24968 RVA: 0x001DA628 File Offset: 0x001D8828
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

	// Token: 0x06006189 RID: 24969 RVA: 0x001DA65F File Offset: 0x001D885F
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600618A RID: 24970 RVA: 0x001DA67C File Offset: 0x001D887C
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("?");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600618B RID: 24971 RVA: 0x001DA6A0 File Offset: 0x001D88A0
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600618C RID: 24972 RVA: 0x001DA6C4 File Offset: 0x001D88C4
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("roomDescription");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600618D RID: 24973 RVA: 0x001DA65F File Offset: 0x001D885F
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600618E RID: 24974 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x0600618F RID: 24975 RVA: 0x001DA6E8 File Offset: 0x001D88E8
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 332f)
			{
				this.HBJJOCHGOPH = 1594f;
			}
			this.HNICHJCGJOC().SetFloat("maps.", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_BlurRadius", this.Hole_Size);
			this.IONHGBPGCHK().SetFloat(" ", this.Hole_Smooth);
			this.EPCGJFCCAFH().SetFloat("colorB", this.Hole_Speed * 1146f);
			this.DBOLLHHMKKN().SetColor("settings.cameramovements", this.ColorBlood);
			this.HNICHJCGJOC().SetFloat("_TimeX", this.Intensity);
			this.LNLKMDPHDCC().SetFloat("replayData", this.BloodAlternative1);
			this.DBOLLHHMKKN().SetFloat("\n", this.BloodAlternative2);
			this.HNICHJCGJOC().SetFloat("_ScreenResolution", this.BloodAlternative3);
			this.HNICHJCGJOC().SetVector("LevelNameInputField", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 532f, 924f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006190 RID: 24976 RVA: 0x001DA65F File Offset: 0x001D885F
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06006191 RID: 24977 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06006192 RID: 24978 RVA: 0x001DA848 File Offset: 0x001D8A48
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1843f)
			{
				this.HBJJOCHGOPH = 497f;
			}
			this.NBPKMLMCHFN.SetFloat("_Value2", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("_TimeX", this.Hole_Size);
			this.ADBKPGFMNKO().SetFloat("FinalScoreText", this.Hole_Smooth);
			this.NBPKMLMCHFN.SetFloat("Joystick1Button9", this.Hole_Speed * 1815f);
			this.IONHGBPGCHK().SetColor("settings.enablehitsoundsinnormal", this.ColorBlood);
			this.EPCGJFCCAFH().SetFloat("[Left]", this.Intensity);
			this.EFDEIFCDAFG().SetFloat("SetBGColor", this.BloodAlternative1);
			this.DBOLLHHMKKN().SetFloat("Data/Skins/", this.BloodAlternative2);
			this.ADBKPGFMNKO().SetFloat("Lightning", this.BloodAlternative3);
			this.HFBJAOFLCJI().SetVector("SaveButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 96f, 896f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006193 RID: 24979 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06006194 RID: 24980 RVA: 0x001DA9A5 File Offset: 0x001D8BA5
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("_RayStepSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06006195 RID: 24981 RVA: 0x001DA9CC File Offset: 0x001D8BCC
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 785f)
			{
				this.HBJJOCHGOPH = 1618f;
			}
			this.HNICHJCGJOC().SetFloat(" x ", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("resource id", this.Hole_Size);
			this.EPCGJFCCAFH().SetFloat("VisionBlur", this.Hole_Smooth);
			this.HFBJAOFLCJI().SetFloat("Select", this.Hole_Speed * 758f);
			this.ADBKPGFMNKO().SetColor("Start Color's hex value #RRGGBBAA", this.ColorBlood);
			this.ADBKPGFMNKO().SetFloat("Set Crosshair Color", this.Intensity);
			this.HFBJAOFLCJI().SetFloat("BadgeText", this.BloodAlternative1);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.BloodAlternative2);
			this.HFBJAOFLCJI().SetFloat("JoinRandomRoom failed. In offline mode you still have to leave a room to enter another.", this.BloodAlternative3);
			this.NBPKMLMCHFN.SetVector("EVENT CONFIG [Ctrl+E]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 675f, 1049f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06006197 RID: 24983 RVA: 0x001DABA0 File Offset: 0x001D8DA0
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06006198 RID: 24984 RVA: 0x001DABD7 File Offset: 0x001D8DD7
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Light_Rainbow");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06006199 RID: 24985 RVA: 0x001DA65F File Offset: 0x001D885F
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600619A RID: 24986 RVA: 0x001DABFC File Offset: 0x001D8DFC
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Hole_Size);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Hole_Smooth);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Hole_Speed * 15f);
			this.NBPKMLMCHFN.SetColor("ColorBlood", this.ColorBlood);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Intensity);
			this.NBPKMLMCHFN.SetFloat("BloodAlternative1", this.BloodAlternative1);
			this.NBPKMLMCHFN.SetFloat("BloodAlternative2", this.BloodAlternative2);
			this.NBPKMLMCHFN.SetFloat("BloodAlternative3", this.BloodAlternative3);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600619B RID: 24987 RVA: 0x001DAD59 File Offset: 0x001D8F59
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("No Name");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600619C RID: 24988 RVA: 0x001DAD7D File Offset: 0x001D8F7D
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600619D RID: 24989 RVA: 0x001DADB4 File Offset: 0x001D8FB4
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("/../");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600619E RID: 24990 RVA: 0x001DADD8 File Offset: 0x001D8FD8
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600619F RID: 24991 RVA: 0x001DAE0F File Offset: 0x001D900F
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_Hell_Blood");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060061A0 RID: 24992 RVA: 0x001DAE33 File Offset: 0x001D9033
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("Search: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060061A1 RID: 24993 RVA: 0x001DA628 File Offset: 0x001D8828
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060061A2 RID: 24994 RVA: 0x001DA65F File Offset: 0x001D885F
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060061A3 RID: 24995 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x060061A4 RID: 24996 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x060061A5 RID: 24997 RVA: 0x001DAE58 File Offset: 0x001D9058
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 28f)
			{
				this.HBJJOCHGOPH = 1144f;
			}
			this.HFBJAOFLCJI().SetFloat("/", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("Lerp speed. Recomended 10", this.Hole_Size);
			this.LNLKMDPHDCC().SetFloat("_Saturation", this.Hole_Smooth);
			this.ADBKPGFMNKO().SetFloat("' has been reset to the fault value", this.Hole_Speed * 117f);
			this.NBPKMLMCHFN.SetColor("UpperMid", this.ColorBlood);
			this.LNLKMDPHDCC().SetFloat("_TimeX", this.Intensity);
			this.ADBKPGFMNKO().SetFloat(".lastCheckpoint.checkpointsUsed", this.BloodAlternative1);
			this.HNICHJCGJOC().SetFloat("Ev OwnershipTransfer. ViewID ", this.BloodAlternative2);
			this.ADBKPGFMNKO().SetFloat(" Also make sure to disable sprite packing for this sprite.", this.BloodAlternative3);
			this.IONHGBPGCHK().SetVector("RB", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 826f, 1510f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060061A6 RID: 24998 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x060061A7 RID: 24999 RVA: 0x001DADD8 File Offset: 0x001D8FD8
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060061A8 RID: 25000 RVA: 0x001DAFB5 File Offset: 0x001D91B5
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060061A9 RID: 25001 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x060061AA RID: 25002 RVA: 0x001DAFEC File Offset: 0x001D91EC
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060061AB RID: 25003 RVA: 0x001DA65F File Offset: 0x001D885F
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040009D5 RID: 2517
	public Shader SCShader;

	// Token: 0x040009D6 RID: 2518
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040009D7 RID: 2519
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040009D8 RID: 2520
	private Material BJFKDHHMLJH;

	// Token: 0x040009D9 RID: 2521
	[Range(0f, 1f)]
	public float Hole_Size = 0.57f;

	// Token: 0x040009DA RID: 2522
	[Range(0f, 0.5f)]
	public float Hole_Smooth = 0.362f;

	// Token: 0x040009DB RID: 2523
	[Range(-2f, 2f)]
	public float Hole_Speed = 0.85f;

	// Token: 0x040009DC RID: 2524
	[Range(-10f, 10f)]
	public float Intensity = 0.24f;

	// Token: 0x040009DD RID: 2525
	public Color ColorBlood = new Color(1f, 0f, 0f, 1f);

	// Token: 0x040009DE RID: 2526
	[Range(-1f, 1f)]
	public float BloodAlternative1;

	// Token: 0x040009DF RID: 2527
	[Range(-1f, 1f)]
	public float BloodAlternative2;

	// Token: 0x040009E0 RID: 2528
	[Range(-1f, 1f)]
	public float BloodAlternative3 = -1f;
}
