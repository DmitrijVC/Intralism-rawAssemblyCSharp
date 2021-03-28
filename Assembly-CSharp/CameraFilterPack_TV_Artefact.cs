using System;
using UnityEngine;

// Token: 0x02000111 RID: 273
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/TV/Artefact")]
public class CameraFilterPack_TV_Artefact : MonoBehaviour
{
	// Token: 0x06005503 RID: 21763 RVA: 0x001A507D File Offset: 0x001A327D
	private void LOMDIOLNFHI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005504 RID: 21764 RVA: 0x001A507D File Offset: 0x001A327D
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005505 RID: 21765 RVA: 0x0002523B File Offset: 0x0002343B
	private void AEIJFLJEABG()
	{
	}

	// Token: 0x06005506 RID: 21766 RVA: 0x001A507D File Offset: 0x001A327D
	private void FGBDGGCBFLP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005507 RID: 21767 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x06005508 RID: 21768 RVA: 0x0002523B File Offset: 0x0002343B
	private void OIBMHPIFAKK()
	{
	}

	// Token: 0x06005509 RID: 21769 RVA: 0x001A509A File Offset: 0x001A329A
	private void FIJHDKIPENG()
	{
		this.SCShader = Shader.Find("_MatrixColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600550A RID: 21770 RVA: 0x001A50C0 File Offset: 0x001A32C0
	private void HCOGCFOBBMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 823f)
			{
				this.HBJJOCHGOPH = 198f;
			}
			this.MHBAIEKFBIJ().SetFloat("Case-Sensitive", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("menu.tabid", this.Colorisation);
			this.ADBKPGFMNKO().SetFloat("---", this.Parasite);
			this.DOMEEFLPEPJ().SetFloat("Error: I/O Failure", this.Noise);
			this.BFGNMFCNDBC().SetFloat("menu.relaxinfo", this.Fade);
			this.NBPKMLMCHFN.SetVector("[LevelEditorScene] Print Audio Wave: Done", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 796f, 185f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600550B RID: 21771 RVA: 0x001A51C0 File Offset: 0x001A33C0
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1536f)
			{
				this.HBJJOCHGOPH = 1495f;
			}
			this.EOCCJGIGEGJ().SetFloat("st", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("StartButton", this.Colorisation);
			this.DOHGBNPMBKG().SetFloat("menu.playedsolo", this.Parasite);
			this.HHLFDHNEIAH().SetFloat("_ReflectionBlur", this.Noise);
			this.DNLMFEGJJDD().SetFloat("LevelProgressBar", this.Fade);
			this.ADBKPGFMNKO().SetVector("default", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1418f, 642f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600550C RID: 21772 RVA: 0x001A52C0 File Offset: 0x001A34C0
	private void BLMICAMBBCD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1520f)
			{
				this.HBJJOCHGOPH = 794f;
			}
			this.AELJLBOJAIL().SetFloat("_Value7", this.HBJJOCHGOPH);
			this.MHBAIEKFBIJ().SetFloat("_TimeX", this.Colorisation);
			this.AELJLBOJAIL().SetFloat("Copy from ", this.Parasite);
			this.MHBAIEKFBIJ().SetFloat(".highscore", this.Noise);
			this.DOMEEFLPEPJ().SetFloat("SUBMIT", this.Fade);
			this.EOCCJGIGEGJ().SetVector("Anomaly_Near", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 457f, 464f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600550D RID: 21773 RVA: 0x001A53C0 File Offset: 0x001A35C0
	private void LDIOANOMHMO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1761f)
			{
				this.HBJJOCHGOPH = 1465f;
			}
			this.NBPKMLMCHFN.SetFloat("#rategameinfo", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("#", this.Colorisation);
			this.ADBKPGFMNKO().SetFloat("settings.fps", this.Parasite);
			this.LPMLLJKMAMP().SetFloat("<b>#", this.Noise);
			this.DOHGBNPMBKG().SetFloat("Default UI Material", this.Fade);
			this.BFGNMFCNDBC().SetVector(" registered.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 899f, 915f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600550E RID: 21774 RVA: 0x001A54BF File Offset: 0x001A36BF
	private Material FHFLKLMFHOI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-105);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600550F RID: 21775 RVA: 0x001A54F6 File Offset: 0x001A36F6
	private void IHLMNAGPKDA()
	{
		this.SCShader = Shader.Find("Anomaly_Near");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005510 RID: 21776 RVA: 0x001A551A File Offset: 0x001A371A
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("Vertical");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005511 RID: 21777 RVA: 0x001A507D File Offset: 0x001A327D
	private void BFEILOMHNPC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005512 RID: 21778 RVA: 0x001A553E File Offset: 0x001A373E
	private Material EOCCJGIGEGJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)106;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005513 RID: 21779 RVA: 0x001A5578 File Offset: 0x001A3778
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1413f)
			{
				this.HBJJOCHGOPH = 65f;
			}
			this.HNFFHCLNBDN().SetFloat("player.blackwhite", this.HBJJOCHGOPH);
			this.HHLFDHNEIAH().SetFloat("[FileSelector] Dialog canceled", this.Colorisation);
			this.KJMECMIGJJA().SetFloat("player.dragon", this.Parasite);
			this.KJMECMIGJJA().SetFloat("_Offsets", this.Noise);
			this.PDEAHJPOMEF().SetFloat("_Value5", this.Fade);
			this.AELJLBOJAIL().SetVector("_Value12", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 191f, 1096f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005514 RID: 21780 RVA: 0x001A507D File Offset: 0x001A327D
	private void IBPAMDEAGJL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005515 RID: 21781 RVA: 0x001A5677 File Offset: 0x001A3877
	private Material BFGNMFCNDBC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005516 RID: 21782 RVA: 0x001A56AE File Offset: 0x001A38AE
	private Material KJMECMIGJJA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005517 RID: 21783 RVA: 0x001A507D File Offset: 0x001A327D
	private void EDBEHEKMGFH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005518 RID: 21784 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x06005519 RID: 21785 RVA: 0x001A56E5 File Offset: 0x001A38E5
	private void EFJDNLGNACH()
	{
		this.SCShader = Shader.Find("SpawnObj");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600551A RID: 21786 RVA: 0x001A570C File Offset: 0x001A390C
	private void JIAAFKOPEKO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1447f)
			{
				this.HBJJOCHGOPH = 822f;
			}
			this.DNLMFEGJJDD().SetFloat("_Value", this.HBJJOCHGOPH);
			this.HNFFHCLNBDN().SetFloat("/?player=", this.Colorisation);
			this.DNLMFEGJJDD().SetFloat("id", this.Parasite);
			this.AELJLBOJAIL().SetFloat("OpAuthenticate()", this.Noise);
			this.EOCCJGIGEGJ().SetFloat("_Value3", this.Fade);
			this.AELJLBOJAIL().SetVector("#md5submitionfailed: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 925f, 1418f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600551B RID: 21787 RVA: 0x001A580B File Offset: 0x001A3A0B
	private void DOKAKEMDALN()
	{
		this.SCShader = Shader.Find("CameraFilterPack/OldFilm_Cutting1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600551C RID: 21788 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x0600551D RID: 21789 RVA: 0x0002523B File Offset: 0x0002343B
	private void HNDNDPECBPL()
	{
	}

	// Token: 0x0600551E RID: 21790 RVA: 0x001A582F File Offset: 0x001A3A2F
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600551F RID: 21791 RVA: 0x001A5853 File Offset: 0x001A3A53
	private Material AELJLBOJAIL()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005520 RID: 21792 RVA: 0x001A588C File Offset: 0x001A3A8C
	private void AIJJOIOAKGD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1310f)
			{
				this.HBJJOCHGOPH = 649f;
			}
			this.PDEAHJPOMEF().SetFloat("%", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("NewIconFileSelector", this.Colorisation);
			this.FHFLKLMFHOI().SetFloat("LoadMapCanvas", this.Parasite);
			this.DNLMFEGJJDD().SetFloat("#tryagain", this.Noise);
			this.DNLMFEGJJDD().SetFloat("Failed to InstantiateSceneObject prefab:", this.Fade);
			this.DOHGBNPMBKG().SetVector("[LevelEditorScene] Map submitted!", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1015f, 1197f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FHFLKLMFHOI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005521 RID: 21793 RVA: 0x001A598B File Offset: 0x001A3B8B
	private Material PDEAHJPOMEF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)64;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005522 RID: 21794 RVA: 0x001A507D File Offset: 0x001A327D
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005523 RID: 21795 RVA: 0x001A507D File Offset: 0x001A327D
	private void EODOHEAKJFO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005524 RID: 21796 RVA: 0x001A507D File Offset: 0x001A327D
	private void ELDMKIAPNGP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005525 RID: 21797 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06005526 RID: 21798 RVA: 0x001A59C2 File Offset: 0x001A3BC2
	private Material DNLMFEGJJDD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-122);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005527 RID: 21799 RVA: 0x001A59FC File Offset: 0x001A3BFC
	private void KMAPABACMAG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1412f)
			{
				this.HBJJOCHGOPH = 1165f;
			}
			this.DNLMFEGJJDD().SetFloat("_MainTex2", this.HBJJOCHGOPH);
			this.HHLFDHNEIAH().SetFloat("</b>", this.Colorisation);
			this.EOCCJGIGEGJ().SetFloat("x", this.Parasite);
			this.PDEAHJPOMEF().SetFloat("_Color_R", this.Noise);
			this.DOHGBNPMBKG().SetFloat("turn: {0:0}", this.Fade);
			this.FHFLKLMFHOI().SetVector("Exit to menu?", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 479f, 1161f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005528 RID: 21800 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x06005529 RID: 21801 RVA: 0x001A5AFB File Offset: 0x001A3CFB
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600552A RID: 21802 RVA: 0x001A5B32 File Offset: 0x001A3D32
	private void HIPEHGNBJMN()
	{
		this.SCShader = Shader.Find("#close");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600552B RID: 21803 RVA: 0x001A5B56 File Offset: 0x001A3D56
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("https://steamcommunity.com/sharedfiles/filedetails/?id=");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600552C RID: 21804 RVA: 0x001A5B7A File Offset: 0x001A3D7A
	private void KDMANOEMOCA()
	{
		this.SCShader = Shader.Find("#yes");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600552D RID: 21805 RVA: 0x001A5BA0 File Offset: 0x001A3DA0
	private void JBMEPDENLOM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 277f)
			{
				this.HBJJOCHGOPH = 1337f;
			}
			this.DOHGBNPMBKG().SetFloat("No Name", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("RanksButton", this.Colorisation);
			this.DNLMFEGJJDD().SetFloat("CameraFilterPack/AAA_Blood", this.Parasite);
			this.MHBAIEKFBIJ().SetFloat("IntraTime", this.Noise);
			this.DOMEEFLPEPJ().SetFloat("UseScanLineSize", this.Fade);
			this.HNFFHCLNBDN().SetVector(". Verify the Prefab is in a Resources folder (and not in a subfolder)", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1831f, 1960f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600552E RID: 21806 RVA: 0x001A5C9F File Offset: 0x001A3E9F
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600552F RID: 21807 RVA: 0x001A507D File Offset: 0x001A327D
	private void BKGJOECFMID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005530 RID: 21808 RVA: 0x001A5CD8 File Offset: 0x001A3ED8
	private void KCNIHHNMFFF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1724f)
			{
				this.HBJJOCHGOPH = 955f;
			}
			this.KHCLIAMBBNC().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.FHFLKLMFHOI().SetFloat("_HighlightSuppression", this.Colorisation);
			this.AELJLBOJAIL().SetFloat(" but this PhotonView does not exist! View was/is ours.", this.Parasite);
			this.ADBKPGFMNKO().SetFloat("EventTimeInputField", this.Noise);
			this.DOMEEFLPEPJ().SetFloat("GlassColor", this.Fade);
			this.DNLMFEGJJDD().SetVector("FinalScoreSmallText", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 898f, 1811f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KJMECMIGJJA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005531 RID: 21809 RVA: 0x001A5DD7 File Offset: 0x001A3FD7
	private void CCFEDENFNEF()
	{
		this.SCShader = Shader.Find("#lives");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005532 RID: 21810 RVA: 0x0002523B File Offset: 0x0002343B
	private void BGFJOEPFOPM()
	{
	}

	// Token: 0x06005533 RID: 21811 RVA: 0x001A5DFC File Offset: 0x001A3FFC
	private void DDBNDCAFHOA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 5f)
			{
				this.HBJJOCHGOPH = 240f;
			}
			this.LPMLLJKMAMP().SetFloat("Set environment sprite color and alpha.", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("maps.", this.Colorisation);
			this.LPMLLJKMAMP().SetFloat("_Offsets", this.Parasite);
			this.ADBKPGFMNKO().SetFloat("&", this.Noise);
			this.KJMECMIGJJA().SetFloat(" cannot be used as a 3D LUT.", this.Fade);
			this.PDEAHJPOMEF().SetVector("[LocalizationService] All languages: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 992f, 1995f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005534 RID: 21812 RVA: 0x001A507D File Offset: 0x001A327D
	private void EKCDEFDELMP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005535 RID: 21813 RVA: 0x0002523B File Offset: 0x0002343B
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x06005536 RID: 21814 RVA: 0x001A507D File Offset: 0x001A327D
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005537 RID: 21815 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06005538 RID: 21816 RVA: 0x0002523B File Offset: 0x0002343B
	private void PFNFPINPCMH()
	{
	}

	// Token: 0x06005539 RID: 21817 RVA: 0x001A507D File Offset: 0x001A327D
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600553A RID: 21818 RVA: 0x001A507D File Offset: 0x001A327D
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600553B RID: 21819 RVA: 0x001A5EFB File Offset: 0x001A40FB
	private Material KHCLIAMBBNC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600553C RID: 21820 RVA: 0x0002523B File Offset: 0x0002343B
	private void HPNNCNNFMGK()
	{
	}

	// Token: 0x0600553D RID: 21821 RVA: 0x001A5F32 File Offset: 0x001A4132
	private void MGMAOBPPOBJ()
	{
		this.SCShader = Shader.Find("L2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600553E RID: 21822 RVA: 0x0002523B File Offset: 0x0002343B
	private void POJFHDFJOPE()
	{
	}

	// Token: 0x0600553F RID: 21823 RVA: 0x001A507D File Offset: 0x001A327D
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005540 RID: 21824 RVA: 0x001A5F56 File Offset: 0x001A4156
	private Material HHLFDHNEIAH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)107;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005541 RID: 21825 RVA: 0x001A5F8D File Offset: 0x001A418D
	private void ADPLHDFJFID()
	{
		this.SCShader = Shader.Find("settings.shaders");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005542 RID: 21826 RVA: 0x001A5FB4 File Offset: 0x001A41B4
	private void JKMBDBCDJAL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 839f)
			{
				this.HBJJOCHGOPH = 899f;
			}
			this.DOHGBNPMBKG().SetFloat("#close", this.HBJJOCHGOPH);
			this.ADBKPGFMNKO().SetFloat("Screenshots only supported in PlayMode", this.Colorisation);
			this.KJMECMIGJJA().SetFloat("_Value2", this.Parasite);
			this.FHFLKLMFHOI().SetFloat("[LocalizationService] Localization: ", this.Noise);
			this.KHCLIAMBBNC().SetFloat("SetSatelliteEmission", this.Fade);
			this.KJMECMIGJJA().SetVector("LevelConfigButton", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 80f, 1038f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.BFGNMFCNDBC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005543 RID: 21827 RVA: 0x001A60B3 File Offset: 0x001A42B3
	private void OHFOLGANOLC()
	{
		this.SCShader = Shader.Find("Set sun min/max size");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005544 RID: 21828 RVA: 0x0002523B File Offset: 0x0002343B
	private void FABKIGNFECE()
	{
	}

	// Token: 0x06005545 RID: 21829 RVA: 0x001A507D File Offset: 0x001A327D
	private void LADCJEIALMH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005546 RID: 21830 RVA: 0x0002523B File Offset: 0x0002343B
	private void KDJEJBBDILE()
	{
	}

	// Token: 0x06005547 RID: 21831 RVA: 0x001A60D8 File Offset: 0x001A42D8
	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 218f)
			{
				this.HBJJOCHGOPH = 1606f;
			}
			this.EOCCJGIGEGJ().SetFloat("_PositionX", this.HBJJOCHGOPH);
			this.HHLFDHNEIAH().SetFloat("_Value3", this.Colorisation);
			this.DOHGBNPMBKG().SetFloat("[MapsStats] Length: ", this.Parasite);
			this.KJMECMIGJJA().SetFloat("_Value2", this.Noise);
			this.HNFFHCLNBDN().SetFloat("#exit", this.Fade);
			this.DOMEEFLPEPJ().SetVector("The server address is 127.0.0.1 (localhost): Make sure the server is running on this machine. Android and iOS emulators have their own localhost.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 615f, 626f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005548 RID: 21832 RVA: 0x001A61D8 File Offset: 0x001A43D8
	private void HJGNJDAADGP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 340f)
			{
				this.HBJJOCHGOPH = 1913f;
			}
			this.KHCLIAMBBNC().SetFloat("{\"items\":", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("LastHighScoreText", this.Colorisation);
			this.LPMLLJKMAMP().SetFloat("_ScreenResolution", this.Parasite);
			this.MHBAIEKFBIJ().SetFloat("MessageText", this.Noise);
			this.DOHGBNPMBKG().SetFloat("#ok", this.Fade);
			this.FHFLKLMFHOI().SetVector("skin.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1031f, 909f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005549 RID: 21833 RVA: 0x001A62D8 File Offset: 0x001A44D8
	private void BGMNONMHAJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1360f)
			{
				this.HBJJOCHGOPH = 1124f;
			}
			this.PDEAHJPOMEF().SetFloat("CameraFilterPack/FX_DigitalMatrix", this.HBJJOCHGOPH);
			this.BFGNMFCNDBC().SetFloat("System.Int32", this.Colorisation);
			this.FHFLKLMFHOI().SetFloat("_ScreenResolution", this.Parasite);
			this.KJMECMIGJJA().SetFloat("#discord{0}joinrequest", this.Noise);
			this.NBPKMLMCHFN.SetFloat("_MainTex2", this.Fade);
			this.ADBKPGFMNKO().SetVector("[EditorEvent] Exception: ", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1781f, 1592f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EOCCJGIGEGJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600554A RID: 21834 RVA: 0x001A63D8 File Offset: 0x001A45D8
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 31f)
			{
				this.HBJJOCHGOPH = 1387f;
			}
			this.DOHGBNPMBKG().SetFloat("ScrollPanel", this.HBJJOCHGOPH);
			this.DOMEEFLPEPJ().SetFloat("CameraFilterPack/3D_Myst", this.Colorisation);
			this.MHBAIEKFBIJ().SetFloat("_RGB", this.Parasite);
			this.LPMLLJKMAMP().SetFloat("Edited unlock conditions", this.Noise);
			this.PDEAHJPOMEF().SetFloat("' has been reset to the fault value", this.Fade);
			this.KHCLIAMBBNC().SetVector("SpawnObj", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1164f, 1869f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600554B RID: 21835 RVA: 0x001A64D7 File Offset: 0x001A46D7
	private void FMNPFCHBLJF()
	{
		this.SCShader = Shader.Find("curScn");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600554C RID: 21836 RVA: 0x001A507D File Offset: 0x001A327D
	private void IABLKKAALGI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600554D RID: 21837 RVA: 0x001A64FB File Offset: 0x001A46FB
	private void IGPCNCJIEOJ()
	{
		this.SCShader = Shader.Find("_NoiseTilingPerChannel");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600554E RID: 21838 RVA: 0x001A6520 File Offset: 0x001A4720
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 261f)
			{
				this.HBJJOCHGOPH = 47f;
			}
			this.PDEAHJPOMEF().SetFloat(" not exist", this.HBJJOCHGOPH);
			this.PDEAHJPOMEF().SetFloat("_ScreenResolution", this.Colorisation);
			this.KHCLIAMBBNC().SetFloat("CameraFilterPack/Blend2Camera_DarkerColor", this.Parasite);
			this.KJMECMIGJJA().SetFloat("_Value4", this.Noise);
			this.DOMEEFLPEPJ().SetFloat("Item creation successful! Published Item ID: ", this.Fade);
			this.AELJLBOJAIL().SetVector("_Value3", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 196f, 880f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HHLFDHNEIAH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600554F RID: 21839 RVA: 0x001A507D File Offset: 0x001A327D
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005550 RID: 21840 RVA: 0x001A661F File Offset: 0x001A481F
	private void JDKHBGDEONK()
	{
		this.SCShader = Shader.Find("_Value8");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005551 RID: 21841 RVA: 0x001A6643 File Offset: 0x001A4843
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("Data/Editor/leveltemplate");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005552 RID: 21842 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBIOIEANMGI()
	{
	}

	// Token: 0x06005553 RID: 21843 RVA: 0x001A6667 File Offset: 0x001A4867
	private void LGHCJCFHEMF()
	{
		this.SCShader = Shader.Find("_Red_G");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005554 RID: 21844 RVA: 0x001A668C File Offset: 0x001A488C
	private void GKJFBIJGCHP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 673f)
			{
				this.HBJJOCHGOPH = 1717f;
			}
			this.DOMEEFLPEPJ().SetFloat("_FixDistance", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("Committing changes...", this.Colorisation);
			this.AELJLBOJAIL().SetFloat("_Visualize", this.Parasite);
			this.DOHGBNPMBKG().SetFloat("</color>", this.Noise);
			this.PDEAHJPOMEF().SetFloat("DPADVER", this.Fade);
			this.NBPKMLMCHFN.SetVector("GlassesColor2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 30f, 142f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DNLMFEGJJDD());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005555 RID: 21845 RVA: 0x001A678C File Offset: 0x001A498C
	private void NHNMJJBFLJP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1253f)
			{
				this.HBJJOCHGOPH = 1604f;
			}
			this.BFGNMFCNDBC().SetFloat("ComboScoreText", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("_TimeX", this.Colorisation);
			this.LPMLLJKMAMP().SetFloat("CameraFilterPack/TV_Distorted", this.Parasite);
			this.BFGNMFCNDBC().SetFloat("_TimeX", this.Noise);
			this.AELJLBOJAIL().SetFloat("settings_bindings_sec_", this.Fade);
			this.DOMEEFLPEPJ().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 570f, 1631f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005556 RID: 21846 RVA: 0x001A688C File Offset: 0x001A4A8C
	private void HGJJPACDBEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1033f)
			{
				this.HBJJOCHGOPH = 1920f;
			}
			this.HNFFHCLNBDN().SetFloat("_Value4", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("note.7", this.Colorisation);
			this.HNFFHCLNBDN().SetFloat("#yes", this.Parasite);
			this.DOHGBNPMBKG().SetFloat("_SceneFogMode", this.Noise);
			this.AELJLBOJAIL().SetFloat("(master)", this.Fade);
			this.PDEAHJPOMEF().SetVector("Please specify either t or f.", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 639f, 238f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.KHCLIAMBBNC());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005557 RID: 21847 RVA: 0x001A698C File Offset: 0x001A4B8C
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
			this.NBPKMLMCHFN.SetFloat("_Colorisation", this.Colorisation);
			this.NBPKMLMCHFN.SetFloat("_Parasite", this.Parasite);
			this.NBPKMLMCHFN.SetFloat("_Noise", this.Noise);
			this.NBPKMLMCHFN.SetFloat("Fade", this.Fade);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 0f, 0f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005558 RID: 21848 RVA: 0x001A6A8B File Offset: 0x001A4C8B
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("_Value5");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005559 RID: 21849 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONMGIPAILOH()
	{
	}

	// Token: 0x0600555A RID: 21850 RVA: 0x001A6AB0 File Offset: 0x001A4CB0
	private void NCDPFPKBCCM(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 791f)
			{
				this.HBJJOCHGOPH = 891f;
			}
			this.HHLFDHNEIAH().SetFloat("a", this.HBJJOCHGOPH);
			this.KJMECMIGJJA().SetFloat("_TimeX", this.Colorisation);
			this.KHCLIAMBBNC().SetFloat("_Value9", this.Parasite);
			this.PDEAHJPOMEF().SetFloat("Please specify either t or f.", this.Noise);
			this.FHFLKLMFHOI().SetFloat("]. Please verify you have this gameobject in a Resources folder.", this.Fade);
			this.LPMLLJKMAMP().SetVector("_Value2", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 363f, 1246f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600555B RID: 21851 RVA: 0x0002523B File Offset: 0x0002343B
	private void DPIPGGDNGHN()
	{
	}

	// Token: 0x0600555C RID: 21852 RVA: 0x001A6BAF File Offset: 0x001A4DAF
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-102);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600555D RID: 21853 RVA: 0x001A6BE6 File Offset: 0x001A4DE6
	private Material DOMEEFLPEPJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600555E RID: 21854 RVA: 0x001A6C1D File Offset: 0x001A4E1D
	private void BMOFEBKGLFI()
	{
		this.SCShader = Shader.Find("VoteUpToggle");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600555F RID: 21855 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06005560 RID: 21856 RVA: 0x001A6C44 File Offset: 0x001A4E44
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 563f)
			{
				this.HBJJOCHGOPH = 616f;
			}
			this.FHFLKLMFHOI().SetFloat("Case-Sensitive", this.HBJJOCHGOPH);
			this.DNLMFEGJJDD().SetFloat("settings.volume.game", this.Colorisation);
			this.HNFFHCLNBDN().SetFloat(" not exist", this.Parasite);
			this.KJMECMIGJJA().SetFloat("_Value4", this.Noise);
			this.DOHGBNPMBKG().SetFloat("FinalScoreText", this.Fade);
			this.MHBAIEKFBIJ().SetVector("_Distance", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 737f, 441f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.AELJLBOJAIL());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005561 RID: 21857 RVA: 0x001A6D43 File Offset: 0x001A4F43
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("itemid");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005562 RID: 21858 RVA: 0x001A507D File Offset: 0x001A327D
	private void JOONHGHGKKF()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005563 RID: 21859 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06005564 RID: 21860 RVA: 0x0002523B File Offset: 0x0002343B
	private void ONKDMMJPEMN()
	{
	}

	// Token: 0x06005565 RID: 21861 RVA: 0x001A507D File Offset: 0x001A327D
	private void JEBIBKLHFLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005566 RID: 21862 RVA: 0x001A6D67 File Offset: 0x001A4F67
	private void FHGKIOOMMOH()
	{
		this.SCShader = Shader.Find("MenuScene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005567 RID: 21863 RVA: 0x001A6D8B File Offset: 0x001A4F8B
	private Material DOHGBNPMBKG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)90;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005568 RID: 21864 RVA: 0x001A507D File Offset: 0x001A327D
	private void JNGMIAFLBDL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600556A RID: 21866 RVA: 0x001A6E01 File Offset: 0x001A5001
	private void ILCFPCIPENO()
	{
		this.SCShader = Shader.Find("_Distortion");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x170000F6 RID: 246
	// (get) Token: 0x0600556B RID: 21867 RVA: 0x001A6E25 File Offset: 0x001A5025
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

	// Token: 0x0600556C RID: 21868 RVA: 0x0002523B File Offset: 0x0002343B
	private void DDBOODLPCAM()
	{
	}

	// Token: 0x0600556D RID: 21869 RVA: 0x0002523B File Offset: 0x0002343B
	private void HDDECCMEJKA()
	{
	}

	// Token: 0x0600556E RID: 21870 RVA: 0x0002523B File Offset: 0x0002343B
	private void MJNPIDGNJMK()
	{
	}

	// Token: 0x0600556F RID: 21871 RVA: 0x001A507D File Offset: 0x001A327D
	private void FMHOHGEAIEA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005570 RID: 21872 RVA: 0x001A6E5C File Offset: 0x001A505C
	private void CACIIEMMMHG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 275f)
			{
				this.HBJJOCHGOPH = 940f;
			}
			this.PDEAHJPOMEF().SetFloat("lobby '{0}'[{1}]", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("masterSteamID", this.Colorisation);
			this.PDEAHJPOMEF().SetFloat("_Value3", this.Parasite);
			this.AELJLBOJAIL().SetFloat("CameraFilterPack/EXTRA_SHOWFPS", this.Noise);
			this.KJMECMIGJJA().SetFloat("Fade", this.Fade);
			this.LPMLLJKMAMP().SetVector("SetSunDirectionVector", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1722f, 1740f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005571 RID: 21873 RVA: 0x001A507D File Offset: 0x001A327D
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005572 RID: 21874 RVA: 0x001A6F5B File Offset: 0x001A515B
	private void KLILJHJNICK()
	{
		this.SCShader = Shader.Find("_MainTex2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005573 RID: 21875 RVA: 0x001A6F80 File Offset: 0x001A5180
	private void JJCEACGCOHB(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1403f)
			{
				this.HBJJOCHGOPH = 1532f;
			}
			this.ADBKPGFMNKO().SetFloat("_Value2", this.HBJJOCHGOPH);
			this.AELJLBOJAIL().SetFloat("end", this.Colorisation);
			this.NBPKMLMCHFN.SetFloat("_MainTex2", this.Parasite);
			this.EOCCJGIGEGJ().SetFloat("CameraFilterPack/Blend2Camera_Blend", this.Noise);
			this.LPMLLJKMAMP().SetFloat("Object ID. Case-Sensitive", this.Fade);
			this.BFGNMFCNDBC().SetVector("' got destroyed by engine. This is OK when loading levels. Otherwise use: PhotonNetwork.Destroy().", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 1337f, 286f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06005574 RID: 21876 RVA: 0x001A707F File Offset: 0x001A527F
	private void KOFAMEKHHGD()
	{
		this.SCShader = Shader.Find("_ScreenResolution");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06005575 RID: 21877 RVA: 0x001A70A3 File Offset: 0x001A52A3
	private Material MHBAIEKFBIJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06005576 RID: 21878 RVA: 0x001A507D File Offset: 0x001A327D
	private void HLLHJIDOOGA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06005577 RID: 21879 RVA: 0x001A70DA File Offset: 0x001A52DA
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/TV_Artefact");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06005578 RID: 21880 RVA: 0x001A7100 File Offset: 0x001A5300
	private void MNMONMPIPPO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1722f)
			{
				this.HBJJOCHGOPH = 116f;
			}
			this.HHLFDHNEIAH().SetFloat("_DisplayVelocityScale", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("EventTimeInputField", this.Colorisation);
			this.PDEAHJPOMEF().SetFloat("Ev OwnershipTransfer. ViewID ", this.Parasite);
			this.AELJLBOJAIL().SetFloat("_MainTex2", this.Noise);
			this.ADBKPGFMNKO().SetFloat("Changed config", this.Fade);
			this.FHFLKLMFHOI().SetVector("_TimeX", new Vector4((float)AAACLELCPML.width, (float)AAACLELCPML.height, 648f, 1958f));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x040008DB RID: 2267
	public Shader SCShader;

	// Token: 0x040008DC RID: 2268
	private Vector4 GOIJPFAHKPE;

	// Token: 0x040008DD RID: 2269
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040008DE RID: 2270
	[Range(0f, 1f)]
	public float Fade = 1f;

	// Token: 0x040008DF RID: 2271
	[Range(-10f, 10f)]
	public float Colorisation = 1f;

	// Token: 0x040008E0 RID: 2272
	[Range(-10f, 10f)]
	public float Parasite = 1f;

	// Token: 0x040008E1 RID: 2273
	[Range(-10f, 10f)]
	public float Noise = 1f;

	// Token: 0x040008E2 RID: 2274
	private Material BJFKDHHMLJH;
}
