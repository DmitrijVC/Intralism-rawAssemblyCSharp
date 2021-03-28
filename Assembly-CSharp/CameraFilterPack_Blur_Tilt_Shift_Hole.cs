using System;
using UnityEngine;

// Token: 0x02000069 RID: 105
[AddComponentMenu("Camera Filter Pack/Blur/Tilt_Shift_Hole")]
[ExecuteInEditMode]
public class CameraFilterPack_Blur_Tilt_Shift_Hole : MonoBehaviour
{
	// Token: 0x06001D68 RID: 7528 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06001D69 RID: 7529 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x06001D6A RID: 7530 RVA: 0x000B2230 File Offset: 0x000B0430
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)119;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D6B RID: 7531 RVA: 0x000B2267 File Offset: 0x000B0467
	private void KMOCDAOKGLI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D6C RID: 7532 RVA: 0x000B2284 File Offset: 0x000B0484
	private void NBHMOIGDDAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 624f)
			{
				this.HBJJOCHGOPH = 1342f;
			}
			this.FEAEGGCNIAA().SetFloat("Set particles audio input", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("MissesText", this.Amount);
			this.GCDFNHMJMIP().SetFloat("_TimeX", this.Smooth);
			this.NLFJGMBCICG().SetFloat("\n\n• ", this.Size);
			this.BKKJJJGADLM().SetFloat("UI Extensions/UIAdditive", this.PositionX);
			this.ACHNOHCLGOO().SetFloat("_ScreenResolution", this.PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)7;
				Graphics.Blit(AAACLELCPML, temporary, this.DBOLLHHMKKN(), 1);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 0);
				this.ABHDNGIHBKE().SetFloat("_ScreenResolution", this.Amount * 1326f);
				Graphics.Blit(temporary2, temporary, this.BKKJJJGADLM(), 0);
				Graphics.Blit(temporary, temporary2, this.DBOLLHHMKKN(), 1);
				this.GCDFNHMJMIP().SetTexture("There is already a virtual button named ", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001D6D RID: 7533 RVA: 0x000B2438 File Offset: 0x000B0638
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 842f)
			{
				this.HBJJOCHGOPH = 227f;
			}
			this.ACHNOHCLGOO().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.ABHDNGIHBKE().SetFloat("AudioSampler", this.Amount);
			this.ABHDNGIHBKE().SetFloat("Menu", this.Smooth);
			this.GHHPOGODBHB().SetFloat("maps.", this.Size);
			this.GHHPOGODBHB().SetFloat("#mapby", this.PositionX);
			this.GHHPOGODBHB().SetFloat("PossibleMapPointsText", this.PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)3;
				Graphics.Blit(AAACLELCPML, temporary, this.HCGJCMDJPGD(), 7);
				Graphics.Blit(temporary, temporary2, this.GHHPOGODBHB(), 0);
				this.LONNIJMNKFB().SetFloat("[MapEditor] Updating map assets", this.Amount * 1310f);
				Graphics.Blit(temporary2, temporary, this.PDEAHJPOMEF(), 6);
				Graphics.Blit(temporary, temporary2, this.HCGJCMDJPGD(), 1);
				this.IONHGBPGCHK().SetTexture("Reset 21 achievement progress", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NDMPCDHADMJ(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001D6E RID: 7534 RVA: 0x000B25E9 File Offset: 0x000B07E9
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D6F RID: 7535 RVA: 0x000B2620 File Offset: 0x000B0820
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D70 RID: 7536 RVA: 0x000B2657 File Offset: 0x000B0857
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("position");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001D71 RID: 7537 RVA: 0x000B267B File Offset: 0x000B087B
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("DPADVER");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001D72 RID: 7538 RVA: 0x000B2267 File Offset: 0x000B0467
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D73 RID: 7539 RVA: 0x000B269F File Offset: 0x000B089F
	private Material DBOLLHHMKKN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)82;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D74 RID: 7540 RVA: 0x000B26D6 File Offset: 0x000B08D6
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D75 RID: 7541 RVA: 0x000B270D File Offset: 0x000B090D
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find("ReconnectAndRejoin() failed. Can only connect while in state 'Disconnected'. Current state: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001D76 RID: 7542 RVA: 0x000B2731 File Offset: 0x000B0931
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D77 RID: 7543 RVA: 0x000B2768 File Offset: 0x000B0968
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1109f)
			{
				this.HBJJOCHGOPH = 890f;
			}
			this.NLFJGMBCICG().SetFloat("Committing changes...", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("Multiplayer", this.Amount);
			this.PDEAHJPOMEF().SetFloat("x", this.Smooth);
			this.FEAEGGCNIAA().SetFloat(" to ", this.Size);
			this.JIBOKBCPDLC().SetFloat("Can't do manual instantiation without PhotonView component.", this.PositionX);
			this.ACHNOHCLGOO().SetFloat("_TimeX", this.PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, this.BKKJJJGADLM(), 0);
				Graphics.Blit(temporary, temporary2, this.EFDEIFCDAFG(), 1);
				this.BKKJJJGADLM().SetFloat("_FixDistance", this.Amount * 606f);
				Graphics.Blit(temporary2, temporary, this.FEAEGGCNIAA(), 8);
				Graphics.Blit(temporary, temporary2, this.IONHGBPGCHK(), 1);
				this.GCDFNHMJMIP().SetTexture("z", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001D78 RID: 7544 RVA: 0x000B291C File Offset: 0x000B0B1C
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1253f)
			{
				this.HBJJOCHGOPH = 970f;
			}
			this.FAIFBBGFAIB().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetFloat(" not found", this.Amount);
			this.GHHPOGODBHB().SetFloat("SetLives", this.Smooth);
			this.IIJMIPBMMBF().SetFloat("maps.", this.Size);
			this.NBPKMLMCHFN.SetFloat("SpawnObj", this.PositionX);
			this.FHFLKLMFHOI().SetFloat("_SizeX", this.PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, this.BKKJJJGADLM(), 3);
				Graphics.Blit(temporary, temporary2, this.JIBOKBCPDLC(), 1);
				this.IONHGBPGCHK().SetFloat("Dec", this.Amount * 1621f);
				Graphics.Blit(temporary2, temporary, this.JIBOKBCPDLC(), 2);
				Graphics.Blit(temporary, temporary2, this.HCGJCMDJPGD(), 1);
				this.EFDEIFCDAFG().SetTexture("ticket", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001D79 RID: 7545 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06001D7A RID: 7546 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x06001D7B RID: 7547 RVA: 0x000B2267 File Offset: 0x000B0467
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D7C RID: 7548 RVA: 0x000B2ACD File Offset: 0x000B0CCD
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("Down");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001D7D RID: 7549 RVA: 0x000B2AF1 File Offset: 0x000B0CF1
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D7E RID: 7550 RVA: 0x0002523B File Offset: 0x0002343B
	private void OEENOOGEEHD()
	{
	}

	// Token: 0x06001D7F RID: 7551 RVA: 0x000B2B28 File Offset: 0x000B0D28
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D80 RID: 7552 RVA: 0x000B2B5F File Offset: 0x000B0D5F
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D81 RID: 7553 RVA: 0x000B2B96 File Offset: 0x000B0D96
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)72;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D82 RID: 7554 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06001D83 RID: 7555 RVA: 0x000B2BCD File Offset: 0x000B0DCD
	private void MJEFMIPLFAB()
	{
		this.SCShader = Shader.Find("StartButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001D84 RID: 7556 RVA: 0x000B2BF4 File Offset: 0x000B0DF4
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1111f)
			{
				this.HBJJOCHGOPH = 36f;
			}
			this.EFDEIFCDAFG().SetFloat("SaveMapButton", this.HBJJOCHGOPH);
			this.HCGJCMDJPGD().SetFloat("Jun", this.Amount);
			this.GHHPOGODBHB().SetFloat("Received event Leave for unknown player ID: {0}", this.Smooth);
			this.NLFJGMBCICG().SetFloat("maps.", this.Size);
			this.PDEAHJPOMEF().SetFloat("OpChangeGroups()", this.PositionX);
			this.LONNIJMNKFB().SetFloat("_Value", this.PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, this.NLFJGMBCICG(), 6);
				Graphics.Blit(temporary, temporary2, this.ABHDNGIHBKE(), 0);
				this.FAIFBBGFAIB().SetFloat("CameraFilterPack/Color_BrightContrastSaturation", this.Amount * 1654f);
				Graphics.Blit(temporary2, temporary, this.HCGJCMDJPGD(), 4);
				Graphics.Blit(temporary, temporary2, this.BKKJJJGADLM(), 0);
				this.IIJMIPBMMBF().SetTexture("RaiseEvent() failed. Your event is not being sent! Check if your are in a Room and the eventCode must be less than 200 (0..199).", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JIBOKBCPDLC(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001D85 RID: 7557 RVA: 0x000B2267 File Offset: 0x000B0467
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D86 RID: 7558 RVA: 0x000B2DA5 File Offset: 0x000B0FA5
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D88 RID: 7560 RVA: 0x000B2267 File Offset: 0x000B0467
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D89 RID: 7561 RVA: 0x0002523B File Offset: 0x0002343B
	private void JHPOIOELNCG()
	{
	}

	// Token: 0x06001D8A RID: 7562 RVA: 0x000B2E38 File Offset: 0x000B1038
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("Source directory does not exist or could not be found: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001D8B RID: 7563 RVA: 0x000B2267 File Offset: 0x000B0467
	private void BLKGOMCPEKI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D8C RID: 7564 RVA: 0x000B2E5C File Offset: 0x000B105C
	private void NOEAGHKPPKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 700f)
			{
				this.HBJJOCHGOPH = 944f;
			}
			this.NLFJGMBCICG().SetFloat("Warning: Unhandled Event ErrorInfo (251). Set PhotonNetwork.OnEventCall to the method PUN should call for this event.", this.HBJJOCHGOPH);
			this.NDMPCDHADMJ().SetFloat("Use ticket: ", this.Amount);
			this.PDEAHJPOMEF().SetFloat("RecieveChatActionMessage", this.Smooth);
			this.HCGJCMDJPGD().SetFloat("skin.", this.Size);
			this.FAIFBBGFAIB().SetFloat("Object ID. Case-Sensitive", this.PositionX);
			this.NBPKMLMCHFN.SetFloat("downloading", this.PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Point;
				Graphics.Blit(AAACLELCPML, temporary, this.NDMPCDHADMJ(), 2);
				Graphics.Blit(temporary, temporary2, this.NFMGLIKNOOC(), 0);
				this.NFMGLIKNOOC().SetFloat("Fake", this.Amount * 390f);
				Graphics.Blit(temporary2, temporary, this.ABHDNGIHBKE(), 0);
				Graphics.Blit(temporary, temporary2, this.ABHDNGIHBKE(), 0);
				this.GHHPOGODBHB().SetTexture("ConfigVersionSlider", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GHHPOGODBHB(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HCGJCMDJPGD(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001D8D RID: 7565 RVA: 0x000B3010 File Offset: 0x000B1210
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1604f)
			{
				this.HBJJOCHGOPH = 393f;
			}
			this.EFDEIFCDAFG().SetFloat("X", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("CameraFilterPack_Glasses_On6", this.Amount);
			this.NFMGLIKNOOC().SetFloat("&", this.Smooth);
			this.IIJMIPBMMBF().SetFloat("The other scroll rect doesnt support scrolling vertically", this.Size);
			this.NFMGLIKNOOC().SetFloat("_Value4", this.PositionX);
			this.FHFLKLMFHOI().SetFloat("[ResourcesManager] Load image error: ", this.PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)6;
				Graphics.Blit(AAACLELCPML, temporary, this.NDMPCDHADMJ(), 7);
				Graphics.Blit(temporary, temporary2, this.JIBOKBCPDLC(), 0);
				this.ACHNOHCLGOO().SetFloat("?", this.Amount * 97f);
				Graphics.Blit(temporary2, temporary, this.GHHPOGODBHB(), 6);
				Graphics.Blit(temporary, temporary2, this.HCGJCMDJPGD(), 0);
				this.EFDEIFCDAFG().SetTexture("Joystick1Button7", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NFMGLIKNOOC(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001D8E RID: 7566 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x06001D8F RID: 7567 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06001D90 RID: 7568 RVA: 0x000B31C4 File Offset: 0x000B13C4
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 287f)
			{
				this.HBJJOCHGOPH = 765f;
			}
			this.NDMPCDHADMJ().SetFloat("Set Trail Zoom Speed", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("(\\[ *i *\\])", this.Amount);
			this.NFMGLIKNOOC().SetFloat("MusicFileSelector", this.Smooth);
			this.LONNIJMNKFB().SetFloat("CameraFilterPack/FX_Scan", this.Size);
			this.GCDFNHMJMIP().SetFloat("_Value10", this.PositionX);
			this.LONNIJMNKFB().SetFloat("_TimeX", this.PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, this.BKKJJJGADLM(), 4);
				Graphics.Blit(temporary, temporary2, this.EFDEIFCDAFG(), 0);
				this.FAIFBBGFAIB().SetFloat("time", this.Amount * 1743f);
				Graphics.Blit(temporary2, temporary, this.IONHGBPGCHK(), 8);
				Graphics.Blit(temporary, temporary2, this.BKKJJJGADLM(), 0);
				this.IONHGBPGCHK().SetTexture("itemdefid[0]", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NLFJGMBCICG(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001D91 RID: 7569 RVA: 0x000B3375 File Offset: 0x000B1575
	private void FNCDAPDOBBI()
	{
		this.SCShader = Shader.Find("Working.\nPlease wait..");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001D92 RID: 7570 RVA: 0x000B2267 File Offset: 0x000B0467
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D93 RID: 7571 RVA: 0x000B2267 File Offset: 0x000B0467
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D94 RID: 7572 RVA: 0x000B2267 File Offset: 0x000B0467
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D95 RID: 7573 RVA: 0x000B3399 File Offset: 0x000B1599
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("_FadeFX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001D96 RID: 7574 RVA: 0x000B33BD File Offset: 0x000B15BD
	private void COIJKMKIEAK()
	{
		this.SCShader = Shader.Find("_Axis");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001D97 RID: 7575 RVA: 0x000B33E1 File Offset: 0x000B15E1
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D98 RID: 7576 RVA: 0x000B2267 File Offset: 0x000B0467
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001D99 RID: 7577 RVA: 0x000B3418 File Offset: 0x000B1618
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D9A RID: 7578 RVA: 0x000B344F File Offset: 0x000B164F
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("Editor/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001D9B RID: 7579 RVA: 0x000B3473 File Offset: 0x000B1673
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-87);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001D9C RID: 7580 RVA: 0x000B34AA File Offset: 0x000B16AA
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("_BlurredColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001D9D RID: 7581 RVA: 0x000B2267 File Offset: 0x000B0467
	private void JHLGHODFJOO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x1700004F RID: 79
	// (get) Token: 0x06001D9E RID: 7582 RVA: 0x000B34CE File Offset: 0x000B16CE
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

	// Token: 0x06001D9F RID: 7583 RVA: 0x000B3505 File Offset: 0x000B1705
	private Material LONNIJMNKFB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001DA0 RID: 7584 RVA: 0x000B2267 File Offset: 0x000B0467
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DA1 RID: 7585 RVA: 0x000B353C File Offset: 0x000B173C
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 330f)
			{
				this.HBJJOCHGOPH = 358f;
			}
			this.EFDEIFCDAFG().SetFloat("[EditorEvent] Exception: ", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("CameraFilterPack_Glasses_On5", this.Amount);
			this.FAIFBBGFAIB().SetFloat("[Right]", this.Smooth);
			this.IONHGBPGCHK().SetFloat("Vertical", this.Size);
			this.FAIFBBGFAIB().SetFloat("_Offsets", this.PositionX);
			this.LONNIJMNKFB().SetFloat("resource", this.PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = (FilterMode)3;
				Graphics.Blit(AAACLELCPML, temporary, this.FHFLKLMFHOI(), 8);
				Graphics.Blit(temporary, temporary2, this.NLFJGMBCICG(), 0);
				this.FEAEGGCNIAA().SetFloat("settings.volume.editor", this.Amount * 109f);
				Graphics.Blit(temporary2, temporary, this.DBOLLHHMKKN(), 0);
				Graphics.Blit(temporary, temporary2, this.GCDFNHMJMIP(), 1);
				this.PDEAHJPOMEF().SetTexture("SetSunLerpSpeed", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ACHNOHCLGOO(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GHHPOGODBHB(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001DA2 RID: 7586 RVA: 0x000B36ED File Offset: 0x000B18ED
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/BlurTiltShift_Hole");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001DA3 RID: 7587 RVA: 0x000B3714 File Offset: 0x000B1914
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1185f)
			{
				this.HBJJOCHGOPH = 875f;
			}
			this.NFMGLIKNOOC().SetFloat("[Left]", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat(".", this.Amount);
			this.FHFLKLMFHOI().SetFloat("CameraFilterPack/Retro_Loading", this.Smooth);
			this.GCDFNHMJMIP().SetFloat("SetTrailZoomSpeed", this.Size);
			this.FEAEGGCNIAA().SetFloat("nd", this.PositionX);
			this.DBOLLHHMKKN().SetFloat("_TimeX", this.PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 1);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)3;
				Graphics.Blit(AAACLELCPML, temporary, this.NFMGLIKNOOC(), 7);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 0);
				this.ABHDNGIHBKE().SetFloat("Image", this.Amount * 1356f);
				Graphics.Blit(temporary2, temporary, this.NFMGLIKNOOC(), 5);
				Graphics.Blit(temporary, temporary2, this.NFMGLIKNOOC(), 0);
				this.IIJMIPBMMBF().SetTexture("_ScreenResolution", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB(), 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001DA4 RID: 7588 RVA: 0x000B38C5 File Offset: 0x000B1AC5
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001DA5 RID: 7589 RVA: 0x000B38EC File Offset: 0x000B1AEC
	private void OnRenderImage(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 100f)
			{
				this.HBJJOCHGOPH = 0f;
			}
			this.NBPKMLMCHFN.SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_Amount", this.Amount);
			this.NBPKMLMCHFN.SetFloat("_Value1", this.Smooth);
			this.NBPKMLMCHFN.SetFloat("_Value2", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.PositionX);
			this.NBPKMLMCHFN.SetFloat("_Value4", this.PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 1)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, this.NBPKMLMCHFN, 2);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 0);
				this.NBPKMLMCHFN.SetFloat("_Amount", this.Amount * 2f);
				Graphics.Blit(temporary2, temporary, this.NBPKMLMCHFN, 2);
				Graphics.Blit(temporary, temporary2, this.NBPKMLMCHFN, 0);
				this.NBPKMLMCHFN.SetTexture("_MainTex2", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN, 0);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001DA6 RID: 7590 RVA: 0x000B2267 File Offset: 0x000B0467
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DA7 RID: 7591 RVA: 0x000B3AA0 File Offset: 0x000B1CA0
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1042f)
			{
				this.HBJJOCHGOPH = 1076f;
			}
			this.ABHDNGIHBKE().SetFloat("DPADVER", this.HBJJOCHGOPH);
			this.ACHNOHCLGOO().SetFloat("menu.tabid", this.Amount);
			this.BKKJJJGADLM().SetFloat("settings.volume.sfx", this.Smooth);
			this.IIJMIPBMMBF().SetFloat("local CheckCondition = function()", this.Size);
			this.HCGJCMDJPGD().SetFloat(" Kb", this.PositionX);
			this.GCDFNHMJMIP().SetFloat("LevelFolderInputField", this.PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, this.ACHNOHCLGOO(), 0);
				Graphics.Blit(temporary, temporary2, this.NLFJGMBCICG(), 0);
				this.FEAEGGCNIAA().SetFloat("y", this.Amount * 1156f);
				Graphics.Blit(temporary2, temporary, this.NBPKMLMCHFN, 1);
				Graphics.Blit(temporary, temporary2, this.PDEAHJPOMEF(), 0);
				this.FAIFBBGFAIB().SetTexture("settings.arcsnohitsoundtimedelay", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP(), 0);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ABHDNGIHBKE(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001DA8 RID: 7592 RVA: 0x000B3C51 File Offset: 0x000B1E51
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001DA9 RID: 7593 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x06001DAA RID: 7594 RVA: 0x000B3C88 File Offset: 0x000B1E88
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 838f)
			{
				this.HBJJOCHGOPH = 1027f;
			}
			this.FEAEGGCNIAA().SetFloat("Back", this.HBJJOCHGOPH);
			this.GCDFNHMJMIP().SetFloat("offsets", this.Amount);
			this.NBPKMLMCHFN.SetFloat("_Value3", this.Smooth);
			this.BKKJJJGADLM().SetFloat("_ReflectionBlur", this.Size);
			this.IIJMIPBMMBF().SetFloat("event", this.PositionX);
			this.IONHGBPGCHK().SetFloat(". Not connectedAndReady.", this.PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 1);
				temporary.filterMode = FilterMode.Trilinear;
				Graphics.Blit(AAACLELCPML, temporary, this.DBOLLHHMKKN(), 3);
				Graphics.Blit(temporary, temporary2, this.NLFJGMBCICG(), 1);
				this.PDEAHJPOMEF().SetFloat("speed", this.Amount * 215f);
				Graphics.Blit(temporary2, temporary, this.ACHNOHCLGOO(), 4);
				Graphics.Blit(temporary, temporary2, this.HCGJCMDJPGD(), 1);
				this.JIBOKBCPDLC().SetTexture("sprite", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IIJMIPBMMBF(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001DAB RID: 7595 RVA: 0x000B2267 File Offset: 0x000B0467
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DAC RID: 7596 RVA: 0x000B3E39 File Offset: 0x000B2039
	private void KDMKDEKCELE()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06001DAD RID: 7597 RVA: 0x000B2267 File Offset: 0x000B0467
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DAE RID: 7598 RVA: 0x000B3E60 File Offset: 0x000B2060
	private void GHILGJJEAOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			int fastFilter = this.FastFilter;
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1413f)
			{
				this.HBJJOCHGOPH = 1751f;
			}
			this.FAIFBBGFAIB().SetFloat("Player", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("No Name", this.Amount);
			this.NBPKMLMCHFN.SetFloat("ViewMenu", this.Smooth);
			this.IIJMIPBMMBF().SetFloat("value", this.Size);
			this.IONHGBPGCHK().SetFloat("Connection error: ", this.PositionX);
			this.FEAEGGCNIAA().SetFloat("request", this.PositionY);
			int width = AAACLELCPML.width / fastFilter;
			int height = AAACLELCPML.height / fastFilter;
			if (this.FastFilter > 0)
			{
				RenderTexture temporary = RenderTexture.GetTemporary(width, height, 0);
				RenderTexture temporary2 = RenderTexture.GetTemporary(width, height, 0);
				temporary.filterMode = (FilterMode)5;
				Graphics.Blit(AAACLELCPML, temporary, this.NLFJGMBCICG(), 3);
				Graphics.Blit(temporary, temporary2, this.FEAEGGCNIAA(), 1);
				this.LONNIJMNKFB().SetFloat("/", this.Amount * 1023f);
				Graphics.Blit(temporary2, temporary, this.JIBOKBCPDLC(), 2);
				Graphics.Blit(temporary, temporary2, this.PDEAHJPOMEF(), 1);
				this.ACHNOHCLGOO().SetTexture("achievements.id", temporary2);
				RenderTexture.ReleaseTemporary(temporary);
				RenderTexture.ReleaseTemporary(temporary2);
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FAIFBBGFAIB(), 1);
			}
			else
			{
				Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DBOLLHHMKKN(), 1);
			}
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06001DAF RID: 7599 RVA: 0x000B2267 File Offset: 0x000B0467
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DB0 RID: 7600 RVA: 0x000B4011 File Offset: 0x000B2211
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001DB1 RID: 7601 RVA: 0x000B4048 File Offset: 0x000B2248
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001DB2 RID: 7602 RVA: 0x000B2267 File Offset: 0x000B0467
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06001DB3 RID: 7603 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06001DB4 RID: 7604 RVA: 0x000B406C File Offset: 0x000B226C
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find(">");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06001DB5 RID: 7605 RVA: 0x000B4090 File Offset: 0x000B2290
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001DB6 RID: 7606 RVA: 0x000B40C7 File Offset: 0x000B22C7
	private Material NDMPCDHADMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06001DB7 RID: 7607 RVA: 0x000B40FE File Offset: 0x000B22FE
	private void CHOPDIGHJNH()
	{
		this.SCShader = Shader.Find(".icon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x040003F8 RID: 1016
	public Shader SCShader;

	// Token: 0x040003F9 RID: 1017
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040003FA RID: 1018
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040003FB RID: 1019
	private Material BJFKDHHMLJH;

	// Token: 0x040003FC RID: 1020
	[Range(0f, 20f)]
	public float Amount = 3f;

	// Token: 0x040003FD RID: 1021
	[Range(2f, 16f)]
	public int FastFilter = 8;

	// Token: 0x040003FE RID: 1022
	[Range(0f, 1f)]
	public float Smooth = 0.5f;

	// Token: 0x040003FF RID: 1023
	[Range(0f, 1f)]
	public float Size = 0.2f;

	// Token: 0x04000400 RID: 1024
	[Range(-1f, 1f)]
	public float PositionX = 0.5f;

	// Token: 0x04000401 RID: 1025
	[Range(-1f, 1f)]
	public float PositionY = 0.5f;
}
