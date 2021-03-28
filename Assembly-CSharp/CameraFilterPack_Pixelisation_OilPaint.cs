using System;
using UnityEngine;

// Token: 0x02000104 RID: 260
[AddComponentMenu("Camera Filter Pack/Pixelisation/OilPaint")]
[ExecuteInEditMode]
public class CameraFilterPack_Pixelisation_OilPaint : MonoBehaviour
{
	// Token: 0x0600517D RID: 20861 RVA: 0x0002523B File Offset: 0x0002343B
	private void GPFJMKCGHGB()
	{
	}

	// Token: 0x0600517E RID: 20862 RVA: 0x00195AC4 File Offset: 0x00193CC4
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 823f)
			{
				this.HBJJOCHGOPH = 204f;
			}
			this.ACHNOHCLGOO().SetFloat("shader.sunny", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetVector("CameraFilterPack/Distortion_Half_Sphere", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1137f, 1421f));
			this.FEAEGGCNIAA().SetFloat("00", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600517F RID: 20863 RVA: 0x00195B81 File Offset: 0x00193D81
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005180 RID: 20864 RVA: 0x00195B9E File Offset: 0x00193D9E
	private void DKOPKPBLDHH()
	{
		this.SCShader = Shader.Find("https://steamcommunity.com/sharedfiles/filedetails/?id=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005181 RID: 20865 RVA: 0x00195BC4 File Offset: 0x00193DC4
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 796f)
			{
				this.HBJJOCHGOPH = 653f;
			}
			this.CFEDGDGBCHE().SetFloat("_NoiseScale", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetVector("file://", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1076f, 957f));
			this.ACHNOHCLGOO().SetFloat("_ScreenResolution", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005182 RID: 20866 RVA: 0x00195C81 File Offset: 0x00193E81
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("ConnectToMaster() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005183 RID: 20867 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x06005184 RID: 20868 RVA: 0x00195CA8 File Offset: 0x00193EA8
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1442f)
			{
				this.HBJJOCHGOPH = 1194f;
			}
			this.CFEDGDGBCHE().SetFloat("_Green_C", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetVector("Set EnvSprite Image", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1915f, 1874f));
			this.KBOPGONOCNP().SetFloat("NewMusicFileSelector", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005185 RID: 20869 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x06005186 RID: 20870 RVA: 0x00195D68 File Offset: 0x00193F68
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 811f)
			{
				this.HBJJOCHGOPH = 188f;
			}
			this.KBOPGONOCNP().SetFloat(" respawn: ", this.HBJJOCHGOPH);
			this.LDNADDJMIPK().SetVector("Bad SegmentType passed in to CreateLineCap. Must be SegmentType.Start or SegmentType.End", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1305f, 1489f));
			this.KBOPGONOCNP().SetFloat("_Value2", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005187 RID: 20871 RVA: 0x00195E25 File Offset: 0x00194025
	private Material KBOPGONOCNP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-77);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005188 RID: 20872 RVA: 0x00195E5C File Offset: 0x0019405C
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005189 RID: 20873 RVA: 0x00195E80 File Offset: 0x00194080
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 337f)
			{
				this.HBJJOCHGOPH = 324f;
			}
			this.AELJLBOJAIL().SetFloat("#getrewardnow ", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetVector("_Value7", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 580f, 46f));
			this.CFEDGDGBCHE().SetFloat("menu.enableselectormusic", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600518A RID: 20874 RVA: 0x00195F40 File Offset: 0x00194140
	private void ENGFEPKGEDG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 69f)
			{
				this.HBJJOCHGOPH = 653f;
			}
			this.KBOPGONOCNP().SetFloat("GetRegions failed. Can't provide regions list. Error: ", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetVector("OpAuthenticate()", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1043f, 811f));
			this.LDNADDJMIPK().SetFloat("_Value", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600518B RID: 20875 RVA: 0x0002523B File Offset: 0x0002343B
	private void OMCLOFCJMPG()
	{
	}

	// Token: 0x0600518C RID: 20876 RVA: 0x00195B81 File Offset: 0x00193D81
	private void LIEGJOHINGC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600518D RID: 20877 RVA: 0x00195FFD File Offset: 0x001941FD
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600518E RID: 20878 RVA: 0x00195B81 File Offset: 0x00193D81
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600518F RID: 20879 RVA: 0x00196024 File Offset: 0x00194224
	private void OGAGBDIAKGB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1559f)
			{
				this.HBJJOCHGOPH = 1525f;
			}
			this.LONNIJMNKFB().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetVector(": ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1035f, 1074f));
			this.HNICHJCGJOC().SetFloat("SetRotation", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005190 RID: 20880 RVA: 0x001960E1 File Offset: 0x001942E1
	private Material HNICHJCGJOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)91;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005191 RID: 20881 RVA: 0x00195B81 File Offset: 0x00193D81
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x170000E9 RID: 233
	// (get) Token: 0x06005192 RID: 20882 RVA: 0x00196118 File Offset: 0x00194318
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

	// Token: 0x06005193 RID: 20883 RVA: 0x0019614F File Offset: 0x0019434F
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005194 RID: 20884 RVA: 0x00196188 File Offset: 0x00194388
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1121f)
			{
				this.HBJJOCHGOPH = 1475f;
			}
			this.LONNIJMNKFB().SetFloat("_EdgeThresholdMin", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetVector("_Parasite", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 849f, 1470f));
			this.LDNADDJMIPK().SetFloat("arcs", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005195 RID: 20885 RVA: 0x00196245 File Offset: 0x00194445
	private void KNBJBNDGCIJ()
	{
		this.SCShader = Shader.Find("Joystick1Button0");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005196 RID: 20886 RVA: 0x00196269 File Offset: 0x00194469
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("Hip-hop");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005197 RID: 20887 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06005198 RID: 20888 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005199 RID: 20889 RVA: 0x0019628D File Offset: 0x0019448D
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600519A RID: 20890 RVA: 0x001962C4 File Offset: 0x001944C4
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600519C RID: 20892 RVA: 0x00196308 File Offset: 0x00194508
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1891f)
			{
				this.HBJJOCHGOPH = 151f;
			}
			this.LONNIJMNKFB().SetFloat("[LevelEditorScene] Map submitted!", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetVector("#checkpoint", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1998f, 287f));
			this.AELJLBOJAIL().SetFloat("Joystick1Button9", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600519D RID: 20893 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x0600519E RID: 20894 RVA: 0x001963C8 File Offset: 0x001945C8
	private void DBIDOEKLEII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1670f)
			{
				this.HBJJOCHGOPH = 97f;
			}
			this.GCDFNHMJMIP().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetVector("[LevelEditorScene] Error: I/O Failure! :(", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1472f, 745f));
			this.HNICHJCGJOC().SetFloat("Tab1Content", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LDNADDJMIPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600519F RID: 20895 RVA: 0x00196485 File Offset: 0x00194685
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060051A0 RID: 20896 RVA: 0x001964BC File Offset: 0x001946BC
	private void CLLJDEAJDNL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1662f)
			{
				this.HBJJOCHGOPH = 1887f;
			}
			this.ACHNOHCLGOO().SetFloat("_Speed", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetVector("Fake", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 428f, 1054f));
			this.AELJLBOJAIL().SetFloat("JoinRandom failed: No open game. Calling: OnPhotonRandomJoinFailed() and staying on master server.", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060051A1 RID: 20897 RVA: 0x0019657C File Offset: 0x0019477C
	private void HLAIEDEHIBC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1678f)
			{
				this.HBJJOCHGOPH = 1381f;
			}
			this.HNICHJCGJOC().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetVector("CameraFilterPack/NightVision_4", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1125f, 1662f));
			this.LDNADDJMIPK().SetFloat("UnAllocateViewID() should be called after the PhotonView was destroyed (GameObject.Destroy()). ViewID: {0} still found in: {1}", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060051A2 RID: 20898 RVA: 0x00196639 File Offset: 0x00194839
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("_Near");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060051A3 RID: 20899 RVA: 0x0019665D File Offset: 0x0019485D
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)89;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060051A4 RID: 20900 RVA: 0x00196694 File Offset: 0x00194894
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-106);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060051A5 RID: 20901 RVA: 0x001966CB File Offset: 0x001948CB
	private Material CFEDGDGBCHE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060051A6 RID: 20902 RVA: 0x00196704 File Offset: 0x00194904
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 246f)
			{
				this.HBJJOCHGOPH = 1927f;
			}
			this.GCDFNHMJMIP().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetVector("Set Sun Colors", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1513f, 327f));
			this.GCDFNHMJMIP().SetFloat("[PlayerController] ", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060051A7 RID: 20903 RVA: 0x001967C1 File Offset: 0x001949C1
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-92);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060051A8 RID: 20904 RVA: 0x001967F8 File Offset: 0x001949F8
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1935f)
			{
				this.HBJJOCHGOPH = 1340f;
			}
			this.FEAEGGCNIAA().SetFloat("#FFFFFF", this.HBJJOCHGOPH);
			this.CFEDGDGBCHE().SetVector("[DiscordController] Sectate ({0})", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1319f, 1553f));
			this.KEMJNOMIPHN().SetFloat("_Offsets", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNICHJCGJOC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060051A9 RID: 20905 RVA: 0x0002523B File Offset: 0x0002343B
	private void NKLIHNJCHOG()
	{
	}

	// Token: 0x060051AA RID: 20906 RVA: 0x001968B5 File Offset: 0x00194AB5
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060051AB RID: 20907 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x060051AC RID: 20908 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x060051AD RID: 20909 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x060051AE RID: 20910 RVA: 0x001968EC File Offset: 0x00194AEC
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1271f)
			{
				this.HBJJOCHGOPH = 1675f;
			}
			this.HNICHJCGJOC().SetFloat("ok", this.HBJJOCHGOPH);
			this.LONNIJMNKFB().SetVector("SetSunColors", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 196f, 1196f));
			this.CFEDGDGBCHE().SetFloat("_MainTex2", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060051AF RID: 20911 RVA: 0x00195B81 File Offset: 0x00193D81
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060051B0 RID: 20912 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x060051B1 RID: 20913 RVA: 0x00195B81 File Offset: 0x00193D81
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060051B2 RID: 20914 RVA: 0x001969AC File Offset: 0x00194BAC
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
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			this.NBPKMLMCHFN.SetFloat("_Value", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060051B3 RID: 20915 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x060051B4 RID: 20916 RVA: 0x00196A6C File Offset: 0x00194C6C
	private void DPMMIPDKJND(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1500f)
			{
				this.HBJJOCHGOPH = 1131f;
			}
			this.KBOPGONOCNP().SetFloat("CloseConnection: Only the masterclient can kick another player.", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 241f, 1998f));
			this.ACHNOHCLGOO().SetFloat(" GameServer:", this.Value);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CFEDGDGBCHE());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060051B5 RID: 20917 RVA: 0x00196B29 File Offset: 0x00194D29
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Pixelisation_OilPaint");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060051B6 RID: 20918 RVA: 0x00196B4D File Offset: 0x00194D4D
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("_CenterY");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x04000881 RID: 2177
	public Shader SCShader;

	// Token: 0x04000882 RID: 2178
	private float HBJJOCHGOPH = 1f;

	// Token: 0x04000883 RID: 2179
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000884 RID: 2180
	private Material BJFKDHHMLJH;

	// Token: 0x04000885 RID: 2181
	[Range(0f, 5f)]
	public float Value = 1f;
}
