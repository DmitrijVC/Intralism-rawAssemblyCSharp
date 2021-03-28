using System;
using UnityEngine;

// Token: 0x02000125 RID: 293
[AddComponentMenu("Camera Filter Pack/VHS/VHS_Rewind")]
[ExecuteInEditMode]
public class CameraFilterPack_TV_VHS_Rewind : MonoBehaviour
{
	// Token: 0x06005C7C RID: 23676 RVA: 0x001C57A3 File Offset: 0x001C39A3
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find("(\\[ */ *quote *\\])");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005C7D RID: 23677 RVA: 0x001C57C7 File Offset: 0x001C39C7
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("_VelocityScale");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005C7E RID: 23678 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x06005C7F RID: 23679 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06005C80 RID: 23680 RVA: 0x001C57EB File Offset: 0x001C39EB
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C81 RID: 23681 RVA: 0x001C5808 File Offset: 0x001C3A08
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-94);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005C82 RID: 23682 RVA: 0x001C5840 File Offset: 0x001C3A40
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 61f)
			{
				this.HBJJOCHGOPH = 366f;
			}
			this.KJMECMIGJJA().SetFloat("_Far", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("_Red_R", this.Cryptage);
			this.KBOPGONOCNP().SetFloat("cmd.exe", this.Parasite);
			this.KAFBNOBOIAJ().SetFloat("SetSatelliteSensitivity", this.Parasite2);
			this.OKJOKHGJHGF().SetFloat("Reload Steam Inventory", this.FIOHJEJCGAK);
			this.HKHBBBFLGJH().SetVector(".lastCheckpoint.time", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 284f, 1295f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C83 RID: 23683 RVA: 0x001C593F File Offset: 0x001C3B3F
	private void JHANGPCOCIG()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005C84 RID: 23684 RVA: 0x001C57EB File Offset: 0x001C39EB
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C85 RID: 23685 RVA: 0x001C57EB File Offset: 0x001C39EB
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C86 RID: 23686 RVA: 0x001C5963 File Offset: 0x001C3B63
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005C87 RID: 23687 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x06005C88 RID: 23688 RVA: 0x001C599A File Offset: 0x001C3B9A
	private void FDNONDCGGCG()
	{
		this.SCShader = Shader.Find("roomDescription");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C89 RID: 23689 RVA: 0x001C59BE File Offset: 0x001C3BBE
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005C8A RID: 23690 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x06005C8B RID: 23691 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06005C8C RID: 23692 RVA: 0x001C59F5 File Offset: 0x001C3BF5
	private void FLKEJJEGCFA()
	{
		this.SCShader = Shader.Find("setbool");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C8D RID: 23693 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x06005C8E RID: 23694 RVA: 0x001C5A19 File Offset: 0x001C3C19
	private void ECBILENEOOL()
	{
		this.SCShader = Shader.Find("gameVolume");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C8F RID: 23695 RVA: 0x001C5A3D File Offset: 0x001C3C3D
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find("USE_UV_BASED_REPROJECTION");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C90 RID: 23696 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06005C91 RID: 23697 RVA: 0x001C5A61 File Offset: 0x001C3C61
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005C92 RID: 23698 RVA: 0x001C5A98 File Offset: 0x001C3C98
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("violet");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005C93 RID: 23699 RVA: 0x001C57EB File Offset: 0x001C39EB
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C94 RID: 23700 RVA: 0x001C5ABC File Offset: 0x001C3CBC
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 876f)
			{
				this.HBJJOCHGOPH = 875f;
			}
			this.CFEDGDGBCHE().SetFloat("#,0", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("return ", this.Cryptage);
			this.EHDJJANLINB().SetFloat("_Value2", this.Parasite);
			this.LPCHMEKDCHI().SetFloat("SettingsCanvas", this.Parasite2);
			this.BFGNMFCNDBC().SetFloat("CameraFilterPack/FX_Drunk2", this.FIOHJEJCGAK);
			this.OLHDPICFBOF().SetVector("PLEASE WAIT", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1248f, 68f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C95 RID: 23701 RVA: 0x001C57EB File Offset: 0x001C39EB
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C96 RID: 23702 RVA: 0x0002523B File Offset: 0x0002343B
	private void MDCFIHDPLIG()
	{
	}

	// Token: 0x06005C97 RID: 23703 RVA: 0x001C5BBB File Offset: 0x001C3DBB
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005C98 RID: 23704 RVA: 0x001C5BF2 File Offset: 0x001C3DF2
	private void JONGNKNLLND()
	{
		this.SCShader = Shader.Find("&page=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005C99 RID: 23705 RVA: 0x001C5C16 File Offset: 0x001C3E16
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("action");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005C9A RID: 23706 RVA: 0x001C57EB File Offset: 0x001C39EB
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005C9B RID: 23707 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x06005C9C RID: 23708 RVA: 0x001C5C3C File Offset: 0x001C3E3C
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 318f)
			{
				this.HBJJOCHGOPH = 750f;
			}
			this.EHDJJANLINB().SetFloat("CameraMovementSlider", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("Texture2", this.Cryptage);
			this.NBPKMLMCHFN.SetFloat("_SSAO", this.Parasite);
			this.CFEDGDGBCHE().SetFloat("ScrollPanel", this.Parasite2);
			this.CEKJODEAMGB().SetFloat("SpawnObj", this.FIOHJEJCGAK);
			this.KAFBNOBOIAJ().SetVector("_Value5", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1270f, 1855f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C9D RID: 23709 RVA: 0x001C5D3C File Offset: 0x001C3F3C
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Cryptage);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Parasite);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Parasite2);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.FIOHJEJCGAK);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C9E RID: 23710 RVA: 0x001C5E3C File Offset: 0x001C403C
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1736f)
			{
				this.HBJJOCHGOPH = 898f;
			}
			this.EOCCJGIGEGJ().SetFloat("#tryagain", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("_History4ChromaTex", this.Cryptage);
			this.OKJOKHGJHGF().SetFloat("settings.hitvariation", this.Parasite);
			this.KJMECMIGJJA().SetFloat("Have you fully accept the terms?", this.Parasite2);
			this.NBPKMLMCHFN.SetFloat("_SprTex", this.FIOHJEJCGAK);
			this.CFEDGDGBCHE().SetVector("OnJoinedRoom() called by PUN. Now this client is in a room. From here on, your game would be running. For reference, all callbacks are listed in enum: PhotonNetworkingMessage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 35f, 1493f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005C9F RID: 23711 RVA: 0x001C5F3B File Offset: 0x001C413B
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("_OcclusionTexture");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005CA0 RID: 23712 RVA: 0x001C5F5F File Offset: 0x001C415F
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)109;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005CA1 RID: 23713 RVA: 0x001C5F96 File Offset: 0x001C4196
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005CA2 RID: 23714 RVA: 0x001C5FCD File Offset: 0x001C41CD
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005CA3 RID: 23715 RVA: 0x001C6004 File Offset: 0x001C4204
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005CA4 RID: 23716 RVA: 0x001C603B File Offset: 0x001C423B
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005CA5 RID: 23717 RVA: 0x001C57EB File Offset: 0x001C39EB
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005CA6 RID: 23718 RVA: 0x001C6074 File Offset: 0x001C4274
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1772f)
			{
				this.HBJJOCHGOPH = 1002f;
			}
			this.CFCPHFMKHII().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("Tab1Content", this.Cryptage);
			this.IGKFMCPDNOI().SetFloat("RestartButton", this.Parasite);
			this.EHDJJANLINB().SetFloat("#forever", this.Parasite2);
			this.KBOPGONOCNP().SetFloat("RecieveChatMessage", this.FIOHJEJCGAK);
			this.OKJOKHGJHGF().SetVector(": ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 813f, 117f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005CA7 RID: 23719 RVA: 0x001C6174 File Offset: 0x001C4374
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1915f)
			{
				this.HBJJOCHGOPH = 241f;
			}
			this.KJMECMIGJJA().SetFloat("LeaderboardsButton", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("127.0.0.1", this.Cryptage);
			this.EHDJJANLINB().SetFloat("_RangeScale", this.Parasite);
			this.JFDGLLEOPGB().SetFloat("_MainTex2", this.Parasite2);
			this.JIBOKBCPDLC().SetFloat("Error: Cannot change the name of a remote player!", this.FIOHJEJCGAK);
			this.NBPKMLMCHFN.SetVector("_Offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 209f, 1027f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005CA8 RID: 23720 RVA: 0x001C6273 File Offset: 0x001C4473
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005CA9 RID: 23721 RVA: 0x001C6298 File Offset: 0x001C4498
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1565f)
			{
				this.HBJJOCHGOPH = 1485f;
			}
			this.HKHBBBFLGJH().SetFloat("_RgbTex", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat(": ", this.Cryptage);
			this.BFGNMFCNDBC().SetFloat("Checkpoint", this.Parasite);
			this.IIJMIPBMMBF().SetFloat("settings_bindings_sec_", this.Parasite2);
			this.CFCPHFMKHII().SetFloat("In Network lobby", this.FIOHJEJCGAK);
			this.LPCHMEKDCHI().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 569f, 1166f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005CAA RID: 23722 RVA: 0x001C57EB File Offset: 0x001C39EB
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005CAB RID: 23723 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06005CAC RID: 23724 RVA: 0x001C6397 File Offset: 0x001C4597
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005CAD RID: 23725 RVA: 0x001C57EB File Offset: 0x001C39EB
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005CAE RID: 23726 RVA: 0x001C57EB File Offset: 0x001C39EB
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005CB0 RID: 23728 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005CB1 RID: 23729 RVA: 0x001C6410 File Offset: 0x001C4610
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 619f)
			{
				this.HBJJOCHGOPH = 790f;
			}
			this.JIBOKBCPDLC().SetFloat("_Value", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("#close", this.Cryptage);
			this.KBOPGONOCNP().SetFloat(",", this.Parasite);
			this.JIBOKBCPDLC().SetFloat("Joystick1Button4", this.Parasite2);
			this.DKKBFFHBHJE().SetFloat("_Near", this.FIOHJEJCGAK);
			this.KJMECMIGJJA().SetVector("RarityImage", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 587f, 79f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005CB2 RID: 23730 RVA: 0x001C650F File Offset: 0x001C470F
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005CB3 RID: 23731 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x06005CB4 RID: 23732 RVA: 0x001C6533 File Offset: 0x001C4733
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005CB5 RID: 23733 RVA: 0x001C6397 File Offset: 0x001C4597
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x1700010A RID: 266
	// (get) Token: 0x06005CB6 RID: 23734 RVA: 0x001C656A File Offset: 0x001C476A
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

	// Token: 0x06005CB7 RID: 23735 RVA: 0x001C65A4 File Offset: 0x001C47A4
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1527f)
			{
				this.HBJJOCHGOPH = 1833f;
			}
			this.BFGNMFCNDBC().SetFloat("\n\n• ", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("HPToggle", this.Cryptage);
			this.DKKBFFHBHJE().SetFloat("ConnectToRegion: ", this.Parasite);
			this.OLHDPICFBOF().SetFloat("UseFinalGlassColor", this.Parasite2);
			this.JFDGLLEOPGB().SetFloat("<command>", this.FIOHJEJCGAK);
			this.JIBOKBCPDLC().SetVector("SetSatelliteTrailWidth", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 338f, 673f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005CB8 RID: 23736 RVA: 0x001C66A4 File Offset: 0x001C48A4
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1168f)
			{
				this.HBJJOCHGOPH = 1204f;
			}
			this.LPCHMEKDCHI().SetFloat("\nCreated by Oxy949", this.HBJJOCHGOPH);
			this.KBOPGONOCNP().SetFloat("Player", this.Cryptage);
			this.IGKFMCPDNOI().SetFloat("mapselector.filter.rateduponly", this.Parasite);
			this.OKJOKHGJHGF().SetFloat("_Value", this.Parasite2);
			this.EHDJJANLINB().SetFloat("EventSystem", this.FIOHJEJCGAK);
			this.OKJOKHGJHGF().SetVector("player.linea", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1704f, 1779f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005CB9 RID: 23737 RVA: 0x0002523B File Offset: 0x0002343B
	private void NCPAFCKGJEA()
	{
	}

	// Token: 0x06005CBA RID: 23738 RVA: 0x001C67A3 File Offset: 0x001C49A3
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005CBB RID: 23739 RVA: 0x001C67C7 File Offset: 0x001C49C7
	private void DKGBFNCOAEO()
	{
		this.SCShader = Shader.Find("_Amount");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005CBC RID: 23740 RVA: 0x001C67EB File Offset: 0x001C49EB
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find(". Current number of cells is ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005CBD RID: 23741 RVA: 0x001C680F File Offset: 0x001C4A0F
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-82);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005CBE RID: 23742 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06005CBF RID: 23743 RVA: 0x001C6848 File Offset: 0x001C4A48
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1143f)
			{
				this.HBJJOCHGOPH = 1953f;
			}
			this.CFEDGDGBCHE().SetFloat("UI Extensions/SoftMaskShaderText", this.HBJJOCHGOPH);
			this.OLHDPICFBOF().SetFloat("FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.", this.Cryptage);
			this.KBOPGONOCNP().SetFloat("float,10", this.Parasite);
			this.IIJMIPBMMBF().SetFloat("SetSatelliteInput", this.Parasite2);
			this.JIBOKBCPDLC().SetFloat("[ItemsHandler] Item not found:", this.FIOHJEJCGAK);
			this.BFGNMFCNDBC().SetVector(" Server: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1349f, 1693f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005CC0 RID: 23744 RVA: 0x001C6948 File Offset: 0x001C4B48
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1736f)
			{
				this.HBJJOCHGOPH = 586f;
			}
			this.OLHDPICFBOF().SetFloat("mapselector.filter.rateduponly", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("CameraFilterPack/RainFX", this.Cryptage);
			this.CFCPHFMKHII().SetFloat("steamid", this.Parasite);
			this.KAFBNOBOIAJ().SetFloat("[DiscordController] Join ({0})", this.Parasite2);
			this.KBOPGONOCNP().SetFloat("config.txt", this.FIOHJEJCGAK);
			this.IIJMIPBMMBF().SetVector("[PlayerBase] Loaded music", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1078f, 596f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OLHDPICFBOF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005CC1 RID: 23745 RVA: 0x001C6A48 File Offset: 0x001C4C48
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1932f)
			{
				this.HBJJOCHGOPH = 1573f;
			}
			this.OKJOKHGJHGF().SetFloat("Failed to 'network-remove' GameObject because has no PhotonView components: ", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetFloat("_Value4", this.Cryptage);
			this.LPCHMEKDCHI().SetFloat("_Value3", this.Parasite);
			this.KAFBNOBOIAJ().SetFloat("#lives", this.Parasite2);
			this.BFGNMFCNDBC().SetFloat("OpSetPropertiesOfActor not sent. ActorNr must be > 0 and actorProperties != null.", this.FIOHJEJCGAK);
			this.IIJMIPBMMBF().SetVector("_MainTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1865f, 645f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EHDJJANLINB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005CC2 RID: 23746 RVA: 0x001C6B47 File Offset: 0x001C4D47
	private void MJEFMIPLFAB()
	{
		this.SCShader = Shader.Find("SetBGColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005CC3 RID: 23747 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06005CC4 RID: 23748 RVA: 0x001C6B6B File Offset: 0x001C4D6B
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005CC5 RID: 23749 RVA: 0x001C57EB File Offset: 0x001C39EB
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005CC6 RID: 23750 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06005CC7 RID: 23751 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06005CC8 RID: 23752 RVA: 0x001C6BA2 File Offset: 0x001C4DA2
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005CC9 RID: 23753 RVA: 0x001C6BDC File Offset: 0x001C4DDC
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 240f)
			{
				this.HBJJOCHGOPH = 383f;
			}
			this.KBOPGONOCNP().SetFloat("_Speed", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat(" beatThreshold: ", this.Cryptage);
			this.BFGNMFCNDBC().SetFloat("_ScreenResolution", this.Parasite);
			this.NBPKMLMCHFN.SetFloat("CheckpointsScoreText", this.Parasite2);
			this.OLHDPICFBOF().SetFloat("Object ID. Case-Sensitive", this.FIOHJEJCGAK);
			this.CFCPHFMKHII().SetVector("\n", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 621f, 1465f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGKFMCPDNOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005CCA RID: 23754 RVA: 0x001C6CDB File Offset: 0x001C4EDB
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005CCB RID: 23755 RVA: 0x001C6D12 File Offset: 0x001C4F12
	private void HIPEHGNBJMN()
	{
		this.SCShader = Shader.Find("player.arrow");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005CCC RID: 23756 RVA: 0x0002523B File Offset: 0x0002343B
	private void LDDKCCMHMIC()
	{
	}

	// Token: 0x06005CCD RID: 23757 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06005CCE RID: 23758 RVA: 0x001C6D38 File Offset: 0x001C4F38
	private void MPJCMKFFKHH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1853f)
			{
				this.HBJJOCHGOPH = 68f;
			}
			this.DKKBFFHBHJE().SetFloat("Added checkpoint", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", this.Cryptage);
			this.NBPKMLMCHFN.SetFloat("ShadersToggle", this.Parasite);
			this.KBOPGONOCNP().SetFloat("settings.fps", this.Parasite2);
			this.OKJOKHGJHGF().SetFloat("23x3", this.FIOHJEJCGAK);
			this.CFEDGDGBCHE().SetVector("Set particles count per one beat", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1867f, 1775f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KBOPGONOCNP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005CCF RID: 23759 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x06005CD0 RID: 23760 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x06005CD1 RID: 23761 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x06005CD2 RID: 23762 RVA: 0x001C6E38 File Offset: 0x001C5038
	private void PEBBCNICBDK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 166f)
			{
				this.HBJJOCHGOPH = 8f;
			}
			this.KAFBNOBOIAJ().SetFloat("No Dispatcher exists in the scene. Actions will not be invoked!", this.HBJJOCHGOPH);
			this.LPCHMEKDCHI().SetFloat(" Server: ", this.Cryptage);
			this.LPCHMEKDCHI().SetFloat("_Value", this.Parasite);
			this.CFEDGDGBCHE().SetFloat("CameraFilterPack/Blur_Steam", this.Parasite2);
			this.KBOPGONOCNP().SetFloat("{0} seconds ago", this.FIOHJEJCGAK);
			this.EHDJJANLINB().SetVector("_Intensity", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 919f, 180f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005CD3 RID: 23763 RVA: 0x001C6F37 File Offset: 0x001C5137
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("Error! no audio sources attached to AudioSampler.css");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005CD4 RID: 23764 RVA: 0x001C6F5B File Offset: 0x001C515B
	private Material CFCPHFMKHII()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005CD5 RID: 23765 RVA: 0x001C57EB File Offset: 0x001C39EB
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005CD6 RID: 23766 RVA: 0x001C57EB File Offset: 0x001C39EB
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005CD7 RID: 23767 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06005CD8 RID: 23768 RVA: 0x001C6F92 File Offset: 0x001C5192
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_VHS_Rewind");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005CD9 RID: 23769 RVA: 0x001C57EB File Offset: 0x001C39EB
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005CDA RID: 23770 RVA: 0x001C57EB File Offset: 0x001C39EB
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x04000963 RID: 2403
	public Shader SCShader;

	// Token: 0x04000964 RID: 2404
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000965 RID: 2405
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000966 RID: 2406
	private Material BJFKDHHMLJH;

	// Token: 0x04000967 RID: 2407
	[Range(0f, 1f)]
	public float Cryptage = 1f;

	// Token: 0x04000968 RID: 2408
	[Range(-20f, 20f)]
	public float Parasite = 9f;

	// Token: 0x04000969 RID: 2409
	[Range(-20f, 20f)]
	public float Parasite2 = 12f;

	// Token: 0x0400096A RID: 2410
	[Range(0f, 1f)]
	private float FIOHJEJCGAK = 1f;
}
