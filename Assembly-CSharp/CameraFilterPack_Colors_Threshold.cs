using System;
using UnityEngine;

// Token: 0x02000082 RID: 130
[AddComponentMenu("Camera Filter Pack/Colors/Threshold")]
[ExecuteInEditMode]
public class CameraFilterPack_Colors_Threshold : MonoBehaviour
{
	// Token: 0x060024E5 RID: 9445 RVA: 0x000D3EBB File Offset: 0x000D20BB
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060024E6 RID: 9446 RVA: 0x000D3ED8 File Offset: 0x000D20D8
	private void DFFKKLAPHCC()
	{
		this.SCShader = Shader.Find("SpeedSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060024E7 RID: 9447 RVA: 0x000D3EFC File Offset: 0x000D20FC
	private void KCCIEMBMOBA()
	{
		this.SCShader = Shader.Find("_Value5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060024E8 RID: 9448 RVA: 0x000D3EBB File Offset: 0x000D20BB
	private void LAMEHAHJKMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060024E9 RID: 9449 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x060024EA RID: 9450 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBPCODPOJAH()
	{
	}

	// Token: 0x060024EB RID: 9451 RVA: 0x000D3F20 File Offset: 0x000D2120
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060024EC RID: 9452 RVA: 0x000D3F57 File Offset: 0x000D2157
	private Material IONHGBPGCHK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060024ED RID: 9453 RVA: 0x000D3F8E File Offset: 0x000D218E
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("menuVolume");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060024EE RID: 9454 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x060024EF RID: 9455 RVA: 0x000D3FB4 File Offset: 0x000D21B4
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
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060024F0 RID: 9456 RVA: 0x000D3EBB File Offset: 0x000D20BB
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060024F1 RID: 9457 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMKLDAJLCNM()
	{
	}

	// Token: 0x060024F2 RID: 9458 RVA: 0x0002523B File Offset: 0x0002343B
	private void MFMIODIAKNI()
	{
	}

	// Token: 0x060024F3 RID: 9459 RVA: 0x000D3EBB File Offset: 0x000D20BB
	private void BNLENEDAHHL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060024F4 RID: 9460 RVA: 0x000D4044 File Offset: 0x000D2244
	private void CGDMLHLJIDK()
	{
		this.SCShader = Shader.Find("open");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060024F5 RID: 9461 RVA: 0x000D4068 File Offset: 0x000D2268
	private void BMBIGILMLLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 202f)
			{
				this.HBJJOCHGOPH = 990f;
			}
			this.IGIAPKPKGPK().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetFloat("mapselector.lastSearch", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIAIGCAHDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060024F6 RID: 9462 RVA: 0x000D3EBB File Offset: 0x000D20BB
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060024F7 RID: 9463 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x060024F8 RID: 9464 RVA: 0x000D40F8 File Offset: 0x000D22F8
	private void OKNOJEEGONA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1197f)
			{
				this.HBJJOCHGOPH = 776f;
			}
			this.OIMMPLPBLBK().SetFloat("EditMenu", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("_TimeX", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060024F9 RID: 9465 RVA: 0x000D4188 File Offset: 0x000D2388
	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1242f)
			{
				this.HBJJOCHGOPH = 132f;
			}
			this.FKEOGPDLBDD().SetFloat("_Value", this.HBJJOCHGOPH);
			this.IONHGBPGCHK().SetFloat("_Value3", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060024FA RID: 9466 RVA: 0x000D4218 File Offset: 0x000D2418
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1876f)
			{
				this.HBJJOCHGOPH = 1522f;
			}
			this.EFDEIFCDAFG().SetFloat("CameraFilterPack/TV_WideScreenHorizontal", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("#000000", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060024FB RID: 9467 RVA: 0x000D42A8 File Offset: 0x000D24A8
	private void EPEGAEGDJAM()
	{
		this.SCShader = Shader.Find("OnEvent: {0}");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060024FC RID: 9468 RVA: 0x000D42CC File Offset: 0x000D24CC
	private Material BKKJJJGADLM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060024FD RID: 9469 RVA: 0x000D3EBB File Offset: 0x000D20BB
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060024FE RID: 9470 RVA: 0x000D4303 File Offset: 0x000D2503
	private Material FKEOGPDLBDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060024FF RID: 9471 RVA: 0x000D433C File Offset: 0x000D253C
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 371f)
			{
				this.HBJJOCHGOPH = 1610f;
			}
			this.ADGHJOHKEHG().SetFloat("CameraFilterPack/Edge_Golden", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("Set sun lerp speed", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002500 RID: 9472 RVA: 0x000D43CC File Offset: 0x000D25CC
	private void BABCJIIKIAD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1063f)
			{
				this.HBJJOCHGOPH = 1214f;
			}
			this.NBPKMLMCHFN.SetFloat(" (inactive)", this.HBJJOCHGOPH);
			this.IGIAPKPKGPK().SetFloat("#ok", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002501 RID: 9473 RVA: 0x000D445C File Offset: 0x000D265C
	private void NDBPCNICGLC()
	{
		this.SCShader = Shader.Find("_Near");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002502 RID: 9474 RVA: 0x000D3EBB File Offset: 0x000D20BB
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002503 RID: 9475 RVA: 0x000D4480 File Offset: 0x000D2680
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find("_Near");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002504 RID: 9476 RVA: 0x000D44A4 File Offset: 0x000D26A4
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("hitsounds:");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002505 RID: 9477 RVA: 0x000D3EBB File Offset: 0x000D20BB
	private void ELDMKIAPNGP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002506 RID: 9478 RVA: 0x000D3EBB File Offset: 0x000D20BB
	private void FKEJGBFDCAH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002507 RID: 9479 RVA: 0x000D44C8 File Offset: 0x000D26C8
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 95f)
			{
				this.HBJJOCHGOPH = 830f;
			}
			this.KAFBNOBOIAJ().SetFloat("_CenterRadius", this.HBJJOCHGOPH);
			this.KAFBNOBOIAJ().SetFloat("DPADHOR", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002508 RID: 9480 RVA: 0x000D4558 File Offset: 0x000D2758
	private void HNADGLKNADJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 258f)
			{
				this.HBJJOCHGOPH = 851f;
			}
			this.OIMMPLPBLBK().SetFloat("#mapnotloaded", this.HBJJOCHGOPH);
			this.HHIAIGCAHDA().SetFloat("Save the map before exiting?", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002509 RID: 9481 RVA: 0x000D3EBB File Offset: 0x000D20BB
	private void JHJGJJKELJM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600250B RID: 9483 RVA: 0x000D4606 File Offset: 0x000D2806
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find(" ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600250C RID: 9484 RVA: 0x000D462A File Offset: 0x000D282A
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-84);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600250D RID: 9485 RVA: 0x000D4664 File Offset: 0x000D2864
	private void JCCIHFMBFJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 20f)
			{
				this.HBJJOCHGOPH = 347f;
			}
			this.IONHGBPGCHK().SetFloat("RT", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("VeryHigh", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600250E RID: 9486 RVA: 0x000D46F4 File Offset: 0x000D28F4
	private Material HHIFMIPPMPF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600250F RID: 9487 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x06002510 RID: 9488 RVA: 0x000D472C File Offset: 0x000D292C
	private void EMKCNMFNDDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 385f)
			{
				this.HBJJOCHGOPH = 1935f;
			}
			this.ADGHJOHKEHG().SetFloat("Hidden/Image Effects/Cinematic/AmbientOcclusion", this.HBJJOCHGOPH);
			this.OIMMPLPBLBK().SetFloat("CameraFilterPack/Distortion_Dream", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002511 RID: 9489 RVA: 0x000D47BC File Offset: 0x000D29BC
	private void ECBILENEOOL()
	{
		this.SCShader = Shader.Find("colorA");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002512 RID: 9490 RVA: 0x000D47E0 File Offset: 0x000D29E0
	private void FEKECCBFGMI()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002513 RID: 9491 RVA: 0x000D4804 File Offset: 0x000D2A04
	private void DDFCIOMKEEB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1574f)
			{
				this.HBJJOCHGOPH = 1509f;
			}
			this.KAFBNOBOIAJ().SetFloat("NEW_ACHIEVEMENT_1_26", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("CameraFilterPack_Paper2", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002514 RID: 9492 RVA: 0x000D4894 File Offset: 0x000D2A94
	private Material CIAFLBFJLEJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002515 RID: 9493 RVA: 0x000D3EBB File Offset: 0x000D20BB
	private void AMHEJBMLFNM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002516 RID: 9494 RVA: 0x000D48CB File Offset: 0x000D2ACB
	private void EGEPLFGKGLI()
	{
		this.SCShader = Shader.Find("GameScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002517 RID: 9495 RVA: 0x0002523B File Offset: 0x0002343B
	private void JNBPKNNBMDI()
	{
	}

	// Token: 0x06002518 RID: 9496 RVA: 0x000D48EF File Offset: 0x000D2AEF
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.None;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002519 RID: 9497 RVA: 0x000D4928 File Offset: 0x000D2B28
	private void BODGDCPNBLL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 52f)
			{
				this.HBJJOCHGOPH = 1060f;
			}
			this.IONHGBPGCHK().SetFloat("CloseConnection: Only the masterclient can kick another player.", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("' found!", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600251A RID: 9498 RVA: 0x000D3EBB File Offset: 0x000D20BB
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600251B RID: 9499 RVA: 0x000D49B8 File Offset: 0x000D2BB8
	private void GAANDCGCBHF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 453f)
			{
				this.HBJJOCHGOPH = 324f;
			}
			this.OIMMPLPBLBK().SetFloat("PerfectHitsScoreText", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat("settings.volume.menu", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600251C RID: 9500 RVA: 0x000D4A48 File Offset: 0x000D2C48
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1472f)
			{
				this.HBJJOCHGOPH = 333f;
			}
			this.KAFBNOBOIAJ().SetFloat("GraphicsQualitySlider", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("_DotSize", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600251D RID: 9501 RVA: 0x000D4AD8 File Offset: 0x000D2CD8
	private Material KAFBNOBOIAJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600251E RID: 9502 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGDONBMDPGM()
	{
	}

	// Token: 0x0600251F RID: 9503 RVA: 0x000D4B0F File Offset: 0x000D2D0F
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)122;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002520 RID: 9504 RVA: 0x000D3EBB File Offset: 0x000D20BB
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002521 RID: 9505 RVA: 0x000D3EBB File Offset: 0x000D20BB
	private void GNMGIHFKJIJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002522 RID: 9506 RVA: 0x000D3EBB File Offset: 0x000D20BB
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002523 RID: 9507 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x06002524 RID: 9508 RVA: 0x000D4B46 File Offset: 0x000D2D46
	private void NEFHGMNAPEP()
	{
		this.SCShader = Shader.Find("Maps Editor v.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x17000067 RID: 103
	// (get) Token: 0x06002525 RID: 9509 RVA: 0x000D4B6A File Offset: 0x000D2D6A
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

	// Token: 0x06002526 RID: 9510 RVA: 0x000D3EBB File Offset: 0x000D20BB
	private void OOGIHDLBBLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002527 RID: 9511 RVA: 0x000D4BA4 File Offset: 0x000D2DA4
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1473f)
			{
				this.HBJJOCHGOPH = 1084f;
			}
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.HBJJOCHGOPH);
			this.IGIAPKPKGPK().SetFloat("roomDescription", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LNLKMDPHDCC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002528 RID: 9512 RVA: 0x000D4C34 File Offset: 0x000D2E34
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 269f)
			{
				this.HBJJOCHGOPH = 132f;
			}
			this.IGIAPKPKGPK().SetFloat("[MapsData] Bad map: ", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("#close", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002529 RID: 9513 RVA: 0x000D4CC4 File Offset: 0x000D2EC4
	private void EFMOIIPLOOB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 487f)
			{
				this.HBJJOCHGOPH = 572f;
			}
			this.MHBAIEKFBIJ().SetFloat("shader.ghost", this.HBJJOCHGOPH);
			this.HHIAIGCAHDA().SetFloat("_Greenness", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600252A RID: 9514 RVA: 0x000D4D54 File Offset: 0x000D2F54
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Colors_Threshold");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600252B RID: 9515 RVA: 0x000D4D78 File Offset: 0x000D2F78
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-125);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600252C RID: 9516 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x0600252D RID: 9517 RVA: 0x000D4DB0 File Offset: 0x000D2FB0
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 107f)
			{
				this.HBJJOCHGOPH = 1686f;
			}
			this.NBPKMLMCHFN.SetFloat("_NeighbourMaxTex", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("maps.", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHIFMIPPMPF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600252E RID: 9518 RVA: 0x000D4E40 File Offset: 0x000D3040
	private void NBGIMIDICKE()
	{
		this.SCShader = Shader.Find(" timeUntilRespawn: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600252F RID: 9519 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHCGBJDFMHG()
	{
	}

	// Token: 0x06002530 RID: 9520 RVA: 0x000D4E64 File Offset: 0x000D3064
	private void MKIFJMPELJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1216f)
			{
				this.HBJJOCHGOPH = 1634f;
			}
			this.LNLKMDPHDCC().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("[LocalizationService] Loading file: ", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CIAFLBFJLEJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002531 RID: 9521 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06002532 RID: 9522 RVA: 0x000D4EF4 File Offset: 0x000D30F4
	private void CKCPPNHANAA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 975f)
			{
				this.HBJJOCHGOPH = 1155f;
			}
			this.IONHGBPGCHK().SetFloat("Commands for challenges", this.HBJJOCHGOPH);
			this.MHBAIEKFBIJ().SetFloat("FavoriteButton", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002533 RID: 9523 RVA: 0x000D3EBB File Offset: 0x000D20BB
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002534 RID: 9524 RVA: 0x000D4F84 File Offset: 0x000D3184
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 202f)
			{
				this.HBJJOCHGOPH = 858f;
			}
			this.OIMMPLPBLBK().SetFloat("[DiscordController] Error {0}: {1}", this.HBJJOCHGOPH);
			this.MHBAIEKFBIJ().SetFloat("Object ID. Case-Sensitive", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KAFBNOBOIAJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002535 RID: 9525 RVA: 0x000D5014 File Offset: 0x000D3214
	private void KFGGHDFLDIP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 776f)
			{
				this.HBJJOCHGOPH = 135f;
			}
			this.FKEOGPDLBDD().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.MHBAIEKFBIJ().SetFloat("st", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002536 RID: 9526 RVA: 0x000D50A4 File Offset: 0x000D32A4
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("RecieveChatActionMessage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002537 RID: 9527 RVA: 0x000D3EBB File Offset: 0x000D20BB
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002538 RID: 9528 RVA: 0x000D50C8 File Offset: 0x000D32C8
	private void GOBILPKKHFA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1156f)
			{
				this.HBJJOCHGOPH = 1694f;
			}
			this.IONHGBPGCHK().SetFloat("settings.enableranking", this.HBJJOCHGOPH);
			this.FKEOGPDLBDD().SetFloat("player.lollipop", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DEFBJOCJJKF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002539 RID: 9529 RVA: 0x000D5158 File Offset: 0x000D3358
	private void ALJEJJCIMJN()
	{
		this.SCShader = Shader.Find("Object ID. Case-Sensitive");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600253A RID: 9530 RVA: 0x000D517C File Offset: 0x000D337C
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 907f)
			{
				this.HBJJOCHGOPH = 388f;
			}
			this.OIMMPLPBLBK().SetFloat("StopMusic", this.HBJJOCHGOPH);
			this.DEFBJOCJJKF().SetFloat("ready", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600253B RID: 9531 RVA: 0x000D520C File Offset: 0x000D340C
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("/Saved Games/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600253C RID: 9532 RVA: 0x000D5230 File Offset: 0x000D3430
	private void IPGKJCJBHDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1902f)
			{
				this.HBJJOCHGOPH = 1216f;
			}
			this.LNLKMDPHDCC().SetFloat("intensity", this.HBJJOCHGOPH);
			this.BKKJJJGADLM().SetFloat("IconImage", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600253D RID: 9533 RVA: 0x000D3EBB File Offset: 0x000D20BB
	private void GAOOPEEBGJA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600253E RID: 9534 RVA: 0x0002523B File Offset: 0x0002343B
	private void AGMJDGHLBMN()
	{
	}

	// Token: 0x0600253F RID: 9535 RVA: 0x000D52C0 File Offset: 0x000D34C0
	private void AGEJKLMJGDO()
	{
		this.SCShader = Shader.Find("_Size");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002540 RID: 9536 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x06002541 RID: 9537 RVA: 0x000D52E4 File Offset: 0x000D34E4
	private void PDHKMDBNGGN()
	{
		this.SCShader = Shader.Find("Joystick1Button2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002542 RID: 9538 RVA: 0x000D5308 File Offset: 0x000D3508
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)87;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002543 RID: 9539 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06002544 RID: 9540 RVA: 0x000D3EBB File Offset: 0x000D20BB
	private void CPAJLKHMOJB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002545 RID: 9541 RVA: 0x000D5340 File Offset: 0x000D3540
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 35f)
			{
				this.HBJJOCHGOPH = 498f;
			}
			this.IONHGBPGCHK().SetFloat("[MenuScene] Error: ", this.HBJJOCHGOPH);
			this.CIAFLBFJLEJ().SetFloat(".highscore", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFDEIFCDAFG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002546 RID: 9542 RVA: 0x000D53D0 File Offset: 0x000D35D0
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 78f)
			{
				this.HBJJOCHGOPH = 1483f;
			}
			this.OIMMPLPBLBK().SetFloat("1", this.HBJJOCHGOPH);
			this.EMDFHOKEGNG().SetFloat("CameraFilterPack_Glasses_On5", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IONHGBPGCHK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002547 RID: 9543 RVA: 0x000D5460 File Offset: 0x000D3660
	private Material LNLKMDPHDCC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002548 RID: 9544 RVA: 0x000D5497 File Offset: 0x000D3697
	private Material MHBAIEKFBIJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002549 RID: 9545 RVA: 0x000D54CE File Offset: 0x000D36CE
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("_Value4");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600254A RID: 9546 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x0600254B RID: 9547 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x0600254C RID: 9548 RVA: 0x000D54F4 File Offset: 0x000D36F4
	private void EEFLHPENNEI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 881f)
			{
				this.HBJJOCHGOPH = 126f;
			}
			this.NBPKMLMCHFN.SetFloat(". Client should be in a room. Current connectionStateDetailed: ", this.HBJJOCHGOPH);
			this.HHIFMIPPMPF().SetFloat("Save", this.Threshold);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADGHJOHKEHG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600254D RID: 9549 RVA: 0x000D47E0 File Offset: 0x000D29E0
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600254E RID: 9550 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600254F RID: 9551 RVA: 0x000D3EBB File Offset: 0x000D20BB
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002550 RID: 9552 RVA: 0x000D5584 File Offset: 0x000D3784
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("inventory.selected.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002551 RID: 9553 RVA: 0x0002523B File Offset: 0x0002343B
	private void POIMNOBDBBN()
	{
	}

	// Token: 0x06002552 RID: 9554 RVA: 0x000D55A8 File Offset: 0x000D37A8
	private void LIBGAKMKHJJ()
	{
		this.SCShader = Shader.Find("PenaltyScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002553 RID: 9555 RVA: 0x000D55CC File Offset: 0x000D37CC
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002554 RID: 9556 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x06002555 RID: 9557 RVA: 0x000D5603 File Offset: 0x000D3803
	private void HMPGIFBJFIK()
	{
		this.SCShader = Shader.Find("ItemNameText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002556 RID: 9558 RVA: 0x000D5627 File Offset: 0x000D3827
	private void ODBNMPGBCGO()
	{
		this.SCShader = Shader.Find("#FFDA44CC");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002557 RID: 9559 RVA: 0x0002523B File Offset: 0x0002343B
	private void EPJJDKJEDMM()
	{
	}

	// Token: 0x040004BD RID: 1213
	public Shader SCShader;

	// Token: 0x040004BE RID: 1214
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040004BF RID: 1215
	[Range(0f, 1f)]
	public float Threshold = 0.3f;

	// Token: 0x040004C0 RID: 1216
	private Material BJFKDHHMLJH;
}
