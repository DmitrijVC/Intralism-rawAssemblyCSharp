using System;
using UnityEngine;

// Token: 0x020000C8 RID: 200
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Glitch/Glitch1")]
public class CameraFilterPack_FX_Glitch1 : MonoBehaviour
{
	// Token: 0x06003C34 RID: 15412 RVA: 0x0012F4B3 File Offset: 0x0012D6B3
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("Items");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003C35 RID: 15413 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C36 RID: 15414 RVA: 0x0012F4F4 File Offset: 0x0012D6F4
	private void ECBILENEOOL()
	{
		this.SCShader = Shader.Find("_Speed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003C37 RID: 15415 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x06003C38 RID: 15416 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06003C39 RID: 15417 RVA: 0x0012F518 File Offset: 0x0012D718
	private void ADPLHDFJFID()
	{
		this.SCShader = Shader.Find("#random #rare #item");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003C3A RID: 15418 RVA: 0x0012F53C File Offset: 0x0012D73C
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003C3B RID: 15419 RVA: 0x0012F560 File Offset: 0x0012D760
	private void FIJHDKIPENG()
	{
		this.SCShader = Shader.Find("#savemapbeforeuploading");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003C3C RID: 15420 RVA: 0x0012F584 File Offset: 0x0012D784
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-110);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C3D RID: 15421 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void BDBJEDIOKBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C3E RID: 15422 RVA: 0x0012F5BB File Offset: 0x0012D7BB
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C3F RID: 15423 RVA: 0x0012F5F2 File Offset: 0x0012D7F2
	private Material INOBFNCKFGK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C40 RID: 15424 RVA: 0x0012F629 File Offset: 0x0012D829
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C41 RID: 15425 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x06003C42 RID: 15426 RVA: 0x0012F660 File Offset: 0x0012D860
	private void JDKHBGDEONK()
	{
		this.SCShader = Shader.Find("Using PhotonServerSettings.Protocol when leaving the NameServer (AuthMode is AuthOnceWss): ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003C43 RID: 15427 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x06003C44 RID: 15428 RVA: 0x0012F684 File Offset: 0x0012D884
	private void FEHCNJLLJMP()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003C45 RID: 15429 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x06003C46 RID: 15430 RVA: 0x0012F6A8 File Offset: 0x0012D8A8
	private void EENEOAPPGJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1540f)
			{
				this.HBJJOCHGOPH = 512f;
			}
			this.DKKBFFHBHJE().SetFloat("ConnectUsingSettings() disabled the offline mode. No longer offline.", this.HBJJOCHGOPH);
			this.HEHKGPKLAKK().SetFloat("Texture2", this.Glitch);
			this.NBPKMLMCHFN.SetVector("_Distortion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1124f, 1822f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CBCNOEIALHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C47 RID: 15431 RVA: 0x0012F765 File Offset: 0x0012D965
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C48 RID: 15432 RVA: 0x0012F79C File Offset: 0x0012D99C
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003C49 RID: 15433 RVA: 0x0002523B File Offset: 0x0002343B
	private void MBLDJEFBLFL()
	{
	}

	// Token: 0x06003C4A RID: 15434 RVA: 0x0012F7C0 File Offset: 0x0012D9C0
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("UseFinalGlassColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003C4B RID: 15435 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06003C4C RID: 15436 RVA: 0x0012F7E4 File Offset: 0x0012D9E4
	private void MKOMIDCPCDC()
	{
		this.SCShader = Shader.Find("Warning: Unhandled Event ErrorInfo (251). Set PhotonNetwork.OnEventCall to the method PUN should call for this event.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003C4D RID: 15437 RVA: 0x0012F808 File Offset: 0x0012DA08
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Vision_AuraDistortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003C4E RID: 15438 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBPCODPOJAH()
	{
	}

	// Token: 0x06003C4F RID: 15439 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C50 RID: 15440 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C51 RID: 15441 RVA: 0x0012F82C File Offset: 0x0012DA2C
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1678f)
			{
				this.HBJJOCHGOPH = 714f;
			}
			this.LPPEPKGFOEM().SetFloat("Delete events", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("X", this.Glitch);
			this.INOBFNCKFGK().SetVector("_FadeDistance", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1805f, 1053f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C52 RID: 15442 RVA: 0x0012F8EC File Offset: 0x0012DAEC
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1887f)
			{
				this.HBJJOCHGOPH = 1143f;
			}
			this.DNLMFEGJJDD().SetFloat("steamid", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("settings.volume.menu", this.Glitch);
			this.AELJLBOJAIL().SetVector("CameraFilterPack/Distortion_Flush", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1646f, 1390f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C53 RID: 15443 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x06003C54 RID: 15444 RVA: 0x0012F9A9 File Offset: 0x0012DBA9
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C55 RID: 15445 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C56 RID: 15446 RVA: 0x0012F9E0 File Offset: 0x0012DBE0
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 966f)
			{
				this.HBJJOCHGOPH = 1529f;
			}
			this.OGMEGHKECAH().SetFloat("error", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("88f00bdf0ad61b16b803971ebe071962", this.Glitch);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1f, 863f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C57 RID: 15447 RVA: 0x0012FA9D File Offset: 0x0012DC9D
	private void KOFAMEKHHGD()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003C58 RID: 15448 RVA: 0x0012FAC4 File Offset: 0x0012DCC4
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
			this.NBPKMLMCHFN.SetFloat("_Glitch", this.Glitch);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C59 RID: 15449 RVA: 0x0012FB81 File Offset: 0x0012DD81
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("UseScanLineSize");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003C5A RID: 15450 RVA: 0x0012FBA5 File Offset: 0x0012DDA5
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C5B RID: 15451 RVA: 0x0012FBDC File Offset: 0x0012DDDC
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("_FixDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003C5C RID: 15452 RVA: 0x0012FC00 File Offset: 0x0012DE00
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C5D RID: 15453 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C5E RID: 15454 RVA: 0x0012FC37 File Offset: 0x0012DE37
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003C5F RID: 15455 RVA: 0x0012FC5C File Offset: 0x0012DE5C
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 543f)
			{
				this.HBJJOCHGOPH = 855f;
			}
			this.ADBKPGFMNKO().SetFloat(" ", this.HBJJOCHGOPH);
			this.HKIMAANBGMJ().SetFloat("Connected to masterserver.", this.Glitch);
			this.HFBJAOFLCJI().SetVector("ViewMenu", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 336f, 555f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.INOBFNCKFGK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C60 RID: 15456 RVA: 0x0012FD1C File Offset: 0x0012DF1C
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1482f)
			{
				this.HBJJOCHGOPH = 598f;
			}
			this.ADBKPGFMNKO().SetFloat("OPEN FILE", this.HBJJOCHGOPH);
			this.KHCLIAMBBNC().SetFloat(".lastCheckpoint.powerupsScore", this.Glitch);
			this.HFBJAOFLCJI().SetVector("Parent ID", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 523f, 1365f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C61 RID: 15457 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06003C62 RID: 15458 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void PNNPDMHLFHE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C63 RID: 15459 RVA: 0x0012FDD9 File Offset: 0x0012DFD9
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("_BokehParams");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003C64 RID: 15460 RVA: 0x0012FDFD File Offset: 0x0012DFFD
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C65 RID: 15461 RVA: 0x0012FE34 File Offset: 0x0012E034
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C66 RID: 15462 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x170000AE RID: 174
	// (get) Token: 0x06003C67 RID: 15463 RVA: 0x0012FE6B File Offset: 0x0012E06B
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

	// Token: 0x06003C68 RID: 15464 RVA: 0x0012FEA2 File Offset: 0x0012E0A2
	private void MEBPBNLBECA()
	{
		this.SCShader = Shader.Find("editor.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003C69 RID: 15465 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C6A RID: 15466 RVA: 0x0012FEC8 File Offset: 0x0012E0C8
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 185f)
			{
				this.HBJJOCHGOPH = 776f;
			}
			this.KAFBNOBOIAJ().SetFloat("ExitGames.Client.Photon.SocketWebTcp, Assembly-CSharp-firstpass", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("_Value2", this.Glitch);
			this.FAIFBBGFAIB().SetVector("settings_bindings_", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1036f, 1007f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C6B RID: 15467 RVA: 0x0012FF88 File Offset: 0x0012E188
	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 986f)
			{
				this.HBJJOCHGOPH = 1664f;
			}
			this.ADBKPGFMNKO().SetFloat("powerup.1", this.HBJJOCHGOPH);
			this.INOBFNCKFGK().SetFloat("misses", this.Glitch);
			this.CBCNOEIALHB().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 414f, 824f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C6C RID: 15468 RVA: 0x00130048 File Offset: 0x0012E248
	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 482f)
			{
				this.HBJJOCHGOPH = 1229f;
			}
			this.OGMEGHKECAH().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.LPPEPKGFOEM().SetFloat("_ScreenResolution", this.Glitch);
			this.DKNJGHFLAIF().SetVector("_ProjectToPixelMatrix", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1175f, 1541f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C6D RID: 15469 RVA: 0x00130105 File Offset: 0x0012E305
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("Set satellite trail length in seconds");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003C6E RID: 15470 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C6F RID: 15471 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x06003C70 RID: 15472 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06003C71 RID: 15473 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06003C72 RID: 15474 RVA: 0x00130129 File Offset: 0x0012E329
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003C74 RID: 15476 RVA: 0x0013016C File Offset: 0x0012E36C
	private void MHGGJOAHGLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 14f)
			{
				this.HBJJOCHGOPH = 344f;
			}
			this.HKIMAANBGMJ().SetFloat("[LobbyPlayerElement] On ready click", this.HBJJOCHGOPH);
			this.LPPEPKGFOEM().SetFloat("In Main Menu", this.Glitch);
			this.KDMBOKLMADJ().SetVector("CameraFilterPack/BlurTiltShift", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 931f, 1475f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C75 RID: 15477 RVA: 0x0012F684 File Offset: 0x0012D884
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003C76 RID: 15478 RVA: 0x00130229 File Offset: 0x0012E429
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C77 RID: 15479 RVA: 0x0012FBA5 File Offset: 0x0012DDA5
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C78 RID: 15480 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x06003C79 RID: 15481 RVA: 0x00130129 File Offset: 0x0012E329
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003C7A RID: 15482 RVA: 0x00130260 File Offset: 0x0012E460
	private void HIPEHGNBJMN()
	{
		this.SCShader = Shader.Find("LevelConfigButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003C7B RID: 15483 RVA: 0x00130284 File Offset: 0x0012E484
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("shader.future");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003C7C RID: 15484 RVA: 0x001302A8 File Offset: 0x0012E4A8
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C7D RID: 15485 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDBBPKIFNJ()
	{
	}

	// Token: 0x06003C7E RID: 15486 RVA: 0x001302DF File Offset: 0x0012E4DF
	private Material CBCNOEIALHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C7F RID: 15487 RVA: 0x0012FC37 File Offset: 0x0012DE37
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003C80 RID: 15488 RVA: 0x00130318 File Offset: 0x0012E518
	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1066f)
			{
				this.HBJJOCHGOPH = 492f;
			}
			this.LPPEPKGFOEM().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("_ReflectionTexture2", this.Glitch);
			this.HEHKGPKLAKK().SetVector("PlayerBase_", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1233f, 1812f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C81 RID: 15489 RVA: 0x001303D8 File Offset: 0x0012E5D8
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 766f)
			{
				this.HBJJOCHGOPH = 503f;
			}
			this.LPPEPKGFOEM().SetFloat("LevelFolderInputField", this.HBJJOCHGOPH);
			this.KHCLIAMBBNC().SetFloat("CameraFilterPack/Blend2Camera_Lighten", this.Glitch);
			this.LNLKMDPHDCC().SetVector("_History4LumaTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1363f, 1316f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C82 RID: 15490 RVA: 0x00130495 File Offset: 0x0012E695
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_Glitch1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003C83 RID: 15491 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C84 RID: 15492 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06003C85 RID: 15493 RVA: 0x001304B9 File Offset: 0x0012E6B9
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("LevelURLInputField");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003C86 RID: 15494 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void GJAJBMGGPFB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C87 RID: 15495 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C88 RID: 15496 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C89 RID: 15497 RVA: 0x001304DD File Offset: 0x0012E6DD
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("Is Clone ?: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003C8A RID: 15498 RVA: 0x00130504 File Offset: 0x0012E704
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1323f)
			{
				this.HBJJOCHGOPH = 1535f;
			}
			this.NJDIODJNGGA().SetFloat(": ", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("STICKRVER", this.Glitch);
			this.DKKBFFHBHJE().SetVector("StartRound", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 431f, 1795f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C8B RID: 15499 RVA: 0x001305C4 File Offset: 0x0012E7C4
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1508f)
			{
				this.HBJJOCHGOPH = 1669f;
			}
			this.HKIMAANBGMJ().SetFloat("CameraFilterPack_TV_BrokenGlass_2", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("0", this.Glitch);
			this.NBPKMLMCHFN.SetVector("win", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 96f, 143f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C8C RID: 15500 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06003C8D RID: 15501 RVA: 0x00130681 File Offset: 0x0012E881
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C8E RID: 15502 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06003C8F RID: 15503 RVA: 0x001306B8 File Offset: 0x0012E8B8
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1678f)
			{
				this.HBJJOCHGOPH = 71f;
			}
			this.LPPEPKGFOEM().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("_TimeX", this.Glitch);
			this.INOBFNCKFGK().SetVector("CameraFilterPack_Paper4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 929f, 1097f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C90 RID: 15504 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C91 RID: 15505 RVA: 0x00130775 File Offset: 0x0012E975
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C92 RID: 15506 RVA: 0x001307AC File Offset: 0x0012E9AC
	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 818f)
			{
				this.HBJJOCHGOPH = 987f;
			}
			this.FHFLKLMFHOI().SetFloat("MapEnd", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("(\\[ */ *i *\\])", this.Glitch);
			this.OGMEGHKECAH().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 932f, 534f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C93 RID: 15507 RVA: 0x00130869 File Offset: 0x0012EA69
	private Material KHCLIAMBBNC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C94 RID: 15508 RVA: 0x001308A0 File Offset: 0x0012EAA0
	private Material LPPEPKGFOEM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C95 RID: 15509 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C96 RID: 15510 RVA: 0x001308D7 File Offset: 0x0012EAD7
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C97 RID: 15511 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C98 RID: 15512 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06003C99 RID: 15513 RVA: 0x0013090E File Offset: 0x0012EB0E
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInBuild;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C9A RID: 15514 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003C9B RID: 15515 RVA: 0x00130945 File Offset: 0x0012EB45
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("PunRespawn with Position.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003C9C RID: 15516 RVA: 0x00130969 File Offset: 0x0012EB69
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003C9D RID: 15517 RVA: 0x001309A0 File Offset: 0x0012EBA0
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1001f)
			{
				this.HBJJOCHGOPH = 1701f;
			}
			this.KHCLIAMBBNC().SetFloat("resource id", this.HBJJOCHGOPH);
			this.INOBFNCKFGK().SetFloat("_Distortion", this.Glitch);
			this.LNLKMDPHDCC().SetVector("settings_bindings_sec_", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 187f, 1901f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C9E RID: 15518 RVA: 0x00130A60 File Offset: 0x0012EC60
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 365f)
			{
				this.HBJJOCHGOPH = 1958f;
			}
			this.FAIFBBGFAIB().SetFloat("stats on", this.HBJJOCHGOPH);
			this.HKIMAANBGMJ().SetFloat(" ", this.Glitch);
			this.HFBJAOFLCJI().SetVector("OnAwakeRPC", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1694f, 657f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003C9F RID: 15519 RVA: 0x00130B20 File Offset: 0x0012ED20
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 333f)
			{
				this.HBJJOCHGOPH = 659f;
			}
			this.LPPEPKGFOEM().SetFloat("maps.", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("DPADHOR", this.Glitch);
			this.ADBKPGFMNKO().SetVector("st", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 683f, 16f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003CA0 RID: 15520 RVA: 0x00130BE0 File Offset: 0x0012EDE0
	private void ABHEECINLJA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 760f)
			{
				this.HBJJOCHGOPH = 1943f;
			}
			this.LPPEPKGFOEM().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.OIIDAKBILMI().SetFloat("_TimeX", this.Glitch);
			this.KDMBOKLMADJ().SetVector("ChallengesButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1110f, 398f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003CA1 RID: 15521 RVA: 0x0002523B File Offset: 0x0002343B
	private void ABFNJCEBIKA()
	{
	}

	// Token: 0x06003CA2 RID: 15522 RVA: 0x00130C9D File Offset: 0x0012EE9D
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find("RecieveChatActionMessage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003CA3 RID: 15523 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CA4 RID: 15524 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void FDPOFMCFBMF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CA5 RID: 15525 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CA6 RID: 15526 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x06003CA7 RID: 15527 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CA8 RID: 15528 RVA: 0x00130CC4 File Offset: 0x0012EEC4
	private void ABIOAMNCEOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 899f)
			{
				this.HBJJOCHGOPH = 1022f;
			}
			this.FAIFBBGFAIB().SetFloat("warning: Audio Source: ", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetFloat("_SunThreshold", this.Glitch);
			this.LENEJAGLCNL().SetVector("_BaseTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1024f, 1980f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003CA9 RID: 15529 RVA: 0x0012F4D7 File Offset: 0x0012D6D7
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003CAA RID: 15530 RVA: 0x00130D81 File Offset: 0x0012EF81
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003CAB RID: 15531 RVA: 0x00130DB8 File Offset: 0x0012EFB8
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 322f)
			{
				this.HBJJOCHGOPH = 575f;
			}
			this.LNLKMDPHDCC().SetFloat("help", this.HBJJOCHGOPH);
			this.CBCNOEIALHB().SetFloat(",", this.Glitch);
			this.LENEJAGLCNL().SetVector("ns", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1219f, 1010f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CBCNOEIALHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0400069B RID: 1691
	public Shader SCShader;

	// Token: 0x0400069C RID: 1692
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400069D RID: 1693
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400069E RID: 1694
	private Material BJFKDHHMLJH;

	// Token: 0x0400069F RID: 1695
	[Range(0f, 1f)]
	public float Glitch = 1f;
}
