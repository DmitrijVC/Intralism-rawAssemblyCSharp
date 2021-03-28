using System;
using UnityEngine;

// Token: 0x02000057 RID: 87
[AddComponentMenu("Camera Filter Pack/Split Screen/Split 3D")]
[ExecuteInEditMode]
public class CameraFilterPack_Blend2Camera_SplitScreen3D : MonoBehaviour
{
	// Token: 0x06001830 RID: 6192 RVA: 0x0009B73A File Offset: 0x0009993A
	private void GNPDGBNDCPL()
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

	// Token: 0x06001831 RID: 6193 RVA: 0x0009B774 File Offset: 0x00099974
	private void MKKJICPMPHK()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001832 RID: 6194 RVA: 0x0009B774 File Offset: 0x00099974
	private void ABKHEFGLAOJ()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001833 RID: 6195 RVA: 0x0009B73A File Offset: 0x0009993A
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

	// Token: 0x06001834 RID: 6196 RVA: 0x0009B798 File Offset: 0x00099998
	private void OnEnable()
	{
		this.Start();
	}

	// Token: 0x06001835 RID: 6197 RVA: 0x0009B73A File Offset: 0x0009993A
	private void JNALDALAJLG()
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

	// Token: 0x06001836 RID: 6198 RVA: 0x0009B7A0 File Offset: 0x000999A0
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 202f)
			{
				this.HBJJOCHGOPH = 704f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("player.xp", this.JDMCFBKJHDD);
			}
			this.ABHDNGIHBKE().SetFloat("_Visualize", this._Distance);
			this.NMDBCDFPGOK().SetFloat("maps.", this._Size);
			this.ADBKPGFMNKO().SetFloat("OK", this._FixDistance);
			this.LNLKMDPHDCC().SetFloat("BitsData", this.HBJJOCHGOPH);
			this.LNLKMDPHDCC().SetFloat("_GrainOffsetScale", this.BlendFX);
			this.LPMLLJKMAMP().SetFloat("settings.enablehitsoundsinnormal", this.SwitchCameraToCamera2);
			this.NMDBCDFPGOK().SetFloat("rarity", this.SplitX);
			this.KDMBOKLMADJ().SetFloat("CameraFilterPack/Color_Convert_Normal", this.SplitY);
			this.FLGPDBBKAIP().SetFloat("DisableStoryboardToggle", this.Smooth);
			this.ADBKPGFMNKO().SetFloat("#pleasewait", this.Rotation);
			this.HKHBBBFLGJH().SetInt("MaxLivesSlider", (!this.CONEELGCALI) ? 0 : 0);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HJGEHJDMCGI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001837 RID: 6199 RVA: 0x0009B938 File Offset: 0x00099B38
	private void EGEPLFGKGLI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 79);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001838 RID: 6200 RVA: 0x0009B9B0 File Offset: 0x00099BB0
	private void DFFKKLAPHCC()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 79);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001839 RID: 6201 RVA: 0x0009B774 File Offset: 0x00099974
	private void EGEGNHLODAA()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x0600183A RID: 6202 RVA: 0x0009BA28 File Offset: 0x00099C28
	private void BEKMLIFILFP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 70);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600183B RID: 6203 RVA: 0x0009B774 File Offset: 0x00099974
	private void OnValidate()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x0600183C RID: 6204 RVA: 0x0009B798 File Offset: 0x00099998
	private void AENIGCONKBD()
	{
		this.Start();
	}

	// Token: 0x0600183D RID: 6205 RVA: 0x0009BA9F File Offset: 0x00099C9F
	private void FLHBCHLMOFK()
	{
		this.KOFAMEKHHGD();
	}

	// Token: 0x0600183E RID: 6206 RVA: 0x0009B774 File Offset: 0x00099974
	private void DBGBCCBHBBC()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x0600183F RID: 6207 RVA: 0x0009B798 File Offset: 0x00099998
	private void PMAADPNNHKK()
	{
		this.Start();
	}

	// Token: 0x06001840 RID: 6208 RVA: 0x0009BAA7 File Offset: 0x00099CA7
	private Material HJGEHJDMCGI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001841 RID: 6209 RVA: 0x0009B774 File Offset: 0x00099974
	private void IKIDIJLIGOH()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001842 RID: 6210 RVA: 0x0009B774 File Offset: 0x00099974
	private void LDDKCCMHMIC()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001843 RID: 6211 RVA: 0x0009BADE File Offset: 0x00099CDE
	private void MEJPBKFMAIG()
	{
		this.EGEPLFGKGLI();
	}

	// Token: 0x06001844 RID: 6212 RVA: 0x0009B73A File Offset: 0x0009993A
	private void ICDBMJKMIKC()
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

	// Token: 0x06001845 RID: 6213 RVA: 0x0009B73A File Offset: 0x0009993A
	private void CNPINCHINJA()
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

	// Token: 0x06001846 RID: 6214 RVA: 0x0009BAE8 File Offset: 0x00099CE8
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1315f)
			{
				this.HBJJOCHGOPH = 1503f;
			}
			if (this.Camera2 != null)
			{
				this.HFBJAOFLCJI().SetTexture("_Threshhold", this.JDMCFBKJHDD);
			}
			this.GCDFNHMJMIP().SetFloat("_Intervale", this._Distance);
			this.NKBIEMJBCBM().SetFloat("CameraFilterPack/Drawing_Manga3", this._Size);
			this.MCDGIILBNIF().SetFloat("Connection error: ", this._FixDistance);
			this.OOMFJGPAOKL().SetFloat("b", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("<color=#", this.BlendFX);
			this.KAFBNOBOIAJ().SetFloat("clear", this.SwitchCameraToCamera2);
			this.NMDBCDFPGOK().SetFloat("GameMessagesDurationSlider", this.SplitX);
			this.ECCPAOBFDKP().SetFloat("SetEnvSpriteImage", this.SplitY);
			this.NMDBCDFPGOK().SetFloat("LevelNameInputField", this.Smooth);
			this.HKHBBBFLGJH().SetFloat("note.1", this.Rotation);
			this.HJGEHJDMCGI().SetInt("BitsData", (!this.CONEELGCALI) ? 1 : 0);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001847 RID: 6215 RVA: 0x0009B73A File Offset: 0x0009993A
	private void BAEHKBADMAO()
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

	// Token: 0x06001848 RID: 6216 RVA: 0x0009BC7D File Offset: 0x00099E7D
	private void IBEAPBDAOCC()
	{
		this.NEFHGMNAPEP();
	}

	// Token: 0x06001849 RID: 6217 RVA: 0x0009B73A File Offset: 0x0009993A
	private void CAKNMILHHNE()
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

	// Token: 0x0600184A RID: 6218 RVA: 0x0009B774 File Offset: 0x00099974
	private void Update()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x0600184B RID: 6219 RVA: 0x0009B774 File Offset: 0x00099974
	private void GFACKFCEIBC()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x0600184C RID: 6220 RVA: 0x0009BC88 File Offset: 0x00099E88
	private void ANBIJFCCANE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1273f)
			{
				this.HBJJOCHGOPH = 1390f;
			}
			if (this.Camera2 != null)
			{
				this.LPDOGGFOBDH().SetTexture("Stream did not contain properly formatted byte array", this.JDMCFBKJHDD);
			}
			this.FLGPDBBKAIP().SetFloat("High", this._Distance);
			this.EFDEIFCDAFG().SetFloat("_DepthLevel", this._Size);
			this.OOMFJGPAOKL().SetFloat("GridDataArcs", this._FixDistance);
			this.LNLKMDPHDCC().SetFloat("Edited hands count", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("_FixDistance", this.BlendFX);
			this.KDMBOKLMADJ().SetFloat("roomDescription", this.SwitchCameraToCamera2);
			this.MCDGIILBNIF().SetFloat("Cant send PickupItem spawn times to unknown targetPlayer.", this.SplitX);
			this.KAFBNOBOIAJ().SetFloat("_VignettingDirt", this.SplitY);
			this.HJGEHJDMCGI().SetFloat("default", this.Smooth);
			this.HJGEHJDMCGI().SetFloat("Tab2Content", this.Rotation);
			this.ABHDNGIHBKE().SetInt("SetSunSensitivity", (!this.CONEELGCALI) ? 1 : 0);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600184D RID: 6221 RVA: 0x0009B774 File Offset: 0x00099974
	private void HDDECCMEJKA()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x0600184E RID: 6222 RVA: 0x0009BE1D File Offset: 0x0009A01D
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600184F RID: 6223 RVA: 0x0009BE54 File Offset: 0x0009A054
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001850 RID: 6224 RVA: 0x0009B774 File Offset: 0x00099974
	private void KMEONPMCNJG()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001851 RID: 6225 RVA: 0x0009BE8B File Offset: 0x0009A08B
	private void OOBIMFILNED()
	{
		this.AGEJKLMJGDO();
	}

	// Token: 0x06001852 RID: 6226 RVA: 0x0009BE94 File Offset: 0x0009A094
	private void OCNIANNJIPP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 820f)
			{
				this.HBJJOCHGOPH = 1714f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("SupportLogger OnDisconnectedFromPhoton().", this.JDMCFBKJHDD);
			}
			this.KGOLDDBHIFN().SetFloat("_CenterY", this._Distance);
			this.GCDFNHMJMIP().SetFloat("_Value2", this._Size);
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack/Distortion_Heat", this._FixDistance);
			this.FLGPDBBKAIP().SetFloat("id", this.HBJJOCHGOPH);
			this.FLGPDBBKAIP().SetFloat("accuracy", this.BlendFX);
			this.ADBKPGFMNKO().SetFloat("<b>", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetFloat("_InvRenderTargetSize", this.SplitX);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.SplitY);
			this.NKBIEMJBCBM().SetFloat("#exit", this.Smooth);
			this.CBCNOEIALHB().SetFloat("GameMessagesDurationSlider", this.Rotation);
			this.ADBKPGFMNKO().SetInt(" canvas not found", (!this.CONEELGCALI) ? 0 : 1);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001853 RID: 6227 RVA: 0x0009B774 File Offset: 0x00099974
	private void LCDJFJIBADI()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001854 RID: 6228 RVA: 0x0009C02C File Offset: 0x0009A22C
	private void NJFDLOBJCCF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1218f)
			{
				this.HBJJOCHGOPH = 292f;
			}
			if (this.Camera2 != null)
			{
				this.OOMFJGPAOKL().SetTexture("_FarCamera", this.JDMCFBKJHDD);
			}
			this.HKHBBBFLGJH().SetFloat("Can't find key ", this._Distance);
			this.AELJLBOJAIL().SetFloat("CameraFilterPack/TV_BrokenGlass2", this._Size);
			this.PDEAHJPOMEF().SetFloat("maps.", this._FixDistance);
			this.ECCPAOBFDKP().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.OOMFJGPAOKL().SetFloat("_Value2", this.BlendFX);
			this.ACHNOHCLGOO().SetFloat("Horizontal", this.SwitchCameraToCamera2);
			this.ACHNOHCLGOO().SetFloat("SetSunColors", this.SplitX);
			this.AELJLBOJAIL().SetFloat("0", this.SplitY);
			this.LPDOGGFOBDH().SetFloat("_ScreenResolution", this.Smooth);
			this.NMDBCDFPGOK().SetFloat("Jan", this.Rotation);
			this.KAFBNOBOIAJ().SetInt("_Distortion", (!this.CONEELGCALI) ? 1 : 1);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001855 RID: 6229 RVA: 0x0009B774 File Offset: 0x00099974
	private void LPMINJJPDCH()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001856 RID: 6230 RVA: 0x0009B73A File Offset: 0x0009993A
	private void FODKODGPPDA()
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

	// Token: 0x06001857 RID: 6231 RVA: 0x0009C1C1 File Offset: 0x0009A3C1
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-127);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001858 RID: 6232 RVA: 0x0009B774 File Offset: 0x00099974
	private void PNLKFANNOKO()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001859 RID: 6233 RVA: 0x0009C1F8 File Offset: 0x0009A3F8
	private Material NKBIEMJBCBM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-109);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600185A RID: 6234 RVA: 0x0009BC7D File Offset: 0x00099E7D
	private void AENGMPAMCFL()
	{
		this.NEFHGMNAPEP();
	}

	// Token: 0x0600185B RID: 6235 RVA: 0x0009B73A File Offset: 0x0009993A
	private void JOONHGHGKKF()
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

	// Token: 0x0600185C RID: 6236 RVA: 0x0009B73A File Offset: 0x0009993A
	private void BNEJMABFKJE()
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

	// Token: 0x0600185D RID: 6237 RVA: 0x0009BAA7 File Offset: 0x00099CA7
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600185E RID: 6238 RVA: 0x0009B73A File Offset: 0x0009993A
	private void OHIJGCLBMJL()
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

	// Token: 0x0600185F RID: 6239 RVA: 0x0009B774 File Offset: 0x00099974
	private void KCDOMIJBFLL()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001860 RID: 6240 RVA: 0x0009C22F File Offset: 0x0009A42F
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001861 RID: 6241 RVA: 0x0009C266 File Offset: 0x0009A466
	private void KGHFKHBPHEH()
	{
		this.JFJLGJEPEAA();
	}

	// Token: 0x06001862 RID: 6242 RVA: 0x0009B774 File Offset: 0x00099974
	private void LGJAHGCLMLE()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001863 RID: 6243 RVA: 0x0009B73A File Offset: 0x0009993A
	private void BKGJOECFMID()
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

	// Token: 0x06001864 RID: 6244 RVA: 0x0009B73A File Offset: 0x0009993A
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

	// Token: 0x06001865 RID: 6245 RVA: 0x0009B774 File Offset: 0x00099974
	private void ONKDMMJPEMN()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001866 RID: 6246 RVA: 0x0009C26E File Offset: 0x0009A46E
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)97;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001867 RID: 6247 RVA: 0x0009B774 File Offset: 0x00099974
	private void IKMELABKBHO()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001868 RID: 6248 RVA: 0x0009B73A File Offset: 0x0009993A
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

	// Token: 0x06001869 RID: 6249 RVA: 0x0009C2A8 File Offset: 0x0009A4A8
	private void GOANCMNGDLE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 435f)
			{
				this.HBJJOCHGOPH = 366f;
			}
			if (this.Camera2 != null)
			{
				this.LPDOGGFOBDH().SetTexture("_LightIntensity", this.JDMCFBKJHDD);
			}
			this.MCDGIILBNIF().SetFloat("_ColorLevel", this._Distance);
			this.LNLKMDPHDCC().SetFloat("USE_DIAG_SEARCH", this._Size);
			this.NMDBCDFPGOK().SetFloat("Image", this._FixDistance);
			this.OOMFJGPAOKL().SetFloat("_Value7", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("speed", this.BlendFX);
			this.NMDBCDFPGOK().SetFloat("_TimeX", this.SwitchCameraToCamera2);
			this.ECCPAOBFDKP().SetFloat("float", this.SplitX);
			this.CBCNOEIALHB().SetFloat("CameraFilterPack/Blend2Camera_VividLight", this.SplitY);
			this.DOMEEFLPEPJ().SetFloat("Item invalid. Make sure your mod contains at leats one file.", this.Smooth);
			this.ACHNOHCLGOO().SetFloat("_Offsets", this.Rotation);
			this.KDMBOKLMADJ().SetInt(".a", (!this.CONEELGCALI) ? 1 : 0);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600186A RID: 6250 RVA: 0x0009BA9F File Offset: 0x00099C9F
	private void EBBOJPEPDCN()
	{
		this.KOFAMEKHHGD();
	}

	// Token: 0x0600186B RID: 6251 RVA: 0x0009C43D File Offset: 0x0009A63D
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600186C RID: 6252 RVA: 0x0009BC7D File Offset: 0x00099E7D
	private void DPGHJILBPCE()
	{
		this.NEFHGMNAPEP();
	}

	// Token: 0x1700003D RID: 61
	// (get) Token: 0x0600186D RID: 6253 RVA: 0x0009C474 File Offset: 0x0009A674
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

	// Token: 0x0600186E RID: 6254 RVA: 0x0009C4AC File Offset: 0x0009A6AC
	private void DBLILJGKGHJ()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 125);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600186F RID: 6255 RVA: 0x0009C266 File Offset: 0x0009A466
	private void OAKONCDEPPI()
	{
		this.JFJLGJEPEAA();
	}

	// Token: 0x06001870 RID: 6256 RVA: 0x0009C523 File Offset: 0x0009A723
	private void CPMAAHPLGOP()
	{
		this.BMIOFJFMCBG();
	}

	// Token: 0x06001871 RID: 6257 RVA: 0x0009B774 File Offset: 0x00099974
	private void OEAMLMGNFFC()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001872 RID: 6258 RVA: 0x0009C52C File Offset: 0x0009A72C
	private void KOFAMEKHHGD()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 53);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001873 RID: 6259 RVA: 0x0009C5A4 File Offset: 0x0009A7A4
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 975f)
			{
				this.HBJJOCHGOPH = 104f;
			}
			if (this.Camera2 != null)
			{
				this.NBPKMLMCHFN.SetTexture("_FarCamera", this.JDMCFBKJHDD);
			}
			this.EFDEIFCDAFG().SetFloat("menu.tabid", this._Distance);
			this.HKHBBBFLGJH().SetFloat("You need to have a Graphic control (such as an Image) for the list [", this._Size);
			this.ADBKPGFMNKO().SetFloat("BlockCount", this._FixDistance);
			this.NMDBCDFPGOK().SetFloat("_Value", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("achievements.21.completed.workshop.", this.BlendFX);
			this.NMDBCDFPGOK().SetFloat("settings.customdataskin", this.SwitchCameraToCamera2);
			this.LPMLLJKMAMP().SetFloat("float,50", this.SplitX);
			this.EFDEIFCDAFG().SetFloat("bans.viewed.", this.SplitY);
			this.ADBKPGFMNKO().SetFloat("Object ID. Case-Sensitive", this.Smooth);
			this.DOMEEFLPEPJ().SetFloat("_ExposureAdjustment", this.Rotation);
			this.ECCPAOBFDKP().SetInt("UseFinalGlassColor", (!this.CONEELGCALI) ? 0 : 0);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001874 RID: 6260 RVA: 0x0009B774 File Offset: 0x00099974
	private void IBHACCEEFFI()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001875 RID: 6261 RVA: 0x0009B774 File Offset: 0x00099974
	private void AEIJFLJEABG()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001876 RID: 6262 RVA: 0x0009B774 File Offset: 0x00099974
	private void LIEEGINIKOK()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001877 RID: 6263 RVA: 0x0009C739 File Offset: 0x0009A939
	private Material CBCNOEIALHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001878 RID: 6264 RVA: 0x0009C770 File Offset: 0x0009A970
	private void PPGEGFMNIKO()
	{
		this.JKBMKPDGCHG();
	}

	// Token: 0x06001879 RID: 6265 RVA: 0x0009C778 File Offset: 0x0009A978
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600187A RID: 6266 RVA: 0x0009C7AF File Offset: 0x0009A9AF
	private void EAOKCECGKAK()
	{
		this.AEOLJEIDMDB();
	}

	// Token: 0x0600187B RID: 6267 RVA: 0x0009C7B8 File Offset: 0x0009A9B8
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1455f)
			{
				this.HBJJOCHGOPH = 1496f;
			}
			if (this.Camera2 != null)
			{
				this.MCDGIILBNIF().SetTexture("float,2", this.JDMCFBKJHDD);
			}
			this.KGOLDDBHIFN().SetFloat("_Visualize", this._Distance);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this._Size);
			this.LNLKMDPHDCC().SetFloat("/", this._FixDistance);
			this.CBCNOEIALHB().SetFloat("[PlayerController] ", this.HBJJOCHGOPH);
			this.LPDOGGFOBDH().SetFloat("_Value6", this.BlendFX);
			this.CBCNOEIALHB().SetFloat("EnableRankedNotificationsToggle", this.SwitchCameraToCamera2);
			this.OOMFJGPAOKL().SetFloat("Time Offset: {0}", this.SplitX);
			this.KDMBOKLMADJ().SetFloat("Rock", this.SplitY);
			this.LPMLLJKMAMP().SetFloat("SlidingArea", this.Smooth);
			this.NBPKMLMCHFN.SetFloat("_FgOverlap", this.Rotation);
			this.PDEAHJPOMEF().SetInt("DPADHOR", (!this.CONEELGCALI) ? 1 : 1);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLGPDBBKAIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600187C RID: 6268 RVA: 0x0009C950 File Offset: 0x0009AB50
	private void OIKAPFGPLML(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1979f)
			{
				this.HBJJOCHGOPH = 369f;
			}
			if (this.Camera2 != null)
			{
				this.PDEAHJPOMEF().SetTexture("_BlurParams", this.JDMCFBKJHDD);
			}
			this.EFDEIFCDAFG().SetFloat("LoadingStatusText", this._Distance);
			this.KDMBOKLMADJ().SetFloat("VisionBlur", this._Size);
			this.EFDEIFCDAFG().SetFloat("LivesSlider", this._FixDistance);
			this.CBCNOEIALHB().SetFloat("OnReadyClick", this.HBJJOCHGOPH);
			this.OOMFJGPAOKL().SetFloat("closed", this.BlendFX);
			this.DOMEEFLPEPJ().SetFloat("_FarCorner", this.SwitchCameraToCamera2);
			this.AELJLBOJAIL().SetFloat("settings.hitvariation", this.SplitX);
			this.HKHBBBFLGJH().SetFloat("_Visualize", this.SplitY);
			this.OOMFJGPAOKL().SetFloat("icon", this.Smooth);
			this.NBPKMLMCHFN.SetFloat("_SceneFogParams", this.Rotation);
			this.HJGEHJDMCGI().SetInt("CameraFilterPack/FX_superDot", (!this.CONEELGCALI) ? 0 : 0);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600187D RID: 6269 RVA: 0x0009CAE8 File Offset: 0x0009ACE8
	private void Start()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 24);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600187E RID: 6270 RVA: 0x0009B774 File Offset: 0x00099974
	private void OIBMHPIFAKK()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x0600187F RID: 6271 RVA: 0x0009CB60 File Offset: 0x0009AD60
	private void JKBMKPDGCHG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -88);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001880 RID: 6272 RVA: 0x0009B73A File Offset: 0x0009993A
	private void CNDACAHCCOI()
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

	// Token: 0x06001881 RID: 6273 RVA: 0x0009B774 File Offset: 0x00099974
	private void MOMGJJDIFFI()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001882 RID: 6274 RVA: 0x0009B774 File Offset: 0x00099974
	private void PBEPCAPAKLG()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001883 RID: 6275 RVA: 0x0009CBD7 File Offset: 0x0009ADD7
	private Material KDMBOKLMADJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001884 RID: 6276 RVA: 0x0009CC10 File Offset: 0x0009AE10
	private void LNOOFNGHNEL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1501f)
			{
				this.HBJJOCHGOPH = 744f;
			}
			if (this.Camera2 != null)
			{
				this.KDMBOKLMADJ().SetTexture("_MainTexBlurred", this.JDMCFBKJHDD);
			}
			this.FLGPDBBKAIP().SetFloat(". local RequestedView.ownerId: ", this._Distance);
			this.NBPKMLMCHFN.SetFloat("Hidden/ScreenSpaceReflection", this._Size);
			this.KDMBOKLMADJ().SetFloat("LevelEditor/patterns", this._FixDistance);
			this.HKHBBBFLGJH().SetFloat("#md5submitionfailed: ", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("#no", this.BlendFX);
			this.ACHNOHCLGOO().SetFloat("_Visualize", this.SwitchCameraToCamera2);
			this.HFBJAOFLCJI().SetFloat("Tab2Content", this.SplitX);
			this.CBCNOEIALHB().SetFloat("_Rand", this.SplitY);
			this.KDMBOKLMADJ().SetFloat("GlassAberration", this.Smooth);
			this.NKBIEMJBCBM().SetFloat("_BokehParams", this.Rotation);
			this.ABHDNGIHBKE().SetInt("Texture3", (!this.CONEELGCALI) ? 0 : 1);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001885 RID: 6277 RVA: 0x0009B774 File Offset: 0x00099974
	private void GMELGGJOPBB()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001886 RID: 6278 RVA: 0x0009CDA8 File Offset: 0x0009AFA8
	private void NEFHGMNAPEP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 64);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001887 RID: 6279 RVA: 0x0009CE1F File Offset: 0x0009B01F
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001888 RID: 6280 RVA: 0x0009C770 File Offset: 0x0009A970
	private void LLAJPKFNDIG()
	{
		this.JKBMKPDGCHG();
	}

	// Token: 0x06001889 RID: 6281 RVA: 0x0009B774 File Offset: 0x00099974
	private void GGELPAHPFAJ()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x0600188A RID: 6282 RVA: 0x0009CE58 File Offset: 0x0009B058
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
			this.NBPKMLMCHFN.SetFloat("_Near", this._Distance);
			this.NBPKMLMCHFN.SetFloat("_Far", this._Size);
			this.NBPKMLMCHFN.SetFloat("_FixDistance", this._FixDistance);
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Value", this.BlendFX);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.SwitchCameraToCamera2);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.SplitX);
			this.NBPKMLMCHFN.SetFloat("_Value6", this.SplitY);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.Smooth);
			this.NBPKMLMCHFN.SetFloat("_Value5", this.Rotation);
			this.NBPKMLMCHFN.SetInt("_ForceYSwap", (!this.CONEELGCALI) ? 1 : 0);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600188B RID: 6283 RVA: 0x0009CFF0 File Offset: 0x0009B1F0
	private void POENGNEMHJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1962f)
			{
				this.HBJJOCHGOPH = 770f;
			}
			if (this.Camera2 != null)
			{
				this.ACHNOHCLGOO().SetTexture("Objects in List: ", this.JDMCFBKJHDD);
			}
			this.LPDOGGFOBDH().SetFloat("/", this._Distance);
			this.EFDEIFCDAFG().SetFloat("settings.fps", this._Size);
			this.NBPKMLMCHFN.SetFloat("PublishButton", this._FixDistance);
			this.KAFBNOBOIAJ().SetFloat(": ", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("_TimeX", this.BlendFX);
			this.HFBJAOFLCJI().SetFloat("_SpawnHeuristic", this.SwitchCameraToCamera2);
			this.KGOLDDBHIFN().SetFloat("CameraFilterPack_VHS1", this.SplitX);
			this.ACHNOHCLGOO().SetFloat("time", this.SplitY);
			this.MCDGIILBNIF().SetFloat("_TimeX", this.Smooth);
			this.ECCPAOBFDKP().SetFloat("_Value", this.Rotation);
			this.HJGEHJDMCGI().SetInt(" from: ", (!this.CONEELGCALI) ? 1 : 0);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KDMBOKLMADJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600188C RID: 6284 RVA: 0x0009BC7D File Offset: 0x00099E7D
	private void MAMFKACDKDP()
	{
		this.NEFHGMNAPEP();
	}

	// Token: 0x0600188D RID: 6285 RVA: 0x0009B73A File Offset: 0x0009993A
	private void LLKKGGLNIDF()
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

	// Token: 0x0600188E RID: 6286 RVA: 0x0009B774 File Offset: 0x00099974
	private void EJFJENFKLND()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x0600188F RID: 6287 RVA: 0x0009B774 File Offset: 0x00099974
	private void JFMIDILENDO()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001890 RID: 6288 RVA: 0x0009D188 File Offset: 0x0009B388
	private void JFJLGJEPEAA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -116);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001891 RID: 6289 RVA: 0x0009D200 File Offset: 0x0009B400
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 123f)
			{
				this.HBJJOCHGOPH = 1672f;
			}
			if (this.Camera2 != null)
			{
				this.KAFBNOBOIAJ().SetTexture("_PixelsPerMeterAtOneMeter", this.JDMCFBKJHDD);
			}
			this.CBCNOEIALHB().SetFloat("_SizeX", this._Distance);
			this.KGOLDDBHIFN().SetFloat("_Value2", this._Size);
			this.LPMLLJKMAMP().SetFloat("note.2", this._FixDistance);
			this.ACHNOHCLGOO().SetFloat("selector", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("Set particles count per one beat", this.BlendFX);
			this.LPMLLJKMAMP().SetFloat("_TimeX", this.SwitchCameraToCamera2);
			this.KGOLDDBHIFN().SetFloat("_EmissionGain", this.SplitX);
			this.OOMFJGPAOKL().SetFloat("\\n", this.SplitY);
			this.PDEAHJPOMEF().SetFloat("[PlayerBase] Loaded environment: ", this.Smooth);
			this.ACHNOHCLGOO().SetFloat("#000000CC", this.Rotation);
			this.KAFBNOBOIAJ().SetInt("IconImage", (!this.CONEELGCALI) ? 1 : 1);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001892 RID: 6290 RVA: 0x0009B774 File Offset: 0x00099974
	private void KMKLDAJLCNM()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001893 RID: 6291 RVA: 0x0009B774 File Offset: 0x00099974
	private void JBAPHFIBANG()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001894 RID: 6292 RVA: 0x0009B774 File Offset: 0x00099974
	private void GEGDELOFIML()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001895 RID: 6293 RVA: 0x0009B73A File Offset: 0x0009993A
	private void DIGHKAJILJH()
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

	// Token: 0x06001896 RID: 6294 RVA: 0x0009D398 File Offset: 0x0009B598
	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1619f)
			{
				this.HBJJOCHGOPH = 218f;
			}
			if (this.Camera2 != null)
			{
				this.HKHBBBFLGJH().SetTexture("_Green_B", this.JDMCFBKJHDD);
			}
			this.KAFBNOBOIAJ().SetFloat("CameraFilterPack/Drawing_NewCellShading", this._Distance);
			this.EFDEIFCDAFG().SetFloat("maps.", this._Size);
			this.DOMEEFLPEPJ().SetFloat("================================", this._FixDistance);
			this.KGOLDDBHIFN().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("No regions available. Are you sure your appid is valid and setup?", this.BlendFX);
			this.HFBJAOFLCJI().SetFloat("_History4LumaTex", this.SwitchCameraToCamera2);
			this.HFBJAOFLCJI().SetFloat("ResetButton", this.SplitX);
			this.NMDBCDFPGOK().SetFloat(" {0}", this.SplitY);
			this.ECCPAOBFDKP().SetFloat("offsets", this.Smooth);
			this.DOMEEFLPEPJ().SetFloat(".completedMaps", this.Rotation);
			this.LPDOGGFOBDH().SetInt("_PositionX", (!this.CONEELGCALI) ? 1 : 0);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001897 RID: 6295 RVA: 0x0009B774 File Offset: 0x00099974
	private void BNJEFIBPJLO()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x06001899 RID: 6297 RVA: 0x0009D5B4 File Offset: 0x0009B7B4
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1174f)
			{
				this.HBJJOCHGOPH = 1416f;
			}
			if (this.Camera2 != null)
			{
				this.DOMEEFLPEPJ().SetTexture("InventoryButton", this.JDMCFBKJHDD);
			}
			this.PDEAHJPOMEF().SetFloat("/../", this._Distance);
			this.LPMLLJKMAMP().SetFloat("speed", this._Size);
			this.NBPKMLMCHFN.SetFloat("[Left]", this._FixDistance);
			this.DOMEEFLPEPJ().SetFloat(".lastCheckpoint.bgcolor", this.HBJJOCHGOPH);
			this.CBCNOEIALHB().SetFloat("MaxLivesSlider", this.BlendFX);
			this.HFBJAOFLCJI().SetFloat("Case-Sensitive", this.SwitchCameraToCamera2);
			this.PDEAHJPOMEF().SetFloat("(\\[ */ *quote *\\])", this.SplitX);
			this.LPMLLJKMAMP().SetFloat("Coord", this.SplitY);
			this.LPDOGGFOBDH().SetFloat("Failed to InstantiateSceneObject prefab: ", this.Smooth);
			this.KGOLDDBHIFN().SetFloat("PunRespawn", this.Rotation);
			this.FLGPDBBKAIP().SetInt(":", (!this.CONEELGCALI) ? 1 : 1);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600189A RID: 6298 RVA: 0x0009D749 File Offset: 0x0009B949
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600189B RID: 6299 RVA: 0x0009D780 File Offset: 0x0009B980
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-1);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600189C RID: 6300 RVA: 0x0009B73A File Offset: 0x0009993A
	private void JMAIIENCEKE()
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

	// Token: 0x0600189D RID: 6301 RVA: 0x0009B774 File Offset: 0x00099974
	private void CFIAKIJAILI()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x0600189E RID: 6302 RVA: 0x0009D7B7 File Offset: 0x0009B9B7
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)100;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600189F RID: 6303 RVA: 0x0009B774 File Offset: 0x00099974
	private void NFEDLAOPHML()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x060018A0 RID: 6304 RVA: 0x0009B774 File Offset: 0x00099974
	private void IHAGANPOFDP()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x060018A1 RID: 6305 RVA: 0x0009D7EE File Offset: 0x0009B9EE
	private Material HKHBBBFLGJH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060018A2 RID: 6306 RVA: 0x0009BA9F File Offset: 0x00099C9F
	private void BKCJHBJCAKO()
	{
		this.KOFAMEKHHGD();
	}

	// Token: 0x060018A3 RID: 6307 RVA: 0x0009D825 File Offset: 0x0009BA25
	private Material OOMFJGPAOKL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060018A4 RID: 6308 RVA: 0x0009B774 File Offset: 0x00099974
	private void CCKABCDEOJC()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x060018A5 RID: 6309 RVA: 0x0009D85C File Offset: 0x0009BA5C
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060018A6 RID: 6310 RVA: 0x0009D894 File Offset: 0x0009BA94
	private void AGEJKLMJGDO()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 126);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060018A7 RID: 6311 RVA: 0x0009B73A File Offset: 0x0009993A
	private void CIHGFHNNFEE()
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

	// Token: 0x060018A8 RID: 6312 RVA: 0x0009B774 File Offset: 0x00099974
	private void HFLHDMPHOJA()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x060018A9 RID: 6313 RVA: 0x0009D90C File Offset: 0x0009BB0C
	private void BMIOFJFMCBG()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -119);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060018AA RID: 6314 RVA: 0x0009B73A File Offset: 0x0009993A
	private void JOJFHFHOCHO()
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

	// Token: 0x060018AB RID: 6315 RVA: 0x0009B73A File Offset: 0x0009993A
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

	// Token: 0x060018AC RID: 6316 RVA: 0x0009B774 File Offset: 0x00099974
	private void CLBJLKBNHOK()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x060018AD RID: 6317 RVA: 0x0009D983 File Offset: 0x0009BB83
	private void FPFJGEHEOPF()
	{
		this.DBLILJGKGHJ();
	}

	// Token: 0x060018AE RID: 6318 RVA: 0x0009D98B File Offset: 0x0009BB8B
	private Material ECCPAOBFDKP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060018AF RID: 6319 RVA: 0x0009B774 File Offset: 0x00099974
	private void KKLMPKLKAEM()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x060018B0 RID: 6320 RVA: 0x0009D9C2 File Offset: 0x0009BBC2
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060018B1 RID: 6321 RVA: 0x0009B774 File Offset: 0x00099974
	private void FOLDLDLFFLM()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x060018B2 RID: 6322 RVA: 0x0009B774 File Offset: 0x00099974
	private void KDJEJBBDILE()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x060018B3 RID: 6323 RVA: 0x0009C266 File Offset: 0x0009A466
	private void OCHCKGMIDND()
	{
		this.JFJLGJEPEAA();
	}

	// Token: 0x060018B4 RID: 6324 RVA: 0x0009B774 File Offset: 0x00099974
	private void FKDKJKCAHJC()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x060018B5 RID: 6325 RVA: 0x0009D9FC File Offset: 0x0009BBFC
	private void ANCKKLFPGDI()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 81);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060018B6 RID: 6326 RVA: 0x0009B73A File Offset: 0x0009993A
	private void OFMNDBNFBDJ()
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

	// Token: 0x060018B7 RID: 6327 RVA: 0x0009B774 File Offset: 0x00099974
	private void KFMEAMBLODG()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x060018B8 RID: 6328 RVA: 0x0009DA73 File Offset: 0x0009BC73
	private Material FLGPDBBKAIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060018B9 RID: 6329 RVA: 0x0009DAAC File Offset: 0x0009BCAC
	private void KDMANOEMOCA()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, -35);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060018BA RID: 6330 RVA: 0x0009B774 File Offset: 0x00099974
	private void FINDGJLEHOL()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x060018BB RID: 6331 RVA: 0x0009DB24 File Offset: 0x0009BD24
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 994f)
			{
				this.HBJJOCHGOPH = 1640f;
			}
			if (this.Camera2 != null)
			{
				this.KDMBOKLMADJ().SetTexture("intensity", this.JDMCFBKJHDD);
			}
			this.ECCPAOBFDKP().SetFloat("mapselector.tags.", this._Distance);
			this.ADBKPGFMNKO().SetFloat("Bad parameters for setbool! Use <key> <value>", this._Size);
			this.HFBJAOFLCJI().SetFloat(" not exist", this._FixDistance);
			this.KGOLDDBHIFN().SetFloat("_BlurRadius", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("FileMenu", this.BlendFX);
			this.HFBJAOFLCJI().SetFloat("PlayButton", this.SwitchCameraToCamera2);
			this.HFBJAOFLCJI().SetFloat("menu.selectedlevelid", this.SplitX);
			this.FLGPDBBKAIP().SetFloat("settings.customdataskin", this.SplitY);
			this.LPMLLJKMAMP().SetFloat("_Value3", this.Smooth);
			this.PDEAHJPOMEF().SetFloat("UNDISTORT", this.Rotation);
			this.ABHDNGIHBKE().SetInt("Exception while connecting to: ", (!this.CONEELGCALI) ? 0 : 1);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OOMFJGPAOKL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060018BC RID: 6332 RVA: 0x0009DCBC File Offset: 0x0009BEBC
	private void KOIKNJLPOPA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1025f)
			{
				this.HBJJOCHGOPH = 748f;
			}
			if (this.Camera2 != null)
			{
				this.MCDGIILBNIF().SetTexture("CameraFilterPack/AAA_WaterDrop", this.JDMCFBKJHDD);
			}
			this.LPDOGGFOBDH().SetFloat("AvatarImage", this._Distance);
			this.PDEAHJPOMEF().SetFloat("ShowTitle", this._Size);
			this.DOMEEFLPEPJ().SetFloat("_CenterY", this._FixDistance);
			this.NKBIEMJBCBM().SetFloat("colorD", this.HBJJOCHGOPH);
			this.FLGPDBBKAIP().SetFloat("_Value", this.BlendFX);
			this.HJGEHJDMCGI().SetFloat(" - Contains ", this.SwitchCameraToCamera2);
			this.KGOLDDBHIFN().SetFloat("_Value3", this.SplitX);
			this.MCDGIILBNIF().SetFloat("_TimeX", this.SplitY);
			this.NBPKMLMCHFN.SetFloat("\t", this.Smooth);
			this.KGOLDDBHIFN().SetFloat("_Green_G", this.Rotation);
			this.LPMLLJKMAMP().SetInt("offsets", (!this.CONEELGCALI) ? 0 : 0);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.None;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060018BD RID: 6333 RVA: 0x0009DE54 File Offset: 0x0009C054
	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1094f)
			{
				this.HBJJOCHGOPH = 233f;
			}
			if (this.Camera2 != null)
			{
				this.NKBIEMJBCBM().SetTexture("HandleEventLeave for player ID: ", this.JDMCFBKJHDD);
			}
			this.PDEAHJPOMEF().SetFloat("_LutTex", this._Distance);
			this.NKBIEMJBCBM().SetFloat("There was an error retrieving the NumberOfCurrentPlayers.", this._Size);
			this.LNLKMDPHDCC().SetFloat("CameraFilterPack_WaterDrop", this._FixDistance);
			this.HJGEHJDMCGI().SetFloat("Horizontal", this.HBJJOCHGOPH);
			this.KGOLDDBHIFN().SetFloat("_ScreenResolution", this.BlendFX);
			this.KGOLDDBHIFN().SetFloat("_Size", this.SwitchCameraToCamera2);
			this.MCDGIILBNIF().SetFloat("arcs", this.SplitX);
			this.ABHDNGIHBKE().SetFloat("_ProjectToPixelMatrix", this.SplitY);
			this.KDMBOKLMADJ().SetFloat("Error0", this.Smooth);
			this.PDEAHJPOMEF().SetFloat("#yes", this.Rotation);
			this.LNLKMDPHDCC().SetInt("_LensDirtIntensity", (!this.CONEELGCALI) ? 0 : 1);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLGPDBBKAIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060018BE RID: 6334 RVA: 0x0009BC7D File Offset: 0x00099E7D
	private void HMKJFPBFOFI()
	{
		this.NEFHGMNAPEP();
	}

	// Token: 0x060018BF RID: 6335 RVA: 0x0009B774 File Offset: 0x00099974
	private void JDGFCEPDKAJ()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x060018C0 RID: 6336 RVA: 0x0009DFE9 File Offset: 0x0009C1E9
	private Material DOMEEFLPEPJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-90);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060018C1 RID: 6337 RVA: 0x0009E020 File Offset: 0x0009C220
	private Material NMDBCDFPGOK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-91);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060018C2 RID: 6338 RVA: 0x0009E058 File Offset: 0x0009C258
	private void CACCPBENDAP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1736f)
			{
				this.HBJJOCHGOPH = 471f;
			}
			if (this.Camera2 != null)
			{
				this.NMDBCDFPGOK().SetTexture("Working.\nPlease wait..", this.JDMCFBKJHDD);
			}
			this.ABHDNGIHBKE().SetFloat("Please specify either t or f.", this._Distance);
			this.HKHBBBFLGJH().SetFloat("_ReflectionTexture0", this._Size);
			this.HKHBBBFLGJH().SetFloat("Received event Leave for unknown player ID: {0}", this._FixDistance);
			this.LPMLLJKMAMP().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.FLGPDBBKAIP().SetFloat("_Intensity", this.BlendFX);
			this.KAFBNOBOIAJ().SetFloat("_TimeX", this.SwitchCameraToCamera2);
			this.NMDBCDFPGOK().SetFloat("LobbyCanvas", this.SplitX);
			this.ECCPAOBFDKP().SetFloat("_Far", this.SplitY);
			this.MCDGIILBNIF().SetFloat("CameraFilterPack_3D_Myst1", this.Smooth);
			this.HJGEHJDMCGI().SetFloat("_Value2", this.Rotation);
			this.ECCPAOBFDKP().SetInt("skin.", (!this.CONEELGCALI) ? 0 : 1);
			base.GetComponent<Camera>().depthTextureMode = DepthTextureMode.Depth;
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060018C3 RID: 6339 RVA: 0x0009B774 File Offset: 0x00099974
	private void GGPDKCHEBAG()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x060018C4 RID: 6340 RVA: 0x0009E1F0 File Offset: 0x0009C3F0
	private void AEOLJEIDMDB()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 67);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060018C5 RID: 6341 RVA: 0x0009B73A File Offset: 0x0009993A
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

	// Token: 0x060018C6 RID: 6342 RVA: 0x0009E268 File Offset: 0x0009C468
	private void AKHCOBHHGJP()
	{
		if (this.Camera2 != null)
		{
			this.JDMCFBKJHDD = new RenderTexture((int)this.FPEMMGKMJGA.x, (int)this.FPEMMGKMJGA.y, 83);
			this.Camera2.targetTexture = this.JDMCFBKJHDD;
		}
		this.SCShader = Shader.Find(this.ELOFMLPCCEA);
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060018C7 RID: 6343 RVA: 0x0009B774 File Offset: 0x00099974
	private void MLAGEPNCCGM()
	{
		this.FPEMMGKMJGA.x = (float)Screen.width;
		this.FPEMMGKMJGA.y = (float)Screen.height;
	}

	// Token: 0x060018C8 RID: 6344 RVA: 0x0009BADE File Offset: 0x00099CDE
	private void HIFPDKKBDHJ()
	{
		this.EGEPLFGKGLI();
	}

	// Token: 0x060018C9 RID: 6345 RVA: 0x0009D983 File Offset: 0x0009BB83
	private void KFCCKOBOLAH()
	{
		this.DBLILJGKGHJ();
	}

	// Token: 0x0400036C RID: 876
	private string ELOFMLPCCEA = "CameraFilterPack/Blend2Camera_SplitScreen3D";

	// Token: 0x0400036D RID: 877
	public Shader SCShader;

	// Token: 0x0400036E RID: 878
	public Camera Camera2;

	// Token: 0x0400036F RID: 879
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000370 RID: 880
	private Material BJFKDHHMLJH;

	// Token: 0x04000371 RID: 881
	[Range(0f, 100f)]
	public float _FixDistance = 1f;

	// Token: 0x04000372 RID: 882
	[Range(-0.99f, 0.99f)]
	public float _Distance = 0.5f;

	// Token: 0x04000373 RID: 883
	[Range(0f, 0.5f)]
	public float _Size = 0.1f;

	// Token: 0x04000374 RID: 884
	[Range(0f, 1f)]
	public float SwitchCameraToCamera2;

	// Token: 0x04000375 RID: 885
	[Range(0f, 1f)]
	public float BlendFX = 1f;

	// Token: 0x04000376 RID: 886
	[Range(-3f, 3f)]
	public float SplitX = 0.5f;

	// Token: 0x04000377 RID: 887
	[Range(-3f, 3f)]
	public float SplitY = 0.5f;

	// Token: 0x04000378 RID: 888
	[Range(0f, 2f)]
	public float Smooth = 0.1f;

	// Token: 0x04000379 RID: 889
	[Range(-3.14f, 3.14f)]
	public float Rotation = 3.14f;

	// Token: 0x0400037A RID: 890
	private bool CONEELGCALI;

	// Token: 0x0400037B RID: 891
	private RenderTexture JDMCFBKJHDD;

	// Token: 0x0400037C RID: 892
	private Vector2 FPEMMGKMJGA;
}
