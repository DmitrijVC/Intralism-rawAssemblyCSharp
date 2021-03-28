using System;
using UnityEngine;

// Token: 0x0200006A RID: 106
[AddComponentMenu("Camera Filter Pack/Blur/Tilt_Shift_V")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_Tilt_Shift_V : MonoBehaviour
{
	// Token: 0x06001DB8 RID: 7608 RVA: 0x000B4122 File Offset: 0x000B2322
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DB9 RID: 7609 RVA: 0x000B413F File Offset: 0x000B233F
	private Material IIBLJCKLGFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001DBA RID: 7610 RVA: 0x000B4176 File Offset: 0x000B2376
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001DBB RID: 7611 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06001DBC RID: 7612 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06001DBD RID: 7613 RVA: 0x000B4122 File Offset: 0x000B2322
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DBF RID: 7615 RVA: 0x000B4204 File Offset: 0x000B2404
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1141f)
			{
				this.HBJJOCHGOPH = 1235f;
			}
			this.ADBKPGFMNKO().SetFloat("_Near", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("_Bullet_9", this.Amount);
			this.OIMMPLPBLBK().SetFloat("CameraFilterPack_TV_Noise", this.Smooth);
			this.IIBLJCKLGFG().SetFloat("_LightIntensity", this.Size);
			this.IIJMIPBMMBF().SetFloat("MapCreationCanvas", this.Position);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, this.IIBLJCKLGFG(), 6);
				Graphics.Blit(temporary, temporary2, this.MMOODGIODPC(), 0);
				this.NBPKMLMCHFN.SetFloat("CameraFilterPack_Glasses_On5", this.Amount * 925f);
				Graphics.Blit(temporary2, temporary, this.MMOODGIODPC(), 5);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 1);
				this.NBPKMLMCHFN.SetTexture("FPSToggle", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001DC0 RID: 7616 RVA: 0x000B4122 File Offset: 0x000B2322
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DC1 RID: 7617 RVA: 0x000B4122 File Offset: 0x000B2322
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DC2 RID: 7618 RVA: 0x000B4122 File Offset: 0x000B2322
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DC3 RID: 7619 RVA: 0x000B439F File Offset: 0x000B259F
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/BlurTiltShift_V");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001DC4 RID: 7620 RVA: 0x000B43C4 File Offset: 0x000B25C4
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1498f)
			{
				this.HBJJOCHGOPH = 824f;
			}
			this.OIMMPLPBLBK().SetFloat("Default UI Material", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.Amount);
			this.OIMMPLPBLBK().SetFloat("z", this.Smooth);
			this.NBPKMLMCHFN.SetFloat("Init", this.Size);
			this.MMOODGIODPC().SetFloat("CameraFilterPack_OldFilm1", this.Position);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, this.IIJMIPBMMBF(), 8);
				Graphics.Blit(temporary, temporary2, this.MMOODGIODPC(), 1);
				this.IIBLJCKLGFG().SetFloat("float,0", this.Amount * 1692f);
				Graphics.Blit(temporary2, temporary, this.NBPKMLMCHFN, 6);
				Graphics.Blit(temporary, temporary2, this.ADBKPGFMNKO(), 0);
				this.MMOODGIODPC().SetTexture("_TimeX", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIBLJCKLGFG(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001DC5 RID: 7621 RVA: 0x000B455F File Offset: 0x000B275F
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001DC6 RID: 7622 RVA: 0x000B4584 File Offset: 0x000B2784
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Amount", this.Amount);
			this.NBPKMLMCHFN.SetFloat("_Value1", this.Smooth);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Position);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, this.NBPKMLMCHFN, 2);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 0);
				this.NBPKMLMCHFN.SetFloat("_Amount", this.Amount * 2f);
				Graphics.Blit(temporary2, temporary, this.NBPKMLMCHFN, 2);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 0);
				this.NBPKMLMCHFN.SetTexture("_MainTex2", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001DC7 RID: 7623 RVA: 0x000B471F File Offset: 0x000B291F
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_DarkerColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001DC8 RID: 7624 RVA: 0x000B4743 File Offset: 0x000B2943
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("). ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001DC9 RID: 7625 RVA: 0x000B4767 File Offset: 0x000B2967
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("SetSatelliteTrailWidth");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001DCA RID: 7626 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x06001DCB RID: 7627 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06001DCC RID: 7628 RVA: 0x000B478B File Offset: 0x000B298B
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001DCD RID: 7629 RVA: 0x000B47C2 File Offset: 0x000B29C2
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("Couldn't color correct with 3D LUT texture. Image Effect will be disabled.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001DCE RID: 7630 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06001DCF RID: 7631 RVA: 0x000B47E6 File Offset: 0x000B29E6
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001DD0 RID: 7632 RVA: 0x000B4820 File Offset: 0x000B2A20
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 795f)
			{
				this.HBJJOCHGOPH = 643f;
			}
			this.NBPKMLMCHFN.SetFloat(";", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End", this.Amount);
			this.IIBLJCKLGFG().SetFloat("{0:0} day{1}, ", this.Smooth);
			this.IIBLJCKLGFG().SetFloat("PointsScoreText", this.Size);
			this.ADBKPGFMNKO().SetFloat("_BgFade", this.Position);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)6;
				Graphics.Blit(AAACLELCPML, temporary, this.NBPKMLMCHFN, 6);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 1);
				this.ADBKPGFMNKO().SetFloat("{0:x2}", this.Amount * 1238f);
				Graphics.Blit(temporary2, temporary, this.MMOODGIODPC(), 5);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 1);
				this.MMOODGIODPC().SetTexture("/icon", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001DD1 RID: 7633 RVA: 0x000B49BB File Offset: 0x000B2BBB
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("[Down]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001DD2 RID: 7634 RVA: 0x000B49DF File Offset: 0x000B2BDF
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001DD3 RID: 7635 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001DD4 RID: 7636 RVA: 0x000B4A16 File Offset: 0x000B2C16
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find(" not found");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001DD5 RID: 7637 RVA: 0x000B4122 File Offset: 0x000B2322
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DD6 RID: 7638 RVA: 0x000B4A3C File Offset: 0x000B2C3C
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1438f)
			{
				this.HBJJOCHGOPH = 288f;
			}
			this.IIBLJCKLGFG().SetFloat("(?<=#)\\w+", this.HBJJOCHGOPH);
			this.IIBLJCKLGFG().SetFloat("SetSatelliteTrailMinVertexDistance", this.Amount);
			this.IIJMIPBMMBF().SetFloat("_Value2", this.Smooth);
			this.IIBLJCKLGFG().SetFloat("_ScreenResolution", this.Size);
			this.IIBLJCKLGFG().SetFloat("Unable to get a reward! Try again?", this.Position);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Bilinear;
				Graphics.Blit(AAACLELCPML, temporary, this.NBPKMLMCHFN, 5);
				Graphics.Blit(temporary, temporary2, this.ADBKPGFMNKO(), 1);
				this.NBPKMLMCHFN.SetFloat("BlockSize", this.Amount * 523f);
				Graphics.Blit(temporary2, temporary, this.OIMMPLPBLBK(), 5);
				Graphics.Blit(temporary, temporary2, this.MMOODGIODPC(), 1);
				this.IIBLJCKLGFG().SetTexture("DPADHOR", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001DD7 RID: 7639 RVA: 0x000B4122 File Offset: 0x000B2322
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DD8 RID: 7640 RVA: 0x000B4122 File Offset: 0x000B2322
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000050 RID: 80
	// (get) Token: 0x06001DD9 RID: 7641 RVA: 0x000B4BD7 File Offset: 0x000B2DD7
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

	// Token: 0x06001DDA RID: 7642 RVA: 0x000B4C10 File Offset: 0x000B2E10
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1054f)
			{
				this.HBJJOCHGOPH = 211f;
			}
			this.IIJMIPBMMBF().SetFloat("Texture2", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("yyyy-MM-dd HH:mm:ss", this.Amount);
			this.NBPKMLMCHFN.SetFloat(": ", this.Smooth);
			this.IIBLJCKLGFG().SetFloat("Received RPC \"", this.Size);
			this.MMOODGIODPC().SetFloat("_DisplayVelocityScale", this.Position);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)7;
				Graphics.Blit(AAACLELCPML, temporary, this.ADBKPGFMNKO(), 5);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 0);
				this.OIMMPLPBLBK().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", this.Amount * 601f);
				Graphics.Blit(temporary2, temporary, this.OIMMPLPBLBK(), 1);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 0);
				this.OIMMPLPBLBK().SetTexture("[LocalizationService] All keys for ", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001DDB RID: 7643 RVA: 0x000B4122 File Offset: 0x000B2322
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DDC RID: 7644 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06001DDD RID: 7645 RVA: 0x000B4DAC File Offset: 0x000B2FAC
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1818f)
			{
				this.HBJJOCHGOPH = 1380f;
			}
			this.IIBLJCKLGFG().SetFloat("id", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("_Red_C", this.Amount);
			this.MMOODGIODPC().SetFloat("_BlurArea", this.Smooth);
			this.OIMMPLPBLBK().SetFloat("SetSatelliteTrailWidth", this.Size);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.Position);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(AAACLELCPML, temporary, this.IIBLJCKLGFG(), 7);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 0);
				this.IIBLJCKLGFG().SetFloat("mapselector.filter.favoriteonly", this.Amount * 449f);
				Graphics.Blit(temporary2, temporary, this.IIBLJCKLGFG(), 8);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 1);
				this.IIJMIPBMMBF().SetTexture("float,1.5", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001DDE RID: 7646 RVA: 0x000B4122 File Offset: 0x000B2322
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DDF RID: 7647 RVA: 0x000B4122 File Offset: 0x000B2322
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x04000402 RID: 1026
	public Shader SCShader;

	// Token: 0x04000403 RID: 1027
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000404 RID: 1028
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000405 RID: 1029
	private Material BJFKDHHMLJH;

	// Token: 0x04000406 RID: 1030
	[Range(0f, 20f)]
	public float Amount = 3f;

	// Token: 0x04000407 RID: 1031
	[Range(2f, 16f)]
	public int FastFilter = 8;

	// Token: 0x04000408 RID: 1032
	[Range(0f, 1f)]
	public float Smooth = 0.5f;

	// Token: 0x04000409 RID: 1033
	[Range(0f, 1f)]
	public float Size = 0.5f;

	// Token: 0x0400040A RID: 1034
	[Range(-1f, 1f)]
	public float Position = 0.5f;
}
