using System;
using UnityEngine;

// Token: 0x0200007D RID: 125
[AddComponentMenu("Camera Filter Pack/Colors/DarkColor")]
[ExecuteInEditMode]
public class CameraFilterPack_Colors_DarkColor : MonoBehaviour
{
	// Token: 0x060023A8 RID: 9128 RVA: 0x000CE659 File Offset: 0x000CC859
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060023A9 RID: 9129 RVA: 0x000CE659 File Offset: 0x000CC859
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060023AA RID: 9130 RVA: 0x000CE659 File Offset: 0x000CC859
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060023AB RID: 9131 RVA: 0x000CE676 File Offset: 0x000CC876
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060023AC RID: 9132 RVA: 0x000CE6AD File Offset: 0x000CC8AD
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("Source Object: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060023AD RID: 9133 RVA: 0x000CE6D1 File Offset: 0x000CC8D1
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060023AE RID: 9134 RVA: 0x000CE659 File Offset: 0x000CC859
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060023B0 RID: 9136 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060023B1 RID: 9137 RVA: 0x000CE659 File Offset: 0x000CC859
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060023B2 RID: 9138 RVA: 0x000CE734 File Offset: 0x000CC934
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1782f)
			{
				this.HBJJOCHGOPH = 1558f;
			}
			this.JIBOKBCPDLC().SetFloat("_Value1", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("CorrectHitsScoreText", this.Alpha);
			this.OIMMPLPBLBK().SetFloat("CameraFilterPack_AAA_Blood2", this.LHFNOLGKGMO);
			this.NBPKMLMCHFN.SetFloat("SpawnObj", this.NEJIJAPDALK);
			this.NBPKMLMCHFN.SetFloat("OpCreateRoom()", this.CCIENBFIKKH);
			this.JIBOKBCPDLC().SetVector("Set Object Scale", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1091f, 741f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060023B3 RID: 9139 RVA: 0x000CE659 File Offset: 0x000CC859
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000062 RID: 98
	// (get) Token: 0x060023B4 RID: 9140 RVA: 0x000CE833 File Offset: 0x000CCA33
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

	// Token: 0x060023B5 RID: 9141 RVA: 0x000CE659 File Offset: 0x000CC859
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060023B6 RID: 9142 RVA: 0x000CE86A File Offset: 0x000CCA6A
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("restrictions\n\n#until: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060023B7 RID: 9143 RVA: 0x000CE659 File Offset: 0x000CC859
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060023B8 RID: 9144 RVA: 0x000CE88E File Offset: 0x000CCA8E
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Plasma");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060023B9 RID: 9145 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x060023BA RID: 9146 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x060023BB RID: 9147 RVA: 0x000CE8B2 File Offset: 0x000CCAB2
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060023BC RID: 9148 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x060023BD RID: 9149 RVA: 0x000CE8D8 File Offset: 0x000CCAD8
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 885f)
			{
				this.HBJJOCHGOPH = 1461f;
			}
			this.GCDFNHMJMIP().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("SetSunMaxSize", this.Alpha);
			this.OIMMPLPBLBK().SetFloat("player.xp", this.LHFNOLGKGMO);
			this.JIBOKBCPDLC().SetFloat("Operation failed: ", this.NEJIJAPDALK);
			this.OIMMPLPBLBK().SetFloat("_TimeX", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("Malformed RPC; this should never occur. Content: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 701f, 1196f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060023BE RID: 9150 RVA: 0x000CE659 File Offset: 0x000CC859
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060023BF RID: 9151 RVA: 0x000CE9D7 File Offset: 0x000CCBD7
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060023C0 RID: 9152 RVA: 0x000CEA10 File Offset: 0x000CCC10
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1122f)
			{
				this.HBJJOCHGOPH = 932f;
			}
			this.OIMMPLPBLBK().SetFloat("Fade", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("513510", this.Alpha);
			this.GCDFNHMJMIP().SetFloat("_TreatBackfaceHitAsMiss", this.LHFNOLGKGMO);
			this.OIMMPLPBLBK().SetFloat("Text", this.NEJIJAPDALK);
			this.KAFBNOBOIAJ().SetFloat("maps.", this.CCIENBFIKKH);
			this.KAFBNOBOIAJ().SetVector("ViewMenu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 485f, 1455f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060023C1 RID: 9153 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x060023C2 RID: 9154 RVA: 0x000CEB10 File Offset: 0x000CCD10
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 917f)
			{
				this.HBJJOCHGOPH = 382f;
			}
			this.JIBOKBCPDLC().SetFloat(".", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("_FixDistance", this.Alpha);
			this.NBPKMLMCHFN.SetFloat("offsets", this.LHFNOLGKGMO);
			this.JIBOKBCPDLC().SetFloat("CameraFilterPack/3D_BlackHole", this.NEJIJAPDALK);
			this.OIMMPLPBLBK().SetFloat("{0} seconds ago", this.CCIENBFIKKH);
			this.JIBOKBCPDLC().SetVector("menutheme.hunter", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 519f, 254f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060023C3 RID: 9155 RVA: 0x000CEC10 File Offset: 0x000CCE10
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1057f)
			{
				this.HBJJOCHGOPH = 671f;
			}
			this.OIMMPLPBLBK().SetFloat("_Distortion", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetFloat("[NetworkManager] Connection failed: ", this.Alpha);
			this.JIBOKBCPDLC().SetFloat(" (inactive)", this.LHFNOLGKGMO);
			this.NBPKMLMCHFN.SetFloat("player.xp", this.NEJIJAPDALK);
			this.GCDFNHMJMIP().SetFloat("_Value2", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("mapselector.filter.favoriteonly", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1131f, 1865f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060023C4 RID: 9156 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x060023C5 RID: 9157 RVA: 0x000CED0F File Offset: 0x000CCF0F
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Colors_DarkColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060023C6 RID: 9158 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x060023C7 RID: 9159 RVA: 0x000CED33 File Offset: 0x000CCF33
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060023C8 RID: 9160 RVA: 0x000CED6C File Offset: 0x000CCF6C
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 431f)
			{
				this.HBJJOCHGOPH = 1292f;
			}
			this.NBPKMLMCHFN.SetFloat("[PlayerController] ", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetFloat("_Curve", this.Alpha);
			this.JIBOKBCPDLC().SetFloat("mapselector.filter.favoriteonly", this.LHFNOLGKGMO);
			this.OIMMPLPBLBK().SetFloat("Tab2Content", this.NEJIJAPDALK);
			this.KAFBNOBOIAJ().SetFloat("_Value5", this.CCIENBFIKKH);
			this.KAFBNOBOIAJ().SetVector("[MapEditor] Exported to ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1943f, 663f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIMMPLPBLBK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060023C9 RID: 9161 RVA: 0x000CEE6B File Offset: 0x000CD06B
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)85;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060023CA RID: 9162 RVA: 0x000CE659 File Offset: 0x000CC859
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060023CB RID: 9163 RVA: 0x000CEEA2 File Offset: 0x000CD0A2
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("SetSatelliteInput");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060023CC RID: 9164 RVA: 0x000CE659 File Offset: 0x000CC859
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060023CD RID: 9165 RVA: 0x000CEEC8 File Offset: 0x000CD0C8
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 210f)
			{
				this.HBJJOCHGOPH = 667f;
			}
			this.NBPKMLMCHFN.SetFloat("Objects in List: ", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.Alpha);
			this.OIMMPLPBLBK().SetFloat(".", this.LHFNOLGKGMO);
			this.GCDFNHMJMIP().SetFloat("SetSunInput", this.NEJIJAPDALK);
			this.OIMMPLPBLBK().SetFloat("_ExposureAdjustment", this.CCIENBFIKKH);
			this.JIBOKBCPDLC().SetVector("LocalPlayer is null or not in mActors! LocalPlayer: {0} mActors==null: {1} newID: {2}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 338f, 1792f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060023CE RID: 9166 RVA: 0x000CEFC8 File Offset: 0x000CD1C8
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Alpha);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.LHFNOLGKGMO);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.NEJIJAPDALK);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x04000497 RID: 1175
	public Shader SCShader;

	// Token: 0x04000498 RID: 1176
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000499 RID: 1177
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400049A RID: 1178
	private Material BJFKDHHMLJH;

	// Token: 0x0400049B RID: 1179
	[Range(-5f, 5f)]
	public float Alpha = 1f;

	// Token: 0x0400049C RID: 1180
	[Range(0f, 16f)]
	private float LHFNOLGKGMO = 11f;

	// Token: 0x0400049D RID: 1181
	[Range(-1f, 1f)]
	private float NEJIJAPDALK = 1f;

	// Token: 0x0400049E RID: 1182
	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;
}
