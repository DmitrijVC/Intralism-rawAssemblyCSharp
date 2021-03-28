using System;
using UnityEngine;

// Token: 0x0200009D RID: 157
[AddComponentMenu("Camera Filter Pack/Drawing/EnhancedComics")]
[ExecuteInEditMode]
public class CameraFilterPack_Drawing_EnhancedComics : MonoBehaviour
{
	// Token: 0x06002F7E RID: 12158 RVA: 0x000FC724 File Offset: 0x000FA924
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 488f)
			{
				this.HBJJOCHGOPH = 912f;
			}
			this.DKKBFFHBHJE().SetFloat("_Offsets", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("offsets", this.DotSize);
			this.CFEDGDGBCHE().SetFloat("_ScreenResolution", this._ColorR);
			this.DKKBFFHBHJE().SetFloat("_Value5", this._ColorG);
			this.HNICHJCGJOC().SetFloat("B", this._ColorB);
			this.BFGNMFCNDBC().SetFloat(".lastCheckpoint.checkpointsUsed", this._Blood);
			this.NJDIODJNGGA().SetColor("id", this.ColorRGB);
			this.DBOLLHHMKKN().SetFloat("id", this._SmoothStart);
			this.OKJOKHGJHGF().SetFloat("editor.", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F7F RID: 12159 RVA: 0x000FC850 File Offset: 0x000FAA50
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1329f)
			{
				this.HBJJOCHGOPH = 1006f;
			}
			this.FHFLKLMFHOI().SetFloat("Emergency Help:", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("value", this.DotSize);
			this.FHFLKLMFHOI().SetFloat("error", this._ColorR);
			this.MCDGIILBNIF().SetFloat("_TimeX", this._ColorG);
			this.NJDIODJNGGA().SetFloat("OpJoinLobby()", this._ColorB);
			this.HNICHJCGJOC().SetFloat("Tab1Content", this._Blood);
			this.NJDIODJNGGA().SetColor("[Up]", this.ColorRGB);
			this.CFEDGDGBCHE().SetFloat("_ScreenResolution", this._SmoothStart);
			this.CFEDGDGBCHE().SetFloat("Creating awesome maps", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F80 RID: 12160 RVA: 0x000FC97A File Offset: 0x000FAB7A
	private void BJOHDLNDFAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F81 RID: 12161 RVA: 0x000FC998 File Offset: 0x000FAB98
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 405f)
			{
				this.HBJJOCHGOPH = 1875f;
			}
			this.NBPKMLMCHFN.SetFloat("#forever", this.HBJJOCHGOPH);
			this.EJDPNJAEAKJ().SetFloat("Only the Master Client can AllocateSceneViewID(). Check PhotonNetwork.isMasterClient!", this.DotSize);
			this.BFGNMFCNDBC().SetFloat("_Vignetting", this._ColorR);
			this.ACHNOHCLGOO().SetFloat("curScn", this._ColorG);
			this.DBOLLHHMKKN().SetFloat("Tab1Content", this._ColorB);
			this.NJDIODJNGGA().SetFloat("_Red_B", this._Blood);
			this.EFDEIFCDAFG().SetColor("offsets", this.ColorRGB);
			this.BFGNMFCNDBC().SetFloat("_LutTex", this._SmoothStart);
			this.ACHNOHCLGOO().SetFloat("#failed!", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKKBFFHBHJE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F82 RID: 12162 RVA: 0x000FCAC4 File Offset: 0x000FACC4
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 877f)
			{
				this.HBJJOCHGOPH = 131f;
			}
			this.DKKBFFHBHJE().SetFloat("Using clickAlphaThreshold lower than 1 on Image whose sprite texture cannot be read. ", this.HBJJOCHGOPH);
			this.HNICHJCGJOC().SetFloat("menu.selectedplaymode", this.DotSize);
			this.EFDEIFCDAFG().SetFloat("CameraFilterPack/Distortion_Dream", this._ColorR);
			this.NLFJGMBCICG().SetFloat("catched: ", this._ColorG);
			this.AELJLBOJAIL().SetFloat("_VelocityScale", this._ColorB);
			this.DOHGBNPMBKG().SetFloat("_Value4", this._Blood);
			this.HNICHJCGJOC().SetColor("SetEnvSpriteColor", this.ColorRGB);
			this.FHFLKLMFHOI().SetFloat("_History2ChromaTex", this._SmoothStart);
			this.NLFJGMBCICG().SetFloat("PhotonView with ID ", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F83 RID: 12163 RVA: 0x000FCBEE File Offset: 0x000FADEE
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F84 RID: 12164 RVA: 0x000FCC25 File Offset: 0x000FAE25
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("ls");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002F85 RID: 12165 RVA: 0x000FCC4C File Offset: 0x000FAE4C
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1175f)
			{
				this.HBJJOCHGOPH = 1218f;
			}
			this.ACHNOHCLGOO().SetFloat("/config", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("_MainTex2", this.DotSize);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Fly_Vision", this._ColorR);
			this.DBOLLHHMKKN().SetFloat("_Green_C", this._ColorG);
			this.EJDPNJAEAKJ().SetFloat("settings.hitvariation", this._ColorB);
			this.EFDEIFCDAFG().SetFloat("TypedLobbyInfo '{0}'[{1}] rooms: {2} players: {3}", this._Blood);
			this.NBPKMLMCHFN.SetColor("\\", this.ColorRGB);
			this.AELJLBOJAIL().SetFloat("CameraFilterPack/FX_Dot_Circle", this._SmoothStart);
			this.ACHNOHCLGOO().SetFloat("Prints list of all previous commands", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F86 RID: 12166 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x06002F87 RID: 12167 RVA: 0x000FCD78 File Offset: 0x000FAF78
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 504f)
			{
				this.HBJJOCHGOPH = 1270f;
			}
			this.AELJLBOJAIL().SetFloat("Keypad", this.HBJJOCHGOPH);
			this.DOHGBNPMBKG().SetFloat("_TimeX", this.DotSize);
			this.BFGNMFCNDBC().SetFloat("Can't find PhotonView of incoming OwnershipRequest. ViewId not found: ", this._ColorR);
			this.DBOLLHHMKKN().SetFloat("player.orangearc", this._ColorG);
			this.MCDGIILBNIF().SetFloat("_Radius2", this._ColorB);
			this.EFDEIFCDAFG().SetFloat("[ResourcesManager] Load audio error: ", this._Blood);
			this.NBPKMLMCHFN.SetColor("Failed to InstantiateSceneObject prefab: ", this.ColorRGB);
			this.FHFLKLMFHOI().SetFloat("CameraFilterPack_Atmosphere_Rain_FX", this._SmoothStart);
			this.BFGNMFCNDBC().SetFloat("EnableRankedNotificationsToggle", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F88 RID: 12168 RVA: 0x0002523B File Offset: 0x0002343B
	private void EJFJENFKLND()
	{
	}

	// Token: 0x06002F89 RID: 12169 RVA: 0x000FC97A File Offset: 0x000FAB7A
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F8A RID: 12170 RVA: 0x000FCEA2 File Offset: 0x000FB0A2
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F8B RID: 12171 RVA: 0x000FC97A File Offset: 0x000FAB7A
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F8D RID: 12173 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06002F8E RID: 12174 RVA: 0x000FC97A File Offset: 0x000FAB7A
	private void NJHJHBOJKIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F8F RID: 12175 RVA: 0x000FCF64 File Offset: 0x000FB164
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 341f)
			{
				this.HBJJOCHGOPH = 1433f;
			}
			this.MCDGIILBNIF().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetFloat(" TimeOfRespawn: ", this.DotSize);
			this.ACHNOHCLGOO().SetFloat("colorD", this._ColorR);
			this.NLFJGMBCICG().SetFloat("_TimeX", this._ColorG);
			this.MCDGIILBNIF().SetFloat("_MainTex", this._ColorB);
			this.ACHNOHCLGOO().SetFloat("settings.enablerankingnotifications", this._Blood);
			this.AELJLBOJAIL().SetColor("{0} months ago", this.ColorRGB);
			this.BFGNMFCNDBC().SetFloat("#yes", this._SmoothStart);
			this.NBPKMLMCHFN.SetFloat("OnReadyClick", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F90 RID: 12176 RVA: 0x000FD08E File Offset: 0x000FB28E
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("settings.shaders.bloomintencity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002F91 RID: 12177 RVA: 0x000FD0B2 File Offset: 0x000FB2B2
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F92 RID: 12178 RVA: 0x000FD0EC File Offset: 0x000FB2EC
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 449f)
			{
				this.HBJJOCHGOPH = 858f;
			}
			this.EFDEIFCDAFG().SetFloat("JITTER", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat(".lastCheckpoint.checkpointsUsed", this.DotSize);
			this.NBPKMLMCHFN.SetFloat("_FarCamera", this._ColorR);
			this.FHFLKLMFHOI().SetFloat("shader.ghost", this._ColorG);
			this.DKKBFFHBHJE().SetFloat(" != ", this._ColorB);
			this.EFDEIFCDAFG().SetFloat("value", this._Blood);
			this.NBPKMLMCHFN.SetColor(",viewkeys", this.ColorRGB);
			this.ACHNOHCLGOO().SetFloat("maps.", this._SmoothStart);
			this.BFGNMFCNDBC().SetFloat("</color>", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F93 RID: 12179 RVA: 0x000FD216 File Offset: 0x000FB416
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002F94 RID: 12180 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06002F95 RID: 12181 RVA: 0x000FD23C File Offset: 0x000FB43C
	private void IFPOOKJLOJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1966f)
			{
				this.HBJJOCHGOPH = 1702f;
			}
			this.EFDEIFCDAFG().SetFloat("Bad parameters for init! Use \"init\" or \"init <savename>\"", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("_Distortion", this.DotSize);
			this.BFGNMFCNDBC().SetFloat("_TimeX", this._ColorR);
			this.FHFLKLMFHOI().SetFloat("achievements.id", this._ColorG);
			this.NLFJGMBCICG().SetFloat("_ScreenResolution", this._ColorB);
			this.DBOLLHHMKKN().SetFloat("PLAY [SPACE]", this._Blood);
			this.EFDEIFCDAFG().SetColor("_Distortion", this.ColorRGB);
			this.CFEDGDGBCHE().SetFloat("2;13;14;15;16", this._SmoothStart);
			this.HNICHJCGJOC().SetFloat("_TreatBackfaceHitAsMiss", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F96 RID: 12182 RVA: 0x000FD368 File Offset: 0x000FB568
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1198f)
			{
				this.HBJJOCHGOPH = 379f;
			}
			this.DKKBFFHBHJE().SetFloat("FinishMap", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("#availablechallenges", this.DotSize);
			this.DOHGBNPMBKG().SetFloat("float,1", this._ColorR);
			this.DKNJGHFLAIF().SetFloat("_NeutralTonemapperParams1", this._ColorG);
			this.NBPKMLMCHFN.SetFloat("[DiscordController] Join ({0})", this._ColorB);
			this.EJDPNJAEAKJ().SetFloat("[PlayerController] ", this._Blood);
			this.DOHGBNPMBKG().SetColor("AmbientOcclusion", this.ColorRGB);
			this.CFEDGDGBCHE().SetFloat("Missing shader in ", this._SmoothStart);
			this.DKKBFFHBHJE().SetFloat("ERROR: Preview file must be <1MB!", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F97 RID: 12183 RVA: 0x000FD492 File Offset: 0x000FB692
	private Material DKKBFFHBHJE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-124);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F98 RID: 12184 RVA: 0x000FD4CC File Offset: 0x000FB6CC
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1067f)
			{
				this.HBJJOCHGOPH = 1714f;
			}
			this.BFGNMFCNDBC().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("true", this.DotSize);
			this.HNICHJCGJOC().SetFloat("_QualitySettings", this._ColorR);
			this.CFEDGDGBCHE().SetFloat("_Color", this._ColorG);
			this.EFDEIFCDAFG().SetFloat("Dance", this._ColorB);
			this.MCDGIILBNIF().SetFloat("sfxVolume", this._Blood);
			this.NBPKMLMCHFN.SetColor("Set satellite lerp speed", this.ColorRGB);
			this.DKKBFFHBHJE().SetFloat("_Value", this._SmoothStart);
			this.DKNJGHFLAIF().SetFloat("GameScene", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F99 RID: 12185 RVA: 0x000FD5F6 File Offset: 0x000FB7F6
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-101);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002F9A RID: 12186 RVA: 0x000FD62D File Offset: 0x000FB82D
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_EnhancedComics");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002F9B RID: 12187 RVA: 0x000FC97A File Offset: 0x000FAB7A
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F9C RID: 12188 RVA: 0x000FD654 File Offset: 0x000FB854
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1642f)
			{
				this.HBJJOCHGOPH = 1826f;
			}
			this.EFDEIFCDAFG().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat(".", this.DotSize);
			this.BFGNMFCNDBC().SetFloat("_DepthLevel", this._ColorR);
			this.DBOLLHHMKKN().SetFloat("Gameplay/sun", this._ColorG);
			this.DKNJGHFLAIF().SetFloat("BitsData", this._ColorB);
			this.DOHGBNPMBKG().SetFloat(" ", this._Blood);
			this.NBPKMLMCHFN.SetColor("_EmissionGain", this.ColorRGB);
			this.ACHNOHCLGOO().SetFloat("not available at the moment", this._SmoothStart);
			this.DOHGBNPMBKG().SetFloat("_Bullet_8", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002F9D RID: 12189 RVA: 0x000FD77E File Offset: 0x000FB97E
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("ResetSpeed");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002F9E RID: 12190 RVA: 0x000FC97A File Offset: 0x000FAB7A
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002F9F RID: 12191 RVA: 0x000FD7A4 File Offset: 0x000FB9A4
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1f)
			{
				this.HBJJOCHGOPH = 1447f;
			}
			this.NJDIODJNGGA().SetFloat("23x3", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("steamid", this.DotSize);
			this.BFGNMFCNDBC().SetFloat("Failed to InstantiateSceneObject prefab:", this._ColorR);
			this.DOHGBNPMBKG().SetFloat("Ev DestroyAll! By PlayerId: ", this._ColorG);
			this.NBPKMLMCHFN.SetFloat(", ", this._ColorB);
			this.DBOLLHHMKKN().SetFloat("_Value3", this._Blood);
			this.NBPKMLMCHFN.SetColor("_ScreenResolution", this.ColorRGB);
			this.EJDPNJAEAKJ().SetFloat("Preparing content", this._SmoothStart);
			this.EJDPNJAEAKJ().SetFloat("CameraFilterPack/TV_Rgb", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOHGBNPMBKG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FA0 RID: 12192 RVA: 0x000FD8CE File Offset: 0x000FBACE
	private Material NJDIODJNGGA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-108);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002FA1 RID: 12193 RVA: 0x000FD908 File Offset: 0x000FBB08
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1799f)
			{
				this.HBJJOCHGOPH = 259f;
			}
			this.HNICHJCGJOC().SetFloat("/icon", this.HBJJOCHGOPH);
			this.DBOLLHHMKKN().SetFloat("R:", this.DotSize);
			this.DKKBFFHBHJE().SetFloat("_TimeX", this._ColorR);
			this.OKJOKHGJHGF().SetFloat("_Value5", this._ColorG);
			this.DOHGBNPMBKG().SetFloat("CurrentTimeLabel", this._ColorB);
			this.HNICHJCGJOC().SetFloat("X", this._Blood);
			this.MCDGIILBNIF().SetColor("CurrentTimeLabel", this.ColorRGB);
			this.DBOLLHHMKKN().SetFloat("_Offsets", this._SmoothStart);
			this.BFGNMFCNDBC().SetFloat("Square", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x17000082 RID: 130
	// (get) Token: 0x06002FA2 RID: 12194 RVA: 0x000FDA32 File Offset: 0x000FBC32
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

	// Token: 0x06002FA3 RID: 12195 RVA: 0x000FDA69 File Offset: 0x000FBC69
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("76561198041679481");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002FA4 RID: 12196 RVA: 0x000FDA90 File Offset: 0x000FBC90
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 824f)
			{
				this.HBJJOCHGOPH = 428f;
			}
			this.DKKBFFHBHJE().SetFloat("2hands", this.HBJJOCHGOPH);
			this.NJDIODJNGGA().SetFloat("--------------------------------", this.DotSize);
			this.EJDPNJAEAKJ().SetFloat("_BlurDistance", this._ColorR);
			this.CFEDGDGBCHE().SetFloat("CameraFilterPack/TV_PlanetMars", this._ColorG);
			this.AELJLBOJAIL().SetFloat("_Level", this._ColorB);
			this.ACHNOHCLGOO().SetFloat("turn: {0:0}", this._Blood);
			this.DBOLLHHMKKN().SetColor("value", this.ColorRGB);
			this.AELJLBOJAIL().SetFloat("#ok", this._SmoothStart);
			this.NJDIODJNGGA().SetFloat("_MainTex2", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FA5 RID: 12197 RVA: 0x000FDBBC File Offset: 0x000FBDBC
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1344f)
			{
				this.HBJJOCHGOPH = 1377f;
			}
			this.DBOLLHHMKKN().SetFloat("ticket.ticket1", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("{0}\t is: {1}", this.DotSize);
			this.EFDEIFCDAFG().SetFloat(" GO:", this._ColorR);
			this.CFEDGDGBCHE().SetFloat("return CheckCondition()", this._ColorG);
			this.FHFLKLMFHOI().SetFloat("_TimeX", this._ColorB);
			this.MCDGIILBNIF().SetFloat("_VelocityScale", this._Blood);
			this.MCDGIILBNIF().SetColor("_EdgeWeight", this.ColorRGB);
			this.NBPKMLMCHFN.SetFloat("Object ID. Case-Sensitive", this._SmoothStart);
			this.AELJLBOJAIL().SetFloat("Tab2Content", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FA6 RID: 12198 RVA: 0x000FC97A File Offset: 0x000FAB7A
	private void FPHLDMMAOEF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002FA7 RID: 12199 RVA: 0x000FC97A File Offset: 0x000FAB7A
	private void PLBOFEPBPKC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002FA8 RID: 12200 RVA: 0x000FDCE8 File Offset: 0x000FBEE8
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1649f)
			{
				this.HBJJOCHGOPH = 95f;
			}
			this.CFEDGDGBCHE().SetFloat("remaining: {0:0.000}", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat("[Right-Left]", this.DotSize);
			this.AELJLBOJAIL().SetFloat("BloodAlternative2", this._ColorR);
			this.DBOLLHHMKKN().SetFloat("_Distortion", this._ColorG);
			this.EFDEIFCDAFG().SetFloat("<b>#", this._ColorB);
			this.DKKBFFHBHJE().SetFloat("ChangeSelectedLevel", this._Blood);
			this.MCDGIILBNIF().SetColor("_Near", this.ColorRGB);
			this.DBOLLHHMKKN().SetFloat("int", this._SmoothStart);
			this.EFDEIFCDAFG().SetFloat("#submit", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FA9 RID: 12201 RVA: 0x000FDE14 File Offset: 0x000FC014
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1608f)
			{
				this.HBJJOCHGOPH = 517f;
			}
			this.DKKBFFHBHJE().SetFloat("Case-Sensitive", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetFloat("CameraFilterPack/FX_superDot", this.DotSize);
			this.EFDEIFCDAFG().SetFloat("The observed monobehaviour (", this._ColorR);
			this.DKNJGHFLAIF().SetFloat("mapselector.filter.favoriteonly", this._ColorG);
			this.NBPKMLMCHFN.SetFloat(" [", this._ColorB);
			this.AELJLBOJAIL().SetFloat("id", this._Blood);
			this.NJDIODJNGGA().SetColor("Joystick1Button10", this.ColorRGB);
			this.EJDPNJAEAKJ().SetFloat("[LocalizationService] Loading file: ", this._SmoothStart);
			this.DKKBFFHBHJE().SetFloat("Particles/Additive", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FAA RID: 12202 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06002FAB RID: 12203 RVA: 0x000FDF40 File Offset: 0x000FC140
	private void KDFILLAPHIO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1419f)
			{
				this.HBJJOCHGOPH = 1777f;
			}
			this.HNICHJCGJOC().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat("VIGNETTE_BLUR", this.DotSize);
			this.OKJOKHGJHGF().SetFloat("<b>#", this._ColorR);
			this.NJDIODJNGGA().SetFloat("_ScreenResolution", this._ColorG);
			this.HNICHJCGJOC().SetFloat("#md5submitionfailed: ", this._ColorB);
			this.ACHNOHCLGOO().SetFloat("EnvironmentSlider", this._Blood);
			this.FHFLKLMFHOI().SetColor("hidden", this.ColorRGB);
			this.EJDPNJAEAKJ().SetFloat("#,0", this._SmoothStart);
			this.OKJOKHGJHGF().SetFloat("mapselector.filter.subscribedonly", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EJDPNJAEAKJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FAC RID: 12204 RVA: 0x000FC97A File Offset: 0x000FAB7A
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002FAD RID: 12205 RVA: 0x000FC97A File Offset: 0x000FAB7A
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002FAE RID: 12206 RVA: 0x000FE06A File Offset: 0x000FC26A
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002FAF RID: 12207 RVA: 0x000FE0A1 File Offset: 0x000FC2A1
	private Material EJDPNJAEAKJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002FB0 RID: 12208 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x06002FB1 RID: 12209 RVA: 0x000FE0D8 File Offset: 0x000FC2D8
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 896f)
			{
				this.HBJJOCHGOPH = 193f;
			}
			this.HNICHJCGJOC().SetFloat("1,30,true,0", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("Set Satellite Input", this.DotSize);
			this.AELJLBOJAIL().SetFloat("_Value2", this._ColorR);
			this.HNICHJCGJOC().SetFloat("<color=#{0}>{1}</color>", this._ColorG);
			this.DOHGBNPMBKG().SetFloat("CameraFilterPack/Blend2Camera_Exclusion", this._ColorB);
			this.MCDGIILBNIF().SetFloat("ViewMenu", this._Blood);
			this.OKJOKHGJHGF().SetColor("_Intensity", this.ColorRGB);
			this.NJDIODJNGGA().SetFloat("UseScanLine", this._SmoothStart);
			this.FHFLKLMFHOI().SetFloat("#close", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FB2 RID: 12210 RVA: 0x000FC97A File Offset: 0x000FAB7A
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002FB3 RID: 12211 RVA: 0x000FE202 File Offset: 0x000FC402
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-113);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002FB4 RID: 12212 RVA: 0x000FE239 File Offset: 0x000FC439
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find("%");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002FB5 RID: 12213 RVA: 0x000FC97A File Offset: 0x000FAB7A
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002FB6 RID: 12214 RVA: 0x000FE260 File Offset: 0x000FC460
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1329f)
			{
				this.HBJJOCHGOPH = 1863f;
			}
			this.EFDEIFCDAFG().SetFloat("settings.enablehitsoundsinnormal", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("GhostFade", this.DotSize);
			this.NBPKMLMCHFN.SetFloat("FullscreenToggle", this._ColorR);
			this.NBPKMLMCHFN.SetFloat("maps.", this._ColorG);
			this.HNICHJCGJOC().SetFloat("_Gain", this._ColorB);
			this.EJDPNJAEAKJ().SetFloat("_Far", this._Blood);
			this.DKNJGHFLAIF().SetColor(".lastCheckpoint.playerdistance", this.ColorRGB);
			this.DKKBFFHBHJE().SetFloat("_ScreenResolution", this._SmoothStart);
			this.DKKBFFHBHJE().SetFloat("Working.\nPlease wait..", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FB7 RID: 12215 RVA: 0x000FC97A File Offset: 0x000FAB7A
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002FB8 RID: 12216 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06002FB9 RID: 12217 RVA: 0x000FC97A File Offset: 0x000FAB7A
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002FBA RID: 12218 RVA: 0x000FE38A File Offset: 0x000FC58A
	private void MJEFMIPLFAB()
	{
		this.SCShader = Shader.Find("AudioSampler");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002FBB RID: 12219 RVA: 0x000FE3B0 File Offset: 0x000FC5B0
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1345f)
			{
				this.HBJJOCHGOPH = 762f;
			}
			this.HNICHJCGJOC().SetFloat("player.watermelon", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("DestroyPlayerObjects() failed, cause players can only destroy their own GameObjects. A Master Client can destroy anyone's. This is master: ", this.DotSize);
			this.DKNJGHFLAIF().SetFloat("Joystick1Button8", this._ColorR);
			this.OKJOKHGJHGF().SetFloat("CameraFilterPack/Drawing_Paper3", this._ColorG);
			this.EFDEIFCDAFG().SetFloat("1427616858", this._ColorB);
			this.EFDEIFCDAFG().SetFloat("</color>", this._Blood);
			this.NJDIODJNGGA().SetColor("_Value2", this.ColorRGB);
			this.NJDIODJNGGA().SetFloat("Hex value #RRGGBB", this._SmoothStart);
			this.BFGNMFCNDBC().SetFloat("TestTicket", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FBC RID: 12220 RVA: 0x000FE4DA File Offset: 0x000FC6DA
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002FBD RID: 12221 RVA: 0x000FC97A File Offset: 0x000FAB7A
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002FBE RID: 12222 RVA: 0x000FE511 File Offset: 0x000FC711
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)95;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002FBF RID: 12223 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x06002FC0 RID: 12224 RVA: 0x0002523B File Offset: 0x0002343B
	private void GCHBGCGBMCK()
	{
	}

	// Token: 0x06002FC1 RID: 12225 RVA: 0x000FE548 File Offset: 0x000FC748
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002FC2 RID: 12226 RVA: 0x000FE57F File Offset: 0x000FC77F
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("getbool");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002FC3 RID: 12227 RVA: 0x000FE5A3 File Offset: 0x000FC7A3
	private Material MCDGIILBNIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002FC4 RID: 12228 RVA: 0x000FC97A File Offset: 0x000FAB7A
	private void KKEOHFGKCIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002FC5 RID: 12229 RVA: 0x000FC97A File Offset: 0x000FAB7A
	private void KLOLKEBAPFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002FC6 RID: 12230 RVA: 0x000FE5DA File Offset: 0x000FC7DA
	private void OKLAJINHPAN()
	{
		this.SCShader = Shader.Find("ResourceFileSelector");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002FC7 RID: 12231 RVA: 0x000FE600 File Offset: 0x000FC800
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
			this.NBPKMLMCHFN.SetFloat("_DotSize", this.DotSize);
			this.NBPKMLMCHFN.SetFloat("_ColorR", this._ColorR);
			this.NBPKMLMCHFN.SetFloat("_ColorG", this._ColorG);
			this.NBPKMLMCHFN.SetFloat("_ColorB", this._ColorB);
			this.NBPKMLMCHFN.SetFloat("_Blood", this._Blood);
			this.NBPKMLMCHFN.SetColor("_ColorRGB", this.ColorRGB);
			this.NBPKMLMCHFN.SetFloat("_SmoothStart", this._SmoothStart);
			this.NBPKMLMCHFN.SetFloat("_SmoothEnd", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FC8 RID: 12232 RVA: 0x000FE72A File Offset: 0x000FC92A
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002FC9 RID: 12233 RVA: 0x000FE761 File Offset: 0x000FC961
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find(".completedCount");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002FCA RID: 12234 RVA: 0x000FE788 File Offset: 0x000FC988
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1486f)
			{
				this.HBJJOCHGOPH = 315f;
			}
			this.ACHNOHCLGOO().SetFloat("Called GetNumberOfCurrentPlayers()", this.HBJJOCHGOPH);
			this.DKKBFFHBHJE().SetFloat("[#clicktogetreward]", this.DotSize);
			this.MCDGIILBNIF().SetFloat("Tab2Content", this._ColorR);
			this.EFDEIFCDAFG().SetFloat("The other scroll rect doesnt support scrolling horizontally", this._ColorG);
			this.ACHNOHCLGOO().SetFloat("float,1.5", this._ColorB);
			this.CFEDGDGBCHE().SetFloat("icon", this._Blood);
			this.EFDEIFCDAFG().SetColor(" with prefix ", this.ColorRGB);
			this.DBOLLHHMKKN().SetFloat("GLITCH", this._SmoothStart);
			this.NLFJGMBCICG().SetFloat("ComboScoreText", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FCB RID: 12235 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x06002FCC RID: 12236 RVA: 0x000FE8B2 File Offset: 0x000FCAB2
	private void CCLNNLCOPBL()
	{
		this.SCShader = Shader.Find("CameraFilterPack/RainFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002FCD RID: 12237 RVA: 0x000FE8D6 File Offset: 0x000FCAD6
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002FCE RID: 12238 RVA: 0x000FE910 File Offset: 0x000FCB10
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1447f)
			{
				this.HBJJOCHGOPH = 1449f;
			}
			this.ACHNOHCLGOO().SetFloat("[MapsData] Workshop maps was loaded", this.HBJJOCHGOPH);
			this.NLFJGMBCICG().SetFloat("USE_CORNER_DETECTION", this.DotSize);
			this.DBOLLHHMKKN().SetFloat("_Bullet_11", this._ColorR);
			this.NBPKMLMCHFN.SetFloat("CameraFilterPack/Drawing_Toon", this._ColorG);
			this.DOHGBNPMBKG().SetFloat("_Blue_R", this._ColorB);
			this.NJDIODJNGGA().SetFloat("maps.", this._Blood);
			this.DKNJGHFLAIF().SetColor("_ScreenResolution", this.ColorRGB);
			this.DKNJGHFLAIF().SetFloat("_ReflectionBufferSize", this._SmoothStart);
			this.NBPKMLMCHFN.SetFloat(": ", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DKNJGHFLAIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FCF RID: 12239 RVA: 0x000FEA3C File Offset: 0x000FCC3C
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 179f)
			{
				this.HBJJOCHGOPH = 1549f;
			}
			this.DKNJGHFLAIF().SetFloat("#yes", this.HBJJOCHGOPH);
			this.MCDGIILBNIF().SetFloat("settings.gamemessagesduration", this.DotSize);
			this.DKNJGHFLAIF().SetFloat("_Speed", this._ColorR);
			this.NLFJGMBCICG().SetFloat("[NetworkManager] Connection failed: ", this._ColorG);
			this.NBPKMLMCHFN.SetFloat("_Value12", this._ColorB);
			this.CFEDGDGBCHE().SetFloat("_Value", this._Blood);
			this.DKKBFFHBHJE().SetColor(" PhotonView: ", this.ColorRGB);
			this.EJDPNJAEAKJ().SetFloat("#savemapbeforeuploading", this._SmoothStart);
			this.NJDIODJNGGA().SetFloat("settings.fps", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FD0 RID: 12240 RVA: 0x000FC97A File Offset: 0x000FAB7A
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002FD1 RID: 12241 RVA: 0x000FEB66 File Offset: 0x000FCD66
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("USE_CORNER_DETECTION");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002FD2 RID: 12242 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06002FD3 RID: 12243 RVA: 0x000FEB8A File Offset: 0x000FCD8A
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002FD4 RID: 12244 RVA: 0x000FEBB0 File Offset: 0x000FCDB0
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 353f)
			{
				this.HBJJOCHGOPH = 1873f;
			}
			this.AELJLBOJAIL().SetFloat("OPEN", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("history", this.DotSize);
			this.EJDPNJAEAKJ().SetFloat("player.xp", this._ColorR);
			this.CFEDGDGBCHE().SetFloat("IconImage", this._ColorG);
			this.AELJLBOJAIL().SetFloat(" isOwnerActive: ", this._ColorB);
			this.DBOLLHHMKKN().SetFloat("_Value3", this._Blood);
			this.EFDEIFCDAFG().SetColor("_TimeX", this.ColorRGB);
			this.NBPKMLMCHFN.SetFloat("_ScreenResolution", this._SmoothStart);
			this.DKKBFFHBHJE().SetFloat("#,0.00", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MCDGIILBNIF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FD5 RID: 12245 RVA: 0x000FECDA File Offset: 0x000FCEDA
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002FD6 RID: 12246 RVA: 0x000FED11 File Offset: 0x000FCF11
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find("DestroyRpc");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002FD7 RID: 12247 RVA: 0x000FED38 File Offset: 0x000FCF38
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 862f)
			{
				this.HBJJOCHGOPH = 1308f;
			}
			this.DKNJGHFLAIF().SetFloat("Attempting to remove texture that was not allocated: {0}", this.HBJJOCHGOPH);
			this.OKJOKHGJHGF().SetFloat("ready", this.DotSize);
			this.DOHGBNPMBKG().SetFloat("There is already a virtual axis named ", this._ColorR);
			this.AELJLBOJAIL().SetFloat("Hidden/Image Effects/Cinematic/AmbientOcclusion", this._ColorG);
			this.EJDPNJAEAKJ().SetFloat("#yes", this._ColorB);
			this.HNICHJCGJOC().SetFloat("https://steamcommunity.com/sharedfiles/filedetails/?id=", this._Blood);
			this.HNICHJCGJOC().SetColor("settings.arcsnohitsoundtimedelay", this.ColorRGB);
			this.BFGNMFCNDBC().SetFloat("team", this._SmoothStart);
			this.BFGNMFCNDBC().SetFloat("_Fade", this._SmoothEnd);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NJDIODJNGGA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002FD8 RID: 12248 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x0400056C RID: 1388
	public Shader SCShader;

	// Token: 0x0400056D RID: 1389
	private float HBJJOCHGOPH = 1f;

	// Token: 0x0400056E RID: 1390
	private Material BJFKDHHMLJH;

	// Token: 0x0400056F RID: 1391
	[Range(0f, 1f)]
	public float DotSize = 0.15f;

	// Token: 0x04000570 RID: 1392
	[Range(0f, 1f)]
	public float _ColorR = 0.9f;

	// Token: 0x04000571 RID: 1393
	[Range(0f, 1f)]
	public float _ColorG = 0.4f;

	// Token: 0x04000572 RID: 1394
	[Range(0f, 1f)]
	public float _ColorB = 0.4f;

	// Token: 0x04000573 RID: 1395
	[Range(0f, 1f)]
	public float _Blood = 0.5f;

	// Token: 0x04000574 RID: 1396
	[Range(0f, 1f)]
	public float _SmoothStart = 0.02f;

	// Token: 0x04000575 RID: 1397
	[Range(0f, 1f)]
	public float _SmoothEnd = 0.1f;

	// Token: 0x04000576 RID: 1398
	public Color ColorRGB = new Color(1f, 0f, 0f);
}
