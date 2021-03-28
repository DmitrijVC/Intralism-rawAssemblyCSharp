using System;
using UnityEngine;

// Token: 0x02000070 RID: 112
[AddComponentMenu("Camera Filter Pack/Colors/GrayScale")]
[ExecuteInEditMode]
public class CameraFilterPack_Color_GrayScale : MonoBehaviour
{
	// Token: 0x06001F92 RID: 8082 RVA: 0x000BA9F8 File Offset: 0x000B8BF8
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 11f)
			{
				this.HBJJOCHGOPH = 490f;
			}
			this.FEAEGGCNIAA().SetFloat("pointBuffer", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("CameraFilterPack/Vision_Drost", this._Fade);
			this.HNFFHCLNBDN().SetVector("_Offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1185f, 1087f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F93 RID: 8083 RVA: 0x000BAAB5 File Offset: 0x000B8CB5
	private Material MLMKCOINOOH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F94 RID: 8084 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F95 RID: 8085 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void IENKPJEBMFM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F96 RID: 8086 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void BAEHKBADMAO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F97 RID: 8087 RVA: 0x000BAB09 File Offset: 0x000B8D09
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F98 RID: 8088 RVA: 0x000BAB40 File Offset: 0x000B8D40
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001F99 RID: 8089 RVA: 0x0002523B File Offset: 0x0002343B
	private void KPBKHFNLNBA()
	{
	}

	// Token: 0x06001F9A RID: 8090 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void JMAIIENCEKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F9B RID: 8091 RVA: 0x000BAB78 File Offset: 0x000B8D78
	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 135f)
			{
				this.HBJJOCHGOPH = 1671f;
			}
			this.MPENCEIGLEH().SetFloat("steamid", this.HBJJOCHGOPH);
			this.ADAFMBOGPLN().SetFloat("UpperMid", this._Fade);
			this.BLMPMOIDGMG().SetVector("_MaxBlurRadius", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 868f, 573f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F9C RID: 8092 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x06001F9D RID: 8093 RVA: 0x000BAC38 File Offset: 0x000B8E38
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
			this.NBPKMLMCHFN.SetFloat("_Fade", this._Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001F9E RID: 8094 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001F9F RID: 8095 RVA: 0x000BACF5 File Offset: 0x000B8EF5
	private Material PHGCJOPFDOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)109;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001FA0 RID: 8096 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06001FA1 RID: 8097 RVA: 0x000BAD2C File Offset: 0x000B8F2C
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1905f)
			{
				this.HBJJOCHGOPH = 1464f;
			}
			this.HHLFDHNEIAH().SetFloat("move", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("Clears the console and prints the logs in the specified range", this._Fade);
			this.EPCGJFCCAFH().SetVector("_BlurRadius4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1689f, 1488f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001FA2 RID: 8098 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFMEAMBLODG()
	{
	}

	// Token: 0x06001FA3 RID: 8099 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FA4 RID: 8100 RVA: 0x000BADE9 File Offset: 0x000B8FE9
	private void HPFOFGJPNCI()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001FA5 RID: 8101 RVA: 0x000BAE0D File Offset: 0x000B900D
	private void NDBPCNICGLC()
	{
		this.SCShader = Shader.Find("challenges.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001FA6 RID: 8102 RVA: 0x000BAE34 File Offset: 0x000B9034
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 447f)
			{
				this.HBJJOCHGOPH = 1957f;
			}
			this.INOBFNCKFGK().SetFloat("appid", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Can't set Room.MaxPlayers to: ", this._Fade);
			this.PHGCJOPFDOG().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1117f, 1662f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001FA7 RID: 8103 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void OMFBGCMHNBM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FA8 RID: 8104 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void KMIEAGOFLBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FA9 RID: 8105 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOAGAKFBIGD()
	{
	}

	// Token: 0x06001FAA RID: 8106 RVA: 0x000BAEF1 File Offset: 0x000B90F1
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find("_Red_B");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001FAB RID: 8107 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FAC RID: 8108 RVA: 0x000BAF15 File Offset: 0x000B9115
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("CreateRoom failed. In offline mode you still have to leave a room to enter another.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001FAD RID: 8109 RVA: 0x000BAF3C File Offset: 0x000B913C
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 663f)
			{
				this.HBJJOCHGOPH = 1529f;
			}
			this.HHLFDHNEIAH().SetFloat("SetupEncryption() called but ignored. Not XB1 compiled. EncryptionData: ", this.HBJJOCHGOPH);
			this.INOBFNCKFGK().SetFloat(", ", this._Fade);
			this.BFGNMFCNDBC().SetVector("SetSunMaxSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1021f, 1922f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECICEGFHKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001FAE RID: 8110 RVA: 0x000BAFF9 File Offset: 0x000B91F9
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("EnableRankedNotificationsToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001FAF RID: 8111 RVA: 0x000BB01D File Offset: 0x000B921D
	private void DOKAKEMDALN()
	{
		this.SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001FB0 RID: 8112 RVA: 0x000BB044 File Offset: 0x000B9244
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1585f)
			{
				this.HBJJOCHGOPH = 720f;
			}
			this.EPCGJFCCAFH().SetFloat("' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().", this.HBJJOCHGOPH);
			this.BLMPMOIDGMG().SetFloat("_Green_B", this._Fade);
			this.FKEOGPDLBDD().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 441f, 776f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CECICEGFHKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001FB1 RID: 8113 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x06001FB2 RID: 8114 RVA: 0x000BB104 File Offset: 0x000B9304
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 39f)
			{
				this.HBJJOCHGOPH = 1560f;
			}
			this.NMDBCDFPGOK().SetFloat("[NetworkManager] Connection failed: ", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("Chat", this._Fade);
			this.MALMMJNPILJ().SetVector("Texture2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1492f, 1737f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PHGCJOPFDOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001FB3 RID: 8115 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void KLDNGKBMDAN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FB4 RID: 8116 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void MKFLBEGJJDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FB5 RID: 8117 RVA: 0x000BB1C1 File Offset: 0x000B93C1
	private Material HKGAONMOBMH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)76;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001FB6 RID: 8118 RVA: 0x000BB1F8 File Offset: 0x000B93F8
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001FB7 RID: 8119 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x06001FB8 RID: 8120 RVA: 0x000BB230 File Offset: 0x000B9430
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 99f)
			{
				this.HBJJOCHGOPH = 605f;
			}
			this.FEAEGGCNIAA().SetFloat("No child content found, exiting..", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this._Fade);
			this.FLOHGDECHHH().SetVector("achievements.21.completed.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 234f, 1912f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001FB9 RID: 8121 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x06001FBA RID: 8122 RVA: 0x000BB2ED File Offset: 0x000B94ED
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)113;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001FBB RID: 8123 RVA: 0x000BB324 File Offset: 0x000B9524
	private void BEKMLIFILFP()
	{
		this.SCShader = Shader.Find("curScn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001FBC RID: 8124 RVA: 0x000BB348 File Offset: 0x000B9548
	private void BOPKKCAFODF()
	{
		this.SCShader = Shader.Find("#ok");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001FBD RID: 8125 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x06001FBE RID: 8126 RVA: 0x000BB36C File Offset: 0x000B956C
	private void JDKHBGDEONK()
	{
		this.SCShader = Shader.Find("_Offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001FBF RID: 8127 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FC0 RID: 8128 RVA: 0x000BB390 File Offset: 0x000B9590
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001FC1 RID: 8129 RVA: 0x000BB3C7 File Offset: 0x000B95C7
	private Material NMDBCDFPGOK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001FC2 RID: 8130 RVA: 0x000BB3FE File Offset: 0x000B95FE
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("visible");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001FC3 RID: 8131 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FC4 RID: 8132 RVA: 0x000BB422 File Offset: 0x000B9622
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find(".");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001FC5 RID: 8133 RVA: 0x000BB448 File Offset: 0x000B9648
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1280f)
			{
				this.HBJJOCHGOPH = 1675f;
			}
			this.HKGAONMOBMH().SetFloat("_Amount", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("AvatarImage", this._Fade);
			this.HKGAONMOBMH().SetVector("menu.playedpage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 827f, 769f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BLMPMOIDGMG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001FC6 RID: 8134 RVA: 0x000BB505 File Offset: 0x000B9705
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001FC7 RID: 8135 RVA: 0x000BB53C File Offset: 0x000B973C
	private void JABNHMIHBHC()
	{
		this.SCShader = Shader.Find("menuVolume");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001FC8 RID: 8136 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06001FC9 RID: 8137 RVA: 0x000BB560 File Offset: 0x000B9760
	private Material MALMMJNPILJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)102;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001FCA RID: 8138 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06001FCB RID: 8139 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void FAMLCFNDGNI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FCC RID: 8140 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06001FCD RID: 8141 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x06001FCE RID: 8142 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void DIGHKAJILJH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FCF RID: 8143 RVA: 0x000BB598 File Offset: 0x000B9798
	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1672f)
			{
				this.HBJJOCHGOPH = 288f;
			}
			this.MPENCEIGLEH().SetFloat("_Curve", this.HBJJOCHGOPH);
			this.MLMKCOINOOH().SetFloat("GlassDistortion", this._Fade);
			this.LDNADDJMIPK().SetVector("MaxLivesSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1910f, 1483f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HBLDMJCOAHA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001FD0 RID: 8144 RVA: 0x000BB658 File Offset: 0x000B9858
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1232f)
			{
				this.HBJJOCHGOPH = 1322f;
			}
			this.MPENCEIGLEH().SetFloat("#{0:00} '{1}'{2} {3}", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("_ScreenResolution", this._Fade);
			this.OKJOKHGJHGF().SetVector("x", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1307f, 1839f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001FD1 RID: 8145 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FD2 RID: 8146 RVA: 0x000BB718 File Offset: 0x000B9918
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1144f)
			{
				this.HBJJOCHGOPH = 1470f;
			}
			this.HNFFHCLNBDN().SetFloat("https://bugs.khb-soft.ru/set_project.php?project_id=1", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("ArcsDestroyDelaySlider", this._Fade);
			this.EPCGJFCCAFH().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 854f, 1402f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001FD3 RID: 8147 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FD4 RID: 8148 RVA: 0x000BADE9 File Offset: 0x000B8FE9
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001FD5 RID: 8149 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FD6 RID: 8150 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001FD7 RID: 8151 RVA: 0x000BB7D8 File Offset: 0x000B99D8
	private void AOGCKKLFGPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 970f)
			{
				this.HBJJOCHGOPH = 379f;
			}
			this.HFBJAOFLCJI().SetFloat("CHROMATIC_ABERRATION", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("float,0.5", this._Fade);
			this.NMDBCDFPGOK().SetVector("SaveButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1297f, 1691f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001FD8 RID: 8152 RVA: 0x000BB895 File Offset: 0x000B9A95
	private void MKOMIDCPCDC()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001FD9 RID: 8153 RVA: 0x000BB8B9 File Offset: 0x000B9AB9
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("Editing: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001FDB RID: 8155 RVA: 0x000BB8FC File Offset: 0x000B9AFC
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1149f)
			{
				this.HBJJOCHGOPH = 1094f;
			}
			this.FEAEGGCNIAA().SetFloat("error", this.HBJJOCHGOPH);
			this.FKEOGPDLBDD().SetFloat("CameraFilterPack/3D_BlackHole", this._Fade);
			this.PHGCJOPFDOG().SetVector("Cancel", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1878f, 873f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001FDC RID: 8156 RVA: 0x000BB9BC File Offset: 0x000B9BBC
	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1280f)
			{
				this.HBJJOCHGOPH = 373f;
			}
			this.BFGNMFCNDBC().SetFloat("_Red_C", this.HBJJOCHGOPH);
			this.HKGAONMOBMH().SetFloat("BitsData", this._Fade);
			this.NBPKMLMCHFN.SetVector("_Value5", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1935f, 139f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001FDD RID: 8157 RVA: 0x000BBA79 File Offset: 0x000B9C79
	private Material CECICEGFHKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001FDE RID: 8158 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FDF RID: 8159 RVA: 0x000BB1F8 File Offset: 0x000B93F8
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001FE0 RID: 8160 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBDEJFCNOBF()
	{
	}

	// Token: 0x06001FE1 RID: 8161 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x06001FE2 RID: 8162 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06001FE3 RID: 8163 RVA: 0x000BBAB0 File Offset: 0x000B9CB0
	private Material HHLFDHNEIAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001FE4 RID: 8164 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FE5 RID: 8165 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void OHIJGCLBMJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FE6 RID: 8166 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIPBNBKNICE()
	{
	}

	// Token: 0x06001FE7 RID: 8167 RVA: 0x000BBAE8 File Offset: 0x000B9CE8
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 809f)
			{
				this.HBJJOCHGOPH = 1648f;
			}
			this.MLMKCOINOOH().SetFloat("[PlayerController] ", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("_TimeX", this._Fade);
			this.OIIDAKBILMI().SetVector(" not exist", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1759f, 1083f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001FE8 RID: 8168 RVA: 0x000BBBA5 File Offset: 0x000B9DA5
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("AddEnvironmentObject");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001FE9 RID: 8169 RVA: 0x000BBBC9 File Offset: 0x000B9DC9
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Glitch2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001FEA RID: 8170 RVA: 0x000BBBED File Offset: 0x000B9DED
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001FEB RID: 8171 RVA: 0x000BBC24 File Offset: 0x000B9E24
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find(".lastCheckpoint.playerdistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001FEC RID: 8172 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FED RID: 8173 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FEE RID: 8174 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void EDCMIPNCPLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FEF RID: 8175 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void AAEEHINDPNC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FF0 RID: 8176 RVA: 0x000BBC48 File Offset: 0x000B9E48
	private void HAAFIECGECG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 24f)
			{
				this.HBJJOCHGOPH = 1738f;
			}
			this.HBLDMJCOAHA().SetFloat("Committing changes...", this.HBJJOCHGOPH);
			this.BLMPMOIDGMG().SetFloat("Freq: ", this._Fade);
			this.MPENCEIGLEH().SetVector("Joystick1Button7", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 395f, 1191f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001FF1 RID: 8177 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06001FF2 RID: 8178 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FF3 RID: 8179 RVA: 0x000BBD05 File Offset: 0x000B9F05
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001FF4 RID: 8180 RVA: 0x000BBD3C File Offset: 0x000B9F3C
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 208f)
			{
				this.HBJJOCHGOPH = 889f;
			}
			this.EPCGJFCCAFH().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.HBLDMJCOAHA().SetFloat("#updateoutdatedmap", this._Fade);
			this.FEAEGGCNIAA().SetVector("Texture3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1411f, 1909f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001FF5 RID: 8181 RVA: 0x000BBDF9 File Offset: 0x000B9FF9
	private void DPLLKHHLDBB()
	{
		this.SCShader = Shader.Find("IconImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001FF6 RID: 8182 RVA: 0x000BBE1D File Offset: 0x000BA01D
	private Material ADAFMBOGPLN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001FF7 RID: 8183 RVA: 0x000BAB09 File Offset: 0x000B8D09
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)121;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001FF8 RID: 8184 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void CAKNMILHHNE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FF9 RID: 8185 RVA: 0x000BBE54 File Offset: 0x000BA054
	private Material INOBFNCKFGK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001FFA RID: 8186 RVA: 0x000BBE8C File Offset: 0x000BA08C
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1816f)
			{
				this.HBJJOCHGOPH = 607f;
			}
			this.DKNJGHFLAIF().SetFloat("MapEnd", this.HBJJOCHGOPH);
			this.ADAFMBOGPLN().SetFloat("Can't set Room.MaxPlayers to: ", this._Fade);
			this.DKNJGHFLAIF().SetVector("_DotSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1338f, 1937f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HBLDMJCOAHA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001FFB RID: 8187 RVA: 0x000BBF49 File Offset: 0x000BA149
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("_Bloom4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001FFC RID: 8188 RVA: 0x000BBF6D File Offset: 0x000BA16D
	private Material MPENCEIGLEH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001FFD RID: 8189 RVA: 0x000BBFA4 File Offset: 0x000BA1A4
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1927f)
			{
				this.HBJJOCHGOPH = 610f;
			}
			this.HKGAONMOBMH().SetFloat("action", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("_TimeX", this._Fade);
			this.FEAEGGCNIAA().SetVector(": ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1425f, 1539f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001FFE RID: 8190 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void EKPLGFAEOBE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001FFF RID: 8191 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06002000 RID: 8192 RVA: 0x000BC064 File Offset: 0x000BA264
	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1718f)
			{
				this.HBJJOCHGOPH = 475f;
			}
			this.OKJOKHGJHGF().SetFloat("id", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("_BorderSize", this._Fade);
			this.MPENCEIGLEH().SetVector("steamid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 431f, 923f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002001 RID: 8193 RVA: 0x000BC121 File Offset: 0x000BA321
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Color_GrayScale");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002002 RID: 8194 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x06002003 RID: 8195 RVA: 0x000BC148 File Offset: 0x000BA348
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1473f)
			{
				this.HBJJOCHGOPH = 1448f;
			}
			this.EPCGJFCCAFH().SetFloat("PhotonView with ID {0} wasn't properly unregistered! Please report this case to developer@photonengine.com", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("22x1", this._Fade);
			this.FKEOGPDLBDD().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 711f, 671f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002004 RID: 8196 RVA: 0x000BC205 File Offset: 0x000BA405
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002005 RID: 8197 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002006 RID: 8198 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002007 RID: 8199 RVA: 0x000BC229 File Offset: 0x000BA429
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002008 RID: 8200 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002009 RID: 8201 RVA: 0x000BBE54 File Offset: 0x000BA054
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600200A RID: 8202 RVA: 0x000BC260 File Offset: 0x000BA460
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1189f)
			{
				this.HBJJOCHGOPH = 864f;
			}
			this.HBLDMJCOAHA().SetFloat("Commands for challenges", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("New level loaded. Removed ", this._Fade);
			this.AELJLBOJAIL().SetVector("OpJoinRandomRoom()", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1855f, 134f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600200B RID: 8203 RVA: 0x000BC31D File Offset: 0x000BA51D
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("Save Path: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600200C RID: 8204 RVA: 0x000BC341 File Offset: 0x000BA541
	private void CCFEDENFNEF()
	{
		this.SCShader = Shader.Find("[Sound Manager] Audio clip is null, cannot play music");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600200D RID: 8205 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x0600200E RID: 8206 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void FJABOCDLCAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600200F RID: 8207 RVA: 0x000BC365 File Offset: 0x000BA565
	private void FLKEJJEGCFA()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002010 RID: 8208 RVA: 0x000BC389 File Offset: 0x000BA589
	private void DLBODOFAJGM()
	{
		this.SCShader = Shader.Find("_EdgeThreshold");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002011 RID: 8209 RVA: 0x000BC3AD File Offset: 0x000BA5AD
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("#alreadystarted");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002012 RID: 8210 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06002013 RID: 8211 RVA: 0x000BC3D4 File Offset: 0x000BA5D4
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 273f)
			{
				this.HBJJOCHGOPH = 1458f;
			}
			this.HHLFDHNEIAH().SetFloat("LoadingStatusText", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("maps.", this._Fade);
			this.EPCGJFCCAFH().SetVector("Editor/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 98f, 217f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000056 RID: 86
	// (get) Token: 0x06002014 RID: 8212 RVA: 0x000BC491 File Offset: 0x000BA691
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

	// Token: 0x06002015 RID: 8213 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void NDDNJNCINDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002016 RID: 8214 RVA: 0x000BC4C8 File Offset: 0x000BA6C8
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1728f)
			{
				this.HBJJOCHGOPH = 1523f;
			}
			this.HBLDMJCOAHA().SetFloat("SpawnObj", this.HBJJOCHGOPH);
			this.INOBFNCKFGK().SetFloat("_Value4", this._Fade);
			this.OKJOKHGJHGF().SetVector("MenuVolumeSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 735f, 1815f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EPCGJFCCAFH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002017 RID: 8215 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x06002018 RID: 8216 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void PNNPDMHLFHE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002019 RID: 8217 RVA: 0x000BC588 File Offset: 0x000BA788
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 90f)
			{
				this.HBJJOCHGOPH = 529f;
			}
			this.HBLDMJCOAHA().SetFloat("_Value", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("wss://", this._Fade);
			this.PHGCJOPFDOG().SetVector("<color=#{0}>{1}</color>", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 712f, 195f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600201A RID: 8218 RVA: 0x000BC645 File Offset: 0x000BA845
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600201B RID: 8219 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void ELDMKIAPNGP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600201C RID: 8220 RVA: 0x000BC67C File Offset: 0x000BA87C
	private void ODBNMPGBCGO()
	{
		this.SCShader = Shader.Find("[PlayerController] ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600201D RID: 8221 RVA: 0x000BC6A0 File Offset: 0x000BA8A0
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600201E RID: 8222 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x0600201F RID: 8223 RVA: 0x000BC6D7 File Offset: 0x000BA8D7
	private void MMPHNFPPEHO()
	{
		this.SCShader = Shader.Find("UI");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002020 RID: 8224 RVA: 0x000BC6FB File Offset: 0x000BA8FB
	private Material HBLDMJCOAHA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002021 RID: 8225 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void ODLMOJDBPPG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002022 RID: 8226 RVA: 0x000BC732 File Offset: 0x000BA932
	private void ALNNIDLFILB()
	{
		this.SCShader = Shader.Find("#failed: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002023 RID: 8227 RVA: 0x000BC758 File Offset: 0x000BA958
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1097f)
			{
				this.HBJJOCHGOPH = 1789f;
			}
			this.DKNJGHFLAIF().SetFloat("/icon", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("CameraFilterPack/AAA_WaterDrop", this._Fade);
			this.MLMKCOINOOH().SetVector("_Axis", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 674f, 1510f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002024 RID: 8228 RVA: 0x000BAAEC File Offset: 0x000B8CEC
	private void DHNGNHGDPLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002025 RID: 8229 RVA: 0x000BC815 File Offset: 0x000BAA15
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002026 RID: 8230 RVA: 0x000BC84C File Offset: 0x000BAA4C
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)100;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x04000429 RID: 1065
	public Shader SCShader;

	// Token: 0x0400042A RID: 1066
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400042B RID: 1067
	[Range(0f, 1f)]
	public float _Fade = 1f;

	// Token: 0x0400042C RID: 1068
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400042D RID: 1069
	private Material BJFKDHHMLJH;
}
