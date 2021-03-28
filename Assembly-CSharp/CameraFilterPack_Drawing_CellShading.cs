using System;
using UnityEngine;

// Token: 0x02000098 RID: 152
[AddComponentMenu("Camera Filter Pack/Drawing/CellShading")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_CellShading : MonoBehaviour
{
	// Token: 0x06002D8D RID: 11661 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void BNCLKHOEGDK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D8E RID: 11662 RVA: 0x000F5B21 File Offset: 0x000F3D21
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D8F RID: 11663 RVA: 0x000F5B58 File Offset: 0x000F3D58
	private void ECBILENEOOL()
	{
		this.SCShader = Shader.Find("masterSteamID");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002D90 RID: 11664 RVA: 0x0002523B File Offset: 0x0002343B
	private void APKNAPHOFHC()
	{
	}

	// Token: 0x06002D91 RID: 11665 RVA: 0x000F5B7C File Offset: 0x000F3D7C
	private void BKIGIIINEDH()
	{
		this.SCShader = Shader.Find(" respawn in future: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002D92 RID: 11666 RVA: 0x000F5BA0 File Offset: 0x000F3DA0
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("_EmissionColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002D93 RID: 11667 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D94 RID: 11668 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void ANDELGODEOC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D95 RID: 11669 RVA: 0x000F5BC4 File Offset: 0x000F3DC4
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002D96 RID: 11670 RVA: 0x000F5BE8 File Offset: 0x000F3DE8
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1721f)
			{
				this.HBJJOCHGOPH = 1076f;
			}
			this.AELJLBOJAIL().SetFloat("_VelocityScale", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("_ScreenResolution", this.EdgeSize);
			this.IFMAPIDFNLI().SetFloat("SupportLogger Info: PUN {0}: ", this.ColorLevel);
			this.NFMGLIKNOOC().SetVector("Working.\nPlease wait..", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D97 RID: 11671 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEEGKLABFLN()
	{
	}

	// Token: 0x06002D98 RID: 11672 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D99 RID: 11673 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x06002D9A RID: 11674 RVA: 0x000F5CB4 File Offset: 0x000F3EB4
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D9B RID: 11675 RVA: 0x000F5CEC File Offset: 0x000F3EEC
	private void KENMBHKMEFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1782f)
			{
				this.HBJJOCHGOPH = 1768f;
			}
			this.KJMECMIGJJA().SetFloat("SpawnObj", this.HBJJOCHGOPH);
			this.HHLFDHNEIAH().SetFloat("#FFFFFFFF", this.EdgeSize);
			this.OLHDPICFBOF().SetFloat(" canvas not found", this.ColorLevel);
			this.KEMAALEODNH().SetVector("_Near", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002D9C RID: 11676 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCDLIKEDMCF()
	{
	}

	// Token: 0x06002D9D RID: 11677 RVA: 0x000F5DB8 File Offset: 0x000F3FB8
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002D9E RID: 11678 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002D9F RID: 11679 RVA: 0x000F5DF0 File Offset: 0x000F3FF0
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1664f)
			{
				this.HBJJOCHGOPH = 597f;
			}
			this.MICHFGAOPKM().SetFloat("EnvironmentSlider", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat(". Should be just one?", this.EdgeSize);
			this.ADGHJOHKEHG().SetFloat(": ", this.ColorLevel);
			this.MICHFGAOPKM().SetVector("_Value2", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002DA0 RID: 11680 RVA: 0x000F5EBC File Offset: 0x000F40BC
	private void AEMGPJDJGBJ()
	{
		this.SCShader = Shader.Find("[Right-Down]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002DA1 RID: 11681 RVA: 0x000F5EE0 File Offset: 0x000F40E0
	private void KHIGHFJKPFG()
	{
		this.SCShader = Shader.Find(" Gb");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002DA2 RID: 11682 RVA: 0x000F5F04 File Offset: 0x000F4104
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find("https://steamcommunity.com/sharedfiles/filedetails/?id=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002DA3 RID: 11683 RVA: 0x000F5F28 File Offset: 0x000F4128
	private void NCNPAKFAFOE()
	{
		this.SCShader = Shader.Find("[Up]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002DA4 RID: 11684 RVA: 0x000F5F4C File Offset: 0x000F414C
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002DA5 RID: 11685 RVA: 0x000F5F84 File Offset: 0x000F4184
	private void ANBIJFCCANE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 9f)
			{
				this.HBJJOCHGOPH = 1655f;
			}
			this.DOHGBNPMBKG().SetFloat("EventSystem", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("CameraFilterPack/AAA_Blood_Hit", this.EdgeSize);
			this.HHLFDHNEIAH().SetFloat("SetPlayerDistance", this.ColorLevel);
			this.ADGHJOHKEHG().SetVector("player.goldwatermelon", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IFMAPIDFNLI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002DA6 RID: 11686 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002DA7 RID: 11687 RVA: 0x000F6050 File Offset: 0x000F4250
	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 359f)
			{
				this.HBJJOCHGOPH = 489f;
			}
			this.HKIMAANBGMJ().SetFloat("The observed monobehaviour (", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("YES", this.EdgeSize);
			this.OLHDPICFBOF().SetFloat("[NetworkManager] Updating rooms...", this.ColorLevel);
			this.OLHDPICFBOF().SetVector("AudioClip", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002DA8 RID: 11688 RVA: 0x000F611C File Offset: 0x000F431C
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Divide");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002DA9 RID: 11689 RVA: 0x0002523B File Offset: 0x0002343B
	private void CKECPMDEBLL()
	{
	}

	// Token: 0x06002DAA RID: 11690 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002DAB RID: 11691 RVA: 0x000F6140 File Offset: 0x000F4340
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("[Up-Left]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002DAC RID: 11692 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void DIGHKAJILJH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002DAD RID: 11693 RVA: 0x000F6164 File Offset: 0x000F4364
	private Material NMDBCDFPGOK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)115;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002DAE RID: 11694 RVA: 0x000F619B File Offset: 0x000F439B
	private void FEGJMDDIDIC()
	{
		this.SCShader = Shader.Find("Joystick1Button10");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002DAF RID: 11695 RVA: 0x000F61BF File Offset: 0x000F43BF
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002DB0 RID: 11696 RVA: 0x000F61F6 File Offset: 0x000F43F6
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("Back");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002DB1 RID: 11697 RVA: 0x000F621A File Offset: 0x000F441A
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002DB2 RID: 11698 RVA: 0x000F6251 File Offset: 0x000F4451
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002DB3 RID: 11699 RVA: 0x000F6288 File Offset: 0x000F4488
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_CellShading");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002DB4 RID: 11700 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06002DB5 RID: 11701 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002DB6 RID: 11702 RVA: 0x0002523B File Offset: 0x0002343B
	private void EDDPLJGKLKJ()
	{
	}

	// Token: 0x06002DB7 RID: 11703 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06002DB8 RID: 11704 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002DB9 RID: 11705 RVA: 0x000F62AC File Offset: 0x000F44AC
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-85);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002DBA RID: 11706 RVA: 0x000F62E4 File Offset: 0x000F44E4
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1617f)
			{
				this.HBJJOCHGOPH = 255f;
			}
			this.KEMAALEODNH().SetFloat("_Level", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("VIGNETTE_FILMIC", this.EdgeSize);
			this.DOHGBNPMBKG().SetFloat("ShowTitle", this.ColorLevel);
			this.EFDEIFCDAFG().SetVector("_FadeFX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLGPDBBKAIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002DBB RID: 11707 RVA: 0x000F63B0 File Offset: 0x000F45B0
	private void MJEFMIPLFAB()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002DBC RID: 11708 RVA: 0x000F63D4 File Offset: 0x000F45D4
	private void MDHIALGJMBO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 138f)
			{
				this.HBJJOCHGOPH = 1717f;
			}
			this.AELJLBOJAIL().SetFloat("Items/", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("Editing: ", this.EdgeSize);
			this.EOCCJGIGEGJ().SetFloat("/icon", this.ColorLevel);
			this.NBPKMLMCHFN.SetVector("white", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLGPDBBKAIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002DBD RID: 11709 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void HNGHDAPKEJG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002DBE RID: 11710 RVA: 0x000F64A0 File Offset: 0x000F46A0
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 889f)
			{
				this.HBJJOCHGOPH = 472f;
			}
			this.HHIFMIPPMPF().SetFloat("intensity", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("skin.", this.EdgeSize);
			this.ADAFMBOGPLN().SetFloat("4,28,true,0", this.ColorLevel);
			this.OLHDPICFBOF().SetVector("https://steamcommunity.com/sharedfiles/filedetails/?id=", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002DBF RID: 11711 RVA: 0x000F656C File Offset: 0x000F476C
	private void KOFAMEKHHGD()
	{
		this.SCShader = Shader.Find("settings_bindings_");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002DC0 RID: 11712 RVA: 0x0002523B File Offset: 0x0002343B
	private void MANDOGNJJBD()
	{
	}

	// Token: 0x06002DC1 RID: 11713 RVA: 0x000F6590 File Offset: 0x000F4790
	private void GNJDKAECPKA()
	{
		this.SCShader = Shader.Find("GlassesColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002DC2 RID: 11714 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x06002DC3 RID: 11715 RVA: 0x000F65B4 File Offset: 0x000F47B4
	private void NEFHGMNAPEP()
	{
		this.SCShader = Shader.Find("(master)");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002DC4 RID: 11716 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void CIHGFHNNFEE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002DC5 RID: 11717 RVA: 0x000F65D8 File Offset: 0x000F47D8
	private void OKLAJINHPAN()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002DC6 RID: 11718 RVA: 0x0002523B File Offset: 0x0002343B
	private void LKJMIODJGCM()
	{
	}

	// Token: 0x06002DC7 RID: 11719 RVA: 0x000F65FC File Offset: 0x000F47FC
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find("ns.exitgames.com");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002DC8 RID: 11720 RVA: 0x000F6620 File Offset: 0x000F4820
	private void PJIFJFENPJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 140f)
			{
				this.HBJJOCHGOPH = 1859f;
			}
			this.GJHPODJOBHL().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NMDBCDFPGOK().SetFloat("_TimeX", this.EdgeSize);
			this.HKIMAANBGMJ().SetFloat("_VignettingDirt", this.ColorLevel);
			this.AELJLBOJAIL().SetVector("caret", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002DC9 RID: 11721 RVA: 0x000F66EC File Offset: 0x000F48EC
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("#tryagain");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002DCA RID: 11722 RVA: 0x000F6710 File Offset: 0x000F4910
	private Material HHLFDHNEIAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002DCB RID: 11723 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void EFECEKPFOEM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002DCC RID: 11724 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002DCD RID: 11725 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002DCE RID: 11726 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void IEFMONDKKJN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002DCF RID: 11727 RVA: 0x000F6747 File Offset: 0x000F4947
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002DD0 RID: 11728 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002DD1 RID: 11729 RVA: 0x000F677E File Offset: 0x000F497E
	private void DPLLKHHLDBB()
	{
		this.SCShader = Shader.Find("_Bloom2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002DD2 RID: 11730 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x06002DD3 RID: 11731 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x06002DD4 RID: 11732 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002DD5 RID: 11733 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void OOGIHDLBBLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002DD6 RID: 11734 RVA: 0x000F67A2 File Offset: 0x000F49A2
	private void JFJLGJEPEAA()
	{
		this.SCShader = Shader.Find("[MapEditor] Loading music...");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002DD7 RID: 11735 RVA: 0x000F67C6 File Offset: 0x000F49C6
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find(" takes from: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002DD8 RID: 11736 RVA: 0x000F67EA File Offset: 0x000F49EA
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)100;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002DD9 RID: 11737 RVA: 0x000F6821 File Offset: 0x000F4A21
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)71;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002DDA RID: 11738 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void ABEIEGDHBNO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002DDB RID: 11739 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002DDC RID: 11740 RVA: 0x000F6858 File Offset: 0x000F4A58
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1649f)
			{
				this.HBJJOCHGOPH = 738f;
			}
			this.KEMAALEODNH().SetFloat("Object ID. Case-Sensitive", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat("fetch", this.EdgeSize);
			this.KEMAALEODNH().SetFloat("CameraFilterPack/FX_superDot", this.ColorLevel);
			this.AELJLBOJAIL().SetVector("SteamManager", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002DDD RID: 11741 RVA: 0x000F6924 File Offset: 0x000F4B24
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1150f)
			{
				this.HBJJOCHGOPH = 1327f;
			}
			this.EFMCNLELMDO().SetFloat("Set particles gravity", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("ZoomSpeed", this.EdgeSize);
			this.OLHDPICFBOF().SetFloat("PopulateMapsList", this.ColorLevel);
			this.NMDBCDFPGOK().SetVector("Right Stick Click", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002DDE RID: 11742 RVA: 0x000F69F0 File Offset: 0x000F4BF0
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 935f)
			{
				this.HBJJOCHGOPH = 1912f;
			}
			this.EFMCNLELMDO().SetFloat("Search: ", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat("cancel", this.EdgeSize);
			this.NMDBCDFPGOK().SetFloat("_Value2", this.ColorLevel);
			this.DOHGBNPMBKG().SetVector("LoadingStatusText", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002DDF RID: 11743 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002DE0 RID: 11744 RVA: 0x000F6ABC File Offset: 0x000F4CBC
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1697f)
			{
				this.HBJJOCHGOPH = 1771f;
			}
			this.NFMGLIKNOOC().SetFloat("-1", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("VisionBlur", this.EdgeSize);
			this.NBPKMLMCHFN.SetFloat("Uploading preview image", this.ColorLevel);
			this.EFDEIFCDAFG().SetVector("(scene)", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002DE1 RID: 11745 RVA: 0x000F6B88 File Offset: 0x000F4D88
	private void LFBGJIIECLD()
	{
		this.SCShader = Shader.Find(".lastCheckpoint.currentCombo");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002DE2 RID: 11746 RVA: 0x0002523B File Offset: 0x0002343B
	private void PNLKFANNOKO()
	{
	}

	// Token: 0x06002DE3 RID: 11747 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void ICDBMJKMIKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002DE4 RID: 11748 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002DE5 RID: 11749 RVA: 0x000F6BAC File Offset: 0x000F4DAC
	private Material GJHPODJOBHL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002DE6 RID: 11750 RVA: 0x000F6BE4 File Offset: 0x000F4DE4
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 877f)
			{
				this.HBJJOCHGOPH = 830f;
			}
			this.KJMECMIGJJA().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("_MainTex2", this.EdgeSize);
			this.ACHNOHCLGOO().SetFloat("value", this.ColorLevel);
			this.ACHNOHCLGOO().SetVector("<command>", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002DE7 RID: 11751 RVA: 0x000F6CB0 File Offset: 0x000F4EB0
	private void JKBMKPDGCHG()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002DE8 RID: 11752 RVA: 0x000F6CD4 File Offset: 0x000F4ED4
	private void AGHOLABKLNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1055f)
			{
				this.HBJJOCHGOPH = 1580f;
			}
			this.AELJLBOJAIL().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("DifficultyBG", this.EdgeSize);
			this.IFMAPIDFNLI().SetFloat("Tab1Content", this.ColorLevel);
			this.DOHGBNPMBKG().SetVector("<b>(╯°□°）╯︵ ┻━┻</b>", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HKIMAANBGMJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002DE9 RID: 11753 RVA: 0x000F6DA0 File Offset: 0x000F4FA0
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1033f)
			{
				this.HBJJOCHGOPH = 202f;
			}
			this.NBPKMLMCHFN.SetFloat("{0:0} day{1}, ", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("Chat", this.EdgeSize);
			this.KEMAALEODNH().SetFloat("UI Extensions/UIScreen", this.ColorLevel);
			this.NBPKMLMCHFN.SetVector("CameraFilterPack/Blend2Camera_HardLight", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002DEA RID: 11754 RVA: 0x0002523B File Offset: 0x0002343B
	private void JGMEKCFHGLE()
	{
	}

	// Token: 0x06002DEB RID: 11755 RVA: 0x000F6E6C File Offset: 0x000F506C
	private void HPFIHLMKIPF()
	{
		this.SCShader = Shader.Find("ready");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002DEC RID: 11756 RVA: 0x000F6E90 File Offset: 0x000F5090
	private void OPKNFOGMGII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1154f)
			{
				this.HBJJOCHGOPH = 847f;
			}
			this.HHIFMIPPMPF().SetFloat(": ", this.HBJJOCHGOPH);
			this.GJHPODJOBHL().SetFloat("_Value", this.EdgeSize);
			this.NBPKMLMCHFN.SetFloat("Line", this.ColorLevel);
			this.FLGPDBBKAIP().SetVector("_MainTex", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002DED RID: 11757 RVA: 0x000F6F5C File Offset: 0x000F515C
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1615f)
			{
				this.HBJJOCHGOPH = 1933f;
			}
			this.HHIFMIPPMPF().SetFloat("MainThreadExecuter", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_ForegroundBlurExtrude", this.EdgeSize);
			this.KEMAALEODNH().SetFloat("Saved as: ", this.ColorLevel);
			this.AELJLBOJAIL().SetVector("[MapsStats] Difficulty: ", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002DEE RID: 11758 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x06002DF0 RID: 11760 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06002DF1 RID: 11761 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002DF2 RID: 11762 RVA: 0x000F7051 File Offset: 0x000F5251
	private void CCFEDENFNEF()
	{
		this.SCShader = Shader.Find("\\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002DF3 RID: 11763 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x06002DF4 RID: 11764 RVA: 0x000F7078 File Offset: 0x000F5278
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 548f)
			{
				this.HBJJOCHGOPH = 1542f;
			}
			this.EOCCJGIGEGJ().SetFloat("ns", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("LastNewsButton", this.EdgeSize);
			this.HHIFMIPPMPF().SetFloat("workshop.txt", this.ColorLevel);
			this.OLHDPICFBOF().SetVector("1", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002DF5 RID: 11765 RVA: 0x000F7144 File Offset: 0x000F5344
	private Material FLGPDBBKAIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)104;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002DF6 RID: 11766 RVA: 0x000F717B File Offset: 0x000F537B
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("_Curve");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002DF7 RID: 11767 RVA: 0x000F71A0 File Offset: 0x000F53A0
	private void FJKJGBLPDGG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1003f)
			{
				this.HBJJOCHGOPH = 930f;
			}
			this.KJMECMIGJJA().SetFloat("roomDescription", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("\\", this.EdgeSize);
			this.NMDBCDFPGOK().SetFloat(".completedCount", this.ColorLevel);
			this.DOHGBNPMBKG().SetVector("_TimeX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FEAEGGCNIAA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002DF8 RID: 11768 RVA: 0x0002523B File Offset: 0x0002343B
	private void ABFNJCEBIKA()
	{
	}

	// Token: 0x06002DF9 RID: 11769 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002DFA RID: 11770 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06002DFB RID: 11771 RVA: 0x000F726C File Offset: 0x000F546C
	private void BOPKKCAFODF()
	{
		this.SCShader = Shader.Find(" should be overwritten.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x1700007D RID: 125
	// (get) Token: 0x06002DFC RID: 11772 RVA: 0x000F7290 File Offset: 0x000F5490
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

	// Token: 0x06002DFD RID: 11773 RVA: 0x000F72C7 File Offset: 0x000F54C7
	private void ODMPMJPALID()
	{
		this.SCShader = Shader.Find("_Colorisation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002DFE RID: 11774 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void AMHEJBMLFNM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002DFF RID: 11775 RVA: 0x000F72EC File Offset: 0x000F54EC
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 201f)
			{
				this.HBJJOCHGOPH = 888f;
			}
			this.MICHFGAOPKM().SetFloat("[PowerUp]", this.HBJJOCHGOPH);
			this.ADGHJOHKEHG().SetFloat("_Value4", this.EdgeSize);
			this.HHIFMIPPMPF().SetFloat("workshop.", this.ColorLevel);
			this.EOCCJGIGEGJ().SetVector("_Value2", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E00 RID: 11776 RVA: 0x000F73B8 File Offset: 0x000F55B8
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E01 RID: 11777 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E02 RID: 11778 RVA: 0x000F73F0 File Offset: 0x000F55F0
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
			this.NBPKMLMCHFN.SetFloat("_EdgeSize", this.EdgeSize);
			this.NBPKMLMCHFN.SetFloat("_ColorLevel", this.ColorLevel);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E03 RID: 11779 RVA: 0x000F74BC File Offset: 0x000F56BC
	private Material MICHFGAOPKM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E04 RID: 11780 RVA: 0x000F74F3 File Offset: 0x000F56F3
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("Bad parameters for delete! Use <key>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002E05 RID: 11781 RVA: 0x000F7517 File Offset: 0x000F5717
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("player.licenceaccepted");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002E06 RID: 11782 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06002E07 RID: 11783 RVA: 0x000F753B File Offset: 0x000F573B
	private Material OLHDPICFBOF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E08 RID: 11784 RVA: 0x000F7572 File Offset: 0x000F5772
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E09 RID: 11785 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void EDCMIPNCPLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E0A RID: 11786 RVA: 0x000F75AC File Offset: 0x000F57AC
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 270f)
			{
				this.HBJJOCHGOPH = 1393f;
			}
			this.HKIMAANBGMJ().SetFloat("sprite", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat(" This is not possible to be called for standalone input. Please check your platform and code where this is called", this.EdgeSize);
			this.ADAFMBOGPLN().SetFloat("st", this.ColorLevel);
			this.NFMGLIKNOOC().SetVector(" is set to dontSave = true, continuing loop.", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E0B RID: 11787 RVA: 0x000F7678 File Offset: 0x000F5878
	private Material IFMAPIDFNLI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-88);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E0C RID: 11788 RVA: 0x000F76B0 File Offset: 0x000F58B0
	private void KHGEBPHKAGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 498f)
			{
				this.HBJJOCHGOPH = 769f;
			}
			this.GJHPODJOBHL().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.ADAFMBOGPLN().SetFloat("Send", this.EdgeSize);
			this.HHIFMIPPMPF().SetFloat("Left Stick Click", this.ColorLevel);
			this.KJMECMIGJJA().SetVector("Fade", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MICHFGAOPKM());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E0D RID: 11789 RVA: 0x000F777C File Offset: 0x000F597C
	private void CEDFFAOOPOG()
	{
		this.SCShader = Shader.Find("The shader ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002E0E RID: 11790 RVA: 0x000F77A0 File Offset: 0x000F59A0
	private void LPFHEJNMEOO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1539f)
			{
				this.HBJJOCHGOPH = 1243f;
			}
			this.OLHDPICFBOF().SetFloat("RestartButton", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("_BlurPass", this.EdgeSize);
			this.MICHFGAOPKM().SetFloat("The other scroll rect doesnt support scrolling vertically", this.ColorLevel);
			this.HKIMAANBGMJ().SetVector("_FixDistance", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NMDBCDFPGOK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E0F RID: 11791 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E10 RID: 11792 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06002E11 RID: 11793 RVA: 0x000F786C File Offset: 0x000F5A6C
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("_SoftZDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002E12 RID: 11794 RVA: 0x000F7890 File Offset: 0x000F5A90
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E13 RID: 11795 RVA: 0x000F5B04 File Offset: 0x000F3D04
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002E14 RID: 11796 RVA: 0x000F78C8 File Offset: 0x000F5AC8
	private void PLEOOAJIMEE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1896f)
			{
				this.HBJJOCHGOPH = 1821f;
			}
			this.MICHFGAOPKM().SetFloat("2", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("_TimeX", this.EdgeSize);
			this.ADAFMBOGPLN().SetFloat("DPADHOR", this.ColorLevel);
			this.DOHGBNPMBKG().SetVector("/", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E15 RID: 11797 RVA: 0x000F7994 File Offset: 0x000F5B94
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("_Blue_R");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002E16 RID: 11798 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06002E17 RID: 11799 RVA: 0x000F79B8 File Offset: 0x000F5BB8
	private Material ADAFMBOGPLN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002E18 RID: 11800 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x06002E19 RID: 11801 RVA: 0x000F79F0 File Offset: 0x000F5BF0
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 57f)
			{
				this.HBJJOCHGOPH = 1456f;
			}
			this.KJMECMIGJJA().SetFloat("ReJoinRoom failed. A roomname is required. If you don't know one, how will you join?", this.HBJJOCHGOPH);
			this.EFMCNLELMDO().SetFloat("_TapMedium", this.EdgeSize);
			this.ADAFMBOGPLN().SetFloat("d264dbba9c2410771b4ad918903b3f4cd9e276a9", this.ColorLevel);
			this.EOCCJGIGEGJ().SetVector("inventory.lastitemscount", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADAFMBOGPLN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002E1A RID: 11802 RVA: 0x000F7ABC File Offset: 0x000F5CBC
	private void IDJKNBDKHBD()
	{
		this.SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x04000551 RID: 1361
	public Shader SCShader;

	// Token: 0x04000552 RID: 1362
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000553 RID: 1363
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000554 RID: 1364
	private Material BJFKDHHMLJH;

	// Token: 0x04000555 RID: 1365
	[Range(0f, 1f)]
	public float EdgeSize = 0.1f;

	// Token: 0x04000556 RID: 1366
	[Range(0f, 10f)]
	public float ColorLevel = 4f;
}
