using System;
using UnityEngine;

// Token: 0x02000086 RID: 134
[AddComponentMenu("Camera Filter Pack/Distortion/BlackHole")]
[ExecuteInEditMode]
public class CameraFilterPack_Distortion_BlackHole : MonoBehaviour
{
	// Token: 0x06002613 RID: 9747 RVA: 0x000D7A57 File Offset: 0x000D5C57
	private void LBPHCAMMAPB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002614 RID: 9748 RVA: 0x000D7A74 File Offset: 0x000D5C74
	private void HDMDKOKOOJC()
	{
		this.SCShader = Shader.Find("_Value");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002615 RID: 9749 RVA: 0x000D7A57 File Offset: 0x000D5C57
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002617 RID: 9751 RVA: 0x000D7AC1 File Offset: 0x000D5CC1
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)66;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002618 RID: 9752 RVA: 0x000D7AF8 File Offset: 0x000D5CF8
	private Material JFDGLLEOPGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-69);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002619 RID: 9753 RVA: 0x000D7A57 File Offset: 0x000D5C57
	private void ODAIMOJLJOF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600261A RID: 9754 RVA: 0x000D7B30 File Offset: 0x000D5D30
	private void OAHHAAKEBDD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1270f)
			{
				this.HBJJOCHGOPH = 1135f;
			}
			this.LDNADDJMIPK().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("x", this.PositionX);
			this.GJHLADDCMFF().SetFloat("CameraFilterPack/FX_EarthQuake", this.PositionY);
			this.KGOLDDBHIFN().SetFloat("AudioSampler", this.Size);
			this.FEAEGGCNIAA().SetFloat("[BuildInfo] Error: ", this.Distortion);
			this.JIBOKBCPDLC().SetVector("[LevelEditorScene] Print Audio Wave: Start", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600261B RID: 9755 RVA: 0x000D7A57 File Offset: 0x000D5C57
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600261C RID: 9756 RVA: 0x0002523B File Offset: 0x0002343B
	private void HLDFOJMHKNL()
	{
	}

	// Token: 0x0600261D RID: 9757 RVA: 0x000D7C28 File Offset: 0x000D5E28
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 633f)
			{
				this.HBJJOCHGOPH = 1416f;
			}
			this.IGIAPKPKGPK().SetFloat("\" error: ", this.HBJJOCHGOPH);
			this.EFDEIFCDAFG().SetFloat(".icon", this.PositionX);
			this.BFGNMFCNDBC().SetFloat("shader.pixel", this.PositionY);
			this.DONENAMLFLF().SetFloat("_Value3", this.Size);
			this.NBPKMLMCHFN.SetFloat("_BlurDirectionPacked", this.Distortion);
			this.IGIAPKPKGPK().SetVector("Submition failed", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600261E RID: 9758 RVA: 0x000D7A57 File Offset: 0x000D5C57
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600261F RID: 9759 RVA: 0x000D7A57 File Offset: 0x000D5C57
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002620 RID: 9760 RVA: 0x0002523B File Offset: 0x0002343B
	private void DNENFLNCIJP()
	{
	}

	// Token: 0x06002621 RID: 9761 RVA: 0x000D7D20 File Offset: 0x000D5F20
	private Material IGIAPKPKGPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)120;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002622 RID: 9762 RVA: 0x000D7A57 File Offset: 0x000D5C57
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002623 RID: 9763 RVA: 0x000D7A57 File Offset: 0x000D5C57
	private void MGFFNGEGFDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002624 RID: 9764 RVA: 0x000D7D58 File Offset: 0x000D5F58
	private void PLHMAOMGFMF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 34f)
			{
				this.HBJJOCHGOPH = 948f;
			}
			this.PGPEMMBJOOG().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat(" not exist", this.PositionX);
			this.FEAEGGCNIAA().SetFloat("offsets", this.PositionY);
			this.GJHLADDCMFF().SetFloat("_Distortion", this.Size);
			this.LDNADDJMIPK().SetFloat("ReconnectAndRejoin() enabled isMessageQueueRunning. Needs to be able to dispatch incoming messages.", this.Distortion);
			this.FEAEGGCNIAA().SetVector("player.egglipszerotwo", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JLHLHKPHDFO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002625 RID: 9765 RVA: 0x000D7E50 File Offset: 0x000D6050
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1618f)
			{
				this.HBJJOCHGOPH = 124f;
			}
			this.NBPKMLMCHFN.SetFloat(" - ", this.HBJJOCHGOPH);
			this.JFDGLLEOPGB().SetFloat("LevelNameInputField", this.PositionX);
			this.FEAEGGCNIAA().SetFloat("[Up-Left]", this.PositionY);
			this.FEAEGGCNIAA().SetFloat("player.rgb", this.Size);
			this.NFMGLIKNOOC().SetFloat("CameraFilterPack_Paper4", this.Distortion);
			this.JIBOKBCPDLC().SetVector("delete", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DONENAMLFLF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002626 RID: 9766 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x06002627 RID: 9767 RVA: 0x000D7A57 File Offset: 0x000D5C57
	private void GPHPJIDGEPI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002628 RID: 9768 RVA: 0x000D7F48 File Offset: 0x000D6148
	private Material ADGHJOHKEHG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002629 RID: 9769 RVA: 0x000D7A57 File Offset: 0x000D5C57
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600262A RID: 9770 RVA: 0x000D7F7F File Offset: 0x000D617F
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-116);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600262B RID: 9771 RVA: 0x000D7F48 File Offset: 0x000D6148
	private Material GCDFNHMJMIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600262C RID: 9772 RVA: 0x0002523B File Offset: 0x0002343B
	private void KCDOMIJBFLL()
	{
	}

	// Token: 0x0600262D RID: 9773 RVA: 0x000D7FB8 File Offset: 0x000D61B8
	private void KBGCKEDIGAH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 439f)
			{
				this.HBJJOCHGOPH = 1350f;
			}
			this.ABHDNGIHBKE().SetFloat("\" gets executed locally only, if at all.", this.HBJJOCHGOPH);
			this.GJHLADDCMFF().SetFloat("ConfigVersionSlider", this.PositionX);
			this.ACHNOHCLGOO().SetFloat("There is already a virtual axis named ", this.PositionY);
			this.ABHDNGIHBKE().SetFloat("_TimeX", this.Size);
			this.LDNADDJMIPK().SetFloat("  |  Events Count: ", this.Distortion);
			this.PGPEMMBJOOG().SetVector("Scene", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.PGPEMMBJOOG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600262E RID: 9774 RVA: 0x000D80B0 File Offset: 0x000D62B0
	private void PKLOBJHKFEO()
	{
		this.SCShader = Shader.Find("UI/Particles/Hidden");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600262F RID: 9775 RVA: 0x000D80D4 File Offset: 0x000D62D4
	private void JPOOAJCAJJF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1842f)
			{
				this.HBJJOCHGOPH = 58f;
			}
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.HBJJOCHGOPH);
			this.FEAEGGCNIAA().SetFloat("CameraFilterPack/TV_Vintage", this.PositionX);
			this.FEAEGGCNIAA().SetFloat("_Value", this.PositionY);
			this.PGPEMMBJOOG().SetFloat("Error: You're not logged into Steam!", this.Size);
			this.JIBOKBCPDLC().SetFloat("_TimeX", this.Distortion);
			this.NBPKMLMCHFN.SetVector("Joystick1Button2", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KGOLDDBHIFN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002630 RID: 9776 RVA: 0x000D81CC File Offset: 0x000D63CC
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002631 RID: 9777 RVA: 0x000D8203 File Offset: 0x000D6403
	private Material JLHLHKPHDFO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002632 RID: 9778 RVA: 0x000D823A File Offset: 0x000D643A
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInInspector;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002633 RID: 9779 RVA: 0x000D8271 File Offset: 0x000D6471
	private Material NFMGLIKNOOC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002634 RID: 9780 RVA: 0x000D82A8 File Offset: 0x000D64A8
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002635 RID: 9781 RVA: 0x000D82DF File Offset: 0x000D64DF
	private Material ACHNOHCLGOO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002636 RID: 9782 RVA: 0x000D7A57 File Offset: 0x000D5C57
	private void CCPEDDLAMIB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002637 RID: 9783 RVA: 0x000D8316 File Offset: 0x000D6516
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002638 RID: 9784 RVA: 0x000D834D File Offset: 0x000D654D
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSave;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002639 RID: 9785 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x0600263A RID: 9786 RVA: 0x000D7A57 File Offset: 0x000D5C57
	private void PLIKADJCEPO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600263B RID: 9787 RVA: 0x000D8384 File Offset: 0x000D6584
	private Material DONENAMLFLF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600263C RID: 9788 RVA: 0x000D83BB File Offset: 0x000D65BB
	private Material FEAEGGCNIAA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontSaveInEditor;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600263D RID: 9789 RVA: 0x000D83F4 File Offset: 0x000D65F4
	private void CDCLDBFMKOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1999f)
			{
				this.HBJJOCHGOPH = 684f;
			}
			this.PGPEMMBJOOG().SetFloat("Scene", this.HBJJOCHGOPH);
			this.IGIAPKPKGPK().SetFloat("CameraFilterPack/Color_GrayScale", this.PositionX);
			this.NBPKMLMCHFN.SetFloat("BitsData", this.PositionY);
			this.PGPEMMBJOOG().SetFloat("No player left to ask", this.Size);
			this.KGOLDDBHIFN().SetFloat("achievements.21.progress", this.Distortion);
			this.GCDFNHMJMIP().SetVector("_Distortion", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600263E RID: 9790 RVA: 0x000D84EC File Offset: 0x000D66EC
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 134f)
			{
				this.HBJJOCHGOPH = 1415f;
			}
			this.LPDOGGFOBDH().SetFloat("player.licenceaccepted", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat("_Value5", this.PositionX);
			this.JLHLHKPHDFO().SetFloat(":", this.PositionY);
			this.NFMGLIKNOOC().SetFloat(".ogg", this.Size);
			this.BFGNMFCNDBC().SetFloat("JoinRandomRoom failed. In offline mode you still have to leave a room to enter another.", this.Distortion);
			this.GJHLADDCMFF().SetVector("RoomNameText", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.IGIAPKPKGPK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600263F RID: 9791 RVA: 0x000D85E4 File Offset: 0x000D67E4
	private void ICILLMAKLMI()
	{
		this.SCShader = Shader.Find("[ItemsHandler] Loading ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06002640 RID: 9792 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x06002641 RID: 9793 RVA: 0x0002523B File Offset: 0x0002343B
	private void NFEDLAOPHML()
	{
	}

	// Token: 0x06002642 RID: 9794 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06002643 RID: 9795 RVA: 0x000D8608 File Offset: 0x000D6808
	private Material LDNADDJMIPK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002644 RID: 9796 RVA: 0x000D8640 File Offset: 0x000D6840
	private void OHDKDLLBNFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1295f)
			{
				this.HBJJOCHGOPH = 5f;
			}
			this.GCDFNHMJMIP().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.NFMGLIKNOOC().SetFloat("_Value2", this.PositionX);
			this.EFDEIFCDAFG().SetFloat("RB", this.PositionY);
			this.CEKJODEAMGB().SetFloat("ticket", this.Size);
			this.DONENAMLFLF().SetFloat("  |  Events Count: ", this.Distortion);
			this.CEKJODEAMGB().SetVector("NEW_ACHIEVEMENT_1_", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002645 RID: 9797 RVA: 0x000D8738 File Offset: 0x000D6938
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)109;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002646 RID: 9798 RVA: 0x000D876F File Offset: 0x000D696F
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Distortion_BlackHole");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002647 RID: 9799 RVA: 0x0002523B File Offset: 0x0002343B
	private void IDIIELPAMCJ()
	{
	}

	// Token: 0x06002648 RID: 9800 RVA: 0x0002523B File Offset: 0x0002343B
	private void NEKCPLGFOFD()
	{
	}

	// Token: 0x06002649 RID: 9801 RVA: 0x0002523B File Offset: 0x0002343B
	private void NDAJBJFJGCF()
	{
	}

	// Token: 0x0600264A RID: 9802 RVA: 0x0002523B File Offset: 0x0002343B
	private void IKIDIJLIGOH()
	{
	}

	// Token: 0x0600264B RID: 9803 RVA: 0x0002523B File Offset: 0x0002343B
	private void IEMEHGCFAPD()
	{
	}

	// Token: 0x0600264C RID: 9804 RVA: 0x000D7A57 File Offset: 0x000D5C57
	private void DFENCIHAADO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600264D RID: 9805 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600264E RID: 9806 RVA: 0x000D8793 File Offset: 0x000D6993
	private void PAKPHKPDKGE()
	{
		this.SCShader = Shader.Find("RULES");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600264F RID: 9807 RVA: 0x000D7A57 File Offset: 0x000D5C57
	private void MFLBEJHMEMO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002650 RID: 9808 RVA: 0x000D87B7 File Offset: 0x000D69B7
	private void JMEOGJHCONJ()
	{
		this.SCShader = Shader.Find("Using Stopwatch as precision timer for PUN.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06002651 RID: 9809 RVA: 0x000D7A57 File Offset: 0x000D5C57
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002652 RID: 9810 RVA: 0x000D7A57 File Offset: 0x000D5C57
	private void NAALCEPIHCH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06002653 RID: 9811 RVA: 0x000D87DC File Offset: 0x000D69DC
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 6f)
			{
				this.HBJJOCHGOPH = 1695f;
			}
			this.LDNADDJMIPK().SetFloat("_ColorB", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("accuracy", this.PositionX);
			this.JIBOKBCPDLC().SetFloat("id", this.PositionY);
			this.BFGNMFCNDBC().SetFloat("_InvScreenSize", this.Size);
			this.KGOLDDBHIFN().SetFloat("...", this.Distortion);
			this.GJHLADDCMFF().SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002654 RID: 9812 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x06002655 RID: 9813 RVA: 0x0002523B File Offset: 0x0002343B
	private void JAAJECBCCFM()
	{
	}

	// Token: 0x06002656 RID: 9814 RVA: 0x000D88D4 File Offset: 0x000D6AD4
	private Material OGMEGHKECAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002657 RID: 9815 RVA: 0x000D890C File Offset: 0x000D6B0C
	private void NEALKDCJCJH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 665f)
			{
				this.HBJJOCHGOPH = 322f;
			}
			this.OGMEGHKECAH().SetFloat("Edited hands count", this.HBJJOCHGOPH);
			this.IGIAPKPKGPK().SetFloat("LastHighScoreText", this.PositionX);
			this.IGIAPKPKGPK().SetFloat("workshop.", this.PositionY);
			this.GJHLADDCMFF().SetFloat("_Value2", this.Size);
			this.JLHLHKPHDFO().SetFloat("CameraFilterPack/Blend2Camera_Color", this.Distortion);
			this.LPDOGGFOBDH().SetVector("': ", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GCDFNHMJMIP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002658 RID: 9816 RVA: 0x0002523B File Offset: 0x0002343B
	private void JDGFCEPDKAJ()
	{
	}

	// Token: 0x06002659 RID: 9817 RVA: 0x000D8A04 File Offset: 0x000D6C04
	private Material PGPEMMBJOOG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600265A RID: 9818 RVA: 0x000D8A3B File Offset: 0x000D6C3B
	private Material KGOLDDBHIFN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)75;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600265B RID: 9819 RVA: 0x000D7A57 File Offset: 0x000D5C57
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600265C RID: 9820 RVA: 0x000D7A57 File Offset: 0x000D5C57
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600265D RID: 9821 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x0600265E RID: 9822 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x0600265F RID: 9823 RVA: 0x000D8A72 File Offset: 0x000D6C72
	private Material EFDEIFCDAFG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-128);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06002660 RID: 9824 RVA: 0x000D7A57 File Offset: 0x000D5C57
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x1700006B RID: 107
	// (get) Token: 0x06002661 RID: 9825 RVA: 0x000D8AA9 File Offset: 0x000D6CA9
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

	// Token: 0x06002662 RID: 9826 RVA: 0x000D8AE0 File Offset: 0x000D6CE0
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1012f)
			{
				this.HBJJOCHGOPH = 367f;
			}
			this.JLHLHKPHDFO().SetFloat("EventConfigButton", this.HBJJOCHGOPH);
			this.GCDFNHMJMIP().SetFloat("_NoiseTex", this.PositionX);
			this.BFGNMFCNDBC().SetFloat("_TimeX", this.PositionY);
			this.DNLMFEGJJDD().SetFloat("_Value2", this.Size);
			this.BFGNMFCNDBC().SetFloat("PUNCloudBestRegion", this.Distortion);
			this.KGOLDDBHIFN().SetVector("SlidingArea", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.JFDGLLEOPGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002663 RID: 9827 RVA: 0x000D8BD8 File Offset: 0x000D6DD8
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 817f)
			{
				this.HBJJOCHGOPH = 194f;
			}
			this.NFMGLIKNOOC().SetFloat("maps.", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("CameraFilterPack/Edge_Neon", this.PositionX);
			this.ADGHJOHKEHG().SetFloat("_Near", this.PositionY);
			this.BFGNMFCNDBC().SetFloat("maps.", this.Size);
			this.ACHNOHCLGOO().SetFloat("solo", this.Distortion);
			this.NFMGLIKNOOC().SetVector("Joystick1Button11", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.CEKJODEAMGB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002664 RID: 9828 RVA: 0x000D8CD0 File Offset: 0x000D6ED0
	private void NKKLGKPFPIK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 194f)
			{
				this.HBJJOCHGOPH = 157f;
			}
			this.ABHDNGIHBKE().SetFloat(".lastCheckpoint.longestComboScore", this.HBJJOCHGOPH);
			this.OGMEGHKECAH().SetFloat(" scene: ", this.PositionX);
			this.FEAEGGCNIAA().SetFloat("?", this.PositionY);
			this.GCDFNHMJMIP().SetFloat("_Color_G", this.Size);
			this.BFGNMFCNDBC().SetFloat("UseFinalGlassColor", this.Distortion);
			this.ADGHJOHKEHG().SetVector("player.linea", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002665 RID: 9829 RVA: 0x000D8DC8 File Offset: 0x000D6FC8
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
			this.NBPKMLMCHFN.SetFloat("_PositionX", this.PositionX);
			this.NBPKMLMCHFN.SetFloat("_PositionY", this.PositionY);
			this.NBPKMLMCHFN.SetFloat("_Distortion", this.Size);
			this.NBPKMLMCHFN.SetFloat("_Distortion2", this.Distortion);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06002666 RID: 9830 RVA: 0x000D8EC0 File Offset: 0x000D70C0
	private void CFFCLAHMBAA()
	{
		this.SCShader = Shader.Find("settings.arcsdestroydelay");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x040004D4 RID: 1236
	public Shader SCShader;

	// Token: 0x040004D5 RID: 1237
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040004D6 RID: 1238
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040004D7 RID: 1239
	private Material BJFKDHHMLJH;

	// Token: 0x040004D8 RID: 1240
	[Range(-1f, 1f)]
	public float PositionX;

	// Token: 0x040004D9 RID: 1241
	[Range(-1f, 1f)]
	public float PositionY;

	// Token: 0x040004DA RID: 1242
	[Range(-5f, 5f)]
	public float Size = 0.05f;

	// Token: 0x040004DB RID: 1243
	[Range(0f, 180f)]
	public float Distortion = 30f;
}
