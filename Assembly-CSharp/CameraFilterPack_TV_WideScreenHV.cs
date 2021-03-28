using System;
using UnityEngine;

// Token: 0x0200012C RID: 300
[AddComponentMenu("Camera Filter Pack/TV/WideScreenHV")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_WideScreenHV : MonoBehaviour
{
	// Token: 0x06005EEA RID: 24298 RVA: 0x001CE8C6 File Offset: 0x001CCAC6
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("Left Stick Click");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005EEB RID: 24299 RVA: 0x001CE8EA File Offset: 0x001CCAEA
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("VoteUpToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005EEC RID: 24300 RVA: 0x001CE910 File Offset: 0x001CCB10
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1345f)
			{
				this.HBJJOCHGOPH = 511f;
			}
			this.NBPKMLMCHFN.SetFloat("_BlurCoe", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("BitsData", this.Size);
			this.DBOLLHHMKKN().SetFloat("\"", this.Smooth);
			this.BFGNMFCNDBC().SetFloat("_ScreenResolution", this.ICABEDDNGIH);
			this.MCDGIILBNIF().SetFloat("Joystick1Button11", this.LHOMPJOPKHE);
			this.MCDGIILBNIF().SetVector("_Offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 670f, 1819f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005EED RID: 24301 RVA: 0x001CEA0F File Offset: 0x001CCC0F
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("_CurveTex");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005EEE RID: 24302 RVA: 0x001CEA33 File Offset: 0x001CCC33
	private void AEOLJEIDMDB()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005EEF RID: 24303 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005EF0 RID: 24304 RVA: 0x001CEA74 File Offset: 0x001CCC74
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 550f)
			{
				this.HBJJOCHGOPH = 1403f;
			}
			this.NBPKMLMCHFN.SetFloat("Drop_Far", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetFloat("_Value7", this.Size);
			this.EHDJJANLINB().SetFloat("_Value2", this.Smooth);
			this.CIAFLBFJLEJ().SetFloat("MapConfig", this.ICABEDDNGIH);
			this.BFGNMFCNDBC().SetFloat("Set object anchor to another object", this.LHOMPJOPKHE);
			this.KDMBOKLMADJ().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 416f, 456f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005EF1 RID: 24305 RVA: 0x001CEB73 File Offset: 0x001CCD73
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005EF2 RID: 24306 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005EF3 RID: 24307 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005EF4 RID: 24308 RVA: 0x001CEBAA File Offset: 0x001CCDAA
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005EF5 RID: 24309 RVA: 0x001CEBE1 File Offset: 0x001CCDE1
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005EF6 RID: 24310 RVA: 0x001CEC08 File Offset: 0x001CCE08
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 184f)
			{
				this.HBJJOCHGOPH = 1113f;
			}
			this.KDMBOKLMADJ().SetFloat("0.00", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat(").png", this.Size);
			this.FHFLKLMFHOI().SetFloat("z", this.Smooth);
			this.OGMEGHKECAH().SetFloat("The observed monobehaviour (", this.ICABEDDNGIH);
			this.DBOLLHHMKKN().SetFloat("grid", this.LHOMPJOPKHE);
			this.KDMBOKLMADJ().SetVector("Observed type is not serializable: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 572f, 1564f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005EF7 RID: 24311 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06005EF8 RID: 24312 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOLDLDLFFLM()
	{
	}

	// Token: 0x06005EF9 RID: 24313 RVA: 0x001CED07 File Offset: 0x001CCF07
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005EFA RID: 24314 RVA: 0x001CED3E File Offset: 0x001CCF3E
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find(" url: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005EFB RID: 24315 RVA: 0x001CED64 File Offset: 0x001CCF64
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 14f)
			{
				this.HBJJOCHGOPH = 627f;
			}
			this.OGMEGHKECAH().SetFloat("_Green_R", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat(" - ", this.Size);
			this.LNLKMDPHDCC().SetFloat("_Value", this.Smooth);
			this.EHDJJANLINB().SetFloat("PointsScoreText", this.ICABEDDNGIH);
			this.MCDGIILBNIF().SetFloat("workshop.", this.LHOMPJOPKHE);
			this.MMOODGIODPC().SetVector("OnStatusChanged: {0} current State: {1}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1992f, 280f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005EFC RID: 24316 RVA: 0x001CEE63 File Offset: 0x001CD063
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)73;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005EFD RID: 24317 RVA: 0x001CEE9A File Offset: 0x001CD09A
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005EFE RID: 24318 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06005EFF RID: 24319 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void LLKKGGLNIDF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F00 RID: 24320 RVA: 0x001CEED4 File Offset: 0x001CD0D4
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1119f)
			{
				this.HBJJOCHGOPH = 1545f;
			}
			this.KAFBNOBOIAJ().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.CEKJODEAMGB().SetFloat("JITTER", this.Size);
			this.CEKJODEAMGB().SetFloat("OpJoinRoom()", this.Smooth);
			this.BFGNMFCNDBC().SetFloat("In Main Menu", this.ICABEDDNGIH);
			this.LONNIJMNKFB().SetFloat("_AccumOrig", this.LHOMPJOPKHE);
			this.JLHLHKPHDFO().SetVector("_BlurRadius", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1390f, 1757f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F01 RID: 24321 RVA: 0x001CEFD4 File Offset: 0x001CD1D4
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 265f)
			{
				this.HBJJOCHGOPH = 713f;
			}
			this.CEKJODEAMGB().SetFloat("OpJoinRoom()", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("No child content found, exiting..", this.Size);
			this.MMOODGIODPC().SetFloat("icon", this.Smooth);
			this.OCHJIMJNEMO().SetFloat("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", this.ICABEDDNGIH);
			this.MCDGIILBNIF().SetFloat("player.orangearc", this.LHOMPJOPKHE);
			this.MCDGIILBNIF().SetVector(" BETA", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 454f, 1996f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F02 RID: 24322 RVA: 0x001CF0D4 File Offset: 0x001CD2D4
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1952f)
			{
				this.HBJJOCHGOPH = 1172f;
			}
			this.LNLKMDPHDCC().SetFloat("inventory.selected.", this.HBJJOCHGOPH);
			this.JLHLHKPHDFO().SetFloat("_MainTex2", this.Size);
			this.EHDJJANLINB().SetFloat("_Value4", this.Smooth);
			this.LONNIJMNKFB().SetFloat("_NoiseTex", this.ICABEDDNGIH);
			this.CIAFLBFJLEJ().SetFloat("Set satellite color", this.LHOMPJOPKHE);
			this.GJHPODJOBHL().SetVector("CameraFilterPack/Color_Contrast", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1693f, 326f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LONNIJMNKFB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F03 RID: 24323 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x06005F04 RID: 24324 RVA: 0x001CF1D4 File Offset: 0x001CD3D4
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 127f)
			{
				this.HBJJOCHGOPH = 1504f;
			}
			this.CEKJODEAMGB().SetFloat("id", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat(" PhotonView: ", this.Size);
			this.CEKJODEAMGB().SetFloat("<color=#{0}>{1}</color>", this.Smooth);
			this.KAFBNOBOIAJ().SetFloat("This might be a misconfiguration in the game server config. You need to edit it to a (public) address.", this.ICABEDDNGIH);
			this.LNLKMDPHDCC().SetFloat("_Value2", this.LHOMPJOPKHE);
			this.LNLKMDPHDCC().SetVector("The shader ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1915f, 1599f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F05 RID: 24325 RVA: 0x001CF2D3 File Offset: 0x001CD4D3
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("masterSteamID");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005F06 RID: 24326 RVA: 0x001CF2F8 File Offset: 0x001CD4F8
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1363f)
			{
				this.HBJJOCHGOPH = 1929f;
			}
			this.LNLKMDPHDCC().SetFloat("Set Trail Zoom (player camera move forward effect). Base value - 1.5", this.HBJJOCHGOPH);
			this.EHDJJANLINB().SetFloat("ICollection", this.Size);
			this.CIAFLBFJLEJ().SetFloat(".icon", this.Smooth);
			this.BFGNMFCNDBC().SetFloat("Set Satellite Color", this.ICABEDDNGIH);
			this.JLHLHKPHDFO().SetFloat("AccuracyScoreText", this.LHOMPJOPKHE);
			this.DNLMFEGJJDD().SetVector("player.russia", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1273f, 1057f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F07 RID: 24327 RVA: 0x001CF3F8 File Offset: 0x001CD5F8
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1987f)
			{
				this.HBJJOCHGOPH = 1208f;
			}
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack_Paper2", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("_TimeX", this.Size);
			this.CIAFLBFJLEJ().SetFloat(".lastCheckpoint.time", this.Smooth);
			this.KAFBNOBOIAJ().SetFloat("player", this.ICABEDDNGIH);
			this.BFGNMFCNDBC().SetFloat("_BgColor", this.LHOMPJOPKHE);
			this.KAFBNOBOIAJ().SetVector("file://", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 572f, 398f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F08 RID: 24328 RVA: 0x001CF4F7 File Offset: 0x001CD6F7
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F09 RID: 24329 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06005F0A RID: 24330 RVA: 0x001CF52E File Offset: 0x001CD72E
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)93;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F0B RID: 24331 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06005F0C RID: 24332 RVA: 0x001CF568 File Offset: 0x001CD768
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 421f)
			{
				this.HBJJOCHGOPH = 35f;
			}
			this.LNLKMDPHDCC().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("yyyy-MM-dd HH:mm:ss", this.Size);
			this.KDMBOKLMADJ().SetFloat("_Value6", this.Smooth);
			this.DBOLLHHMKKN().SetFloat("UsernameText", this.ICABEDDNGIH);
			this.EHDJJANLINB().SetFloat("DPADHOR", this.LHOMPJOPKHE);
			this.CIAFLBFJLEJ().SetVector("settings.gamemessagesduration", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 145f, 359f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F0D RID: 24333 RVA: 0x001CF668 File Offset: 0x001CD868
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 821f)
			{
				this.HBJJOCHGOPH = 1584f;
			}
			this.BFGNMFCNDBC().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetFloat("workshop.", this.Size);
			this.GJHPODJOBHL().SetFloat("#close", this.Smooth);
			this.LNLKMDPHDCC().SetFloat("Joystick1Button5", this.ICABEDDNGIH);
			this.DBOLLHHMKKN().SetFloat("_SunThreshold", this.LHOMPJOPKHE);
			this.NBPKMLMCHFN.SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 167f, 1748f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GJHPODJOBHL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F0E RID: 24334 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void OOGIHDLBBLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F0F RID: 24335 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F10 RID: 24336 RVA: 0x001CF767 File Offset: 0x001CD967
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F11 RID: 24337 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F12 RID: 24338 RVA: 0x001CF7A0 File Offset: 0x001CD9A0
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1021f)
			{
				this.HBJJOCHGOPH = 1488f;
			}
			this.KDMBOKLMADJ().SetFloat("Operation failed: ", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("_TimeX", this.Size);
			this.CEKJODEAMGB().SetFloat("\"x", this.Smooth);
			this.EHDJJANLINB().SetFloat("_Value3", this.ICABEDDNGIH);
			this.OGMEGHKECAH().SetFloat("_MainTex", this.LHOMPJOPKHE);
			this.KAFBNOBOIAJ().SetVector("] as we haven't received a full packet for delta compression yet. This is OK if it happens for the first few frames after joining a game.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1771f, 302f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F13 RID: 24339 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void MKFLBEGJJDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F14 RID: 24340 RVA: 0x001CF8A0 File Offset: 0x001CDAA0
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 268f)
			{
				this.HBJJOCHGOPH = 645f;
			}
			this.OCHJIMJNEMO().SetFloat("<b>Difficulty</b>:", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("_VelTex", this.Size);
			this.JLHLHKPHDFO().SetFloat("ready", this.Smooth);
			this.CEKJODEAMGB().SetFloat("0.00", this.ICABEDDNGIH);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.LHOMPJOPKHE);
			this.NBPKMLMCHFN.SetVector("value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1170f, 1472f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F15 RID: 24341 RVA: 0x001CF99F File Offset: 0x001CDB9F
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F16 RID: 24342 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F17 RID: 24343 RVA: 0x001CF9D8 File Offset: 0x001CDBD8
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 49f)
			{
				this.HBJJOCHGOPH = 479f;
			}
			this.DNLMFEGJJDD().SetFloat("closed", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("UI", this.Size);
			this.CIAFLBFJLEJ().SetFloat("CameraFilterPack/Broken_Screen", this.Smooth);
			this.CIAFLBFJLEJ().SetFloat("offline", this.ICABEDDNGIH);
			this.MCDGIILBNIF().SetFloat("id", this.LHOMPJOPKHE);
			this.JLHLHKPHDFO().SetVector("File not found: {0}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1552f, 942f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F18 RID: 24344 RVA: 0x001CFAD7 File Offset: 0x001CDCD7
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F19 RID: 24345 RVA: 0x001CFB0E File Offset: 0x001CDD0E
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("settings_bindings_controller_type");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005F1A RID: 24346 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06005F1B RID: 24347 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABMDEHEDNO()
	{
	}

	// Token: 0x06005F1C RID: 24348 RVA: 0x001CFB32 File Offset: 0x001CDD32
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F1D RID: 24349 RVA: 0x001CFB6C File Offset: 0x001CDD6C
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 93f)
			{
				this.HBJJOCHGOPH = 1674f;
			}
			this.FHFLKLMFHOI().SetFloat(".completed", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("CameraFilterPack/Noise_TV_3", this.Size);
			this.JLHLHKPHDFO().SetFloat("_Value2", this.Smooth);
			this.IONHGBPGCHK().SetFloat("Editor", this.ICABEDDNGIH);
			this.DNLMFEGJJDD().SetFloat("Set satellite trail width", this.LHOMPJOPKHE);
			this.OGMEGHKECAH().SetVector("Fill", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 892f, 1648f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F1E RID: 24350 RVA: 0x001CFC6C File Offset: 0x001CDE6C
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 598f)
			{
				this.HBJJOCHGOPH = 504f;
			}
			this.EHDJJANLINB().SetFloat("RequestSelectedLevel", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("IconImage", this.Size);
			this.IONHGBPGCHK().SetFloat("Set Sun Sensitivity", this.Smooth);
			this.KDMBOKLMADJ().SetFloat("Circle", this.ICABEDDNGIH);
			this.IONHGBPGCHK().SetFloat("_Speed", this.LHOMPJOPKHE);
			this.FHFLKLMFHOI().SetVector("r", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1846f, 41f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F1F RID: 24351 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x06005F20 RID: 24352 RVA: 0x001CFD6B File Offset: 0x001CDF6B
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F21 RID: 24353 RVA: 0x001CFDA2 File Offset: 0x001CDFA2
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("_Amount");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005F22 RID: 24354 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06005F23 RID: 24355 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06005F24 RID: 24356 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F25 RID: 24357 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F26 RID: 24358 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x06005F27 RID: 24359 RVA: 0x001CFDC8 File Offset: 0x001CDFC8
	private void BIMCKDIHBPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 982f)
			{
				this.HBJJOCHGOPH = 1832f;
			}
			this.OCHJIMJNEMO().SetFloat("[SaveSystem] Outdated savefile found", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("_Value3", this.Size);
			this.CIAFLBFJLEJ().SetFloat("appid", this.Smooth);
			this.KAFBNOBOIAJ().SetFloat("_ScreenResolution", this.ICABEDDNGIH);
			this.FHFLKLMFHOI().SetFloat("NEW_ACHIEVEMENT_1_", this.LHOMPJOPKHE);
			this.KAFBNOBOIAJ().SetVector("CameraFilterPack/3D_Inverse", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1661f, 1513f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F28 RID: 24360 RVA: 0x001CFEC7 File Offset: 0x001CE0C7
	private Material GJHPODJOBHL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F29 RID: 24361 RVA: 0x001CFEFE File Offset: 0x001CE0FE
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("note.1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005F2A RID: 24362 RVA: 0x001CFF24 File Offset: 0x001CE124
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 539f)
			{
				this.HBJJOCHGOPH = 329f;
			}
			this.IONHGBPGCHK().SetFloat("1177138211", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("checkpoint", this.Size);
			this.DNLMFEGJJDD().SetFloat("_Value2", this.Smooth);
			this.IONHGBPGCHK().SetFloat("CameraFilterPack/Blend2Camera_Difference", this.ICABEDDNGIH);
			this.IONHGBPGCHK().SetFloat("_FixDistance", this.LHOMPJOPKHE);
			this.NBPKMLMCHFN.SetVector("' was created: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1552f, 1110f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F2B RID: 24363 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F2C RID: 24364 RVA: 0x001D0024 File Offset: 0x001CE224
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 411f)
			{
				this.HBJJOCHGOPH = 1067f;
			}
			this.EHDJJANLINB().SetFloat("mapselector.filter.subscribedonly", this.HBJJOCHGOPH);
			this.CEKJODEAMGB().SetFloat("TransferOwnership() view ", this.Size);
			this.CIAFLBFJLEJ().SetFloat("LevelNameInputField", this.Smooth);
			this.IONHGBPGCHK().SetFloat("Set sun lerp speed", this.ICABEDDNGIH);
			this.GJHPODJOBHL().SetFloat("[LevelEditorScene] Print Audio Wave: Start", this.LHOMPJOPKHE);
			this.BFGNMFCNDBC().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1421f, 1680f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MMOODGIODPC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F2D RID: 24365 RVA: 0x001D0123 File Offset: 0x001CE323
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005F2E RID: 24366 RVA: 0x001D0147 File Offset: 0x001CE347
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F2F RID: 24367 RVA: 0x001D017E File Offset: 0x001CE37E
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F30 RID: 24368 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F31 RID: 24369 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F32 RID: 24370 RVA: 0x001D01B5 File Offset: 0x001CE3B5
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_WideScreenHV");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005F33 RID: 24371 RVA: 0x001D01D9 File Offset: 0x001CE3D9
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("Error: You're not logged into Steam!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005F34 RID: 24372 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void FKDEEJFNNJC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F35 RID: 24373 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F36 RID: 24374 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06005F37 RID: 24375 RVA: 0x001D01FD File Offset: 0x001CE3FD
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F38 RID: 24376 RVA: 0x001D0234 File Offset: 0x001CE434
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("player.xp");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005F39 RID: 24377 RVA: 0x001D0258 File Offset: 0x001CE458
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
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Smooth);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.ICABEDDNGIH);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.LHOMPJOPKHE);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F3A RID: 24378 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F3B RID: 24379 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F3C RID: 24380 RVA: 0x001D0358 File Offset: 0x001CE558
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1123f)
			{
				this.HBJJOCHGOPH = 191f;
			}
			this.CIAFLBFJLEJ().SetFloat("1427616858", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("NEW_ACHIEVEMENT_1_", this.Size);
			this.MMOODGIODPC().SetFloat("_TimeX", this.Smooth);
			this.OCHJIMJNEMO().SetFloat(" ", this.ICABEDDNGIH);
			this.CEKJODEAMGB().SetFloat("_Jitter", this.LHOMPJOPKHE);
			this.OGMEGHKECAH().SetVector("_MainTex2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 410f, 268f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F3D RID: 24381 RVA: 0x001D0458 File Offset: 0x001CE658
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 392f)
			{
				this.HBJJOCHGOPH = 862f;
			}
			this.MMOODGIODPC().SetFloat("DPADHOR", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("SlidingArea", this.Size);
			this.DBOLLHHMKKN().SetFloat("_ScreenResolution", this.Smooth);
			this.CIAFLBFJLEJ().SetFloat("settings.selectormapsperpage", this.ICABEDDNGIH);
			this.KDMBOKLMADJ().SetFloat("GroupNameText", this.LHOMPJOPKHE);
			this.OGMEGHKECAH().SetVector("Had to lookup view that wasn't in photonViewList: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 885f, 1998f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F3E RID: 24382 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F3F RID: 24383 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F40 RID: 24384 RVA: 0x001CEBE1 File Offset: 0x001CCDE1
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005F41 RID: 24385 RVA: 0x001D0558 File Offset: 0x001CE758
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 813f)
			{
				this.HBJJOCHGOPH = 1951f;
			}
			this.JLHLHKPHDFO().SetFloat("http", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("X", this.Size);
			this.GJHPODJOBHL().SetFloat(" x ", this.Smooth);
			this.KDMBOKLMADJ().SetFloat("GetGameList failed: ", this.ICABEDDNGIH);
			this.KAFBNOBOIAJ().SetFloat("_HexaColor", this.LHOMPJOPKHE);
			this.CEKJODEAMGB().SetVector("[PlayerController] ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 642f, 957f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F42 RID: 24386 RVA: 0x001D0657 File Offset: 0x001CE857
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)116;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F43 RID: 24387 RVA: 0x001D068E File Offset: 0x001CE88E
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("_LightIntensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005F44 RID: 24388 RVA: 0x001D06B4 File Offset: 0x001CE8B4
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 579f)
			{
				this.HBJJOCHGOPH = 815f;
			}
			this.EHDJJANLINB().SetFloat("PUN-instantiated '", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat("ConnectUsingSettings() failed. Can only connect while in state 'Disconnected'. Current state: ", this.Size);
			this.MCDGIILBNIF().SetFloat("</i>", this.Smooth);
			this.CEKJODEAMGB().SetFloat("_History3LumaTex", this.ICABEDDNGIH);
			this.GJHPODJOBHL().SetFloat("Mouse Wheel Down", this.LHOMPJOPKHE);
			this.NBPKMLMCHFN.SetVector("[Left]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1369f, 854f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F45 RID: 24389 RVA: 0x001D07B3 File Offset: 0x001CE9B3
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005F46 RID: 24390 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCDLIKEDMCF()
	{
	}

	// Token: 0x06005F47 RID: 24391 RVA: 0x001D07EC File Offset: 0x001CE9EC
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 179f)
			{
				this.HBJJOCHGOPH = 1114f;
			}
			this.DNLMFEGJJDD().SetFloat("float,0", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetFloat("LeaderboardsButton", this.Size);
			this.IONHGBPGCHK().SetFloat("Change Note:", this.Smooth);
			this.KAFBNOBOIAJ().SetFloat("\n\n#", this.ICABEDDNGIH);
			this.KDMBOKLMADJ().SetFloat("file://", this.LHOMPJOPKHE);
			this.KAFBNOBOIAJ().SetVector("CameraFilterPack/FX_8bits_gb", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1745f, 903f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005F48 RID: 24392 RVA: 0x001D08EB File Offset: 0x001CEAEB
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("MainCamera");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005F49 RID: 24393 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000111 RID: 273
	// (get) Token: 0x06005F4B RID: 24395 RVA: 0x001D094E File Offset: 0x001CEB4E
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

	// Token: 0x06005F4C RID: 24396 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F4D RID: 24397 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void MCKCCPLJIFE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F4E RID: 24398 RVA: 0x001D0985 File Offset: 0x001CEB85
	private void JONGNKNLLND()
	{
		this.SCShader = Shader.Find("Waiting for AvailableRegions. State: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005F4F RID: 24399 RVA: 0x001D09A9 File Offset: 0x001CEBA9
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("player.abstract");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005F50 RID: 24400 RVA: 0x0002523B File Offset: 0x0002343B
	private void APKNAPHOFHC()
	{
	}

	// Token: 0x06005F51 RID: 24401 RVA: 0x001CEA57 File Offset: 0x001CCC57
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005F52 RID: 24402 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x0400098E RID: 2446
	public Shader SCShader;

	// Token: 0x0400098F RID: 2447
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000990 RID: 2448
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000991 RID: 2449
	private Material BJFKDHHMLJH;

	// Token: 0x04000992 RID: 2450
	[Range(0f, 0.8f)]
	public float Size = 0.55f;

	// Token: 0x04000993 RID: 2451
	[Range(0.001f, 0.4f)]
	public float Smooth = 0.01f;

	// Token: 0x04000994 RID: 2452
	[Range(0f, 10f)]
	private float ICABEDDNGIH = 1f;

	// Token: 0x04000995 RID: 2453
	[Range(0f, 10f)]
	private float LHOMPJOPKHE = 1f;
}
