using System;
using UnityEngine;

// Token: 0x020000B2 RID: 178
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Edge/Neon")]
public class CameraFilterPack_Edge_Neon : MonoBehaviour
{
	// Token: 0x060035EE RID: 13806 RVA: 0x00116FFD File Offset: 0x001151FD
	private void NDBPCNICGLC()
	{
		this.SCShader = Shader.Find("[DiscordController] Responding yes to Ask to Join request");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060035EF RID: 13807 RVA: 0x00117021 File Offset: 0x00115221
	private Material OJMHIMIPKME()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-103);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060035F0 RID: 13808 RVA: 0x00117058 File Offset: 0x00115258
	private void DAHFFNNIGML()
	{
		this.SCShader = Shader.Find("ReconnectAndRejoin() with AuthValues == null is not correct!");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060035F1 RID: 13809 RVA: 0x0011707C File Offset: 0x0011527C
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("{");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060035F2 RID: 13810 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x060035F3 RID: 13811 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMBDNPLDGIJ()
	{
	}

	// Token: 0x060035F4 RID: 13812 RVA: 0x0002523B File Offset: 0x0002343B
	private void PHJJHFBLICM()
	{
	}

	// Token: 0x060035F5 RID: 13813 RVA: 0x001170A0 File Offset: 0x001152A0
	private void CENLKOLIACP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 885f)
			{
				this.HBJJOCHGOPH = 1171f;
			}
			this.DEFBJOCJJKF().SetFloat("Error; Only the MasterClient can call RemoveRPCs for other players.", this.HBJJOCHGOPH);
			this.OJMHIMIPKME().SetFloat("[MapsData] Bad map: ", this.EdgeWeight);
			this.OCHJIMJNEMO().SetVector("GroupNameText", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEINDEMCGIK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060035F6 RID: 13814 RVA: 0x00117156 File Offset: 0x00115356
	private void MODENHKMKOC()
	{
		this.SCShader = Shader.Find(": ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060035F7 RID: 13815 RVA: 0x0011717A File Offset: 0x0011537A
	private void CBIBDOIBJAI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060035F8 RID: 13816 RVA: 0x00117197 File Offset: 0x00115397
	private void JDKHBGDEONK()
	{
		this.SCShader = Shader.Find("/Segment-[Down]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060035F9 RID: 13817 RVA: 0x001171BB File Offset: 0x001153BB
	private void MKOMIDCPCDC()
	{
		this.SCShader = Shader.Find("DPADVER");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060035FA RID: 13818 RVA: 0x001171DF File Offset: 0x001153DF
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Edge_Neon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060035FB RID: 13819 RVA: 0x00117204 File Offset: 0x00115404
	private void GOIMKCCICFK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1721f)
			{
				this.HBJJOCHGOPH = 1655f;
			}
			this.OIMMPLPBLBK().SetFloat("FinalScoreSmallText", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("MenuScene", this.EdgeWeight);
			this.GHHPOGODBHB().SetVector("CameraFilterPack/Blend2Camera_Difference", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LELKBCALFCF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x060035FC RID: 13820 RVA: 0x0011717A File Offset: 0x0011537A
	private void ELDMKIAPNGP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060035FD RID: 13821 RVA: 0x001172BA File Offset: 0x001154BA
	private void ANCKKLFPGDI()
	{
		this.SCShader = Shader.Find("{0} months ago");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x060035FE RID: 13822 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFACDBHDAOD()
	{
	}

	// Token: 0x060035FF RID: 13823 RVA: 0x001172DE File Offset: 0x001154DE
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)80;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003600 RID: 13824 RVA: 0x0002523B File Offset: 0x0002343B
	private void GJCOELHNLJE()
	{
	}

	// Token: 0x17000097 RID: 151
	// (get) Token: 0x06003601 RID: 13825 RVA: 0x00117315 File Offset: 0x00115515
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

	// Token: 0x06003602 RID: 13826 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIKKPDACJGI()
	{
	}

	// Token: 0x06003603 RID: 13827 RVA: 0x0011717A File Offset: 0x0011537A
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003604 RID: 13828 RVA: 0x0011734C File Offset: 0x0011554C
	private void IGPCNCJIEOJ()
	{
		this.SCShader = Shader.Find("float,1");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003605 RID: 13829 RVA: 0x00117370 File Offset: 0x00115570
	private Material ENKPNJMPDEB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003606 RID: 13830 RVA: 0x0011717A File Offset: 0x0011537A
	private void OCCGJMPAJIK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003607 RID: 13831 RVA: 0x001173A7 File Offset: 0x001155A7
	private Material FAIFBBGFAIB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003608 RID: 13832 RVA: 0x001173DE File Offset: 0x001155DE
	private Material EMDFHOKEGNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003609 RID: 13833 RVA: 0x0011717A File Offset: 0x0011537A
	private void BMGPBIBPBLA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600360A RID: 13834 RVA: 0x00117415 File Offset: 0x00115615
	private Material INOBFNCKFGK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)77;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600360B RID: 13835 RVA: 0x0011744C File Offset: 0x0011564C
	private void DNNFHBOOPIN()
	{
		this.SCShader = Shader.Find("#mapby");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600360C RID: 13836 RVA: 0x00117470 File Offset: 0x00115670
	private Material LELKBCALFCF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600360D RID: 13837 RVA: 0x001174A8 File Offset: 0x001156A8
	private void OMIHEBMMCPG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 957f)
			{
				this.HBJJOCHGOPH = 84f;
			}
			this.GJHLADDCMFF().SetFloat("entering", this.HBJJOCHGOPH);
			this.KEMJNOMIPHN().SetFloat("settings.enablerankingnotifications", this.EdgeWeight);
			this.OIMMPLPBLBK().SetVector("DifficultyBG", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ENKPNJMPDEB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600360E RID: 13838 RVA: 0x0011755E File Offset: 0x0011575E
	private void NEFHGMNAPEP()
	{
		this.SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600360F RID: 13839 RVA: 0x00117582 File Offset: 0x00115782
	private void IKDNLHLBHID()
	{
		this.SCShader = Shader.Find("settings.selectormapsperpage");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003610 RID: 13840 RVA: 0x001175A6 File Offset: 0x001157A6
	private Material DOMEEFLPEPJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003611 RID: 13841 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x06003612 RID: 13842 RVA: 0x0002523B File Offset: 0x0002343B
	private void LKJMIODJGCM()
	{
	}

	// Token: 0x06003613 RID: 13843 RVA: 0x0011717A File Offset: 0x0011537A
	private void HGDDCINLDAD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003614 RID: 13844 RVA: 0x0002523B File Offset: 0x0002343B
	private void AKCADICOFDD()
	{
	}

	// Token: 0x06003615 RID: 13845 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLJLDLLNFBH()
	{
	}

	// Token: 0x06003616 RID: 13846 RVA: 0x001175E0 File Offset: 0x001157E0
	private void AODKAMLEIOJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1690f)
			{
				this.HBJJOCHGOPH = 19f;
			}
			this.KEMJNOMIPHN().SetFloat(":</b> ", this.HBJJOCHGOPH);
			this.JIBOKBCPDLC().SetFloat("offsets", this.EdgeWeight);
			this.LPMLLJKMAMP().SetVector("0,1,false", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003617 RID: 13847 RVA: 0x00117696 File Offset: 0x00115896
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.DontUnloadUnusedAsset;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003618 RID: 13848 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOMNCPKKCFN()
	{
	}

	// Token: 0x06003619 RID: 13849 RVA: 0x001176CD File Offset: 0x001158CD
	private void ALJEJJCIMJN()
	{
		this.SCShader = Shader.Find("Needs to be attached to the Event System component in the scene");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600361A RID: 13850 RVA: 0x0011717A File Offset: 0x0011537A
	private void DLMPALHKMON()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600361B RID: 13851 RVA: 0x001176F1 File Offset: 0x001158F1
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("maps.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600361C RID: 13852 RVA: 0x0011717A File Offset: 0x0011537A
	private void ABEIEGDHBNO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600361D RID: 13853 RVA: 0x00117715 File Offset: 0x00115915
	private Material OKJOKHGJHGF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600361E RID: 13854 RVA: 0x0011774C File Offset: 0x0011594C
	private void MMOKKAPFGAK()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600361F RID: 13855 RVA: 0x00117770 File Offset: 0x00115970
	private void HELHDLOLPLH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1875f)
			{
				this.HBJJOCHGOPH = 998f;
			}
			this.NBMPPNFKFLB().SetFloat("buttons", this.HBJJOCHGOPH);
			this.MLMKCOINOOH().SetFloat("LoadPlayerSkin", this.EdgeWeight);
			this.DOMEEFLPEPJ().SetVector("CameraFilterPack/FX_Glitch1", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003620 RID: 13856 RVA: 0x0011717A File Offset: 0x0011537A
	private void HCDBNAKGDJC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003621 RID: 13857 RVA: 0x0011717A File Offset: 0x0011537A
	private void MKFLBEGJJDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003622 RID: 13858 RVA: 0x00117826 File Offset: 0x00115A26
	private Material OCHJIMJNEMO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-121);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003623 RID: 13859 RVA: 0x0002523B File Offset: 0x0002343B
	private void MECJHOJPODB()
	{
	}

	// Token: 0x06003624 RID: 13860 RVA: 0x0011785D File Offset: 0x00115A5D
	private Material LPMLLJKMAMP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003625 RID: 13861 RVA: 0x00117894 File Offset: 0x00115A94
	private void KHIGHFJKPFG()
	{
		this.SCShader = Shader.Find("_TintColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003626 RID: 13862 RVA: 0x0011717A File Offset: 0x0011537A
	private void EFECEKPFOEM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003627 RID: 13863 RVA: 0x0011717A File Offset: 0x0011537A
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003628 RID: 13864 RVA: 0x0011717A File Offset: 0x0011537A
	private void LECCHIAFGGE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003629 RID: 13865 RVA: 0x0011717A File Offset: 0x0011537A
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600362A RID: 13866 RVA: 0x0011717A File Offset: 0x0011537A
	private void FODKODGPPDA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600362B RID: 13867 RVA: 0x0002523B File Offset: 0x0002343B
	private void KMEONPMCNJG()
	{
	}

	// Token: 0x0600362C RID: 13868 RVA: 0x001178B8 File Offset: 0x00115AB8
	private Material JIBOKBCPDLC()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600362D RID: 13869 RVA: 0x001178F0 File Offset: 0x00115AF0
	private void ELGOMIMONOG(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1743f)
			{
				this.HBJJOCHGOPH = 1966f;
			}
			this.GJHLADDCMFF().SetFloat("\"", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("OpAuthenticate()", this.EdgeWeight);
			this.HKIMAANBGMJ().SetVector("-1", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600362E RID: 13870 RVA: 0x0011717A File Offset: 0x0011537A
	private void CIHGFHNNFEE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600362F RID: 13871 RVA: 0x0011717A File Offset: 0x0011537A
	private void OFPPIKHNJOD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003630 RID: 13872 RVA: 0x001179A6 File Offset: 0x00115BA6
	private void MNBPNHNAEBK()
	{
		this.SCShader = Shader.Find("New SaveGame");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003631 RID: 13873 RVA: 0x0011717A File Offset: 0x0011537A
	private void JOJFHFHOCHO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003632 RID: 13874 RVA: 0x001179CA File Offset: 0x00115BCA
	private void HIPEHGNBJMN()
	{
		this.SCShader = Shader.Find("SetupEncryption() got called. ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003633 RID: 13875 RVA: 0x001179F0 File Offset: 0x00115BF0
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1111f)
			{
				this.HBJJOCHGOPH = 1804f;
			}
			this.MLMKCOINOOH().SetFloat("hardcoreinfo", this.HBJJOCHGOPH);
			this.GHHPOGODBHB().SetFloat("?", this.EdgeWeight);
			this.FGENHBKMPDA().SetVector("menu.enableselectormusic", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ENKPNJMPDEB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003634 RID: 13876 RVA: 0x00117AA6 File Offset: 0x00115CA6
	private void KOJKBFDNGDK()
	{
		this.SCShader = Shader.Find("#reward: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003635 RID: 13877 RVA: 0x00117ACC File Offset: 0x00115CCC
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
			this.NBPKMLMCHFN.SetFloat("_EdgeWeight", this.EdgeWeight);
			this.NBPKMLMCHFN.SetVector("_ScreenResolution", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003636 RID: 13878 RVA: 0x0011717A File Offset: 0x0011537A
	private void HONBLGFDMLL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003637 RID: 13879 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIFLPHLGLFG()
	{
	}

	// Token: 0x06003638 RID: 13880 RVA: 0x00117B82 File Offset: 0x00115D82
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find(" - PUBLISHED #");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003639 RID: 13881 RVA: 0x0011717A File Offset: 0x0011537A
	private void ANDELGODEOC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600363A RID: 13882 RVA: 0x00117BA6 File Offset: 0x00115DA6
	private void OKLAJINHPAN()
	{
		this.SCShader = Shader.Find("workshop.");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600363B RID: 13883 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBNPEHMDCMI()
	{
	}

	// Token: 0x0600363C RID: 13884 RVA: 0x00117BCA File Offset: 0x00115DCA
	private void JOPCCCCHNLI()
	{
		this.SCShader = Shader.Find("/icon");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600363D RID: 13885 RVA: 0x0011717A File Offset: 0x0011537A
	private void IFIHBNJKEKD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600363E RID: 13886 RVA: 0x00117BEE File Offset: 0x00115DEE
	private Material GKILCDHJFEG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003640 RID: 13888 RVA: 0x00117C43 File Offset: 0x00115E43
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003641 RID: 13889 RVA: 0x0002523B File Offset: 0x0002343B
	private void INLDEHPAMJC()
	{
	}

	// Token: 0x06003642 RID: 13890 RVA: 0x00117C7C File Offset: 0x00115E7C
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1148f)
			{
				this.HBJJOCHGOPH = 777f;
			}
			this.GKILCDHJFEG().SetFloat("RPC can't be sent to target PhotonPlayer being null! Did not send \"", this.HBJJOCHGOPH);
			this.HEINDEMCGIK().SetFloat("PRESS A KEY", this.EdgeWeight);
			this.DKNJGHFLAIF().SetVector("/", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003643 RID: 13891 RVA: 0x0011717A File Offset: 0x0011537A
	private void DOEPOGLEGLE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003644 RID: 13892 RVA: 0x0011717A File Offset: 0x0011537A
	private void EKCKJLFFAID()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003645 RID: 13893 RVA: 0x00117D34 File Offset: 0x00115F34
	private void OKHBBIKDIEP(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 163f)
			{
				this.HBJJOCHGOPH = 454f;
			}
			this.LPMLLJKMAMP().SetFloat("Join failed on GameServer. Changing back to MasterServer. Msg: ", this.HBJJOCHGOPH);
			this.HKIMAANBGMJ().SetFloat("Version 1.0", this.EdgeWeight);
			this.OCHJIMJNEMO().SetVector("GameScene", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPMLLJKMAMP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003646 RID: 13894 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLDHEJIEDHO()
	{
	}

	// Token: 0x06003647 RID: 13895 RVA: 0x00117DEA File Offset: 0x00115FEA
	private void NKFDNIAKGEO()
	{
		this.SCShader = Shader.Find("#forever");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003648 RID: 13896 RVA: 0x00117E10 File Offset: 0x00116010
	private void GHOAOEKHEKI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 882f)
			{
				this.HBJJOCHGOPH = 1074f;
			}
			this.NBPKMLMCHFN.SetFloat("solo", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("CameraFilterPack/Glasses_On", this.EdgeWeight);
			this.NBPKMLMCHFN.SetVector("_Value", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003649 RID: 13897 RVA: 0x00117EC6 File Offset: 0x001160C6
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("Myst_Color");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600364A RID: 13898 RVA: 0x00117EEA File Offset: 0x001160EA
	private Material HCGJCMDJPGD()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600364B RID: 13899 RVA: 0x00117F21 File Offset: 0x00116121
	private Material FLOHGDECHHH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)70;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600364C RID: 13900 RVA: 0x00117F58 File Offset: 0x00116158
	private Material KEMJNOMIPHN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600364D RID: 13901 RVA: 0x00117F8F File Offset: 0x0011618F
	private Material NBMPPNFKFLB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600364E RID: 13902 RVA: 0x0011717A File Offset: 0x0011537A
	private void PAEGLMEOKHP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600364F RID: 13903 RVA: 0x0011717A File Offset: 0x0011537A
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003650 RID: 13904 RVA: 0x0011717A File Offset: 0x0011537A
	private void FKDEEJFNNJC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003651 RID: 13905 RVA: 0x00117FC8 File Offset: 0x001161C8
	private void LPFDJPCIADE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1888f)
			{
				this.HBJJOCHGOPH = 520f;
			}
			this.ENKPNJMPDEB().SetFloat("_TimeX", this.HBJJOCHGOPH);
			this.DOMEEFLPEPJ().SetFloat("CameraFilterPack/Blend2Camera_LinearBurn", this.EdgeWeight);
			this.EMDFHOKEGNG().SetVector("EnableRankedNotificationsToggle", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MLMKCOINOOH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003652 RID: 13906 RVA: 0x0011717A File Offset: 0x0011537A
	private void FGOPJMGNHGO()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003653 RID: 13907 RVA: 0x0011807E File Offset: 0x0011627E
	private Material ABHDNGIHBKE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-78);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003654 RID: 13908 RVA: 0x001180B5 File Offset: 0x001162B5
	private void IMCKJCHKMKB()
	{
		this.SCShader = Shader.Find("Set Satellite Input");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003655 RID: 13909 RVA: 0x001180D9 File Offset: 0x001162D9
	private void IBLGHLNNAHN()
	{
		this.SCShader = Shader.Find("BloomShaderValueSlider");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003656 RID: 13910 RVA: 0x001180FD File Offset: 0x001162FD
	private Material MLMKCOINOOH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003657 RID: 13911 RVA: 0x00118134 File Offset: 0x00116334
	private void KHGEBPHKAGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 88f)
			{
				this.HBJJOCHGOPH = 1004f;
			}
			this.GKILCDHJFEG().SetFloat("00", this.HBJJOCHGOPH);
			this.DOMEEFLPEPJ().SetFloat("Please attach component to a Graphical UI component", this.EdgeWeight);
			this.LPMLLJKMAMP().SetVector(": ", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ENKPNJMPDEB());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003658 RID: 13912 RVA: 0x001181EC File Offset: 0x001163EC
	private void HFNLEOLNJLF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 585f)
			{
				this.HBJJOCHGOPH = 277f;
			}
			this.ABHDNGIHBKE().SetFloat("{0}{1}{2}={3}", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("Failed to 'network-remove' GameObject because it is missing a valid InstantiationId on view: ", this.EdgeWeight);
			this.NBMPPNFKFLB().SetVector("_Green_C", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EMDFHOKEGNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003659 RID: 13913 RVA: 0x001182A2 File Offset: 0x001164A2
	private Material DKNJGHFLAIF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600365A RID: 13914 RVA: 0x0011717A File Offset: 0x0011537A
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600365B RID: 13915 RVA: 0x001182D9 File Offset: 0x001164D9
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("\n");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600365C RID: 13916 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x0600365D RID: 13917 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600365E RID: 13918 RVA: 0x0002523B File Offset: 0x0002343B
	private void EGEGNHLODAA()
	{
	}

	// Token: 0x0600365F RID: 13919 RVA: 0x001182FD File Offset: 0x001164FD
	private Material GJHLADDCMFF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)126;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003660 RID: 13920 RVA: 0x0011717A File Offset: 0x0011537A
	private void OOGIHDLBBLM()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003661 RID: 13921 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06003662 RID: 13922 RVA: 0x00118334 File Offset: 0x00116534
	private void DHJKAOMONAJ(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1469f)
			{
				this.HBJJOCHGOPH = 210f;
			}
			this.FLOHGDECHHH().SetFloat("Lerp speed. Recomended 10", this.HBJJOCHGOPH);
			this.OCHJIMJNEMO().SetFloat("D-Pad Down", this.EdgeWeight);
			this.HCGJCMDJPGD().SetVector("_TimeX", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.GKILCDHJFEG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003663 RID: 13923 RVA: 0x001183EA File Offset: 0x001165EA
	private Material HEINDEMCGIK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-75);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003664 RID: 13924 RVA: 0x00118421 File Offset: 0x00116621
	private void FBPHNEJBDJN()
	{
		this.SCShader = Shader.Find("plainText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003665 RID: 13925 RVA: 0x0002523B File Offset: 0x0002343B
	private void LMADKINICIN()
	{
	}

	// Token: 0x06003666 RID: 13926 RVA: 0x00118445 File Offset: 0x00116645
	private Material HKIMAANBGMJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)110;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003667 RID: 13927 RVA: 0x0002523B File Offset: 0x0002343B
	private void AAPKBNDHBLI()
	{
	}

	// Token: 0x06003668 RID: 13928 RVA: 0x0011717A File Offset: 0x0011537A
	private void FJIKDJAMOHA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003669 RID: 13929 RVA: 0x0011847C File Offset: 0x0011667C
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 692f)
			{
				this.HBJJOCHGOPH = 1938f;
			}
			this.GKILCDHJFEG().SetFloat(",", this.HBJJOCHGOPH);
			this.DOMEEFLPEPJ().SetFloat("The directory was created successfully at ", this.EdgeWeight);
			this.CEKJODEAMGB().SetVector("\r\n", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.OKJOKHGJHGF());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600366A RID: 13930 RVA: 0x00118532 File Offset: 0x00116732
	private Material OIMMPLPBLBK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600366B RID: 13931 RVA: 0x00118569 File Offset: 0x00116769
	private Material DEFBJOCJJKF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-82);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600366C RID: 13932 RVA: 0x001185A0 File Offset: 0x001167A0
	private void GENCBNFIILN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1288f)
			{
				this.HBJJOCHGOPH = 1550f;
			}
			this.OIMMPLPBLBK().SetFloat("GameMessagesDurationSlider", this.HBJJOCHGOPH);
			this.LPMLLJKMAMP().SetFloat("DPADHOR", this.EdgeWeight);
			this.HKIMAANBGMJ().SetVector("[Up]", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FLOHGDECHHH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600366D RID: 13933 RVA: 0x0011717A File Offset: 0x0011537A
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600366E RID: 13934 RVA: 0x0011717A File Offset: 0x0011537A
	private void NAOLAJPDGIC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600366F RID: 13935 RVA: 0x00118658 File Offset: 0x00116858
	private void DGMODDJIAKL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1187f)
			{
				this.HBJJOCHGOPH = 1053f;
			}
			this.HEINDEMCGIK().SetFloat("DPADVER", this.HBJJOCHGOPH);
			this.DKNJGHFLAIF().SetFloat("_Axis", this.EdgeWeight);
			this.DEFBJOCJJKF().SetVector("_Value", new Vector2((float)Screen.width, (float)Screen.height));
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003670 RID: 13936 RVA: 0x0002523B File Offset: 0x0002343B
	private void JFMIDILENDO()
	{
	}

	// Token: 0x06003671 RID: 13937 RVA: 0x00117BEE File Offset: 0x00115DEE
	private Material GHHPOGODBHB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = HideFlags.HideInHierarchy;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003672 RID: 13938 RVA: 0x0011870E File Offset: 0x0011690E
	private void FMFNILJIEIA()
	{
		this.SCShader = Shader.Find("_Value2");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003673 RID: 13939 RVA: 0x0002523B File Offset: 0x0002343B
	private void LBPCODPOJAH()
	{
	}

	// Token: 0x040005FD RID: 1533
	public Shader SCShader;

	// Token: 0x040005FE RID: 1534
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040005FF RID: 1535
	private Vector4 GOIJPFAHKPE;

	// Token: 0x04000600 RID: 1536
	private Material BJFKDHHMLJH;

	// Token: 0x04000601 RID: 1537
	[Range(1f, 10f)]
	public float EdgeWeight = 1f;
}
