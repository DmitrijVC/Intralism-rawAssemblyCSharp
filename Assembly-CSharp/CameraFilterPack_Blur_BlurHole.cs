using System;
using UnityEngine;

// Token: 0x0200005C RID: 92
[AddComponentMenu("Camera Filter Pack/Blur/Blur Hole")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_BlurHole : MonoBehaviour
{
	// Token: 0x06001A04 RID: 6660 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06001A05 RID: 6661 RVA: 0x000A2E38 File Offset: 0x000A1038
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A06 RID: 6662 RVA: 0x000A2E6F File Offset: 0x000A106F
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A07 RID: 6663 RVA: 0x000A2EA8 File Offset: 0x000A10A8
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 548f)
			{
				this.HBJJOCHGOPH = 541f;
			}
			this.EJDPNJAEAKJ().SetFloat("{0:0} minute{1}, ", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("The given 2D texture ", this.Size);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this._Radius);
			this.LONNIJMNKFB().SetFloat("_CenterY", this._SpotSize);
			this.JIBOKBCPDLC().SetFloat("Could not find RPC with index: ", this._CenterX);
			this.DEFBJOCJJKF().SetFloat("Editor/", this._CenterY);
			this.LONNIJMNKFB().SetFloat("[Down-Left]", this._AlphaBlur);
			this.FOOCJIDNGBB().SetFloat("OpenButton", this._AlphaBlurInside);
			this.HEINDEMCGIK().SetVector("SaveButton", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A08 RID: 6664 RVA: 0x000A2FE4 File Offset: 0x000A11E4
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1160f)
			{
				this.HBJJOCHGOPH = 1448f;
			}
			this.HNFFHCLNBDN().SetFloat("X", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetFloat("0 seconds", this.Size);
			this.EFDEIFCDAFG().SetFloat(".png", this._Radius);
			this.MLMKCOINOOH().SetFloat("PossibleMapPointsText", this._SpotSize);
			this.OIIDAKBILMI().SetFloat("_Offsets", this._CenterX);
			this.HCGJCMDJPGD().SetFloat("config.txt", this._CenterY);
			this.CIAFLBFJLEJ().SetFloat("s", this._AlphaBlur);
			this.NJDIODJNGGA().SetFloat("_TimeX", this._AlphaBlurInside);
			this.FOOCJIDNGBB().SetVector("_VignettingColor", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A09 RID: 6665 RVA: 0x000A311E File Offset: 0x000A131E
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A0A RID: 6666 RVA: 0x000A313B File Offset: 0x000A133B
	private void FEKECCBFGMI()
	{
		this.SCShader = Shader.Find("pointBuffer");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001A0B RID: 6667 RVA: 0x000A315F File Offset: 0x000A135F
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A0C RID: 6668 RVA: 0x000A3196 File Offset: 0x000A1396
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A0D RID: 6669 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06001A0E RID: 6670 RVA: 0x000A31CD File Offset: 0x000A13CD
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A0F RID: 6671 RVA: 0x000A3204 File Offset: 0x000A1404
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1537f)
			{
				this.HBJJOCHGOPH = 1749f;
			}
			this.OGMEGHKECAH().SetFloat("Missing shader for image effect {0}", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("Something is setup incorrectly with the dropdownlist component causing a Null Refernece Exception", this.Size);
			this.EFDEIFCDAFG().SetFloat("#", this._Radius);
			this.AELJLBOJAIL().SetFloat("hitsounds:", this._SpotSize);
			this.AELJLBOJAIL().SetFloat("_TimeX", this._CenterX);
			this.EJDPNJAEAKJ().SetFloat("RecordButton", this._CenterY);
			this.LENEJAGLCNL().SetFloat("gold", this._AlphaBlur);
			this.EFDEIFCDAFG().SetFloat("_TimeX", this._AlphaBlurInside);
			this.NBPKMLMCHFN.SetVector("[", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A10 RID: 6672 RVA: 0x000A333E File Offset: 0x000A153E
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A11 RID: 6673 RVA: 0x000A3375 File Offset: 0x000A1575
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A12 RID: 6674 RVA: 0x000A33AC File Offset: 0x000A15AC
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001A13 RID: 6675 RVA: 0x000A33D0 File Offset: 0x000A15D0
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("table");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001A14 RID: 6676 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06001A15 RID: 6677 RVA: 0x000A33F4 File Offset: 0x000A15F4
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1693f)
			{
				this.HBJJOCHGOPH = 21f;
			}
			this.OIIDAKBILMI().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("_TimeX", this.Size);
			this.LENEJAGLCNL().SetFloat("/../", this._Radius);
			this.AELJLBOJAIL().SetFloat("In Main Menu", this._SpotSize);
			this.HEINDEMCGIK().SetFloat("Ev Destroy Failed. Could not find PhotonView with instantiationId ", this._CenterX);
			this.ADBKPGFMNKO().SetFloat("_Value", this._CenterY);
			this.OIIDAKBILMI().SetFloat("CameraFilterPack/Atmosphere_Fog", this._AlphaBlur);
			this.HHIFMIPPMPF().SetFloat(",", this._AlphaBlurInside);
			this.CIAFLBFJLEJ().SetVector("HighScaleShot", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A16 RID: 6678 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x06001A17 RID: 6679 RVA: 0x000A352E File Offset: 0x000A172E
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001A18 RID: 6680 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x06001A19 RID: 6681 RVA: 0x000A311E File Offset: 0x000A131E
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A1A RID: 6682 RVA: 0x000A3552 File Offset: 0x000A1752
	private Material OIIDAKBILMI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A1B RID: 6683 RVA: 0x000A311E File Offset: 0x000A131E
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A1C RID: 6684 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x06001A1D RID: 6685 RVA: 0x000A358C File Offset: 0x000A178C
	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 317f)
			{
				this.HBJJOCHGOPH = 191f;
			}
			this.OGMEGHKECAH().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("_LowRez", this.Size);
			this.NBPKMLMCHFN.SetFloat("_MainTex2", this._Radius);
			this.EJDPNJAEAKJ().SetFloat("Joystick1Button6", this._SpotSize);
			this.OIIDAKBILMI().SetFloat("1248864821", this._CenterX);
			this.OGMEGHKECAH().SetFloat("_Visualize", this._CenterY);
			this.OIIDAKBILMI().SetFloat("_copy", this._AlphaBlur);
			this.LONNIJMNKFB().SetFloat("_TimeX", this._AlphaBlurInside);
			this.ADBKPGFMNKO().SetVector("_Value3", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A1E RID: 6686 RVA: 0x000A311E File Offset: 0x000A131E
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A1F RID: 6687 RVA: 0x000A36C8 File Offset: 0x000A18C8
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1294f)
			{
				this.HBJJOCHGOPH = 834f;
			}
			this.DEFBJOCJJKF().SetFloat("D-Pad Down", this.HBJJOCHGOPH);
			this.FKEOGPDLBDD().SetFloat("_Alpha", this.Size);
			this.NJDIODJNGGA().SetFloat("Edited unlock conditions", this._Radius);
			this.DEFBJOCJJKF().SetFloat("_EmissionColor", this._SpotSize);
			this.EFDEIFCDAFG().SetFloat("RULES", this._CenterX);
			this.HCGJCMDJPGD().SetFloat("visible", this._CenterY);
			this.HEINDEMCGIK().SetFloat("_CurrentMipLevel", this._AlphaBlur);
			this.LENEJAGLCNL().SetFloat("_Distortion", this._AlphaBlurInside);
			this.DEFBJOCJJKF().SetVector("_TimeX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A20 RID: 6688 RVA: 0x000A3802 File Offset: 0x000A1A02
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("PlayerPrefs::Deserialize() parameterContent has ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001A21 RID: 6689 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06001A22 RID: 6690 RVA: 0x000A3828 File Offset: 0x000A1A28
	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1650f)
			{
				this.HBJJOCHGOPH = 506f;
			}
			this.DEFBJOCJJKF().SetFloat(".icon", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("_Extra", this.Size);
			this.OGMEGHKECAH().SetFloat("_Intensity", this._Radius);
			this.DEFBJOCJJKF().SetFloat("open", this._SpotSize);
			this.NJDIODJNGGA().SetFloat("_MainTex", this._CenterX);
			this.NBPKMLMCHFN.SetFloat("_Value", this._CenterY);
			this.EFDEIFCDAFG().SetFloat("resource", this._AlphaBlur);
			this.AELJLBOJAIL().SetFloat("_MainTex2", this._AlphaBlurInside);
			this.EJDPNJAEAKJ().SetVector("_TimeX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A23 RID: 6691 RVA: 0x000A3962 File Offset: 0x000A1B62
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A24 RID: 6692 RVA: 0x000A3999 File Offset: 0x000A1B99
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find("PPI: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001A25 RID: 6693 RVA: 0x000A39C0 File Offset: 0x000A1BC0
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1226f)
			{
				this.HBJJOCHGOPH = 1588f;
			}
			this.ADBKPGFMNKO().SetFloat("Joystick1Button3", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("icon.png", this.Size);
			this.AELJLBOJAIL().SetFloat("Reconnect() failed. Can only connect while in state 'Disconnected'. Current state: ", this._Radius);
			this.HEINDEMCGIK().SetFloat("Edited event", this._SpotSize);
			this.MLMKCOINOOH().SetFloat("_BaseTex", this._CenterX);
			this.HNFFHCLNBDN().SetFloat("_ScreenResolution", this._CenterY);
			this.NJDIODJNGGA().SetFloat("Set Sun Emission", this._AlphaBlur);
			this.EJDPNJAEAKJ().SetFloat("float,1", this._AlphaBlurInside);
			this.FKEOGPDLBDD().SetVector("[DiscordController] Disconnect {0}: {1}", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A26 RID: 6694 RVA: 0x000A3AFA File Offset: 0x000A1CFA
	private void AEDDNDHCLNN()
	{
		this.SCShader = Shader.Find("ShowSprite");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001A27 RID: 6695 RVA: 0x000A3B1E File Offset: 0x000A1D1E
	private void FMNPFCHBLJF()
	{
		this.SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001A28 RID: 6696 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x06001A29 RID: 6697 RVA: 0x000A3B42 File Offset: 0x000A1D42
	private Material FOOCJIDNGBB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A2A RID: 6698 RVA: 0x000A3B79 File Offset: 0x000A1D79
	private void JONGNKNLLND()
	{
		this.SCShader = Shader.Find("_Screen");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001A2B RID: 6699 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x06001A2C RID: 6700 RVA: 0x000A3B9D File Offset: 0x000A1D9D
	private void LBAJLLFMMMP()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001A2D RID: 6701 RVA: 0x000A3BC1 File Offset: 0x000A1DC1
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find(".");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001A2E RID: 6702 RVA: 0x000A3962 File Offset: 0x000A1B62
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A2F RID: 6703 RVA: 0x000A3BE5 File Offset: 0x000A1DE5
	private Material MLMKCOINOOH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A30 RID: 6704 RVA: 0x000A3C1C File Offset: 0x000A1E1C
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("TStart");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001A31 RID: 6705 RVA: 0x000A311E File Offset: 0x000A131E
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A32 RID: 6706 RVA: 0x000A311E File Offset: 0x000A131E
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A33 RID: 6707 RVA: 0x000A3C40 File Offset: 0x000A1E40
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 195f)
			{
				this.HBJJOCHGOPH = 185f;
			}
			this.HNFFHCLNBDN().SetFloat("finished", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("_TimeX", this.Size);
			this.HEINDEMCGIK().SetFloat("runas", this._Radius);
			this.HHIFMIPPMPF().SetFloat("_TimeX", this._SpotSize);
			this.CIAFLBFJLEJ().SetFloat("offsets", this._CenterX);
			this.EFDEIFCDAFG().SetFloat("_CenterX", this._CenterY);
			this.ADBKPGFMNKO().SetFloat("-1", this._AlphaBlur);
			this.AELJLBOJAIL().SetFloat("PS Home", this._AlphaBlurInside);
			this.OIIDAKBILMI().SetVector("Set Player Distance", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A34 RID: 6708 RVA: 0x000A3D7C File Offset: 0x000A1F7C
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 234f)
			{
				this.HBJJOCHGOPH = 1446f;
			}
			this.EJDPNJAEAKJ().SetFloat(".progress", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("Uploader", this.Size);
			this.HCGJCMDJPGD().SetFloat("_Saturation", this._Radius);
			this.AELJLBOJAIL().SetFloat("menu.enableselectormusic", this._SpotSize);
			this.OIIDAKBILMI().SetFloat("menu.selectedplaymode", this._CenterX);
			this.OIIDAKBILMI().SetFloat("_Green_R", this._CenterY);
			this.DEFBJOCJJKF().SetFloat("float,0", this._AlphaBlur);
			this.AELJLBOJAIL().SetFloat("float,0", this._AlphaBlurInside);
			this.ADBKPGFMNKO().SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A35 RID: 6709 RVA: 0x0002523B File Offset: 0x0002343B
	private void MAOCOEGAFND()
	{
	}

	// Token: 0x06001A36 RID: 6710 RVA: 0x000A3EB6 File Offset: 0x000A20B6
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find(" ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001A37 RID: 6711 RVA: 0x000A3EDC File Offset: 0x000A20DC
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1200f)
			{
				this.HBJJOCHGOPH = 1368f;
			}
			this.NJDIODJNGGA().SetFloat("Tab1Content", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("_ScreenResolution", this.Size);
			this.AELJLBOJAIL().SetFloat("_TimeX", this._Radius);
			this.HHIFMIPPMPF().SetFloat("CameraFilterPack/Drawing_BluePrint", this._SpotSize);
			this.HHIFMIPPMPF().SetFloat("offsets", this._CenterX);
			this.HHIFMIPPMPF().SetFloat("_TimeX", this._CenterY);
			this.NJDIODJNGGA().SetFloat("_ColorBuffer", this._AlphaBlur);
			this.DEFBJOCJJKF().SetFloat("SaveButton", this._AlphaBlurInside);
			this.HNFFHCLNBDN().SetVector("setfloat", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A38 RID: 6712 RVA: 0x000A4018 File Offset: 0x000A2218
	private void MJFOBAKGCNO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1259f)
			{
				this.HBJJOCHGOPH = 1879f;
			}
			this.FOOCJIDNGBB().SetFloat("SetSunInput", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("\"\"", this.Size);
			this.NBPKMLMCHFN.SetFloat(" evLeave: ", this._Radius);
			this.FKEOGPDLBDD().SetFloat("InfoText", this._SpotSize);
			this.ADBKPGFMNKO().SetFloat("_Value3", this._CenterX);
			this.DEFBJOCJJKF().SetFloat("Noise shaders are not set up! Disabling noise effect.", this._CenterY);
			this.LENEJAGLCNL().SetFloat("Mouse Y", this._AlphaBlur);
			this.ADBKPGFMNKO().SetFloat("_Distortion", this._AlphaBlurInside);
			this.LENEJAGLCNL().SetVector("_RampTex", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A39 RID: 6713 RVA: 0x000A311E File Offset: 0x000A131E
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A3A RID: 6714 RVA: 0x000A4152 File Offset: 0x000A2352
	private void NPLCENPNJBM()
	{
		this.SCShader = Shader.Find("offsets");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001A3B RID: 6715 RVA: 0x000A311E File Offset: 0x000A131E
	private void HOMNAHDDNHJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A3C RID: 6716 RVA: 0x000A311E File Offset: 0x000A131E
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A3D RID: 6717 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCHBFNIPBHB()
	{
	}

	// Token: 0x06001A3E RID: 6718 RVA: 0x000A4176 File Offset: 0x000A2376
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A3F RID: 6719 RVA: 0x000A41B0 File Offset: 0x000A23B0
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 900f)
			{
				this.HBJJOCHGOPH = 432f;
			}
			this.ADBKPGFMNKO().SetFloat("DPADHOR", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("SetTrailZoomSpeed", this.Size);
			this.FKEOGPDLBDD().SetFloat("_SecondTex", this._Radius);
			this.EFDEIFCDAFG().SetFloat("_BlurParams", this._SpotSize);
			this.FKEOGPDLBDD().SetFloat("_Value2", this._CenterX);
			this.OGMEGHKECAH().SetFloat("_ScreenResolution", this._CenterY);
			this.HEINDEMCGIK().SetFloat("JoinButton", this._AlphaBlur);
			this.FOOCJIDNGBB().SetFloat("SUCCESS! Item submitted! :D :D :D", this._AlphaBlurInside);
			this.FKEOGPDLBDD().SetVector("_TimeX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A40 RID: 6720 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001A42 RID: 6722 RVA: 0x000A434C File Offset: 0x000A254C
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 982f)
			{
				this.HBJJOCHGOPH = 257f;
			}
			this.EJDPNJAEAKJ().SetFloat("OnPressRight", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat("_ScreenResolution", this.Size);
			this.EJDPNJAEAKJ().SetFloat("Players NetIDs:", this._Radius);
			this.HHIFMIPPMPF().SetFloat("UI Extensions/UIScreen", this._SpotSize);
			this.EFDEIFCDAFG().SetFloat("float,2", this._CenterX);
			this.OIIDAKBILMI().SetFloat("_Value2", this._CenterY);
			this.NBPKMLMCHFN.SetFloat("Right", this._AlphaBlur);
			this.NBPKMLMCHFN.SetFloat("VIGNETTE_FILMIC", this._AlphaBlurInside);
			this.FKEOGPDLBDD().SetVector("[PlayerBase] Loaded custom model: ", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A43 RID: 6723 RVA: 0x000A4488 File Offset: 0x000A2688
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 833f)
			{
				this.HBJJOCHGOPH = 1780f;
			}
			this.LENEJAGLCNL().SetFloat("Using PhotonServerSettings.Protocol when leaving the NameServer (AuthMode is AuthOnceWss): ", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetFloat(". Verify the Prefab is in a Resources folder (and not in a subfolder)", this.Size);
			this.FKEOGPDLBDD().SetFloat("2;13;14;15;16", this._Radius);
			this.HCGJCMDJPGD().SetFloat("[Up-Right-Left]", this._SpotSize);
			this.ADBKPGFMNKO().SetFloat("System.String", this._CenterX);
			this.HEINDEMCGIK().SetFloat("workshop.", this._CenterY);
			this.HCGJCMDJPGD().SetFloat("_Value3", this._AlphaBlur);
			this.EJDPNJAEAKJ().SetFloat("CameraFilterPack_AAA_Blood_Hit1", this._AlphaBlurInside);
			this.JIBOKBCPDLC().SetVector("history", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A44 RID: 6724 RVA: 0x000A45C4 File Offset: 0x000A27C4
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 306f)
			{
				this.HBJJOCHGOPH = 1880f;
			}
			this.AELJLBOJAIL().SetFloat("_Value", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("_Value2", this.Size);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Colors_DarkColor", this._Radius);
			this.FKEOGPDLBDD().SetFloat("menu.playedpage", this._SpotSize);
			this.CIAFLBFJLEJ().SetFloat("_Value2", this._CenterX);
			this.OIIDAKBILMI().SetFloat("<b>", this._CenterY);
			this.OIIDAKBILMI().SetFloat("_Value2", this._AlphaBlur);
			this.EFDEIFCDAFG().SetFloat("Fade", this._AlphaBlurInside);
			this.HEINDEMCGIK().SetVector("ticket", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A45 RID: 6725 RVA: 0x000A4700 File Offset: 0x000A2900
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 563f)
			{
				this.HBJJOCHGOPH = 1884f;
			}
			this.HNFFHCLNBDN().SetFloat("_Value", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("GameScene", this.Size);
			this.LONNIJMNKFB().SetFloat("player.quantum", this._Radius);
			this.MLMKCOINOOH().SetFloat("_TimeX", this._SpotSize);
			this.HCGJCMDJPGD().SetFloat("MaxLivesSlider", this._CenterX);
			this.HHIFMIPPMPF().SetFloat("_Amount", this._CenterY);
			this.HNFFHCLNBDN().SetFloat("_Speed", this._AlphaBlur);
			this.FKEOGPDLBDD().SetFloat("_DotSize", this._AlphaBlurInside);
			this.CIAFLBFJLEJ().SetVector("Joystick1Button9", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LENEJAGLCNL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A46 RID: 6726 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06001A47 RID: 6727 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x06001A48 RID: 6728 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x06001A49 RID: 6729 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBPCODPOJAH()
	{
	}

	// Token: 0x06001A4A RID: 6730 RVA: 0x000A311E File Offset: 0x000A131E
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A4B RID: 6731 RVA: 0x000A483A File Offset: 0x000A2A3A
	private void OKLAJINHPAN()
	{
		this.SCShader = Shader.Find("0.00");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001A4C RID: 6732 RVA: 0x000A4860 File Offset: 0x000A2A60
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
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Radius", this._Radius);
			this.NBPKMLMCHFN.SetFloat("_SpotSize", this._SpotSize);
			this.NBPKMLMCHFN.SetFloat("_CenterX", this._CenterX);
			this.NBPKMLMCHFN.SetFloat("_CenterY", this._CenterY);
			this.NBPKMLMCHFN.SetFloat("_Alpha", this._AlphaBlur);
			this.NBPKMLMCHFN.SetFloat("_Alpha2", this._AlphaBlurInside);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A4D RID: 6733 RVA: 0x000A499C File Offset: 0x000A2B9C
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1715f)
			{
				this.HBJJOCHGOPH = 1936f;
			}
			this.HNFFHCLNBDN().SetFloat("[LobbyPlayerElement] Created lpe for ", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("player.xp", this.Size);
			this.OIIDAKBILMI().SetFloat("_Value2", this._Radius);
			this.CIAFLBFJLEJ().SetFloat(" ", this._SpotSize);
			this.OIIDAKBILMI().SetFloat("Fill Area", this._CenterX);
			this.MLMKCOINOOH().SetFloat("menu.tabid", this._CenterY);
			this.NJDIODJNGGA().SetFloat("StartButton", this._AlphaBlur);
			this.EJDPNJAEAKJ().SetFloat("(master)", this._AlphaBlurInside);
			this.NBPKMLMCHFN.SetVector("/", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A4E RID: 6734 RVA: 0x000A311E File Offset: 0x000A131E
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A4F RID: 6735 RVA: 0x000A311E File Offset: 0x000A131E
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A50 RID: 6736 RVA: 0x000A311E File Offset: 0x000A131E
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A51 RID: 6737 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06001A52 RID: 6738 RVA: 0x000A4AD6 File Offset: 0x000A2CD6
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A53 RID: 6739 RVA: 0x000A311E File Offset: 0x000A131E
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A54 RID: 6740 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x17000042 RID: 66
	// (get) Token: 0x06001A55 RID: 6741 RVA: 0x000A4B0D File Offset: 0x000A2D0D
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

	// Token: 0x06001A56 RID: 6742 RVA: 0x000A4B44 File Offset: 0x000A2D44
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/BlurHole");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001A57 RID: 6743 RVA: 0x000A4B68 File Offset: 0x000A2D68
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 943f)
			{
				this.HBJJOCHGOPH = 182f;
			}
			this.NJDIODJNGGA().SetFloat("ChallengesButton", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("FrostCanvas", this.Size);
			this.FOOCJIDNGBB().SetFloat("Updated!", this._Radius);
			this.LENEJAGLCNL().SetFloat("</color>", this._SpotSize);
			this.CIAFLBFJLEJ().SetFloat("_HdrParams", this._CenterX);
			this.ADBKPGFMNKO().SetFloat("SetEnvSpriteImage", this._CenterY);
			this.CIAFLBFJLEJ().SetFloat("Image", this._AlphaBlur);
			this.EFDEIFCDAFG().SetFloat("It seems some instantiation is not completed, as instantiation data is used. You should make sure instantiations are paused when calling this method. Cleaning now, despite this.", this._AlphaBlurInside);
			this.JIBOKBCPDLC().SetVector("CameraFilterPack_Paper1", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A58 RID: 6744 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06001A59 RID: 6745 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKMELABKBHO()
	{
	}

	// Token: 0x06001A5A RID: 6746 RVA: 0x000A4CA4 File Offset: 0x000A2EA4
	private void DOOIKOEBBJB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 868f)
			{
				this.HBJJOCHGOPH = 227f;
			}
			this.ADBKPGFMNKO().SetFloat("_Value8", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("_Value2", this.Size);
			this.FOOCJIDNGBB().SetFloat("menu.enableselectormusic", this._Radius);
			this.NBPKMLMCHFN.SetFloat("Mask texture not readable, set your sprite to Texture Type 'Advanced' and check 'Read/Write Enabled'", this._SpotSize);
			this.FKEOGPDLBDD().SetFloat("_MainTex2", this._CenterX);
			this.LONNIJMNKFB().SetFloat("_LutTex", this._CenterY);
			this.FKEOGPDLBDD().SetFloat("_Value3", this._AlphaBlur);
			this.HCGJCMDJPGD().SetFloat("_ScreenResolution", this._AlphaBlurInside);
			this.MLMKCOINOOH().SetVector("editor.", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OGMEGHKECAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A5B RID: 6747 RVA: 0x000A4DE0 File Offset: 0x000A2FE0
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1517f)
			{
				this.HBJJOCHGOPH = 792f;
			}
			this.NBPKMLMCHFN.SetFloat("appid", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("_TimeX", this.Size);
			this.CIAFLBFJLEJ().SetFloat("_ExtraColor", this._Radius);
			this.HEINDEMCGIK().SetFloat("_Intensity", this._SpotSize);
			this.EFDEIFCDAFG().SetFloat("_SmoothEnd", this._CenterX);
			this.LONNIJMNKFB().SetFloat("maps.", this._CenterY);
			this.FOOCJIDNGBB().SetFloat("Maps Editor v.", this._AlphaBlur);
			this.OGMEGHKECAH().SetFloat("CameraFilterPack/TV_Tiles", this._AlphaBlurInside);
			this.DEFBJOCJJKF().SetVector("Fade", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A5C RID: 6748 RVA: 0x000A4F1C File Offset: 0x000A311C
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1357f)
			{
				this.HBJJOCHGOPH = 1029f;
			}
			this.CIAFLBFJLEJ().SetFloat("Left Click", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat("GUICamera", this.Size);
			this.HEINDEMCGIK().SetFloat("workshop.", this._Radius);
			this.OGMEGHKECAH().SetFloat("_Near", this._SpotSize);
			this.OIIDAKBILMI().SetFloat("_Distortion", this._CenterX);
			this.DEFBJOCJJKF().SetFloat("CameraFilterPack/FX_Drunk", this._CenterY);
			this.NBPKMLMCHFN.SetFloat("Ok", this._AlphaBlur);
			this.JIBOKBCPDLC().SetFloat("mapselector.filter.favoriteonly", this._AlphaBlurInside);
			this.ADBKPGFMNKO().SetVector("LocalPlayer is null or not in mActors! LocalPlayer: {0} mActors==null: {1} newID: {2}", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FKEOGPDLBDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A5D RID: 6749 RVA: 0x000A5056 File Offset: 0x000A3256
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("[Steamworks.NET] Could not load [lib]steam_api.dll/so/dylib. It's likely not in the correct location. Refer to the README for more details.\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001A5E RID: 6750 RVA: 0x000A507A File Offset: 0x000A327A
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("FavoriteButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001A5F RID: 6751 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x06001A60 RID: 6752 RVA: 0x000A509E File Offset: 0x000A329E
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A61 RID: 6753 RVA: 0x000A311E File Offset: 0x000A131E
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A62 RID: 6754 RVA: 0x000A50D5 File Offset: 0x000A32D5
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A63 RID: 6755 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06001A64 RID: 6756 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06001A65 RID: 6757 RVA: 0x000A510C File Offset: 0x000A330C
	private Material LENEJAGLCNL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A66 RID: 6758 RVA: 0x000A311E File Offset: 0x000A131E
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A67 RID: 6759 RVA: 0x000A5143 File Offset: 0x000A3343
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_Videoflip");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001A68 RID: 6760 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06001A69 RID: 6761 RVA: 0x000A311E File Offset: 0x000A131E
	private void NNPBKKBFDHH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A6A RID: 6762 RVA: 0x000A5167 File Offset: 0x000A3367
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A6B RID: 6763 RVA: 0x000A519E File Offset: 0x000A339E
	private void HIPEHGNBJMN()
	{
		this.SCShader = Shader.Find("BadgeImage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001A6C RID: 6764 RVA: 0x000A51C4 File Offset: 0x000A33C4
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 93f)
			{
				this.HBJJOCHGOPH = 1677f;
			}
			this.HNFFHCLNBDN().SetFloat("Hidden/Image Effects/Cinematic/Bloom", this.HBJJOCHGOPH);
			this.LENEJAGLCNL().SetFloat(".lastCheckpoint.time", this.Size);
			this.CIAFLBFJLEJ().SetFloat("_TimeX", this._Radius);
			this.DEFBJOCJJKF().SetFloat("_TimeX", this._SpotSize);
			this.FOOCJIDNGBB().SetFloat(" (now: ", this._CenterX);
			this.OIIDAKBILMI().SetFloat("_Value4", this._CenterY);
			this.HEINDEMCGIK().SetFloat("_Value2", this._AlphaBlur);
			this.NJDIODJNGGA().SetFloat("_Value", this._AlphaBlurInside);
			this.HHIFMIPPMPF().SetVector("settings.selectormapsperpage", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A6D RID: 6765 RVA: 0x000A52FE File Offset: 0x000A34FE
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001A6E RID: 6766 RVA: 0x000A5324 File Offset: 0x000A3524
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1073f)
			{
				this.HBJJOCHGOPH = 1065f;
			}
			this.LENEJAGLCNL().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.MLMKCOINOOH().SetFloat("s", this.Size);
			this.FOOCJIDNGBB().SetFloat("&", this._Radius);
			this.CIAFLBFJLEJ().SetFloat("_Value4", this._SpotSize);
			this.JIBOKBCPDLC().SetFloat("workshop.", this._CenterX);
			this.OGMEGHKECAH().SetFloat("...", this._CenterY);
			this.AELJLBOJAIL().SetFloat("_Near", this._AlphaBlur);
			this.FOOCJIDNGBB().SetFloat("_Offsets", this._AlphaBlurInside);
			this.HCGJCMDJPGD().SetVector("/icon", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001A6F RID: 6767 RVA: 0x000A311E File Offset: 0x000A131E
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001A70 RID: 6768 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06001A71 RID: 6769 RVA: 0x000A3B42 File Offset: 0x000A1D42
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001A72 RID: 6770 RVA: 0x000A5460 File Offset: 0x000A3660
	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1299f)
			{
				this.HBJJOCHGOPH = 228f;
			}
			this.HNFFHCLNBDN().SetFloat("saveGameName ", this.HBJJOCHGOPH);
			this.FKEOGPDLBDD().SetFloat("yyyy-MM-dd HH:mm:ss", this.Size);
			this.LONNIJMNKFB().SetFloat("player.linea", this._Radius);
			this.MLMKCOINOOH().SetFloat("Unknown player asked for PickupItems", this._SpotSize);
			this.EJDPNJAEAKJ().SetFloat("NEW_ACHIEVEMENT_1_26", this._CenterX);
			this.FOOCJIDNGBB().SetFloat("[ItemsHandler] Found ", this._CenterY);
			this.LENEJAGLCNL().SetFloat("Item ", this._AlphaBlur);
			this.EJDPNJAEAKJ().SetFloat("Oct", this._AlphaBlurInside);
			this.HEINDEMCGIK().SetVector("Editor/", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OIIDAKBILMI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0400039C RID: 924
	public Shader SCShader;

	// Token: 0x0400039D RID: 925
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400039E RID: 926
	[Range(1f, 16f)]
	public float Size = 10f;

	// Token: 0x0400039F RID: 927
	[Range(0f, 1f)]
	public float _Radius = 0.25f;

	// Token: 0x040003A0 RID: 928
	[Range(0f, 4f)]
	public float _SpotSize = 1f;

	// Token: 0x040003A1 RID: 929
	[Range(0f, 1f)]
	public float _CenterX = 0.5f;

	// Token: 0x040003A2 RID: 930
	[Range(0f, 1f)]
	public float _CenterY = 0.5f;

	// Token: 0x040003A3 RID: 931
	[Range(0f, 1f)]
	public float _AlphaBlur = 1f;

	// Token: 0x040003A4 RID: 932
	[Range(0f, 1f)]
	public float _AlphaBlurInside;

	// Token: 0x040003A5 RID: 933
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040003A6 RID: 934
	private Material BJFKDHHMLJH;
}
