using System;
using UnityEngine;

// Token: 0x0200002E RID: 46
[AddComponentMenu("Camera Filter Pack/AAA/Super Computer")]
[ExecuteInEditMode]
public class CameraFilterPack_AAA_SuperComputer : MonoBehaviour
{
	// Token: 0x06000BA6 RID: 2982 RVA: 0x00056D9F File Offset: 0x00054F9F
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BA7 RID: 2983 RVA: 0x00056DD6 File Offset: 0x00054FD6
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("player.licenceaccepted");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000BA8 RID: 2984 RVA: 0x00056DFC File Offset: 0x00054FFC
	private void JKAKHLNPNNP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 1110f;
			if (this.HBJJOCHGOPH > 340f)
			{
				this.HBJJOCHGOPH = 1760f;
			}
			this.PDEAHJPOMEF().SetFloat("_Exposure", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("There are too many cells created by your subdivision options. Maximum allowed number of cells is ", this.ShapeFormula);
			this.HKHBBBFLGJH().SetFloat(" argument(s): ", this.Shape);
			this.NBPKMLMCHFN.SetFloat("Update() was called by Unity. Scene is loaded. Let's connect to the Photon Master Server. Calling: PhotonNetwork.ConnectUsingSettings();", this.center.x);
			this.NBPKMLMCHFN.SetFloat("Cannot remove cached RPCs on a PhotonView thats not ours! ", this.center.y);
			this.KEMJNOMIPHN().SetFloat("null", this.Radius);
			this.CFCPHFMKHII().SetFloat("EventTimeInputField", this._BorderSize);
			this.NBPKMLMCHFN.SetColor("PointerExit ", this._BorderColor);
			this.IGKFMCPDNOI().SetFloat("float", this._AlphaHexa);
			this.EJDPNJAEAKJ().SetFloat("/../", this._SpotSize);
			this.HNICHJCGJOC().SetVector("&page=", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 343f, 753f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BA9 RID: 2985 RVA: 0x00056F79 File Offset: 0x00055179
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("InfoCanvas");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000BAA RID: 2986 RVA: 0x00056F9D File Offset: 0x0005519D
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BAB RID: 2987 RVA: 0x00056FBA File Offset: 0x000551BA
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("22x3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06000BAC RID: 2988 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06000BAD RID: 2989 RVA: 0x00056FDE File Offset: 0x000551DE
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BAE RID: 2990 RVA: 0x00056F9D File Offset: 0x0005519D
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BAF RID: 2991 RVA: 0x00057018 File Offset: 0x00055218
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 1823f;
			if (this.HBJJOCHGOPH > 6f)
			{
				this.HBJJOCHGOPH = 1669f;
			}
			this.NFMGLIKNOOC().SetFloat("table", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("RecordButton", this.ShapeFormula);
			this.ABHDNGIHBKE().SetFloat("-1", this.Shape);
			this.GJHLADDCMFF().SetFloat(") of this PhotonView does not implement OnPhotonSerializeView()!", this.center.x);
			this.HNICHJCGJOC().SetFloat("MultiplayerButton", this.center.y);
			this.CFCPHFMKHII().SetFloat("_TimeX", this.Radius);
			this.ABHDNGIHBKE().SetFloat("[LocalizationService] Loading file: ", this._BorderSize);
			this.OGMEGHKECAH().SetColor("Joined room ", this._BorderColor);
			this.HKHBBBFLGJH().SetFloat("_Green_C", this._AlphaHexa);
			this.DOHGBNPMBKG().SetFloat("_Screen", this._SpotSize);
			this.NBPKMLMCHFN.SetVector("_DiffuseColor", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1129f, 209f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PDEAHJPOMEF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BB0 RID: 2992 RVA: 0x00057198 File Offset: 0x00055398
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 765f;
			if (this.HBJJOCHGOPH > 140f)
			{
				this.HBJJOCHGOPH = 46f;
			}
			this.NFMGLIKNOOC().SetFloat("Committing changes...", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("SetSunEmission", this.ShapeFormula);
			this.HHIAIGCAHDA().SetFloat("Source: ", this.Shape);
			this.OGMEGHKECAH().SetFloat("0.00", this.center.x);
			this.HKHBBBFLGJH().SetFloat("_Distortion", this.center.y);
			this.HKHBBBFLGJH().SetFloat("UseScanLine", this.Radius);
			this.CFCPHFMKHII().SetFloat("Joystick1Button4", this._BorderSize);
			this.EJDPNJAEAKJ().SetColor("<b>", this._BorderColor);
			this.HHIAIGCAHDA().SetFloat("_TimeX", this._AlphaHexa);
			this.NBPKMLMCHFN.SetFloat("getfloat", this._SpotSize);
			this.DOHGBNPMBKG().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 553f, 134f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BB1 RID: 2993 RVA: 0x00057318 File Offset: 0x00055518
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 4f;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.ShapeFormula);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Shape);
			this.NBPKMLMCHFN.SetFloat("_PositionX", this.center.x);
			this.NBPKMLMCHFN.SetFloat("_PositionY", this.center.y);
			this.NBPKMLMCHFN.SetFloat("_Radius", this.Radius);
			this.NBPKMLMCHFN.SetFloat("_BorderSize", this._BorderSize);
			this.NBPKMLMCHFN.SetColor("_BorderColor", this._BorderColor);
			this.NBPKMLMCHFN.SetFloat("_AlphaHexa", this._AlphaHexa);
			this.NBPKMLMCHFN.SetFloat("_SpotSize", this._SpotSize);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BB2 RID: 2994 RVA: 0x00056F9D File Offset: 0x0005519D
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BB3 RID: 2995 RVA: 0x00057495 File Offset: 0x00055695
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)118;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BB4 RID: 2996 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06000BB5 RID: 2997 RVA: 0x000574CC File Offset: 0x000556CC
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BB6 RID: 2998 RVA: 0x00057503 File Offset: 0x00055703
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("[ResourcesManager] Load image error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000BB7 RID: 2999 RVA: 0x00057527 File Offset: 0x00055727
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BB8 RID: 3000 RVA: 0x0005755E File Offset: 0x0005575E
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000BB9 RID: 3001 RVA: 0x00057584 File Offset: 0x00055784
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 138f;
			if (this.HBJJOCHGOPH > 721f)
			{
				this.HBJJOCHGOPH = 836f;
			}
			this.EJDPNJAEAKJ().SetFloat("PUNCloudBestRegion", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("settings.showHP", this.ShapeFormula);
			this.OGMEGHKECAH().SetFloat("_TileTexDebug", this.Shape);
			this.DOHGBNPMBKG().SetFloat("[PlayerBase] Loaded custom model: ", this.center.x);
			this.HKHBBBFLGJH().SetFloat("appid", this.center.y);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Blend2Camera_DarkerColor", this.Radius);
			this.KEMJNOMIPHN().SetFloat("ItemsCountText", this._BorderSize);
			this.ABHDNGIHBKE().SetColor("Set Particles Count Per Beat", this._BorderColor);
			this.HKHBBBFLGJH().SetFloat("ConfigVersionSlider", this._AlphaHexa);
			this.PDEAHJPOMEF().SetFloat("_History1ChromaTex", this._SpotSize);
			this.IGKFMCPDNOI().SetVector("Can't connect: ServerSettings asset must be in any 'Resources' folder as: PhotonServerSettings", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1731f, 451f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BBA RID: 3002 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x06000BBB RID: 3003 RVA: 0x00057704 File Offset: 0x00055904
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 1243f;
			if (this.HBJJOCHGOPH > 154f)
			{
				this.HBJJOCHGOPH = 1305f;
			}
			this.OGMEGHKECAH().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.IGKFMCPDNOI().SetFloat("#changenote", this.ShapeFormula);
			this.EFDEIFCDAFG().SetFloat("SpectatingUserInfo", this.Shape);
			this.OGMEGHKECAH().SetFloat("BitsData", this.center.x);
			this.CFCPHFMKHII().SetFloat("_Speed", this.center.y);
			this.KEMJNOMIPHN().SetFloat("_Value", this.Radius);
			this.KEMJNOMIPHN().SetFloat("_ScreenResolution", this._BorderSize);
			this.EJDPNJAEAKJ().SetColor("CameraFilterPack/FX_8bits", this._BorderColor);
			this.DOHGBNPMBKG().SetFloat("{0:0}", this._AlphaHexa);
			this.ABHDNGIHBKE().SetFloat("win", this._SpotSize);
			this.ABHDNGIHBKE().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1572f, 1466f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BBC RID: 3004 RVA: 0x00057881 File Offset: 0x00055A81
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("itemdefid[0]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000BBD RID: 3005 RVA: 0x000578A5 File Offset: 0x00055AA5
	private Material CFCPHFMKHII()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BBE RID: 3006 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06000BBF RID: 3007 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06000BC0 RID: 3008 RVA: 0x00056F9D File Offset: 0x0005519D
	private void GKNKIIEALCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BC1 RID: 3009 RVA: 0x000578DC File Offset: 0x00055ADC
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-115);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BC2 RID: 3010 RVA: 0x00057914 File Offset: 0x00055B14
	private void JCCIKBBEMEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 1803f;
			if (this.HBJJOCHGOPH > 435f)
			{
				this.HBJJOCHGOPH = 77f;
			}
			this.OGMEGHKECAH().SetFloat("FPSToggle", this.HBJJOCHGOPH);
			this.HHIAIGCAHDA().SetFloat(": ", this.ShapeFormula);
			this.EJDPNJAEAKJ().SetFloat("LevelURLInputField", this.Shape);
			this.CFCPHFMKHII().SetFloat("Object ID. Case-Sensitive", this.center.x);
			this.PDEAHJPOMEF().SetFloat("Finished", this.center.y);
			this.HHIAIGCAHDA().SetFloat("GhostPosY", this.Radius);
			this.NBPKMLMCHFN.SetFloat("[Right-Down-Left]", this._BorderSize);
			this.CFCPHFMKHII().SetColor("EnvironmentSlider", this._BorderColor);
			this.CFCPHFMKHII().SetFloat(":\n", this._AlphaHexa);
			this.PDEAHJPOMEF().SetFloat("_TimeX", this._SpotSize);
			this.HKHBBBFLGJH().SetVector("/", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 191f, 1113f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BC3 RID: 3011 RVA: 0x00057A91 File Offset: 0x00055C91
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("settings.enablehitsoundsinrelax");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000BC4 RID: 3012 RVA: 0x00056F9D File Offset: 0x0005519D
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BC5 RID: 3013 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBCNIPJDPJB()
	{
	}

	// Token: 0x06000BC6 RID: 3014 RVA: 0x0002523B File Offset: 0x0002343B
	private void IIFCIDDJHPM()
	{
	}

	// Token: 0x06000BC7 RID: 3015 RVA: 0x00056F9D File Offset: 0x0005519D
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BC8 RID: 3016 RVA: 0x00056F9D File Offset: 0x0005519D
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BC9 RID: 3017 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06000BCA RID: 3018 RVA: 0x00057AB5 File Offset: 0x00055CB5
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BCB RID: 3019 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06000BCC RID: 3020 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06000BCD RID: 3021 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06000BCE RID: 3022 RVA: 0x00057AEC File Offset: 0x00055CEC
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BCF RID: 3023 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06000BD0 RID: 3024 RVA: 0x00057B24 File Offset: 0x00055D24
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 627f;
			if (this.HBJJOCHGOPH > 377f)
			{
				this.HBJJOCHGOPH = 553f;
			}
			this.ABHDNGIHBKE().SetFloat("CameraFilterPack/FX_Dot_Circle", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("Start index must in an integer.", this.ShapeFormula);
			this.NFMGLIKNOOC().SetFloat("Children", this.Shape);
			this.HHIAIGCAHDA().SetFloat("_Value2", this.center.x);
			this.GJHLADDCMFF().SetFloat("menuthemes", this.center.y);
			this.OGMEGHKECAH().SetFloat("_FixDistance", this.Radius);
			this.OGMEGHKECAH().SetFloat("0.00", this._BorderSize);
			this.CFCPHFMKHII().SetColor("[#clicktogetreward]", this._BorderColor);
			this.HNICHJCGJOC().SetFloat("_copy", this._AlphaHexa);
			this.PDEAHJPOMEF().SetFloat("hitsounds:", this._SpotSize);
			this.NBPKMLMCHFN.SetVector(".completedMaps", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 307f, 1002f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BD1 RID: 3025 RVA: 0x00057CA1 File Offset: 0x00055EA1
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("CreateRoom failed. Client is not on Master Server or not yet ready to call operations. Wait for callback: OnJoinedLobby or OnConnectedToMaster.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000BD2 RID: 3026 RVA: 0x00057CC8 File Offset: 0x00055EC8
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 22f;
			if (this.HBJJOCHGOPH > 179f)
			{
				this.HBJJOCHGOPH = 685f;
			}
			this.HNICHJCGJOC().SetFloat("[MenuScene] Error: ", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("https://www.youtube.com/watch?v=cDVXukrKo74", this.ShapeFormula);
			this.ABHDNGIHBKE().SetFloat("[RanksSystem] Ranks: no need to update", this.Shape);
			this.HNICHJCGJOC().SetFloat("Set satellite trail width", this.center.x);
			this.EFDEIFCDAFG().SetFloat("PRESS A KEY", this.center.y);
			this.HHIAIGCAHDA().SetFloat("x", this.Radius);
			this.HHIAIGCAHDA().SetFloat("_TimeX", this._BorderSize);
			this.IGKFMCPDNOI().SetColor("_TexelOffsetScale", this._BorderColor);
			this.EFDEIFCDAFG().SetFloat("#onrankchangedowntext", this._AlphaHexa);
			this.KEMJNOMIPHN().SetFloat("CameraFilterPack_OldFilm2", this._SpotSize);
			this.NFMGLIKNOOC().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 437f, 1077f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BD3 RID: 3027 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06000BD4 RID: 3028 RVA: 0x00057E48 File Offset: 0x00056048
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 1360f;
			if (this.HBJJOCHGOPH > 433f)
			{
				this.HBJJOCHGOPH = 1475f;
			}
			this.IGKFMCPDNOI().SetFloat(" not exist", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("#no", this.ShapeFormula);
			this.GJHLADDCMFF().SetFloat("CameraFilterPack_AAA_Blood_Hit1", this.Shape);
			this.NFMGLIKNOOC().SetFloat("_Value4", this.center.x);
			this.GJHLADDCMFF().SetFloat("materialsquantity[", this.center.y);
			this.IGKFMCPDNOI().SetFloat("InfoText", this.Radius);
			this.HNICHJCGJOC().SetFloat("Reconnect() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", this._BorderSize);
			this.HNICHJCGJOC().SetColor(". The group number should be at least 1.", this._BorderColor);
			this.NFMGLIKNOOC().SetFloat("Items/", this._AlphaHexa);
			this.CFCPHFMKHII().SetFloat("AvatarImage", this._SpotSize);
			this.KEMJNOMIPHN().SetVector("(\\[ */ *quote *\\])", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1577f, 1309f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BD5 RID: 3029 RVA: 0x00057FC8 File Offset: 0x000561C8
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 1432f;
			if (this.HBJJOCHGOPH > 1637f)
			{
				this.HBJJOCHGOPH = 682f;
			}
			this.NFMGLIKNOOC().SetFloat("_Speed", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("</color>", this.ShapeFormula);
			this.HHIAIGCAHDA().SetFloat("CameraFilterPack/Blend2Camera_HardLight", this.Shape);
			this.EFDEIFCDAFG().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", this.center.x);
			this.OGMEGHKECAH().SetFloat("ViewMenu", this.center.y);
			this.PDEAHJPOMEF().SetFloat("Chat", this.Radius);
			this.ABHDNGIHBKE().SetFloat("SelectorMapsCountSlider", this._BorderSize);
			this.IGKFMCPDNOI().SetColor("\n", this._BorderColor);
			this.OGMEGHKECAH().SetFloat("Hidden/Subpixel Morphological Anti-aliasing", this._AlphaHexa);
			this.EJDPNJAEAKJ().SetFloat("There was an error retrieving the NumberOfCurrentPlayers.", this._SpotSize);
			this.IGKFMCPDNOI().SetVector("CameraFilterPack/AAA_Blood_Plus", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 85f, 166f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMJNOMIPHN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BD6 RID: 3030 RVA: 0x00058145 File Offset: 0x00056345
	private Material IGKFMCPDNOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BD7 RID: 3031 RVA: 0x0005817C File Offset: 0x0005637C
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 1658f;
			if (this.HBJJOCHGOPH > 1639f)
			{
				this.HBJJOCHGOPH = 1615f;
			}
			this.HKHBBBFLGJH().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.HKHBBBFLGJH().SetFloat("EventConfigButton", this.ShapeFormula);
			this.PDEAHJPOMEF().SetFloat("ScrollPanel", this.Shape);
			this.OGMEGHKECAH().SetFloat("_Intensity", this.center.x);
			this.HKHBBBFLGJH().SetFloat("OPEN", this.center.y);
			this.HKHBBBFLGJH().SetFloat("_Noise", this.Radius);
			this.IGKFMCPDNOI().SetFloat("_Value2", this._BorderSize);
			this.IGKFMCPDNOI().SetColor("<color=#", this._BorderColor);
			this.EJDPNJAEAKJ().SetFloat("MenuScene", this._AlphaHexa);
			this.ABHDNGIHBKE().SetFloat("[MapsStats] Max score: ", this._SpotSize);
			this.EJDPNJAEAKJ().SetVector("CameraFilterPack/TV_Video3D", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1777f, 652f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFCPHFMKHII());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BD8 RID: 3032 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06000BD9 RID: 3033 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06000BDA RID: 3034 RVA: 0x000582F9 File Offset: 0x000564F9
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BDB RID: 3035 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x06000BDC RID: 3036 RVA: 0x00058330 File Offset: 0x00056530
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-119);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BDD RID: 3037 RVA: 0x00058368 File Offset: 0x00056568
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 1525f;
			if (this.HBJJOCHGOPH > 269f)
			{
				this.HBJJOCHGOPH = 601f;
			}
			this.HKHBBBFLGJH().SetFloat("Solo", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("ready", this.ShapeFormula);
			this.EJDPNJAEAKJ().SetFloat("settings_bindings_controller_type", this.Shape);
			this.IGKFMCPDNOI().SetFloat("roomDescription", this.center.x);
			this.IGKFMCPDNOI().SetFloat("_BloomIntensity", this.center.y);
			this.OGMEGHKECAH().SetFloat("player.licenceaccepted", this.Radius);
			this.ABHDNGIHBKE().SetFloat("_ColorBuffer", this._BorderSize);
			this.NBPKMLMCHFN.SetColor("GUICamera", this._BorderColor);
			this.NFMGLIKNOOC().SetFloat("move", this._AlphaHexa);
			this.PDEAHJPOMEF().SetFloat(".lastCheckpoint.powerupsScore", this._SpotSize);
			this.EJDPNJAEAKJ().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1466f, 1663f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BDE RID: 3038 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06000BDF RID: 3039 RVA: 0x00056F9D File Offset: 0x0005519D
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BE0 RID: 3040 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06000BE1 RID: 3041 RVA: 0x000584E8 File Offset: 0x000566E8
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime / 955f;
			if (this.HBJJOCHGOPH > 45f)
			{
				this.HBJJOCHGOPH = 710f;
			}
			this.EFDEIFCDAFG().SetFloat("_Size", this.HBJJOCHGOPH);
			this.HHIAIGCAHDA().SetFloat("UpperMid", this.ShapeFormula);
			this.EFDEIFCDAFG().SetFloat("_Near", this.Shape);
			this.ABHDNGIHBKE().SetFloat("SaveButton", this.center.x);
			this.NBPKMLMCHFN.SetFloat("{0:0.0} ms ({1:0.} fps)", this.center.y);
			this.CFCPHFMKHII().SetFloat("Speed", this.Radius);
			this.IGKFMCPDNOI().SetFloat("Failed to 'network-remove' GameObject. Client is neither owner nor masterClient taking over for owner who left: ", this._BorderSize);
			this.HNICHJCGJOC().SetColor("settings.fps", this._BorderColor);
			this.CFCPHFMKHII().SetFloat("_dec.json", this._AlphaHexa);
			this.PDEAHJPOMEF().SetFloat("_TimeX", this._SpotSize);
			this.PDEAHJPOMEF().SetVector("PointsScoreText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1333f, 293f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06000BE2 RID: 3042 RVA: 0x00056F9D File Offset: 0x0005519D
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BE3 RID: 3043 RVA: 0x00058665 File Offset: 0x00056865
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-65);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BE4 RID: 3044 RVA: 0x0005869C File Offset: 0x0005689C
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("_ColoredChange");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06000BE5 RID: 3045 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x06000BE6 RID: 3046 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06000BE7 RID: 3047 RVA: 0x000586C0 File Offset: 0x000568C0
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06000BE8 RID: 3048 RVA: 0x00056F9D File Offset: 0x0005519D
	private void IMGGCJICLHK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06000BEA RID: 3050 RVA: 0x00056F9D File Offset: 0x0005519D
	private void DPFOEBCADNP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x17000015 RID: 21
	// (get) Token: 0x06000BEB RID: 3051 RVA: 0x0005878C File Offset: 0x0005698C
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

	// Token: 0x06000BEC RID: 3052 RVA: 0x000587C3 File Offset: 0x000569C3
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/AAA_Super_Computer");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x040001C2 RID: 450
	public Shader SCShader;

	// Token: 0x040001C3 RID: 451
	[Range(0f, 1f)]
	public float _AlphaHexa = 1f;

	// Token: 0x040001C4 RID: 452
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040001C5 RID: 453
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040001C6 RID: 454
	private Material BJFKDHHMLJH;

	// Token: 0x040001C7 RID: 455
	[Range(-20f, 20f)]
	public float ShapeFormula = 10f;

	// Token: 0x040001C8 RID: 456
	[Range(0f, 6f)]
	public float Shape = 1f;

	// Token: 0x040001C9 RID: 457
	[Range(-4f, 4f)]
	public float _BorderSize = 1f;

	// Token: 0x040001CA RID: 458
	public Color _BorderColor = new Color(0f, 0.2f, 1f, 1f);

	// Token: 0x040001CB RID: 459
	public float _SpotSize = 2.5f;

	// Token: 0x040001CC RID: 460
	public Vector2 center = new Vector2(0f, 0f);

	// Token: 0x040001CD RID: 461
	public float Radius = 0.77f;
}
