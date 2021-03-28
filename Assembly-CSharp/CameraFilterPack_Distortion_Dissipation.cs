using System;
using UnityEngine;

// Token: 0x02000087 RID: 135
[AddComponentMenu("Camera Filter Pack/Distortion/Dissipation")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_Dissipation : MonoBehaviour
{
	// Token: 0x06002667 RID: 9831 RVA: 0x000D8EE4 File Offset: 0x000D70E4
	private Material OHKGGPFGLFD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002668 RID: 9832 RVA: 0x000D8F1B File Offset: 0x000D711B
	private Material MMOODGIODPC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002669 RID: 9833 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600266A RID: 9834 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void EAHCLIEEJOG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600266B RID: 9835 RVA: 0x000D8F70 File Offset: 0x000D7170
	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 384f)
			{
				this.HBJJOCHGOPH = 1368f;
			}
			this.PHGCJOPFDOG().SetFloat("Tab1Content", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("type", this.Dissipation);
			this.NBPKMLMCHFN.SetFloat("_MainTex2", this.LHFNOLGKGMO);
			this.LMLENGFLEBD().SetFloat("_Value3", this.NEJIJAPDALK);
			this.MFHPKGICPIO().SetFloat("return ", this.CCIENBFIKKH);
			this.LMLENGFLEBD().SetVector("$ {0}", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1341f, 786f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600266C RID: 9836 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600266D RID: 9837 RVA: 0x000D9070 File Offset: 0x000D7270
	private void DLIJFEGIEKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 936f)
			{
				this.HBJJOCHGOPH = 249f;
			}
			this.ALABBJPHCNG().SetFloat("Checkpoint", this.HBJJOCHGOPH);
			this.PHGCJOPFDOG().SetFloat("BitsData", this.Dissipation);
			this.IIJMIPBMMBF().SetFloat("shader.crispwinter", this.LHFNOLGKGMO);
			this.KEMAALEODNH().SetFloat("_Value3", this.NEJIJAPDALK);
			this.GHHPOGODBHB().SetFloat("#91CCFF", this.CCIENBFIKKH);
			this.DONENAMLFLF().SetVector("Case-Sensitive", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1180f, 1976f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600266E RID: 9838 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x0600266F RID: 9839 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void JHJFBCFBKLD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002670 RID: 9840 RVA: 0x000D9170 File Offset: 0x000D7370
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 472f)
			{
				this.HBJJOCHGOPH = 1058f;
			}
			this.MMOODGIODPC().SetFloat("offsets", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Moved event", this.Dissipation);
			this.GKILCDHJFEG().SetFloat("_TimeX", this.LHFNOLGKGMO);
			this.KEMAALEODNH().SetFloat("Crosshair", this.NEJIJAPDALK);
			this.LMLENGFLEBD().SetFloat("#{0:X2}{1:X2}{2:X2}", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("Horizontal", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 4f, 1394f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002671 RID: 9841 RVA: 0x000D926F File Offset: 0x000D746F
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002672 RID: 9842 RVA: 0x0002523B File Offset: 0x0002343B
	private void GFACKFCEIBC()
	{
	}

	// Token: 0x06002673 RID: 9843 RVA: 0x000D92A6 File Offset: 0x000D74A6
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("_BlurVector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002674 RID: 9844 RVA: 0x000D92CA File Offset: 0x000D74CA
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-70);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002675 RID: 9845 RVA: 0x000D9301 File Offset: 0x000D7501
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002676 RID: 9846 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDBBPKIFNJ()
	{
	}

	// Token: 0x06002677 RID: 9847 RVA: 0x0002523B File Offset: 0x0002343B
	private void FAKGFMFAPDG()
	{
	}

	// Token: 0x06002678 RID: 9848 RVA: 0x000D9338 File Offset: 0x000D7538
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 269f)
			{
				this.HBJJOCHGOPH = 1728f;
			}
			this.LMLENGFLEBD().SetFloat("_Value3", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("id", this.Dissipation);
			this.LMLENGFLEBD().SetFloat("Dance", this.LHFNOLGKGMO);
			this.ACHNOHCLGOO().SetFloat("_EmissionColor", this.NEJIJAPDALK);
			this.MMOODGIODPC().SetFloat("JoinTeam was called in state: ", this.CCIENBFIKKH);
			this.LNLKMDPHDCC().SetVector("_CurveTex", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1104f, 1811f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002679 RID: 9849 RVA: 0x000D9438 File Offset: 0x000D7638
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1283f)
			{
				this.HBJJOCHGOPH = 272f;
			}
			this.DOHGBNPMBKG().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.GKILCDHJFEG().SetFloat("G:", this.Dissipation);
			this.MMOODGIODPC().SetFloat("Overlay", this.LHFNOLGKGMO);
			this.OHKGGPFGLFD().SetFloat("_Value", this.NEJIJAPDALK);
			this.GHHPOGODBHB().SetFloat("_TimeX", this.CCIENBFIKKH);
			this.MFHPKGICPIO().SetVector(" This is not possible to be called for standalone input. Please check your platform and code where this is called", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1394f, 786f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OHKGGPFGLFD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600267A RID: 9850 RVA: 0x000D9537 File Offset: 0x000D7737
	private void EIMNPCMHJLJ()
	{
		this.SCShader = Shader.Find("LT");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600267B RID: 9851 RVA: 0x000D955B File Offset: 0x000D775B
	private void MDNHCLKNCLE()
	{
		this.SCShader = Shader.Find("<not connected>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600267C RID: 9852 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x0600267D RID: 9853 RVA: 0x000D9580 File Offset: 0x000D7780
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 448f)
			{
				this.HBJJOCHGOPH = 100f;
			}
			this.ACHNOHCLGOO().SetFloat("0,7,true,0", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("[MapsData] User's maps was loaded", this.Dissipation);
			this.GKILCDHJFEG().SetFloat(":</b> ", this.LHFNOLGKGMO);
			this.MLMKCOINOOH().SetFloat("Set sun lerp speed", this.NEJIJAPDALK);
			this.ALABBJPHCNG().SetFloat("CameraFilterPack/Blend2Camera_Exclusion", this.CCIENBFIKKH);
			this.PHGCJOPFDOG().SetVector("Joystick1Button11", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 58f, 285f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600267E RID: 9854 RVA: 0x0002523B File Offset: 0x0002343B
	private void MBLDJEFBLFL()
	{
	}

	// Token: 0x0600267F RID: 9855 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002680 RID: 9856 RVA: 0x000D967F File Offset: 0x000D787F
	private void ECBILENEOOL()
	{
		this.SCShader = Shader.Find("/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002681 RID: 9857 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void CNDACAHCCOI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002682 RID: 9858 RVA: 0x000D96A3 File Offset: 0x000D78A3
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002683 RID: 9859 RVA: 0x000D96DA File Offset: 0x000D78DA
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("_Bullet_6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002684 RID: 9860 RVA: 0x000D96FE File Offset: 0x000D78FE
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-83);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002685 RID: 9861 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002686 RID: 9862 RVA: 0x000D9735 File Offset: 0x000D7935
	private void CCFEDENFNEF()
	{
		this.SCShader = Shader.Find("Added unlock condition");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002688 RID: 9864 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x06002689 RID: 9865 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600268A RID: 9866 RVA: 0x000D9798 File Offset: 0x000D7998
	private Material ALABBJPHCNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)92;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600268B RID: 9867 RVA: 0x000D97CF File Offset: 0x000D79CF
	private Material LMLENGFLEBD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.NotEditable;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600268C RID: 9868 RVA: 0x000D9806 File Offset: 0x000D7A06
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600268D RID: 9869 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600268E RID: 9870 RVA: 0x000D983D File Offset: 0x000D7A3D
	private void NEFHGMNAPEP()
	{
		this.SCShader = Shader.Find("Joystick1Button9");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600268F RID: 9871 RVA: 0x000D9864 File Offset: 0x000D7A64
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 652f)
			{
				this.HBJJOCHGOPH = 745f;
			}
			this.IIJMIPBMMBF().SetFloat("DPADVER", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("settings.enablehitsoundsinrelax", this.Dissipation);
			this.NBPKMLMCHFN.SetFloat("DPADHOR", this.LHFNOLGKGMO);
			this.LMLENGFLEBD().SetFloat("_Saturation", this.NEJIJAPDALK);
			this.MMOODGIODPC().SetFloat("RecieveChatMessage", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_Value9", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 17f, 636f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002690 RID: 9872 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002691 RID: 9873 RVA: 0x000D9964 File Offset: 0x000D7B64
	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 933f)
			{
				this.HBJJOCHGOPH = 789f;
			}
			this.LNLKMDPHDCC().SetFloat(".lastCheckpoint.isMapCompleted", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("[LocalizationService] Loading file: ", this.Dissipation);
			this.DBOLLHHMKKN().SetFloat("Fade", this.LHFNOLGKGMO);
			this.NBPKMLMCHFN.SetFloat("clear", this.NEJIJAPDALK);
			this.IIJMIPBMMBF().SetFloat("RequestSelectedLevel", this.CCIENBFIKKH);
			this.DBOLLHHMKKN().SetVector("Mid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1171f, 1474f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002692 RID: 9874 RVA: 0x000D9A64 File Offset: 0x000D7C64
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 53f)
			{
				this.HBJJOCHGOPH = 1901f;
			}
			this.MMOODGIODPC().SetFloat("mapselector.filter.favoriteonly", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("settings.cameramovements", this.Dissipation);
			this.ALABBJPHCNG().SetFloat(".played", this.LHFNOLGKGMO);
			this.PHGCJOPFDOG().SetFloat("Type of observed is unknown when receiving.", this.NEJIJAPDALK);
			this.HNFFHCLNBDN().SetFloat("CameraFilterPack/Gradients_FireGradient", this.CCIENBFIKKH);
			this.DOHGBNPMBKG().SetVector("Type \"help\" for list of commands", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 195f, 234f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002693 RID: 9875 RVA: 0x000D9B64 File Offset: 0x000D7D64
	private void IHAAHFFMJLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1119f)
			{
				this.HBJJOCHGOPH = 1860f;
			}
			this.MLMKCOINOOH().SetFloat("CameraFilterPack/EXTRA_SHOWFPS", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("_ScreenResolution", this.Dissipation);
			this.LNLKMDPHDCC().SetFloat("SelectionBox component must be placed on a canvas in Screen Space Overlay mode.", this.LHFNOLGKGMO);
			this.GKILCDHJFEG().SetFloat("CameraFilterPack/Glitch_Mozaic", this.NEJIJAPDALK);
			this.MMOODGIODPC().SetFloat("IntraTime", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_Value6", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 985f, 218f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002694 RID: 9876 RVA: 0x000D9C63 File Offset: 0x000D7E63
	private void IKDNLHLBHID()
	{
		this.SCShader = Shader.Find("settings.showHP");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002695 RID: 9877 RVA: 0x000D9C87 File Offset: 0x000D7E87
	private void MKOMIDCPCDC()
	{
		this.SCShader = Shader.Find("GameModeText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002696 RID: 9878 RVA: 0x000D9CAC File Offset: 0x000D7EAC
	private void OLFAPNGMBPL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 269f)
			{
				this.HBJJOCHGOPH = 1434f;
			}
			this.PHGCJOPFDOG().SetFloat("CameraFilterPack/EXTRA_SHOWFPS", this.HBJJOCHGOPH);
			this.ALABBJPHCNG().SetFloat("Tab2Content", this.Dissipation);
			this.LMLENGFLEBD().SetFloat("_Value3", this.LHFNOLGKGMO);
			this.HNFFHCLNBDN().SetFloat("Error in Instantiation! The resource's PhotonView count is not the same as in incoming data.", this.NEJIJAPDALK);
			this.PHGCJOPFDOG().SetFloat("_Speed", this.CCIENBFIKKH);
			this.DOHGBNPMBKG().SetVector("(\\[ */ *quote *\\])", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1706f, 803f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002697 RID: 9879 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void ANDELGODEOC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002698 RID: 9880 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06002699 RID: 9881 RVA: 0x000D9DAC File Offset: 0x000D7FAC
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1485f)
			{
				this.HBJJOCHGOPH = 1916f;
			}
			this.MLMKCOINOOH().SetFloat("CameraFilterPack_RainFX_Anm2", this.HBJJOCHGOPH);
			this.ALABBJPHCNG().SetFloat("event", this.Dissipation);
			this.LNLKMDPHDCC().SetFloat("_Amount", this.LHFNOLGKGMO);
			this.NBPKMLMCHFN.SetFloat("restrictions\n\n#until: ", this.NEJIJAPDALK);
			this.LMLENGFLEBD().SetFloat("inventory.selected.", this.CCIENBFIKKH);
			this.IIJMIPBMMBF().SetVector("_Value6", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 911f, 1141f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600269A RID: 9882 RVA: 0x0002523B File Offset: 0x0002343B
	private void IBHACCEEFFI()
	{
	}

	// Token: 0x0600269B RID: 9883 RVA: 0x000D9EAC File Offset: 0x000D80AC
	private void NFJFHPCMEGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1887f)
			{
				this.HBJJOCHGOPH = 1971f;
			}
			this.PHGCJOPFDOG().SetFloat("_DistortionSize", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("[ItemsHandler] Found ", this.Dissipation);
			this.DOHGBNPMBKG().SetFloat("challenges.", this.LHFNOLGKGMO);
			this.DOHGBNPMBKG().SetFloat("CameraFilterPack/Blend2Camera_SplitScreen3D", this.NEJIJAPDALK);
			this.LNLKMDPHDCC().SetFloat("_Offsets", this.CCIENBFIKKH);
			this.MLMKCOINOOH().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1138f, 76f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600269C RID: 9884 RVA: 0x000D9FAB File Offset: 0x000D81AB
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600269D RID: 9885 RVA: 0x000D9FD0 File Offset: 0x000D81D0
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
			this.NBPKMLMCHFN.SetFloat("_Value", this.Dissipation);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.LHFNOLGKGMO);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.NEJIJAPDALK);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.CCIENBFIKKH);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x1700006C RID: 108
	// (get) Token: 0x0600269E RID: 9886 RVA: 0x000DA0CF File Offset: 0x000D82CF
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

	// Token: 0x0600269F RID: 9887 RVA: 0x000DA108 File Offset: 0x000D8308
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1824f)
			{
				this.HBJJOCHGOPH = 377f;
			}
			this.DBOLLHHMKKN().SetFloat("EnvironmentSlider", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat(" ", this.Dissipation);
			this.MLMKCOINOOH().SetFloat("addNewButton", this.LHFNOLGKGMO);
			this.HNFFHCLNBDN().SetFloat("_Value", this.NEJIJAPDALK);
			this.OHKGGPFGLFD().SetFloat("BlockSize", this.CCIENBFIKKH);
			this.OHKGGPFGLFD().SetVector("_Value", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 235f, 965f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060026A0 RID: 9888 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void HLHJBJGEEEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060026A1 RID: 9889 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060026A2 RID: 9890 RVA: 0x000DA208 File Offset: 0x000D8408
	private void HHJBIALGCME(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 61f)
			{
				this.HBJJOCHGOPH = 762f;
			}
			this.LMLENGFLEBD().SetFloat("[ResourcesManager] Load image error: ", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this.Dissipation);
			this.MFHPKGICPIO().SetFloat("Warning, using scrollbors with the Scroll Snap controls is not advised as it causes unpredictable results", this.LHFNOLGKGMO);
			this.GHHPOGODBHB().SetFloat("_Fade", this.NEJIJAPDALK);
			this.EFDEIFCDAFG().SetFloat("ws://", this.CCIENBFIKKH);
			this.GKILCDHJFEG().SetVector("SpeedSlider", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 461f, 1766f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KEMAALEODNH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060026A3 RID: 9891 RVA: 0x000DA307 File Offset: 0x000D8507
	private void COOHIILCOCO()
	{
		this.SCShader = Shader.Find("[SERVER] Kicked ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060026A4 RID: 9892 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x060026A5 RID: 9893 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x060026A6 RID: 9894 RVA: 0x000DA32B File Offset: 0x000D852B
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060026A7 RID: 9895 RVA: 0x000DA362 File Offset: 0x000D8562
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060026A8 RID: 9896 RVA: 0x000DA39C File Offset: 0x000D859C
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1511f)
			{
				this.HBJJOCHGOPH = 573f;
			}
			this.GKILCDHJFEG().SetFloat("blue", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("Set sun lerp speed", this.Dissipation);
			this.GHHPOGODBHB().SetFloat("_Value", this.LHFNOLGKGMO);
			this.ALABBJPHCNG().SetFloat("menu.enableselectormusic", this.NEJIJAPDALK);
			this.GKILCDHJFEG().SetFloat("NO", this.CCIENBFIKKH);
			this.MLMKCOINOOH().SetVector("_HalfResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1805f, 550f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060026A9 RID: 9897 RVA: 0x000DA49B File Offset: 0x000D869B
	private void LFAFJKJAEEL()
	{
		this.SCShader = Shader.Find("UseFinalGlassColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060026AA RID: 9898 RVA: 0x000DA4C0 File Offset: 0x000D86C0
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1110f)
			{
				this.HBJJOCHGOPH = 711f;
			}
			this.MLMKCOINOOH().SetFloat("CameraFilterPack/3D_Ghost", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("_TimeX", this.Dissipation);
			this.KEMAALEODNH().SetFloat("\\\\", this.LHFNOLGKGMO);
			this.ALABBJPHCNG().SetFloat("Set Sun Lerp Speed", this.NEJIJAPDALK);
			this.GHHPOGODBHB().SetFloat("clear", this.CCIENBFIKKH);
			this.DONENAMLFLF().SetVector("CameraFilterPack/Alien_Vision", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 499f, 1620f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LMLENGFLEBD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060026AB RID: 9899 RVA: 0x000DA5BF File Offset: 0x000D87BF
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("_Value6");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060026AC RID: 9900 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060026AD RID: 9901 RVA: 0x000DA5E3 File Offset: 0x000D87E3
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_Dissipation");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060026AE RID: 9902 RVA: 0x000DA608 File Offset: 0x000D8808
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 601f)
			{
				this.HBJJOCHGOPH = 828f;
			}
			this.DOHGBNPMBKG().SetFloat(".lastCheckpoint.correctScore", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Populate Mesh Data", this.Dissipation);
			this.IIJMIPBMMBF().SetFloat("LocalPlayer is null or not in mActors! LocalPlayer: {0} mActors==null: {1} newID: {2}", this.LHFNOLGKGMO);
			this.PHGCJOPFDOG().SetFloat("_Value5", this.NEJIJAPDALK);
			this.DONENAMLFLF().SetFloat("_DiffuseColor", this.CCIENBFIKKH);
			this.KEMAALEODNH().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 558f, 1744f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ALABBJPHCNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060026AF RID: 9903 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x060026B0 RID: 9904 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void GJLKJAOBPJD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060026B1 RID: 9905 RVA: 0x0002523B File Offset: 0x0002343B
	private void COGBDFKOHKK()
	{
	}

	// Token: 0x060026B2 RID: 9906 RVA: 0x000DA707 File Offset: 0x000D8907
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060026B3 RID: 9907 RVA: 0x000DA72B File Offset: 0x000D892B
	private void NNCCPEBIAKH()
	{
		this.SCShader = Shader.Find("<color=#{0}>{1}</color>");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060026B4 RID: 9908 RVA: 0x000DA74F File Offset: 0x000D894F
	private void JONGNKNLLND()
	{
		this.SCShader = Shader.Find("0.00");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060026B5 RID: 9909 RVA: 0x000DA773 File Offset: 0x000D8973
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)119;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060026B6 RID: 9910 RVA: 0x000DA7AC File Offset: 0x000D89AC
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1124f)
			{
				this.HBJJOCHGOPH = 852f;
			}
			this.GHHPOGODBHB().SetFloat("player.russia", this.HBJJOCHGOPH);
			this.MFHPKGICPIO().SetFloat("_TimeX", this.Dissipation);
			this.GKILCDHJFEG().SetFloat("_Colorisation", this.LHFNOLGKGMO);
			this.KEMAALEODNH().SetFloat("offsets", this.NEJIJAPDALK);
			this.GHHPOGODBHB().SetFloat("_FixDistance", this.CCIENBFIKKH);
			this.DOHGBNPMBKG().SetVector("_Bloom2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1443f, 1917f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ALABBJPHCNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060026B7 RID: 9911 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060026B8 RID: 9912 RVA: 0x000DA8AC File Offset: 0x000D8AAC
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 229f)
			{
				this.HBJJOCHGOPH = 613f;
			}
			this.MLMKCOINOOH().SetFloat("_Red_G", this.HBJJOCHGOPH);
			this.MMOODGIODPC().SetFloat("<b>Intralism Items Uploader</b> by Oxy949", this.Dissipation);
			this.GHHPOGODBHB().SetFloat("The appId this client sent is unknown on the server (Cloud). Check settings. If using the Cloud, check account.", this.LHFNOLGKGMO);
			this.NBPKMLMCHFN.SetFloat("_Value", this.NEJIJAPDALK);
			this.KEMAALEODNH().SetFloat("[Up-Right-Left]", this.CCIENBFIKKH);
			this.LMLENGFLEBD().SetVector("float,1.5", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1925f, 459f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060026B9 RID: 9913 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060026BA RID: 9914 RVA: 0x000DA9AB File Offset: 0x000D8BAB
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060026BB RID: 9915 RVA: 0x000DA9D0 File Offset: 0x000D8BD0
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 581f)
			{
				this.HBJJOCHGOPH = 1848f;
			}
			this.MFHPKGICPIO().SetFloat("SelectorMapsCountSlider", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("{0}", this.Dissipation);
			this.LMLENGFLEBD().SetFloat("PS Home", this.LHFNOLGKGMO);
			this.OHKGGPFGLFD().SetFloat("checkpoint", this.NEJIJAPDALK);
			this.MMOODGIODPC().SetFloat("_Size", this.CCIENBFIKKH);
			this.DBOLLHHMKKN().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 986f, 591f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060026BC RID: 9916 RVA: 0x000DAACF File Offset: 0x000D8CCF
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find("Other");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060026BD RID: 9917 RVA: 0x000D96A3 File Offset: 0x000D78A3
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060026BE RID: 9918 RVA: 0x000DAAF3 File Offset: 0x000D8CF3
	private Material PHGCJOPFDOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-125);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060026BF RID: 9919 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x060026C0 RID: 9920 RVA: 0x000DAB2A File Offset: 0x000D8D2A
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-112);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060026C1 RID: 9921 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x060026C2 RID: 9922 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void BDBJEDIOKBN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060026C3 RID: 9923 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060026C4 RID: 9924 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060026C5 RID: 9925 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x060026C6 RID: 9926 RVA: 0x000DAB61 File Offset: 0x000D8D61
	private void BMIOFJFMCBG()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060026C7 RID: 9927 RVA: 0x000DAB85 File Offset: 0x000D8D85
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("restrictions");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060026C8 RID: 9928 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060026C9 RID: 9929 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x060026CA RID: 9930 RVA: 0x000DABA9 File Offset: 0x000D8DA9
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Luminosity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060026CB RID: 9931 RVA: 0x000DABCD File Offset: 0x000D8DCD
	private Material MLMKCOINOOH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060026CC RID: 9932 RVA: 0x0002523B File Offset: 0x0002343B
	private void GHILDCBCDJI()
	{
	}

	// Token: 0x060026CD RID: 9933 RVA: 0x000DAC04 File Offset: 0x000D8E04
	private void MJEFMIPLFAB()
	{
		this.SCShader = Shader.Find("UnAllocateViewID() should be called after the PhotonView was destroyed (GameObject.Destroy()). ViewID: {0} still found in: {1}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060026CE RID: 9934 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void EDCMIPNCPLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060026CF RID: 9935 RVA: 0x0002523B File Offset: 0x0002343B
	private void MDCFIHDPLIG()
	{
	}

	// Token: 0x060026D0 RID: 9936 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060026D1 RID: 9937 RVA: 0x000DAC28 File Offset: 0x000D8E28
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060026D2 RID: 9938 RVA: 0x000DAC4C File Offset: 0x000D8E4C
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060026D3 RID: 9939 RVA: 0x000DAC70 File Offset: 0x000D8E70
	private void HDMDKOKOOJC()
	{
		this.SCShader = Shader.Find("\n\n#");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060026D4 RID: 9940 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060026D5 RID: 9941 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060026D6 RID: 9942 RVA: 0x0002523B File Offset: 0x0002343B
	private void OBAEDJJDCPN()
	{
	}

	// Token: 0x060026D7 RID: 9943 RVA: 0x000DAC94 File Offset: 0x000D8E94
	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1667f)
			{
				this.HBJJOCHGOPH = 1335f;
			}
			this.EFDEIFCDAFG().SetFloat("#discord{0}joinrequest", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("OpJoinRandomRoom()", this.Dissipation);
			this.LMLENGFLEBD().SetFloat("_ScreenResolution", this.LHFNOLGKGMO);
			this.LNLKMDPHDCC().SetFloat("Drop_With_Obj", this.NEJIJAPDALK);
			this.DBOLLHHMKKN().SetFloat("/", this.CCIENBFIKKH);
			this.MFHPKGICPIO().SetVector("_TapMedium", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 492f, 835f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060026D8 RID: 9944 RVA: 0x000DAD94 File Offset: 0x000D8F94
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 353f)
			{
				this.HBJJOCHGOPH = 1571f;
			}
			this.EFDEIFCDAFG().SetFloat("_Visualize", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("_Amount", this.Dissipation);
			this.PHGCJOPFDOG().SetFloat("_ScreenResolution", this.LHFNOLGKGMO);
			this.DBOLLHHMKKN().SetFloat("ResetSpeed", this.NEJIJAPDALK);
			this.MLMKCOINOOH().SetFloat("_ScreenResolution", this.CCIENBFIKKH);
			this.MMOODGIODPC().SetVector("/../", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 19f, 274f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GHHPOGODBHB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060026D9 RID: 9945 RVA: 0x000DAE94 File Offset: 0x000D9094
	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 230f)
			{
				this.HBJJOCHGOPH = 1465f;
			}
			this.MFHPKGICPIO().SetFloat("CameraFilterPack/Edge_Edge_filter", this.HBJJOCHGOPH);
			this.PHGCJOPFDOG().SetFloat("UpdateNewsTileStart", this.Dissipation);
			this.PHGCJOPFDOG().SetFloat("Error: I/O Failure", this.LHFNOLGKGMO);
			this.MFHPKGICPIO().SetFloat("sfxVolume", this.NEJIJAPDALK);
			this.LNLKMDPHDCC().SetFloat("_BlurredColor", this.CCIENBFIKKH);
			this.LNLKMDPHDCC().SetVector("menu.tabid", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1625f, 748f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060026DA RID: 9946 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x060026DB RID: 9947 RVA: 0x000DAF93 File Offset: 0x000D9193
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060026DC RID: 9948 RVA: 0x000D8F52 File Offset: 0x000D7152
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060026DD RID: 9949 RVA: 0x000DAFCC File Offset: 0x000D91CC
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 278f)
			{
				this.HBJJOCHGOPH = 1757f;
			}
			this.GHHPOGODBHB().SetFloat("_WaveIntensity", this.HBJJOCHGOPH);
			this.DONENAMLFLF().SetFloat("_MainTex2", this.Dissipation);
			this.OHKGGPFGLFD().SetFloat("Received RPC \"", this.LHFNOLGKGMO);
			this.GHHPOGODBHB().SetFloat("_Screen", this.NEJIJAPDALK);
			this.PHGCJOPFDOG().SetFloat("[PlayerBase] Starting new round", this.CCIENBFIKKH);
			this.EFDEIFCDAFG().SetVector("Hidden/Image Effects/Cinematic/AmbientOcclusion", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 863f, 1643f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060026DE RID: 9950 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x060026DF RID: 9951 RVA: 0x000DB0CB File Offset: 0x000D92CB
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find("CameraFilterPack/FX_InverChromiLum");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060026E0 RID: 9952 RVA: 0x000DB0EF File Offset: 0x000D92EF
	private void DBLILJGKGHJ()
	{
		this.SCShader = Shader.Find("_LightIntensity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x040004DC RID: 1244
	public Shader SCShader;

	// Token: 0x040004DD RID: 1245
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040004DE RID: 1246
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040004DF RID: 1247
	private Material BJFKDHHMLJH;

	// Token: 0x040004E0 RID: 1248
	[Range(0f, 2.99f)]
	public float Dissipation = 1f;

	// Token: 0x040004E1 RID: 1249
	[Range(0f, 16f)]
	private float LHFNOLGKGMO = 11f;

	// Token: 0x040004E2 RID: 1250
	[Range(-1f, 1f)]
	private float NEJIJAPDALK = 1f;

	// Token: 0x040004E3 RID: 1251
	[Range(0f, 10f)]
	private float CCIENBFIKKH = 1f;
}
