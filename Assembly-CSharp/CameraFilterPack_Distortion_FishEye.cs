using System;
using UnityEngine;

// Token: 0x0200008A RID: 138
[AddComponentMenu("Camera Filter Pack/Distortion/FishEye")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_FishEye : MonoBehaviour
{
	// Token: 0x0600279D RID: 10141 RVA: 0x000DD79F File Offset: 0x000DB99F
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600279E RID: 10142 RVA: 0x000DD7BC File Offset: 0x000DB9BC
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600279F RID: 10143 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x060027A0 RID: 10144 RVA: 0x000DD7F3 File Offset: 0x000DB9F3
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-97);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027A1 RID: 10145 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x060027A2 RID: 10146 RVA: 0x000DD82A File Offset: 0x000DBA2A
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("resource id");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060027A3 RID: 10147 RVA: 0x000DD84E File Offset: 0x000DBA4E
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("SetSunColors");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060027A4 RID: 10148 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x060027A5 RID: 10149 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x060027A6 RID: 10150 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x060027A7 RID: 10151 RVA: 0x000DD872 File Offset: 0x000DBA72
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027A8 RID: 10152 RVA: 0x000DD8A9 File Offset: 0x000DBAA9
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027A9 RID: 10153 RVA: 0x000DD8E0 File Offset: 0x000DBAE0
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027AA RID: 10154 RVA: 0x000DD918 File Offset: 0x000DBB18
	private void LBHPMIDFKPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 913f)
			{
				this.HBJJOCHGOPH = 859f;
			}
			this.EPCGJFCCAFH().SetFloat("isVisible", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("workshop.", this.Distortion);
			this.NBPKMLMCHFN.SetVector("[PlayerBase] Game mode: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1926f, 573f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060027AB RID: 10155 RVA: 0x000DD9D5 File Offset: 0x000DBBD5
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("[ERROR KEY {0}]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060027AC RID: 10156 RVA: 0x000DD9F9 File Offset: 0x000DBBF9
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find("(\\[ *b *\\])");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060027AD RID: 10157 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x060027AE RID: 10158 RVA: 0x000DDA1D File Offset: 0x000DBC1D
	private void BEBNOKFLJPH()
	{
		this.SCShader = Shader.Find("mapselector.filter.favoriteonly");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060027AF RID: 10159 RVA: 0x000DD79F File Offset: 0x000DB99F
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060027B0 RID: 10160 RVA: 0x000DDA41 File Offset: 0x000DBC41
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_FishEye");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060027B1 RID: 10161 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x060027B2 RID: 10162 RVA: 0x000DDA65 File Offset: 0x000DBC65
	private Material PLBEJJIHFPB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027B3 RID: 10163 RVA: 0x000DD79F File Offset: 0x000DB99F
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060027B4 RID: 10164 RVA: 0x000DDA9C File Offset: 0x000DBC9C
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027B5 RID: 10165 RVA: 0x000DDAD3 File Offset: 0x000DBCD3
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027B6 RID: 10166 RVA: 0x000DDB0C File Offset: 0x000DBD0C
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1174f)
			{
				this.HBJJOCHGOPH = 1559f;
			}
			this.LPMLLJKMAMP().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("CameraFilterPack/Blend2Camera_Multiply", this.Distortion);
			this.EPCGJFCCAFH().SetVector("menu.selectedplaymode", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1903f, 240f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060027B7 RID: 10167 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x060027B8 RID: 10168 RVA: 0x000DD79F File Offset: 0x000DB99F
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060027B9 RID: 10169 RVA: 0x000DDBC9 File Offset: 0x000DBDC9
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("_NeighbourMaxTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060027BA RID: 10170 RVA: 0x000DDBF0 File Offset: 0x000DBDF0
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 243f)
			{
				this.HBJJOCHGOPH = 1398f;
			}
			this.LPMLLJKMAMP().SetFloat(": ", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("</color>", this.Distortion);
			this.ACHNOHCLGOO().SetVector("settings.volume.game", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1507f, 1412f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060027BB RID: 10171 RVA: 0x000DD79F File Offset: 0x000DB99F
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060027BC RID: 10172 RVA: 0x000DDCB0 File Offset: 0x000DBEB0
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 465f)
			{
				this.HBJJOCHGOPH = 1185f;
			}
			this.MMOODGIODPC().SetFloat("_Speed", this.HBJJOCHGOPH);
			this.PLBEJJIHFPB().SetFloat("Ev DestroyAll! By PlayerId: ", this.Distortion);
			this.KEMAALEODNH().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1922f, 489f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060027BD RID: 10173 RVA: 0x000DDD6D File Offset: 0x000DBF6D
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("_Value6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060027BE RID: 10174 RVA: 0x000DDD91 File Offset: 0x000DBF91
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027BF RID: 10175 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x060027C0 RID: 10176 RVA: 0x000DDDC8 File Offset: 0x000DBFC8
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060027C1 RID: 10177 RVA: 0x000DDDEC File Offset: 0x000DBFEC
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027C2 RID: 10178 RVA: 0x000DD79F File Offset: 0x000DB99F
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060027C3 RID: 10179 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x060027C4 RID: 10180 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x060027C5 RID: 10181 RVA: 0x000DDE24 File Offset: 0x000DC024
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 391f)
			{
				this.HBJJOCHGOPH = 898f;
			}
			this.PGPEMMBJOOG().SetFloat("caret", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("Despawn environment object by id", this.Distortion);
			this.PLBEJJIHFPB().SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 578f, 1047f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060027C6 RID: 10182 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x060027C7 RID: 10183 RVA: 0x000DDEE1 File Offset: 0x000DC0E1
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027C8 RID: 10184 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x060027C9 RID: 10185 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060027CA RID: 10186 RVA: 0x000DDF18 File Offset: 0x000DC118
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 76f)
			{
				this.HBJJOCHGOPH = 1310f;
			}
			this.DONENAMLFLF().SetFloat(" By: ", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("_Threshhold", this.Distortion);
			this.EPCGJFCCAFH().SetVector("Prints the number of logs currently held by DebugLogs", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1755f, 1850f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060027CB RID: 10187 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x060027CC RID: 10188 RVA: 0x000DDFD5 File Offset: 0x000DC1D5
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027CD RID: 10189 RVA: 0x000DE00C File Offset: 0x000DC20C
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027CE RID: 10190 RVA: 0x000DE043 File Offset: 0x000DC243
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027CF RID: 10191 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x060027D0 RID: 10192 RVA: 0x000DE07A File Offset: 0x000DC27A
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027D1 RID: 10193 RVA: 0x000DE0B1 File Offset: 0x000DC2B1
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("x");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060027D2 RID: 10194 RVA: 0x000DE0D5 File Offset: 0x000DC2D5
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027D3 RID: 10195 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x060027D4 RID: 10196 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x060027D5 RID: 10197 RVA: 0x000DE10C File Offset: 0x000DC30C
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1754f)
			{
				this.HBJJOCHGOPH = 633f;
			}
			this.NLFJGMBCICG().SetFloat("Edited unlock conditions", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("/icon", this.Distortion);
			this.OKJOKHGJHGF().SetVector("RoomDescriptionText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 297f, 1536f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060027D6 RID: 10198 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x060027D7 RID: 10199 RVA: 0x000DE1C9 File Offset: 0x000DC3C9
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027D8 RID: 10200 RVA: 0x000DE200 File Offset: 0x000DC400
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("true");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x1700006F RID: 111
	// (get) Token: 0x060027D9 RID: 10201 RVA: 0x000DE224 File Offset: 0x000DC424
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

	// Token: 0x060027DA RID: 10202 RVA: 0x000DE25B File Offset: 0x000DC45B
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("challenges.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060027DC RID: 10204 RVA: 0x000DE2A0 File Offset: 0x000DC4A0
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
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060027DD RID: 10205 RVA: 0x000DE35D File Offset: 0x000DC55D
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027DE RID: 10206 RVA: 0x000DD79F File Offset: 0x000DB99F
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060027DF RID: 10207 RVA: 0x000DD79F File Offset: 0x000DB99F
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060027E0 RID: 10208 RVA: 0x000DE394 File Offset: 0x000DC594
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1656f)
			{
				this.HBJJOCHGOPH = 1389f;
			}
			this.PLBEJJIHFPB().SetFloat("Mouse1", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("Rotate environment object to the rotation", this.Distortion);
			this.LPMLLJKMAMP().SetVector("<b>#", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 268f, 1196f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060027E1 RID: 10209 RVA: 0x000DE451 File Offset: 0x000DC651
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027E2 RID: 10210 RVA: 0x000DD79F File Offset: 0x000DB99F
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060027E3 RID: 10211 RVA: 0x000DE488 File Offset: 0x000DC688
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027E4 RID: 10212 RVA: 0x000DE4BF File Offset: 0x000DC6BF
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("Object ID. Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060027E5 RID: 10213 RVA: 0x000DE4E3 File Offset: 0x000DC6E3
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060027E6 RID: 10214 RVA: 0x000DE508 File Offset: 0x000DC708
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 571f)
			{
				this.HBJJOCHGOPH = 169f;
			}
			this.PGPEMMBJOOG().SetFloat("CountEventsGoal", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("Clear Environment", this.Distortion);
			this.EPCGJFCCAFH().SetVector("#ok", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1935f, 916f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060027E7 RID: 10215 RVA: 0x000DE5C5 File Offset: 0x000DC7C5
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027E8 RID: 10216 RVA: 0x0002523B File Offset: 0x0002343B
	private void CGBHOELMAOC()
	{
	}

	// Token: 0x060027E9 RID: 10217 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x060027EA RID: 10218 RVA: 0x000DE5FC File Offset: 0x000DC7FC
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060027EB RID: 10219 RVA: 0x000DE633 File Offset: 0x000DC833
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find("RarityImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060027EC RID: 10220 RVA: 0x000DD79F File Offset: 0x000DB99F
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x040004EE RID: 1262
	public Shader SCShader;

	// Token: 0x040004EF RID: 1263
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040004F0 RID: 1264
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040004F1 RID: 1265
	private Material BJFKDHHMLJH;

	// Token: 0x040004F2 RID: 1266
	[Range(0f, 1f)]
	public float Distortion = 0.35f;
}
