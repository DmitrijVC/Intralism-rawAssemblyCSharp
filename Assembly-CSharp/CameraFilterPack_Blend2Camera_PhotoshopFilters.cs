using System;
using UnityEngine;

// Token: 0x02000050 RID: 80
[AddComponentMenu("Camera Filter Pack/Blend 2 Camera/PhotoshopFilters")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_PhotoshopFilters : MonoBehaviour
{
	// Token: 0x06001692 RID: 5778 RVA: 0x00091074 File Offset: 0x0008F274
	private void NLGDPIBFHMK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -58);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001693 RID: 5779 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void GJLKJAOBPJD()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001694 RID: 5780 RVA: 0x000910E9 File Offset: 0x0008F2E9
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001695 RID: 5781 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void BNLENEDAHHL()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001696 RID: 5782 RVA: 0x00091120 File Offset: 0x0008F320
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 648f)
			{
				this.HBJJOCHGOPH = 757f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("_BokehParams", this.JDMCFBKJHDD);
			}
			this.PEIMCBBHLBJ().SetFloat("CameraFilterPack/TV_ARCADE_2", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("LetterSpacing: Missing Text component", this.BlendFX);
			this.LPDOGGFOBDH().SetFloat(".lastCheckpoint.powerupsScore", this.SwitchCameraToCamera2);
			this.KEMJNOMIPHN().SetVector("_SpherePositionY", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 666f, 1045f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001697 RID: 5783 RVA: 0x0009121C File Offset: 0x0008F41C
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 186f)
			{
				this.HBJJOCHGOPH = 1271f;
			}
			if (this.Camera2 != null)
			{
				this.MHBAIEKFBIJ().SetTexture("_Value4", this.JDMCFBKJHDD);
			}
			this.IFMAPIDFNLI().SetFloat("}", this.HBJJOCHGOPH);
			this.IKAEIOAHPKI().SetFloat("[Right]", this.BlendFX);
			this.MFHPKGICPIO().SetFloat("settings_bindings_", this.SwitchCameraToCamera2);
			this.LDNADDJMIPK().SetVector("\n", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1355f, 873f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OCMBHMLNCEK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001698 RID: 5784 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06001699 RID: 5785 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCDLIKEDMCF()
	{
	}

	// Token: 0x0600169A RID: 5786 RVA: 0x00091318 File Offset: 0x0008F518
	private void KDOCJGGAOII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 314f)
			{
				this.HBJJOCHGOPH = 1457f;
			}
			if (this.Camera2 != null)
			{
				this.JIBOKBCPDLC().SetTexture("/", this.JDMCFBKJHDD);
			}
			this.NBMPPNFKFLB().SetFloat("AudioSampler", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("Mouse", this.BlendFX);
			this.EFDEIFCDAFG().SetFloat("settings.volume.menu", this.SwitchCameraToCamera2);
			this.LDNADDJMIPK().SetVector("_Offsets", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 46f, 1560f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IKAEIOAHPKI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600169B RID: 5787 RVA: 0x00091414 File Offset: 0x0008F614
	private void BHBCNNIJECK()
	{
		if (this.filterchoice != this.BEHNMDCNKBF)
		{
			this.MPJAFNJLBEF();
			this.SCShader = Shader.Find(this.ELOFMLPCCEA);
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = (HideFlags)80;
			}
		}
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -13);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600169C RID: 5788 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void ABHEJPAGNMO()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600169D RID: 5789 RVA: 0x000914C8 File Offset: 0x0008F6C8
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600169E RID: 5790 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void IFJDKDFLGBG()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600169F RID: 5791 RVA: 0x00091500 File Offset: 0x0008F700
	private void CGCHMJCJOBB()
	{
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "#ok";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Multiply)
		{
			this.ELOFMLPCCEA = "intensity";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.DarkerColor)
		{
			this.ELOFMLPCCEA = "SpawnObj";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Screen)
		{
			this.ELOFMLPCCEA = "_ZCurve";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearBurn)
		{
			this.ELOFMLPCCEA = "_Value2";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearBurn)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/FX_Dot_Circle";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorDodge)
		{
			this.ELOFMLPCCEA = "L1";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearDodge)
		{
			this.ELOFMLPCCEA = "maps.";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.DarkerColor)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/FX_Glitch1";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)105)
		{
			this.ELOFMLPCCEA = "_FadeFX";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)116)
		{
			this.ELOFMLPCCEA = "Waiting to start";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.VividLight)
		{
			this.ELOFMLPCCEA = "[Down]";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-20))
		{
			this.ELOFMLPCCEA = "_PColor";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-16))
		{
			this.ELOFMLPCCEA = "FinalScoreSmallText";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.PinLight)
		{
			this.ELOFMLPCCEA = ":";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)77)
		{
			this.ELOFMLPCCEA = "_FarCamera";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-70))
		{
			this.ELOFMLPCCEA = "If you host Photon yourself, make sure to start the 'Instance LoadBalancing' ";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearBurn)
		{
			this.ELOFMLPCCEA = "\nv.";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Subtract)
		{
			this.ELOFMLPCCEA = "ConnectToMaster() failed. Can only connect while in state 'Disconnected'. Current state: ";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.HardLight)
		{
			this.ELOFMLPCCEA = "Gameplay/sprite";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)78)
		{
			this.ELOFMLPCCEA = "To Log";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-86))
		{
			this.ELOFMLPCCEA = "AccuracyScoreText";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-1))
		{
			this.ELOFMLPCCEA = "achievements.21.completed.workshop.";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-22))
		{
			this.ELOFMLPCCEA = ".a";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-72))
		{
			this.ELOFMLPCCEA = "Players NetIDs:";
		}
	}

	// Token: 0x060016A0 RID: 5792 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x060016A1 RID: 5793 RVA: 0x0009175C File Offset: 0x0008F95C
	private void FMFNILJIEIA()
	{
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -52);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.GBPGJKPMMDN();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060016A2 RID: 5794 RVA: 0x000917D8 File Offset: 0x0008F9D8
	private void ELJEHKEHFLM()
	{
		if (this.filterchoice != this.BEHNMDCNKBF)
		{
			this.CKFICFFNDFJ();
			this.SCShader = Shader.Find(this.ELOFMLPCCEA);
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = (HideFlags)120;
			}
		}
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 36);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016A3 RID: 5795 RVA: 0x0009188C File Offset: 0x0008FA8C
	private void AFOHBGHNBDI()
	{
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "[LevelEditorScene] Error: Unfortunately, you're banned by the community from uploading to the workshop! Bummer. :(";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Multiply)
		{
			this.ELOFMLPCCEA = "uploads/Intralism/mods_terms.pdf";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Multiply)
		{
			this.ELOFMLPCCEA = "workshop.";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.DarkerColor)
		{
			this.ELOFMLPCCEA = "Connection failed: ";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Lighten)
		{
			this.ELOFMLPCCEA = "cipherText";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorBurn)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Colors_NewPosterize";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearBurn)
		{
			this.ELOFMLPCCEA = "_TimeX";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.DarkerColor)
		{
			this.ELOFMLPCCEA = "workshop.";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Screen)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blur_Bloom";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)106)
		{
			this.ELOFMLPCCEA = "_ScreenResolution";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)120)
		{
			this.ELOFMLPCCEA = "#random #rare #item";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Subtract)
		{
			this.ELOFMLPCCEA = "_Value2";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)33)
		{
			this.ELOFMLPCCEA = "Beat Detected";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-44))
		{
			this.ELOFMLPCCEA = "Search: ";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-86))
		{
			this.ELOFMLPCCEA = "LastNewsButton";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)90)
		{
			this.ELOFMLPCCEA = "_ScreenResolution";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)36)
		{
			this.ELOFMLPCCEA = "Line";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)44)
		{
			this.ELOFMLPCCEA = "RequestForPickupItems";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-80))
		{
			this.ELOFMLPCCEA = "</color>";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)118)
		{
			this.ELOFMLPCCEA = "Alpha";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)59)
		{
			this.ELOFMLPCCEA = "grid";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-97))
		{
			this.ELOFMLPCCEA = "_TimeX";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)120)
		{
			this.ELOFMLPCCEA = "_AlphaHexa";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)98)
		{
			this.ELOFMLPCCEA = " not exist";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)44)
		{
			this.ELOFMLPCCEA = "0 - default, 1 - left, 2 - right";
		}
	}

	// Token: 0x060016A4 RID: 5796 RVA: 0x00091AE8 File Offset: 0x0008FCE8
	private void BEKMLIFILFP()
	{
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 89);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.NBMEBBHCNMH();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060016A5 RID: 5797 RVA: 0x00091B64 File Offset: 0x0008FD64
	private void IBBFFKEAOCE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 849f)
			{
				this.HBJJOCHGOPH = 1379f;
			}
			if (this.Camera2 != null)
			{
				this.MFHPKGICPIO().SetTexture("#no", this.JDMCFBKJHDD);
			}
			this.ADBKPGFMNKO().SetFloat("_Screen", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat(" not exist", this.BlendFX);
			this.JIBOKBCPDLC().SetFloat("YES", this.SwitchCameraToCamera2);
			this.MNLKBFFKHIE().SetVector("CameraFilterPack/Distortion_Half_Sphere", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 850f, 741f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBMPPNFKFLB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060016A6 RID: 5798 RVA: 0x00091C60 File Offset: 0x0008FE60
	private void OnValidate()
	{
		if (this.filterchoice != this.BEHNMDCNKBF)
		{
			this.MIPGPMKJELI();
			this.SCShader = Shader.Find(this.ELOFMLPCCEA);
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = HideFlags.HideAndDontSave;
			}
		}
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016A7 RID: 5799 RVA: 0x00091D14 File Offset: 0x0008FF14
	private void MIPGPMKJELI()
	{
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Darken";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Multiply)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Multiply";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorBurn)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_ColorBurn";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearBurn)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_LinearBurn";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.DarkerColor)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_DarkerColor";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Lighten)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Lighten";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Screen)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Screen";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorDodge)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_ColorDodge";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearDodge)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_LinearDodge";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LighterColor)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_LighterColor";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Overlay)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Overlay";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.SoftLight)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_SoftLight";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.HardLight)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_HardLight";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.VividLight)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_VividLight";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearLight)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_LinearLight";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.PinLight)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_PinLight";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.HardMix)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_HardMix";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Difference)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Difference";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Exclusion)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Exclusion";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Subtract)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Subtract";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Divide)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Divide";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Hue)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Hue";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Saturation)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Saturation";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Color)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Color";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Luminosity)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Luminosity";
		}
	}

	// Token: 0x060016A8 RID: 5800 RVA: 0x00091F6F File Offset: 0x0009016F
	private void EAFFHHCMLCG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 5);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016A9 RID: 5801 RVA: 0x00091FAC File Offset: 0x000901AC
	private void ALJEJJCIMJN()
	{
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -46);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.FEHMFPBAGFG();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060016AA RID: 5802 RVA: 0x00092028 File Offset: 0x00090228
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 369f)
			{
				this.HBJJOCHGOPH = 1011f;
			}
			if (this.Camera2 != null)
			{
				this.DOMEEFLPEPJ().SetTexture("_ScreenResolution", this.JDMCFBKJHDD);
			}
			this.PEIMCBBHLBJ().SetFloat("http://steamcommunity.com/sharedfiles/filedetails/?id=", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetFloat("accuracy", this.BlendFX);
			this.MFHPKGICPIO().SetFloat("menu.selectedlevelid", this.SwitchCameraToCamera2);
			this.KEMJNOMIPHN().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1457f, 898f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IKAEIOAHPKI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060016AB RID: 5803 RVA: 0x00092124 File Offset: 0x00090324
	private void MBKICIMOCGC()
	{
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "ViewMenu";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Multiply)
		{
			this.ELOFMLPCCEA = "Item created: Id: ";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearBurn)
		{
			this.ELOFMLPCCEA = "_ScreenResolution";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "_EmissionColor";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearBurn)
		{
			this.ELOFMLPCCEA = "_TimeX";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "Texture2";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorDodge)
		{
			this.ELOFMLPCCEA = "\n\n#";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Screen)
		{
			this.ELOFMLPCCEA = " not exist";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.DarkerColor)
		{
			this.ELOFMLPCCEA = "x";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-98))
		{
			this.ELOFMLPCCEA = "players";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-16))
		{
			this.ELOFMLPCCEA = " not exist";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-58))
		{
			this.ELOFMLPCCEA = ".lastCheckpoint.powerupsScore";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-27))
		{
			this.ELOFMLPCCEA = "_EmissionColor";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)81)
		{
			this.ELOFMLPCCEA = ".lastCheckpoint.bgcolor";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)80)
		{
			this.ELOFMLPCCEA = "_MainTex";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)71)
		{
			this.ELOFMLPCCEA = "_ScreenResolution";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-106))
		{
			this.ELOFMLPCCEA = "RPC can't be sent to target PhotonPlayer being null! Did not send \"";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-115))
		{
			this.ELOFMLPCCEA = "_TimeX";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearDodge)
		{
			this.ELOFMLPCCEA = "_FarCamera";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-38))
		{
			this.ELOFMLPCCEA = "_Value1";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)99)
		{
			this.ELOFMLPCCEA = "_Parameter";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "[LocalizationService] All keys for ";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-38))
		{
			this.ELOFMLPCCEA = "--------------------------------";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)34)
		{
			this.ELOFMLPCCEA = "settings_bindings_controller_type";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-95))
		{
			this.ELOFMLPCCEA = ". Using max value: 255.";
		}
	}

	// Token: 0x060016AC RID: 5804 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void EKCKJLFFAID()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060016AD RID: 5805 RVA: 0x00092380 File Offset: 0x00090580
	private void CKMNIPHKPDD()
	{
		if (this.filterchoice != this.BEHNMDCNKBF)
		{
			this.CGCHMJCJOBB();
			this.SCShader = Shader.Find(this.ELOFMLPCCEA);
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
			}
		}
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 58);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016AE RID: 5806 RVA: 0x00092434 File Offset: 0x00090634
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060016AF RID: 5807 RVA: 0x0009246C File Offset: 0x0009066C
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("_MainTex2", this.JDMCFBKJHDD);
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060016B0 RID: 5808 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void CCPEDDLAMIB()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060016B1 RID: 5809 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void LECCHIAFGGE()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060016B2 RID: 5810 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void FPHLDMMAOEF()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060016B3 RID: 5811 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060016B4 RID: 5812 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x060016B5 RID: 5813 RVA: 0x00092566 File Offset: 0x00090766
	private void DGEPPDJDBLN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 102);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x17000037 RID: 55
	// (get) Token: 0x060016B6 RID: 5814 RVA: 0x000925A1 File Offset: 0x000907A1
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

	// Token: 0x060016B7 RID: 5815 RVA: 0x000925D8 File Offset: 0x000907D8
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 318f)
			{
				this.HBJJOCHGOPH = 1939f;
			}
			if (this.Camera2 != null)
			{
				this.HILDKDFEBPF().SetTexture("_MainTex2", this.JDMCFBKJHDD);
			}
			this.LDNADDJMIPK().SetFloat("yyyy-MM-dd HH:mm:ss", this.HBJJOCHGOPH);
			this.OCMBHMLNCEK().SetFloat("https://vk.com/khb.soft", this.BlendFX);
			this.OCMBHMLNCEK().SetFloat("_ScreenResolution", this.SwitchCameraToCamera2);
			this.FKEOGPDLBDD().SetVector("skin.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1406f, 860f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060016B8 RID: 5816 RVA: 0x000926D4 File Offset: 0x000908D4
	private void CDOAGLJEKKL()
	{
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "_Jitter";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Multiply)
		{
			this.ELOFMLPCCEA = "_Fade";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorBurn)
		{
			this.ELOFMLPCCEA = "Tab2Content";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorDodge)
		{
			this.ELOFMLPCCEA = "ExitButton";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Multiply)
		{
			this.ELOFMLPCCEA = "[MapsData] Found ";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Lighten)
		{
			this.ELOFMLPCCEA = "#scoresubmitionfailed: ";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearBurn)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Distortion_ShockWave";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Screen)
		{
			this.ELOFMLPCCEA = "maps.";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "init";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-123))
		{
			this.ELOFMLPCCEA = "settings.fps";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)116)
		{
			this.ELOFMLPCCEA = "z";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-50))
		{
			this.ELOFMLPCCEA = "EditMenu";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)78)
		{
			this.ELOFMLPCCEA = "SupportLogger OnJoinedRoom(";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)111)
		{
			this.ELOFMLPCCEA = "http://api.steampowered.com/ISteamNews/GetNewsForApp/v0002/?format=json&appid=513510";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-97))
		{
			this.ELOFMLPCCEA = "<command>";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)111)
		{
			this.ELOFMLPCCEA = "Gameplay/LobbyPlayerIconElement";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-125))
		{
			this.ELOFMLPCCEA = "Connection error: ";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-106))
		{
			this.ELOFMLPCCEA = "OnAwakeRPC";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-18))
		{
			this.ELOFMLPCCEA = "settings.crosshairopacity";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-56))
		{
			this.ELOFMLPCCEA = "MultiplayerButton";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)121)
		{
			this.ELOFMLPCCEA = "_TimeX";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)58)
		{
			this.ELOFMLPCCEA = "_UserLutParams";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)26)
		{
			this.ELOFMLPCCEA = "SetSatelliteColor";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-11))
		{
			this.ELOFMLPCCEA = " | Level: ";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-63))
		{
			this.ELOFMLPCCEA = "SpawnObj";
		}
	}

	// Token: 0x060016B9 RID: 5817 RVA: 0x00092930 File Offset: 0x00090B30
	private void OIAACNGKGML()
	{
		if (this.filterchoice != this.BEHNMDCNKBF)
		{
			this.CGCHMJCJOBB();
			this.SCShader = Shader.Find(this.ELOFMLPCCEA);
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = (HideFlags)93;
			}
		}
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -62);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016BA RID: 5818 RVA: 0x000929E4 File Offset: 0x00090BE4
	private Material MNLKBFFKHIE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)67;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060016BB RID: 5819 RVA: 0x00092A1B File Offset: 0x00090C1B
	private void MAMFKACDKDP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -100);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016BC RID: 5820 RVA: 0x00092A58 File Offset: 0x00090C58
	private void MENDFOCFMAN()
	{
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "_Value4";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "_EmissionColor";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Lighten)
		{
			this.ELOFMLPCCEA = "_Value5";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "Bad parameters for setint! Use <key> <value>";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "Currently, the limit of users is reached for this title. Try again later. Disconnecting";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearBurn)
		{
			this.ELOFMLPCCEA = "[MapsStats] Length: ";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Screen)
		{
			this.ELOFMLPCCEA = "[MenuScene] Error: ";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Lighten)
		{
			this.ELOFMLPCCEA = "speed";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearDodge)
		{
			this.ELOFMLPCCEA = "_MainTex2";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LighterColor)
		{
			this.ELOFMLPCCEA = "error";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-76))
		{
			this.ELOFMLPCCEA = "PLEASE WAIT";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)98)
		{
			this.ELOFMLPCCEA = "EventData0DropDownList";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)47)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_DarkerColor";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)95)
		{
			this.ELOFMLPCCEA = "JoinRoom failed. A roomname is required. If you don't know one, how will you join?";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)110)
		{
			this.ELOFMLPCCEA = "_ColorLevel";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-56))
		{
			this.ELOFMLPCCEA = "SpawnObj";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-104))
		{
			this.ELOFMLPCCEA = "GhostPosY";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-71))
		{
			this.ELOFMLPCCEA = "_TimeX";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)123)
		{
			this.ELOFMLPCCEA = "_EmissionColor";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)85)
		{
			this.ELOFMLPCCEA = "InfoButton";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.PinLight)
		{
			this.ELOFMLPCCEA = "Maps Editor v.";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)91)
		{
			this.ELOFMLPCCEA = "_DistAmount";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)25)
		{
			this.ELOFMLPCCEA = "workshop.";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)117)
		{
			this.ELOFMLPCCEA = "maps.";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)86)
		{
			this.ELOFMLPCCEA = "<b>Intralism Items Uploader</b> by Oxy949";
		}
	}

	// Token: 0x060016BD RID: 5821 RVA: 0x00092CB3 File Offset: 0x00090EB3
	private void FCKIJIKNMCF()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -112);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016BE RID: 5822 RVA: 0x00092CF0 File Offset: 0x00090EF0
	private void BMHFAMJELFH()
	{
		if (this.filterchoice != this.BEHNMDCNKBF)
		{
			this.GOCIGGGHANF();
			this.SCShader = Shader.Find(this.ELOFMLPCCEA);
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
		}
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -123);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016BF RID: 5823 RVA: 0x00092DA4 File Offset: 0x00090FA4
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1085f)
			{
				this.HBJJOCHGOPH = 765f;
			}
			if (this.Camera2 != null)
			{
				this.IFMAPIDFNLI().SetTexture(".b", this.JDMCFBKJHDD);
			}
			this.OCMBHMLNCEK().SetFloat("_EmissionGain", this.HBJJOCHGOPH);
			this.OCMBHMLNCEK().SetFloat("Playing ", this.BlendFX);
			this.MFHPKGICPIO().SetFloat("[MapEditor] Item creation successful! Published Item ID: ", this.SwitchCameraToCamera2);
			this.LDNADDJMIPK().SetVector("colorD", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1625f, 1078f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060016C0 RID: 5824 RVA: 0x00092EA0 File Offset: 0x000910A0
	private void MNGEPOFPLMA()
	{
		if (this.filterchoice != this.BEHNMDCNKBF)
		{
			this.MELKBLIIFEO();
			this.SCShader = Shader.Find(this.ELOFMLPCCEA);
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
			}
		}
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -28);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016C1 RID: 5825 RVA: 0x00092F54 File Offset: 0x00091154
	private void LBEHKFNPKMC()
	{
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "mapselector.filter.favoriteonly";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Multiply)
		{
			this.ELOFMLPCCEA = "_Value4";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearBurn)
		{
			this.ELOFMLPCCEA = "RecordButton";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorBurn)
		{
			this.ELOFMLPCCEA = "_VignetteSettings";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearDodge)
		{
			this.ELOFMLPCCEA = "workshop.";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorBurn)
		{
			this.ELOFMLPCCEA = "_ScreenResolution";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Lighten)
		{
			this.ELOFMLPCCEA = "_ScreenResolution";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorDodge)
		{
			this.ELOFMLPCCEA = "Item ";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorBurn)
		{
			this.ELOFMLPCCEA = "There are a few rules that you must accept before submitting your work. Please select \"RULES\" button, if you haven't read them yet.";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-128))
		{
			this.ELOFMLPCCEA = "GlassColor";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)124)
		{
			this.ELOFMLPCCEA = "/files/editor_manual.pdf";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Overlay)
		{
			this.ELOFMLPCCEA = "_BlurRadius4";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-36))
		{
			this.ELOFMLPCCEA = "Screen Space Reflections";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)66)
		{
			this.ELOFMLPCCEA = "GlassesColor2";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-8))
		{
			this.ELOFMLPCCEA = "_NoiseTex";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)95)
		{
			this.ELOFMLPCCEA = "OK";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)49)
		{
			this.ELOFMLPCCEA = "OK";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)68)
		{
			this.ELOFMLPCCEA = "_Bloom0";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-75))
		{
			this.ELOFMLPCCEA = "-showlogs";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-68))
		{
			this.ELOFMLPCCEA = "EventMenu";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-16))
		{
			this.ELOFMLPCCEA = "shader.crispwinter";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-122))
		{
			this.ELOFMLPCCEA = " argument(s): ";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-7))
		{
			this.ELOFMLPCCEA = "_Value2";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)123)
		{
			this.ELOFMLPCCEA = "GlassesColor2";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)32)
		{
			this.ELOFMLPCCEA = "https://bugs.khb-soft.ru/set_project.php?project_id=1";
		}
	}

	// Token: 0x060016C2 RID: 5826 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x060016C3 RID: 5827 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void ALMGMOOHLMA()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060016C4 RID: 5828 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void AMHEJBMLFNM()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060016C5 RID: 5829 RVA: 0x000931AF File Offset: 0x000913AF
	private Material OCMBHMLNCEK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060016C6 RID: 5830 RVA: 0x000931E6 File Offset: 0x000913E6
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-71);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060016C8 RID: 5832 RVA: 0x00093246 File Offset: 0x00091446
	private Material HILDKDFEBPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060016C9 RID: 5833 RVA: 0x0009327D File Offset: 0x0009147D
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)111;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060016CA RID: 5834 RVA: 0x000932B4 File Offset: 0x000914B4
	private void LGHFFANDDCM()
	{
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "Result for ";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Multiply)
		{
			this.ELOFMLPCCEA = "_Value6";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearBurn)
		{
			this.ELOFMLPCCEA = "_CurveParams";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Screen)
		{
			this.ELOFMLPCCEA = "_ScreenResolution";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Multiply)
		{
			this.ELOFMLPCCEA = "Triangle";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Lighten)
		{
			this.ELOFMLPCCEA = " not found";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearDodge)
		{
			this.ELOFMLPCCEA = "UsernameText";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearDodge)
		{
			this.ELOFMLPCCEA = "_History2ChromaTex";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Lighten)
		{
			this.ELOFMLPCCEA = "DPADHOR";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorDodge)
		{
			this.ELOFMLPCCEA = "SetRoomStartTimestamp";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-57))
		{
			this.ELOFMLPCCEA = "Changed config";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-63))
		{
			this.ELOFMLPCCEA = "Set arcs speed. Base value - 15";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-34))
		{
			this.ELOFMLPCCEA = "Bad parameters for setstring! Use <key> <value>";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-48))
		{
			this.ELOFMLPCCEA = "_Value";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-28))
		{
			this.ELOFMLPCCEA = "Rotate environment object to the rotation";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)68)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_HardLight";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-7))
		{
			this.ELOFMLPCCEA = "PopulateMapsList";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)80)
		{
			this.ELOFMLPCCEA = "_MainTex2";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-31))
		{
			this.ELOFMLPCCEA = ".highscore";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)59)
		{
			this.ELOFMLPCCEA = "_ScreenResolution";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)45)
		{
			this.ELOFMLPCCEA = "&";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)121)
		{
			this.ELOFMLPCCEA = "#rt";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Saturation)
		{
			this.ELOFMLPCCEA = "InventoryButton";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-25))
		{
			this.ELOFMLPCCEA = "AuthenticationValues UserId: {0}, GetParameters: {1} Token available: {2}";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-40))
		{
			this.ELOFMLPCCEA = "Add Environment Sprite";
		}
	}

	// Token: 0x060016CB RID: 5835 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void HGDDCINLDAD()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060016CC RID: 5836 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void PKBENONAOOL()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060016CD RID: 5837 RVA: 0x00093510 File Offset: 0x00091710
	private void NBMEBBHCNMH()
	{
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "inventory.selected.";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "FileLabel";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = " Path: ";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorBurn)
		{
			this.ELOFMLPCCEA = "_Value";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Screen)
		{
			this.ELOFMLPCCEA = "Image";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.DarkerColor)
		{
			this.ELOFMLPCCEA = "Reconnect() failed. It seems the client wasn't connected before?! Current state: ";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorDodge)
		{
			this.ELOFMLPCCEA = "EnableRankingToggle";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Multiply)
		{
			this.ELOFMLPCCEA = "RT";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Lighten)
		{
			this.ELOFMLPCCEA = " respawn: ";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)42)
		{
			this.ELOFMLPCCEA = "0.00:0.00";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-74))
		{
			this.ELOFMLPCCEA = "steamid";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-56))
		{
			this.ELOFMLPCCEA = "Player";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)46)
		{
			this.ELOFMLPCCEA = "CameraFilterPack_3D_Myst1";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "rarity";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)61)
		{
			this.ELOFMLPCCEA = "PLEASE WAIT";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)69)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Pixelisation_OilPaintHQ";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-49))
		{
			this.ELOFMLPCCEA = "_NoiseAmount";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-117))
		{
			this.ELOFMLPCCEA = "PunRespawn";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-3))
		{
			this.ELOFMLPCCEA = "_Value4";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)57)
		{
			this.ELOFMLPCCEA = "_ScreenResolution";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)101)
		{
			this.ELOFMLPCCEA = "RecordButton";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)48)
		{
			this.ELOFMLPCCEA = "_ScreenResolution";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-20))
		{
			this.ELOFMLPCCEA = "[MapsData] Installed: ";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)88)
		{
			this.ELOFMLPCCEA = "inventory.itemscash";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)35)
		{
			this.ELOFMLPCCEA = "No Name";
		}
	}

	// Token: 0x060016CE RID: 5838 RVA: 0x0009376C File Offset: 0x0009196C
	private void NPLCENPNJBM()
	{
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -86);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.MELKBLIIFEO();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060016CF RID: 5839 RVA: 0x000937E7 File Offset: 0x000919E7
	private Material PEIMCBBHLBJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060016D0 RID: 5840 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void ALJEADNKJPO()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060016D1 RID: 5841 RVA: 0x00093820 File Offset: 0x00091A20
	private void EBBMDDEFNKL()
	{
		if (this.filterchoice != this.BEHNMDCNKBF)
		{
			this.AFOHBGHNBDI();
			this.SCShader = Shader.Find(this.ELOFMLPCCEA);
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
		}
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 28);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016D2 RID: 5842 RVA: 0x000938D4 File Offset: 0x00091AD4
	private void CKFICFFNDFJ()
	{
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "SpectateButton";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "The image effect ";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.DarkerColor)
		{
			this.ELOFMLPCCEA = "{0}";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Lighten)
		{
			this.ELOFMLPCCEA = "' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Lighten)
		{
			this.ELOFMLPCCEA = "GroupNameText";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearBurn)
		{
			this.ELOFMLPCCEA = "#close";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Lighten)
		{
			this.ELOFMLPCCEA = "_TimeX";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorDodge)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Saturation";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorDodge)
		{
			this.ELOFMLPCCEA = "_ScreenResolution";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)26)
		{
			this.ELOFMLPCCEA = "EndlessLoopsScoreText";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-125))
		{
			this.ELOFMLPCCEA = "_Color";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-78))
		{
			this.ELOFMLPCCEA = "/Segment-[Right]";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-34))
		{
			this.ELOFMLPCCEA = "Deleted event";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)66)
		{
			this.ELOFMLPCCEA = "_OffsetScale";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-71))
		{
			this.ELOFMLPCCEA = "_ReflectionTexture3";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Subtract)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Drawing_BluePrint";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)25)
		{
			this.ELOFMLPCCEA = "#ok";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-19))
		{
			this.ELOFMLPCCEA = "Changed config";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-71))
		{
			this.ELOFMLPCCEA = "/";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)109)
		{
			this.ELOFMLPCCEA = "Misses:";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)44)
		{
			this.ELOFMLPCCEA = "Mouse Wheel Down";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-95))
		{
			this.ELOFMLPCCEA = "Case-Sensitive";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)43)
		{
			this.ELOFMLPCCEA = "player.dragon";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-39))
		{
			this.ELOFMLPCCEA = "menu.selectedplaymode";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Luminosity)
		{
			this.ELOFMLPCCEA = "880078120";
		}
	}

	// Token: 0x060016D3 RID: 5843 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x060016D4 RID: 5844 RVA: 0x00093B30 File Offset: 0x00091D30
	private void JOPCCCCHNLI()
	{
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -43);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.MENDFOCFMAN();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060016D5 RID: 5845 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x060016D6 RID: 5846 RVA: 0x00093BAC File Offset: 0x00091DAC
	private void KNBJBNDGCIJ()
	{
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -32);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.NBMEBBHCNMH();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060016D7 RID: 5847 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void OFPPIKHNJOD()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060016D8 RID: 5848 RVA: 0x00093C27 File Offset: 0x00091E27
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)105;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060016D9 RID: 5849 RVA: 0x0002523B File Offset: 0x0002343B
	private void JFMIDILENDO()
	{
	}

	// Token: 0x060016DA RID: 5850 RVA: 0x00093C5E File Offset: 0x00091E5E
	private Material LPCHMEKDCHI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060016DB RID: 5851 RVA: 0x00093C98 File Offset: 0x00091E98
	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1783f)
			{
				this.HBJJOCHGOPH = 526f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("MenuVolumeSlider", this.JDMCFBKJHDD);
			}
			this.NBMPPNFKFLB().SetFloat("SetBGColor", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("settings.volume.editor", this.BlendFX);
			this.KEMJNOMIPHN().SetFloat("[PlayerBase] Loaded custom model: ", this.SwitchCameraToCamera2);
			this.MHBAIEKFBIJ().SetVector("settings.enablehitsoundsinrelax", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 272f, 466f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060016DC RID: 5852 RVA: 0x00093D92 File Offset: 0x00091F92
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060016DD RID: 5853 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void EDBEHEKMGFH()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060016DE RID: 5854 RVA: 0x00093DCC File Offset: 0x00091FCC
	private void LGJAHGCLMLE()
	{
		if (this.filterchoice != this.BEHNMDCNKBF)
		{
			this.IGCBJKFAFEH();
			this.SCShader = Shader.Find(this.ELOFMLPCCEA);
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = ~HideFlags.DontSaveInEditor;
			}
		}
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 55);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016DF RID: 5855 RVA: 0x00093E80 File Offset: 0x00092080
	private void HGPLPMCJNLL()
	{
		if (this.filterchoice != this.BEHNMDCNKBF)
		{
			this.MPJAFNJLBEF();
			this.SCShader = Shader.Find(this.ELOFMLPCCEA);
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			}
		}
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 16);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016E0 RID: 5856 RVA: 0x00093F34 File Offset: 0x00092134
	private Material MPENCEIGLEH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-120);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060016E1 RID: 5857 RVA: 0x00093F6C File Offset: 0x0009216C
	private void IGCBJKFAFEH()
	{
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "[LevelEditorScene] Updated";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Multiply)
		{
			this.ELOFMLPCCEA = "maps.";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearDodge)
		{
			this.ELOFMLPCCEA = "_CenterX";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Screen)
		{
			this.ELOFMLPCCEA = "<color=#{0}>{1}</color>";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearBurn)
		{
			this.ELOFMLPCCEA = "settings.arcsnohitsoundtimedelay";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorBurn)
		{
			this.ELOFMLPCCEA = "_Value2";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Multiply)
		{
			this.ELOFMLPCCEA = "_Distortion";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "maphash";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Multiply)
		{
			this.ELOFMLPCCEA = "note.1";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-64))
		{
			this.ELOFMLPCCEA = "_SceneFogParams";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)77)
		{
			this.ELOFMLPCCEA = "bad";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-34))
		{
			this.ELOFMLPCCEA = "InfoText";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)123)
		{
			this.ELOFMLPCCEA = "0";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-122))
		{
			this.ELOFMLPCCEA = "value";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)69)
		{
			this.ELOFMLPCCEA = "_Threshhold";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Difference)
		{
			this.ELOFMLPCCEA = "#";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)70)
		{
			this.ELOFMLPCCEA = "_ChromaticAberration";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)79)
		{
			this.ELOFMLPCCEA = "_Value";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-21))
		{
			this.ELOFMLPCCEA = "...";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Hue)
		{
			this.ELOFMLPCCEA = "menu.selectedlevelid";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-99))
		{
			this.ELOFMLPCCEA = "GhostFade2";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-91))
		{
			this.ELOFMLPCCEA = "Lag ";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-78))
		{
			this.ELOFMLPCCEA = "_BokehParams";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-12))
		{
			this.ELOFMLPCCEA = "_ScreenResolution";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-5))
		{
			this.ELOFMLPCCEA = "ShowSprite";
		}
	}

	// Token: 0x060016E2 RID: 5858 RVA: 0x000941C7 File Offset: 0x000923C7
	private void GLNBNEJBMHA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 91);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016E3 RID: 5859 RVA: 0x00094202 File Offset: 0x00092402
	private void FCKMAOMOKNB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -91);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016E4 RID: 5860 RVA: 0x0009423D File Offset: 0x0009243D
	private void IJCBBIJOCAH()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 16);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016E5 RID: 5861 RVA: 0x00094278 File Offset: 0x00092478
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060016E6 RID: 5862 RVA: 0x000942AF File Offset: 0x000924AF
	private void ELHFAMLBLHM()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 54);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016E7 RID: 5863 RVA: 0x000942EA File Offset: 0x000924EA
	private void LICOLMAOHKI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -27);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016E8 RID: 5864 RVA: 0x00094328 File Offset: 0x00092528
	private void JKBMKPDGCHG()
	{
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -58);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.CGCHMJCJOBB();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060016E9 RID: 5865 RVA: 0x000943A4 File Offset: 0x000925A4
	private void GFHPLCFNACM()
	{
		if (this.filterchoice != this.BEHNMDCNKBF)
		{
			this.MIPGPMKJELI();
			this.SCShader = Shader.Find(this.ELOFMLPCCEA);
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
			}
		}
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 96);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016EA RID: 5866 RVA: 0x00094458 File Offset: 0x00092658
	private void CFFCLAHMBAA()
	{
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 42);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.NBMEBBHCNMH();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060016EB RID: 5867 RVA: 0x000944D3 File Offset: 0x000926D3
	private void JHBPINEKDPE()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -34);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016EC RID: 5868 RVA: 0x00094510 File Offset: 0x00092710
	private void OLCOOJIONIL()
	{
		if (this.filterchoice != this.BEHNMDCNKBF)
		{
			this.LGHFFANDDCM();
			this.SCShader = Shader.Find(this.ELOFMLPCCEA);
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
			}
		}
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 53);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016ED RID: 5869 RVA: 0x000945C4 File Offset: 0x000927C4
	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1329f)
			{
				this.HBJJOCHGOPH = 323f;
			}
			if (this.Camera2 != null)
			{
				this.KEMJNOMIPHN().SetTexture("offsets", this.JDMCFBKJHDD);
			}
			this.LPDOGGFOBDH().SetFloat("_Offsets", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("masterSteamID", this.BlendFX);
			this.DOMEEFLPEPJ().SetFloat("_ScreenResolution", this.SwitchCameraToCamera2);
			this.HILDKDFEBPF().SetVector("Set Crosshair Color", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 776f, 1646f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060016EE RID: 5870 RVA: 0x000946C0 File Offset: 0x000928C0
	private void CNGAJDBOCLJ()
	{
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 27);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.MPJAFNJLBEF();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060016EF RID: 5871 RVA: 0x0009473C File Offset: 0x0009293C
	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1825f)
			{
				this.HBJJOCHGOPH = 1863f;
			}
			if (this.Camera2 != null)
			{
				this.LPCHMEKDCHI().SetTexture("</color>", this.JDMCFBKJHDD);
			}
			this.LDNADDJMIPK().SetFloat("CameraFilterPack/Film_ColorPerfection", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat("_TimeX", this.BlendFX);
			this.EFDEIFCDAFG().SetFloat("1.87", this.SwitchCameraToCamera2);
			this.OIIDAKBILMI().SetVector("]", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 901f, 1635f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPCHMEKDCHI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060016F0 RID: 5872 RVA: 0x00094838 File Offset: 0x00092A38
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 645f)
			{
				this.HBJJOCHGOPH = 581f;
			}
			if (this.Camera2 != null)
			{
				this.FKEOGPDLBDD().SetTexture("<color=#{0}>{1}</color>", this.JDMCFBKJHDD);
			}
			this.LDNADDJMIPK().SetFloat("Couldn't call DestroyAll() as only the master client is allowed to call this.", this.HBJJOCHGOPH);
			this.NBMPPNFKFLB().SetFloat(".highscore", this.BlendFX);
			this.EFDEIFCDAFG().SetFloat("Cross", this.SwitchCameraToCamera2);
			this.FKEOGPDLBDD().SetVector("_History4ChromaTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1128f, 1845f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MPENCEIGLEH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060016F1 RID: 5873 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void OnDisable()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060016F2 RID: 5874 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x060016F3 RID: 5875 RVA: 0x00094934 File Offset: 0x00092B34
	private void GHICDLBKEJN()
	{
		if (this.filterchoice != this.BEHNMDCNKBF)
		{
			this.MBKICIMOCGC();
			this.SCShader = Shader.Find(this.ELOFMLPCCEA);
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
			}
		}
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 65);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016F4 RID: 5876 RVA: 0x000949E8 File Offset: 0x00092BE8
	private void PMAADPNNHKK()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -22);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016F5 RID: 5877 RVA: 0x00094A24 File Offset: 0x00092C24
	private void DPKJPFEIHOB()
	{
		if (this.filterchoice != this.BEHNMDCNKBF)
		{
			this.MPJAFNJLBEF();
			this.SCShader = Shader.Find(this.ELOFMLPCCEA);
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = (HideFlags)(-96);
			}
		}
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -98);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016F6 RID: 5878 RVA: 0x00094AD8 File Offset: 0x00092CD8
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1934f)
			{
				this.HBJJOCHGOPH = 1912f;
			}
			if (this.Camera2 != null)
			{
				this.KEMJNOMIPHN().SetTexture("CameraFilterPack/Blend2Camera_LinearLight", this.JDMCFBKJHDD);
			}
			this.IKAEIOAHPKI().SetFloat("CameraFilterPack/Vision_Hell_Blood", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("UI", this.BlendFX);
			this.IKAEIOAHPKI().SetFloat("y", this.SwitchCameraToCamera2);
			this.LPDOGGFOBDH().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 60f, 1011f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060016F7 RID: 5879 RVA: 0x00094BD4 File Offset: 0x00092DD4
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1056f)
			{
				this.HBJJOCHGOPH = 635f;
			}
			if (this.Camera2 != null)
			{
				this.PEIMCBBHLBJ().SetTexture("CameraFilterPack/Real_VHS", this.JDMCFBKJHDD);
			}
			this.LDNADDJMIPK().SetFloat("&page=", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Edge_Sobel", this.BlendFX);
			this.PEIMCBBHLBJ().SetFloat("SetScale", this.SwitchCameraToCamera2);
			this.ADBKPGFMNKO().SetVector("Object ID. Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 405f, 651f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060016F8 RID: 5880 RVA: 0x00094CCE File Offset: 0x00092ECE
	private void OKHGJFFIIBA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 89);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016F9 RID: 5881 RVA: 0x00094D0C File Offset: 0x00092F0C
	private void DBLILJGKGHJ()
	{
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -28);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.MELKBLIIFEO();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060016FA RID: 5882 RVA: 0x00094D87 File Offset: 0x00092F87
	private void AJBHOEBKGDO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 100);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016FB RID: 5883 RVA: 0x0002523B File Offset: 0x0002343B
	private void CFIAKIJAILI()
	{
	}

	// Token: 0x060016FC RID: 5884 RVA: 0x00094DC2 File Offset: 0x00092FC2
	private void LKPBGHGCPKL()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -50);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x060016FD RID: 5885 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x060016FE RID: 5886 RVA: 0x00094E00 File Offset: 0x00093000
	private void KEFKNAOGCHO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 559f)
			{
				this.HBJJOCHGOPH = 1988f;
			}
			if (this.Camera2 != null)
			{
				this.IKAEIOAHPKI().SetTexture("skin.hit_perfect", this.JDMCFBKJHDD);
			}
			this.NBMPPNFKFLB().SetFloat(" ", this.HBJJOCHGOPH);
			this.OCMBHMLNCEK().SetFloat("_TimeX", this.BlendFX);
			this.LDNADDJMIPK().SetFloat("Error: I/O Failure! :(", this.SwitchCameraToCamera2);
			this.LPDOGGFOBDH().SetVector("_Value7", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 268f, 1638f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060016FF RID: 5887 RVA: 0x00094EFC File Offset: 0x000930FC
	private void GBPGJKPMMDN()
	{
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = " Also make sure to disable sprite packing for this sprite.";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "\r";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorDodge)
		{
			this.ELOFMLPCCEA = "Attempting to remove texture that was not allocated: {0}";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorBurn)
		{
			this.ELOFMLPCCEA = "#ok";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorDodge)
		{
			this.ELOFMLPCCEA = "[DiscordController] Responding no to Ask to Join request";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorDodge)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/3D_Binary";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorDodge)
		{
			this.ELOFMLPCCEA = "Tab2Content";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Screen)
		{
			this.ELOFMLPCCEA = "[LocalizationService] Error: ";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorDodge)
		{
			this.ELOFMLPCCEA = "Have you fully accept the terms?";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-114))
		{
			this.ELOFMLPCCEA = "[CraftingPanel] Init";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-101))
		{
			this.ELOFMLPCCEA = "Switch environment sprite image";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)30)
		{
			this.ELOFMLPCCEA = "NEW_ACHIEVEMENT_1_";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-80))
		{
			this.ELOFMLPCCEA = "Object ID. Case-Sensitive";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-107))
		{
			this.ELOFMLPCCEA = "_Value11";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)49)
		{
			this.ELOFMLPCCEA = "_TimeX";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.PinLight)
		{
			this.ELOFMLPCCEA = "Fade";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-30))
		{
			this.ELOFMLPCCEA = "_ScreenResolution";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)36)
		{
			this.ELOFMLPCCEA = "note.2";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)48)
		{
			this.ELOFMLPCCEA = "Music End";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)90)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/TV_Chromatical2";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)123)
		{
			this.ELOFMLPCCEA = "Use ticket: ";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-101))
		{
			this.ELOFMLPCCEA = "_Bloom2";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-28))
		{
			this.ELOFMLPCCEA = "_EmissionColor";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)76)
		{
			this.ELOFMLPCCEA = "High";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-121))
		{
			this.ELOFMLPCCEA = "_Value";
		}
	}

	// Token: 0x06001700 RID: 5888 RVA: 0x00095157 File Offset: 0x00093357
	private void OEFNBKHNJND()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 53);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001701 RID: 5889 RVA: 0x0002523B File Offset: 0x0002343B
	private void MDCFIHDPLIG()
	{
	}

	// Token: 0x06001702 RID: 5890 RVA: 0x00095194 File Offset: 0x00093394
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1843f)
			{
				this.HBJJOCHGOPH = 1208f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("traffic", this.JDMCFBKJHDD);
			}
			this.MPENCEIGLEH().SetFloat("uploads/Intralism/mods_terms.pdf", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("Fade", this.BlendFX);
			this.HILDKDFEBPF().SetFloat("challenges.", this.SwitchCameraToCamera2);
			this.EFDEIFCDAFG().SetVector("SetSunMaxSize", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1682f, 1371f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MPENCEIGLEH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001703 RID: 5891 RVA: 0x00095290 File Offset: 0x00093490
	private void JOLDJFOBCLO()
	{
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "isVisible";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "0 seconds";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Screen)
		{
			this.ELOFMLPCCEA = "FinalScoreSmallText";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearDodge)
		{
			this.ELOFMLPCCEA = "_Value2";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearDodge)
		{
			this.ELOFMLPCCEA = "FindFriends failed to apply the result, as a required value wasn't provided or the friend list length differed from result.";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearDodge)
		{
			this.ELOFMLPCCEA = "_Value4";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "OpGetGameList not sent. LobbyType must be SqlLobby.";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "_ScreenResolution";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearBurn)
		{
			this.ELOFMLPCCEA = "CameraFilterPack_VHS2";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-61))
		{
			this.ELOFMLPCCEA = "/";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-73))
		{
			this.ELOFMLPCCEA = "_ScreenResolution";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-89))
		{
			this.ELOFMLPCCEA = "Observed type is not serializable: ";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)82)
		{
			this.ELOFMLPCCEA = "Received RPC: ";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)52)
		{
			this.ELOFMLPCCEA = "CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-60))
		{
			this.ELOFMLPCCEA = "YES";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-86))
		{
			this.ELOFMLPCCEA = "_Offsets";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-107))
		{
			this.ELOFMLPCCEA = "_Value";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearDodge)
		{
			this.ELOFMLPCCEA = "_Near";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)26)
		{
			this.ELOFMLPCCEA = ". No ViewIDs are free to use. Max is: ";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-56))
		{
			this.ELOFMLPCCEA = "#tryagain";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-26))
		{
			this.ELOFMLPCCEA = " ";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)127)
		{
			this.ELOFMLPCCEA = "_FarCamera";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)82)
		{
			this.ELOFMLPCCEA = "downloading";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-10))
		{
			this.ELOFMLPCCEA = "_Value4";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)90)
		{
			this.ELOFMLPCCEA = "ws://";
		}
	}

	// Token: 0x06001704 RID: 5892 RVA: 0x000954EC File Offset: 0x000936EC
	private void FEHMFPBAGFG()
	{
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "player.circle";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "_ScreenResolution";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorBurn)
		{
			this.ELOFMLPCCEA = "OnJoinedLobby(). This client is connected and does get a room-list, which gets stored as PhotonNetwork.GetRoomList(). This script now calls: PhotonNetwork.JoinRandomRoom();";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Multiply)
		{
			this.ELOFMLPCCEA = "EventTimeInputField";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearBurn)
		{
			this.ELOFMLPCCEA = "_Value2";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorDodge)
		{
			this.ELOFMLPCCEA = "_Distortion";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Lighten)
		{
			this.ELOFMLPCCEA = "Texture2";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Multiply)
		{
			this.ELOFMLPCCEA = "MaxLivesSlider";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Screen)
		{
			this.ELOFMLPCCEA = "_Value7";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-42))
		{
			this.ELOFMLPCCEA = "_ScreenResolution";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)100)
		{
			this.ELOFMLPCCEA = ".lastCheckpoint.incorrectScore";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)80)
		{
			this.ELOFMLPCCEA = "_PositionX";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)65)
		{
			this.ELOFMLPCCEA = "int";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)52)
		{
			this.ELOFMLPCCEA = "_Value2";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)37)
		{
			this.ELOFMLPCCEA = "_Value2";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Subtract)
		{
			this.ELOFMLPCCEA = "/";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-75))
		{
			this.ELOFMLPCCEA = "Fill Area";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-15))
		{
			this.ELOFMLPCCEA = "checkpoint";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)116)
		{
			this.ELOFMLPCCEA = "The used master server address is not available with the subscription currently used. Got to Photon Cloud Dashboard or change URL. Disconnecting.";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-6))
		{
			this.ELOFMLPCCEA = "player.ice";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Hue)
		{
			this.ELOFMLPCCEA = "id";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-53))
		{
			this.ELOFMLPCCEA = "challenges.";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-19))
		{
			this.ELOFMLPCCEA = "[MenuScene] Error: ";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-74))
		{
			this.ELOFMLPCCEA = "PlayersScrollRectContent";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-124))
		{
			this.ELOFMLPCCEA = "selector";
		}
	}

	// Token: 0x06001705 RID: 5893 RVA: 0x00095748 File Offset: 0x00093948
	private void GOCIGGGHANF()
	{
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "_Dist";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "{0}";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Lighten)
		{
			this.ELOFMLPCCEA = "SelectorMusicToggle";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Lighten)
		{
			this.ELOFMLPCCEA = "Joystick1Button7";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorBurn)
		{
			this.ELOFMLPCCEA = "PossibleMapMaxScoreText";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.DarkerColor)
		{
			this.ELOFMLPCCEA = "Item ";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Multiply)
		{
			this.ELOFMLPCCEA = "SupportLogger OnFailedToConnectToPhoton(";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorDodge)
		{
			this.ELOFMLPCCEA = "[LevelEditorScene] Error: Timeout :S";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearDodge)
		{
			this.ELOFMLPCCEA = "#rategameinfo";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-54))
		{
			this.ELOFMLPCCEA = "_Value2";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)83)
		{
			this.ELOFMLPCCEA = "1177138211";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-92))
		{
			this.ELOFMLPCCEA = ",";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)102)
		{
			this.ELOFMLPCCEA = "LivesSlider";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-8))
		{
			this.ELOFMLPCCEA = " while connecting to: ";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)125)
		{
			this.ELOFMLPCCEA = "_Vignette";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)74)
		{
			this.ELOFMLPCCEA = "#forever";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-45))
		{
			this.ELOFMLPCCEA = "22x3";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-93))
		{
			this.ELOFMLPCCEA = "_MainTex2";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)58)
		{
			this.ELOFMLPCCEA = "Set Particle Size";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-88))
		{
			this.ELOFMLPCCEA = "note.5";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-78))
		{
			this.ELOFMLPCCEA = " This is not possible to be called for standalone input. Please check your platform and code where this is called";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-103))
		{
			this.ELOFMLPCCEA = "icon_border";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)121)
		{
			this.ELOFMLPCCEA = "SetSatelliteTrailMinVertexDistance";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)98)
		{
			this.ELOFMLPCCEA = "PhotonView ID duplicate found: {0}. New: {1} old: {2}. Maybe one wasn't destroyed on scene load?! Check for 'DontDestroyOnLoad'. Destroying old entry, adding new.";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)43)
		{
			this.ELOFMLPCCEA = "FreqVolume: ";
		}
	}

	// Token: 0x06001706 RID: 5894 RVA: 0x000959A4 File Offset: 0x00093BA4
	private void HNLPEJJPEGA()
	{
		if (this.filterchoice != this.BEHNMDCNKBF)
		{
			this.MHNCEEDIKCC();
			this.SCShader = Shader.Find(this.ELOFMLPCCEA);
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
			}
		}
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -104);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001707 RID: 5895 RVA: 0x00095A58 File Offset: 0x00093C58
	private void JKFDDNMPOJH()
	{
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 74);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.IGCBJKFAFEH();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001708 RID: 5896 RVA: 0x00095AD3 File Offset: 0x00093CD3
	private void HENBNNAGIKN()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -92);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001709 RID: 5897 RVA: 0x00095B10 File Offset: 0x00093D10
	private void AGFGKIBHCBE()
	{
		if (this.filterchoice != this.BEHNMDCNKBF)
		{
			this.MPJAFNJLBEF();
			this.SCShader = Shader.Find(this.ELOFMLPCCEA);
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
			}
		}
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -6);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600170A RID: 5898 RVA: 0x00095BC4 File Offset: 0x00093DC4
	private void MDGFFKJFLBH()
	{
		if (this.filterchoice != this.BEHNMDCNKBF)
		{
			this.IGCBJKFAFEH();
			this.SCShader = Shader.Find(this.ELOFMLPCCEA);
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = (HideFlags)(-81);
			}
		}
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 74);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600170B RID: 5899 RVA: 0x00095C78 File Offset: 0x00093E78
	private void OFBLDOCCBBN()
	{
		if (this.filterchoice != this.BEHNMDCNKBF)
		{
			this.FEHMFPBAGFG();
			this.SCShader = Shader.Find(this.ELOFMLPCCEA);
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
			}
		}
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 47);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600170C RID: 5900 RVA: 0x00095D2C File Offset: 0x00093F2C
	private void FMNPFCHBLJF()
	{
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 52);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.GOCIGGGHANF();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600170D RID: 5901 RVA: 0x00095DA7 File Offset: 0x00093FA7
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-98);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600170E RID: 5902 RVA: 0x00095DDE File Offset: 0x00093FDE
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600170F RID: 5903 RVA: 0x00095E18 File Offset: 0x00094018
	private void MELKBLIIFEO()
	{
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "_ScreenResolution";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Multiply)
		{
			this.ELOFMLPCCEA = "#";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "[Up]";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "Authentication failed: '{0}' Code: {1}";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorDodge)
		{
			this.ELOFMLPCCEA = "SpawnObj";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "_TimeX";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "ShadersToggle";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearBurn)
		{
			this.ELOFMLPCCEA = "Object ID. Case-Sensitive";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorDodge)
		{
			this.ELOFMLPCCEA = "_BloomIntensity";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)36)
		{
			this.ELOFMLPCCEA = "_Value";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-17))
		{
			this.ELOFMLPCCEA = "maps.";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-28))
		{
			this.ELOFMLPCCEA = "OPEN FILE";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)58)
		{
			this.ELOFMLPCCEA = "_Green_R";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-102))
		{
			this.ELOFMLPCCEA = "[Left]";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-83))
		{
			this.ELOFMLPCCEA = "visible";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)83)
		{
			this.ELOFMLPCCEA = "_TimeX";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-48))
		{
			this.ELOFMLPCCEA = "127.0.0.1";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-39))
		{
			this.ELOFMLPCCEA = "_Blue_R";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-74))
		{
			this.ELOFMLPCCEA = "Square";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-96))
		{
			this.ELOFMLPCCEA = "_TimeX";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-9))
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_LinearDodge";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)108)
		{
			this.ELOFMLPCCEA = "workshop.txt";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.PinLight)
		{
			this.ELOFMLPCCEA = "USE_PREDICATION";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-57))
		{
			this.ELOFMLPCCEA = "steamid";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-81))
		{
			this.ELOFMLPCCEA = "settings.enablehitsoundsinnormal";
		}
	}

	// Token: 0x06001710 RID: 5904 RVA: 0x00092434 File Offset: 0x00090634
	private Material DOMEEFLPEPJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-118);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001711 RID: 5905 RVA: 0x00096074 File Offset: 0x00094274
	private void MFOOCOIIIJN()
	{
		if (this.filterchoice != this.BEHNMDCNKBF)
		{
			this.FEHMFPBAGFG();
			this.SCShader = Shader.Find(this.ELOFMLPCCEA);
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
			}
		}
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -93);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001712 RID: 5906 RVA: 0x00096128 File Offset: 0x00094328
	private void MPJAFNJLBEF()
	{
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "_ScreenResolution";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Multiply)
		{
			this.ELOFMLPCCEA = "_DepthLevel";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Multiply)
		{
			this.ELOFMLPCCEA = "_TimeX";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "_History1Weight";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "Set Particles Gravity";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Lighten)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/FX_DigitalMatrix";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = " AuthMode ";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.DarkerColor)
		{
			this.ELOFMLPCCEA = "_Y";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Multiply)
		{
			this.ELOFMLPCCEA = "Spawn new environment object (sun, satellite etc) and sets its id";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)33)
		{
			this.ELOFMLPCCEA = "] to be droppable";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-95))
		{
			this.ELOFMLPCCEA = "settings_bindings_";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-125))
		{
			this.ELOFMLPCCEA = "ReconnectAndRejoin() failed. It seems the client wasn't connected to a game server before (no address).";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)84)
		{
			this.ELOFMLPCCEA = "Emergency Help:";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)114)
		{
			this.ELOFMLPCCEA = "_SceneFogMode";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-92))
		{
			this.ELOFMLPCCEA = "_ScreenResolution";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)51)
		{
			this.ELOFMLPCCEA = "sfxVolume";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-27))
		{
			this.ELOFMLPCCEA = "[PowerUp]";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-63))
		{
			this.ELOFMLPCCEA = "event";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)39)
		{
			this.ELOFMLPCCEA = "offsets";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-65))
		{
			this.ELOFMLPCCEA = "_Value";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-114))
		{
			this.ELOFMLPCCEA = "HitInRelaxMusicToggle";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)27)
		{
			this.ELOFMLPCCEA = "Can't set Room.MaxPlayers to: ";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-50))
		{
			this.ELOFMLPCCEA = "QuickSave";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-126))
		{
			this.ELOFMLPCCEA = "settings.hitvariation";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)37)
		{
			this.ELOFMLPCCEA = "AddEnvironmentSprite";
		}
	}

	// Token: 0x06001713 RID: 5907 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void OFIMMFHFHDD()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001714 RID: 5908 RVA: 0x00096384 File Offset: 0x00094584
	private void ADPLHDFJFID()
	{
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 69);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.LGHFFANDDCM();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001715 RID: 5909 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void JEBIBKLHFLB()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001716 RID: 5910 RVA: 0x00096400 File Offset: 0x00094600
	private void DAIPOKLLFLD()
	{
		if (this.filterchoice != this.BEHNMDCNKBF)
		{
			this.JOLDJFOBCLO();
			this.SCShader = Shader.Find(this.ELOFMLPCCEA);
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
			}
		}
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 56);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001717 RID: 5911 RVA: 0x000964B4 File Offset: 0x000946B4
	private void LFAFJKJAEEL()
	{
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -103);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.NBMEBBHCNMH();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001718 RID: 5912 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06001719 RID: 5913 RVA: 0x00096530 File Offset: 0x00094730
	private void MOMGJJDIFFI()
	{
		if (this.filterchoice != this.BEHNMDCNKBF)
		{
			this.LBEHKFNPKMC();
			this.SCShader = Shader.Find(this.ELOFMLPCCEA);
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
			}
		}
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -126);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600171A RID: 5914 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void OGLCKDAHOCG()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600171B RID: 5915 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void BLKGOMCPEKI()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600171C RID: 5916 RVA: 0x000965E4 File Offset: 0x000947E4
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600171D RID: 5917 RVA: 0x0009661B File Offset: 0x0009481B
	private void HMKJFPBFOFI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 62);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600171E RID: 5918 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void ELKELFCGMPE()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600171F RID: 5919 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void HLLHJIDOOGA()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001720 RID: 5920 RVA: 0x00096658 File Offset: 0x00094858
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 149f)
			{
				this.HBJJOCHGOPH = 105f;
			}
			if (this.Camera2 != null)
			{
				this.OCMBHMLNCEK().SetTexture("player.slash", this.JDMCFBKJHDD);
			}
			this.MNLKBFFKHIE().SetFloat("_Blue_B", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("ConnectionTimeout", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("ResourcesConfig", this.SwitchCameraToCamera2);
			this.LDNADDJMIPK().SetVector("maps.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1383f, 679f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001721 RID: 5921 RVA: 0x00096752 File Offset: 0x00094952
	private Material IKAEIOAHPKI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001722 RID: 5922 RVA: 0x00096789 File Offset: 0x00094989
	private Material ECCPAOBFDKP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001723 RID: 5923 RVA: 0x000967C0 File Offset: 0x000949C0
	private void MLLPGPANCHI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -68);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001724 RID: 5924 RVA: 0x000967FB File Offset: 0x000949FB
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001725 RID: 5925 RVA: 0x0009661B File Offset: 0x0009481B
	private void KMKKHLGJEMC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 62);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x06001726 RID: 5926 RVA: 0x00096834 File Offset: 0x00094A34
	private void ICILLMAKLMI()
	{
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -54);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.GBPGJKPMMDN();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001727 RID: 5927 RVA: 0x000968B0 File Offset: 0x00094AB0
	private void DAHFFNNIGML()
	{
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 52);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.MPJAFNJLBEF();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001728 RID: 5928 RVA: 0x000965E4 File Offset: 0x000947E4
	private Material MHBAIEKFBIJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)94;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001729 RID: 5929 RVA: 0x000910AF File Offset: 0x0008F2AF
	private void MCKCCPLJIFE()
	{
		if (this.Camera2 != null)
		{
			this.Camera2.targetTexture = null;
		}
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600172A RID: 5930 RVA: 0x0009692C File Offset: 0x00094B2C
	private void AJENCHHLHKF()
	{
		if (this.filterchoice != this.BEHNMDCNKBF)
		{
			this.MELKBLIIFEO();
			this.SCShader = Shader.Find(this.ELOFMLPCCEA);
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
			if (this.BJFKDHHMLJH == null)
			{
				this.BJFKDHHMLJH = new Material(this.SCShader);
				this.BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
			}
		}
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, -101);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600172B RID: 5931 RVA: 0x000969E0 File Offset: 0x00094BE0
	private void OnEnable()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
	}

	// Token: 0x0600172C RID: 5932 RVA: 0x00096A1C File Offset: 0x00094C1C
	private void MHNCEEDIKCC()
	{
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "_History1Weight";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Darken)
		{
			this.ELOFMLPCCEA = "_FarCamera";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearBurn)
		{
			this.ELOFMLPCCEA = "_Extra2";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Multiply)
		{
			this.ELOFMLPCCEA = "_ScreenResolution";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Screen)
		{
			this.ELOFMLPCCEA = "Joystick1Button11";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorDodge)
		{
			this.ELOFMLPCCEA = "menu.relaxinfo";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.ColorBurn)
		{
			this.ELOFMLPCCEA = "[Right-Left]";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.LinearBurn)
		{
			this.ELOFMLPCCEA = "https://twitch.tv/intralism";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.DarkerColor)
		{
			this.ELOFMLPCCEA = "_NoiseTex";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)107)
		{
			this.ELOFMLPCCEA = "_CenterY";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)65)
		{
			this.ELOFMLPCCEA = "player.deleted";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-34))
		{
			this.ELOFMLPCCEA = "OPEN FILE";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-120))
		{
			this.ELOFMLPCCEA = "<b>Difficulty</b>:";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)100)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Color_GrayScale";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)72)
		{
			this.ELOFMLPCCEA = "ZoomFade";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)107)
		{
			this.ELOFMLPCCEA = "ChatHistoryInputField";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)115)
		{
			this.ELOFMLPCCEA = "CameraFilterPack/Pixelisation_Dot";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.DarkerColor)
		{
			this.ELOFMLPCCEA = "achievements.21.progress";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-33))
		{
			this.ELOFMLPCCEA = "Using constructor for new PingNativeDynamic()";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-78))
		{
			this.ELOFMLPCCEA = "CountEventsGoal";
		}
		if (this.filterchoice == CameraFilterPack_Blend2Camera_PhotoshopFilters.filters.Luminosity)
		{
			this.ELOFMLPCCEA = "offsets";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-3))
		{
			this.ELOFMLPCCEA = "Tab2Content";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)(-53))
		{
			this.ELOFMLPCCEA = "_Blend";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)62)
		{
			this.ELOFMLPCCEA = "_Value2";
		}
		if (this.filterchoice == (CameraFilterPack_Blend2Camera_PhotoshopFilters.filters)70)
		{
			this.ELOFMLPCCEA = "ERROR: Make sure your mod contains at leats one file!";
		}
	}

	// Token: 0x0600172D RID: 5933 RVA: 0x00096C78 File Offset: 0x00094E78
	private void HNMIAKKBMDM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1553f)
			{
				this.HBJJOCHGOPH = 720f;
			}
			if (this.Camera2 != null)
			{
				this.ADBKPGFMNKO().SetTexture("stretchWidth", this.JDMCFBKJHDD);
			}
			this.MFHPKGICPIO().SetFloat("GroupNameText", this.HBJJOCHGOPH);
			this.HILDKDFEBPF().SetFloat(".lastCheckpoint.bgcolor", this.BlendFX);
			this.LPDOGGFOBDH().SetFloat("UseScanLineSize", this.SwitchCameraToCamera2);
			this.OIIDAKBILMI().SetVector("_AdditiveReflection", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1497f, 330f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600172E RID: 5934 RVA: 0x00096D74 File Offset: 0x00094F74
	private void Start()
	{
		this.BEHNMDCNKBF = this.filterchoice;
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture(Screen.width, Screen.height, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.MIPGPMKJELI();
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x04000315 RID: 789
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_Darken";

	// Token: 0x04000316 RID: 790
	public Shader SCShader;

	// Token: 0x04000317 RID: 791
	public Camera Camera2;

	// Token: 0x04000318 RID: 792
	public CameraFilterPack_Blend2Camera_PhotoshopFilters.filters filterchoice;

	// Token: 0x04000319 RID: 793
	private CameraFilterPack_Blend2Camera_PhotoshopFilters.filters BEHNMDCNKBF;

	// Token: 0x0400031A RID: 794
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400031B RID: 795
	private Vector4 GOIJPFAHKPE;

	// Token: 0x0400031C RID: 796
	private Material BJFKDHHMLJH;

	// Token: 0x0400031D RID: 797
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x0400031E RID: 798
	[Range(0f, 1f)]
	public float BlendFX = 0.5f;

	// Token: 0x0400031F RID: 799
	private RenderTexture JDMCFBKJHDD;

	// Token: 0x02000051 RID: 81
	public enum filters
	{
		// Token: 0x04000321 RID: 801
		Darken,
		// Token: 0x04000322 RID: 802
		Multiply,
		// Token: 0x04000323 RID: 803
		ColorBurn,
		// Token: 0x04000324 RID: 804
		LinearBurn,
		// Token: 0x04000325 RID: 805
		DarkerColor,
		// Token: 0x04000326 RID: 806
		Lighten,
		// Token: 0x04000327 RID: 807
		Screen,
		// Token: 0x04000328 RID: 808
		ColorDodge,
		// Token: 0x04000329 RID: 809
		LinearDodge,
		// Token: 0x0400032A RID: 810
		LighterColor,
		// Token: 0x0400032B RID: 811
		Overlay,
		// Token: 0x0400032C RID: 812
		SoftLight,
		// Token: 0x0400032D RID: 813
		HardLight,
		// Token: 0x0400032E RID: 814
		VividLight,
		// Token: 0x0400032F RID: 815
		LinearLight,
		// Token: 0x04000330 RID: 816
		PinLight,
		// Token: 0x04000331 RID: 817
		HardMix,
		// Token: 0x04000332 RID: 818
		Difference,
		// Token: 0x04000333 RID: 819
		Exclusion,
		// Token: 0x04000334 RID: 820
		Subtract,
		// Token: 0x04000335 RID: 821
		Divide,
		// Token: 0x04000336 RID: 822
		Hue,
		// Token: 0x04000337 RID: 823
		Saturation,
		// Token: 0x04000338 RID: 824
		Color,
		// Token: 0x04000339 RID: 825
		Luminosity
	}
}
