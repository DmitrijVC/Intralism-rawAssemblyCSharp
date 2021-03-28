using System;
using UnityEngine;

// Token: 0x020000A7 RID: 167
[ExecuteInEditMode]
[AddComponentMenu("Camera Filter Pack/Drawing/Manga3")]
public class CameraFilterPack_Drawing_Manga3 : MonoBehaviour
{
	// Token: 0x06003212 RID: 12818 RVA: 0x00107665 File Offset: 0x00105865
	private void HNGHDAPKEJG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003213 RID: 12819 RVA: 0x0002523B File Offset: 0x0002343B
	private void APKNAPHOFHC()
	{
	}

	// Token: 0x06003214 RID: 12820 RVA: 0x00107665 File Offset: 0x00105865
	private void ALMGMOOHLMA()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003215 RID: 12821 RVA: 0x00107682 File Offset: 0x00105882
	private Material OJMHIMIPKME()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-100);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003217 RID: 12823 RVA: 0x001076D7 File Offset: 0x001058D7
	private void ALNNIDLFILB()
	{
		this.SCShader = Shader.Find("#updateoutdatedmap");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003218 RID: 12824 RVA: 0x001076FC File Offset: 0x001058FC
	private void ELHDLIHODGE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 322f)
			{
				this.HBJJOCHGOPH = 1921f;
			}
			this.OJMHIMIPKME().SetFloat("_ScreenResolution", this.HBJJOCHGOPH);
			this.ECCPAOBFDKP().SetFloat("_LightIntensity", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DOMEEFLPEPJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003219 RID: 12825 RVA: 0x00107665 File Offset: 0x00105865
	private void OHBNLJOPDDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600321A RID: 12826 RVA: 0x00107665 File Offset: 0x00105865
	private void KLDNGKBMDAN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600321B RID: 12827 RVA: 0x0010778C File Offset: 0x0010598C
	private void BGDPIHMAACO()
	{
		this.SCShader = Shader.Find("_Blue_R");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600321C RID: 12828 RVA: 0x001077B0 File Offset: 0x001059B0
	private Material KEMAALEODNH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600321D RID: 12829 RVA: 0x00107665 File Offset: 0x00105865
	private void DHENLPJJOEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600321E RID: 12830 RVA: 0x0002523B File Offset: 0x0002343B
	private void HIFLPHLGLFG()
	{
	}

	// Token: 0x0600321F RID: 12831 RVA: 0x0002523B File Offset: 0x0002343B
	private void HMNLHMLILKD()
	{
	}

	// Token: 0x06003220 RID: 12832 RVA: 0x0002523B File Offset: 0x0002343B
	private void AOLABBMIEIM()
	{
	}

	// Token: 0x06003221 RID: 12833 RVA: 0x0002523B File Offset: 0x0002343B
	private void FBMDHDBELEK()
	{
	}

	// Token: 0x06003222 RID: 12834 RVA: 0x001077E7 File Offset: 0x001059E7
	private Material EPBAAGMGPAP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003223 RID: 12835 RVA: 0x0010781E File Offset: 0x00105A1E
	private void FIKFJDFELIP()
	{
		this.SCShader = Shader.Find("settings.cameramovements");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003224 RID: 12836 RVA: 0x0002523B File Offset: 0x0002343B
	private void OPCLBGHAPMG()
	{
	}

	// Token: 0x06003225 RID: 12837 RVA: 0x0002523B File Offset: 0x0002343B
	private void EHJJFJCKGAJ()
	{
	}

	// Token: 0x06003226 RID: 12838 RVA: 0x00107842 File Offset: 0x00105A42
	private void FJNCHGLIEMA()
	{
		this.SCShader = Shader.Find("inventory.lastitemscount");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003227 RID: 12839 RVA: 0x00107665 File Offset: 0x00105865
	private void BOLBPPHJBMI()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003228 RID: 12840 RVA: 0x00107866 File Offset: 0x00105A66
	private Material EBJKJPAIAAM()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-67);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003229 RID: 12841 RVA: 0x0002523B File Offset: 0x0002343B
	private void KFMEAMBLODG()
	{
	}

	// Token: 0x0600322A RID: 12842 RVA: 0x0002523B File Offset: 0x0002343B
	private void Update()
	{
	}

	// Token: 0x0600322B RID: 12843 RVA: 0x0010789D File Offset: 0x00105A9D
	private Material MALMMJNPILJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)84;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600322C RID: 12844 RVA: 0x001078D4 File Offset: 0x00105AD4
	private void HDEKADONMPE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1769f)
			{
				this.HBJJOCHGOPH = 429f;
			}
			this.EPBAAGMGPAP().SetFloat("#failed: ", this.HBJJOCHGOPH);
			this.HFBJAOFLCJI().SetFloat("Item ", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.LPDOGGFOBDH());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600322D RID: 12845 RVA: 0x00107964 File Offset: 0x00105B64
	private void EGKNJMMAOAO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1209f)
			{
				this.HBJJOCHGOPH = 1921f;
			}
			this.DOMEEFLPEPJ().SetFloat(".", this.HBJJOCHGOPH);
			this.EPCGJFCCAFH().SetFloat("Clears the console and prints the logs in the specified range", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HFBJAOFLCJI());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600322E RID: 12846 RVA: 0x001079F4 File Offset: 0x00105BF4
	private Material DIOAAHJDMLK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.NotEditable);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600322F RID: 12847 RVA: 0x00107A2C File Offset: 0x00105C2C
	private void KCFHGGCIDNE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1921f)
			{
				this.HBJJOCHGOPH = 39f;
			}
			this.BLMPMOIDGMG().SetFloat(",", this.HBJJOCHGOPH);
			this.EBJKJPAIAAM().SetFloat("Right", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003230 RID: 12848 RVA: 0x0002523B File Offset: 0x0002343B
	private void FOAGAKFBIGD()
	{
	}

	// Token: 0x1700008C RID: 140
	// (get) Token: 0x06003231 RID: 12849 RVA: 0x00107ABC File Offset: 0x00105CBC
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

	// Token: 0x06003232 RID: 12850 RVA: 0x0002523B File Offset: 0x0002343B
	private void KDJEJBBDILE()
	{
	}

	// Token: 0x06003233 RID: 12851 RVA: 0x00107AF4 File Offset: 0x00105CF4
	private void POENGNEMHJC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1154f)
			{
				this.HBJJOCHGOPH = 1636f;
			}
			this.ALABBJPHCNG().SetFloat("LevelNameText", this.HBJJOCHGOPH);
			this.KEMAALEODNH().SetFloat("_EmissionGain", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003234 RID: 12852 RVA: 0x00107B84 File Offset: 0x00105D84
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
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.NBPKMLMCHFN);
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003235 RID: 12853 RVA: 0x0002523B File Offset: 0x0002343B
	private void DGCGGKMNPLD()
	{
	}

	// Token: 0x06003236 RID: 12854 RVA: 0x00107C14 File Offset: 0x00105E14
	private void HJPCJGOEKMF()
	{
		this.SCShader = Shader.Find(".message");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003237 RID: 12855 RVA: 0x00107C38 File Offset: 0x00105E38
	private Material HNFFHCLNBDN()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)112;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003238 RID: 12856 RVA: 0x00107C6F File Offset: 0x00105E6F
	private Material DCCHGBHLAAF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)98;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003239 RID: 12857 RVA: 0x00107CA6 File Offset: 0x00105EA6
	private void JOHOFNKJDEB()
	{
		this.SCShader = Shader.Find("_Noise");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600323A RID: 12858 RVA: 0x00107CCA File Offset: 0x00105ECA
	private void JKFDDNMPOJH()
	{
		this.SCShader = Shader.Find("May");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600323B RID: 12859 RVA: 0x00107CEE File Offset: 0x00105EEE
	private void KIMMMCJFMAB()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600323C RID: 12860 RVA: 0x00107D12 File Offset: 0x00105F12
	private void HLIAEEMGBHN()
	{
		this.SCShader = Shader.Find("_SoftZDistance");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x0600323D RID: 12861 RVA: 0x00107D36 File Offset: 0x00105F36
	private Material LPDOGGFOBDH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-114);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600323E RID: 12862 RVA: 0x00107D70 File Offset: 0x00105F70
	private void ABOJKHKBJLN(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 562f)
			{
				this.HBJJOCHGOPH = 178f;
			}
			this.ALABBJPHCNG().SetFloat("/icon", this.HBJJOCHGOPH);
			this.MHBAIEKFBIJ().SetFloat("[NetworkManager] Updating current room...", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600323F RID: 12863 RVA: 0x00107E00 File Offset: 0x00106000
	private Material HFBJAOFLCJI()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-126);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003240 RID: 12864 RVA: 0x00107665 File Offset: 0x00105865
	private void NNBCLMJGFEN()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003241 RID: 12865 RVA: 0x00107E37 File Offset: 0x00106037
	private void EDPDMBFLHLP()
	{
		this.SCShader = Shader.Find("_TimeX");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003242 RID: 12866 RVA: 0x00107E5B File Offset: 0x0010605B
	private void ALJEJJCIMJN()
	{
		this.SCShader = Shader.Find("_LoopCount");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003243 RID: 12867 RVA: 0x0002523B File Offset: 0x0002343B
	private void EDDPLJGKLKJ()
	{
	}

	// Token: 0x06003244 RID: 12868 RVA: 0x00107E7F File Offset: 0x0010607F
	private void MMMDPANNAIO()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blend2Camera_Luminosity");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003245 RID: 12869 RVA: 0x00107EA4 File Offset: 0x001060A4
	private void AFCICEAOBHL(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1941f)
			{
				this.HBJJOCHGOPH = 505f;
			}
			this.HFBJAOFLCJI().SetFloat("Spawn new environment sprite (image) and sets its id", this.HBJJOCHGOPH);
			this.EBJKJPAIAAM().SetFloat("open", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003246 RID: 12870 RVA: 0x00107665 File Offset: 0x00105865
	private void KFEKCJDEECK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003247 RID: 12871 RVA: 0x00107F34 File Offset: 0x00106134
	private void HPFOFGJPNCI()
	{
		this.SCShader = Shader.Find("DPADHOR");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003248 RID: 12872 RVA: 0x00107665 File Offset: 0x00105865
	private void JLNNHKPHMAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003249 RID: 12873 RVA: 0x0002523B File Offset: 0x0002343B
	private void FGNFILLNPJK()
	{
	}

	// Token: 0x0600324A RID: 12874 RVA: 0x00107F58 File Offset: 0x00106158
	private Material ILKALHDJBFE()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)125;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600324B RID: 12875 RVA: 0x00107F90 File Offset: 0x00106190
	private void IEJCEFENLOF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 108f)
			{
				this.HBJJOCHGOPH = 138f;
			}
			this.EBJKJPAIAAM().SetFloat("[MapsStats] Length: ", this.HBJJOCHGOPH);
			this.ALABBJPHCNG().SetFloat("original.tutorial", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HEHKGPKLAKK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600324C RID: 12876 RVA: 0x00108020 File Offset: 0x00106220
	private Material EHDJJANLINB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-73);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600324D RID: 12877 RVA: 0x00108057 File Offset: 0x00106257
	private Material FGENHBKMPDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-93);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600324E RID: 12878 RVA: 0x0010808E File Offset: 0x0010628E
	private Material EPCGJFCCAFH()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-74);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600324F RID: 12879 RVA: 0x0002523B File Offset: 0x0002343B
	private void LEAHIBJDMBI()
	{
	}

	// Token: 0x06003250 RID: 12880 RVA: 0x00107665 File Offset: 0x00105865
	private void HNILMGEKDEC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003251 RID: 12881 RVA: 0x00107665 File Offset: 0x00105865
	private void JNALDALAJLG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003252 RID: 12882 RVA: 0x00107665 File Offset: 0x00105865
	private void BNEJMABFKJE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003253 RID: 12883 RVA: 0x001080C5 File Offset: 0x001062C5
	private Material ADBKPGFMNKO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)65;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003254 RID: 12884 RVA: 0x0002523B File Offset: 0x0002343B
	private void MMBPLGGLPDB()
	{
	}

	// Token: 0x06003255 RID: 12885 RVA: 0x001080FC File Offset: 0x001062FC
	private void JILOMOBDPIA()
	{
		this.SCShader = Shader.Find("_Far");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003256 RID: 12886 RVA: 0x00108120 File Offset: 0x00106320
	private void BKIGIIINEDH()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Blur_Focus");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003257 RID: 12887 RVA: 0x00108144 File Offset: 0x00106344
	private void ADPLHDFJFID()
	{
		this.SCShader = Shader.Find("[DiscordController] Init");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003258 RID: 12888 RVA: 0x0002523B File Offset: 0x0002343B
	private void KIEJKBNBHMD()
	{
	}

	// Token: 0x06003259 RID: 12889 RVA: 0x00108168 File Offset: 0x00106368
	private void KMCPMOGKDEH()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600325A RID: 12890 RVA: 0x0010818C File Offset: 0x0010638C
	private void MMBPPEPNNLA(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1379f)
			{
				this.HBJJOCHGOPH = 87f;
			}
			this.NLFJGMBCICG().SetFloat("CameraFilterPack_eyes_vision_2", this.HBJJOCHGOPH);
			this.BLMPMOIDGMG().SetFloat("menu.enableselectormusic", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ECCPAOBFDKP());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600325B RID: 12891 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCDJFJIBADI()
	{
	}

	// Token: 0x0600325C RID: 12892 RVA: 0x0010821C File Offset: 0x0010641C
	private Material HHIAIGCAHDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600325D RID: 12893 RVA: 0x0002523B File Offset: 0x0002343B
	private void JOACBIEHHCE()
	{
	}

	// Token: 0x0600325E RID: 12894 RVA: 0x00108254 File Offset: 0x00106454
	private void OPIBJIMIOKE(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 205f)
			{
				this.HBJJOCHGOPH = 861f;
			}
			this.OJMHIMIPKME().SetFloat("LevelNameInputField", this.HBJJOCHGOPH);
			this.IIJMIPBMMBF().SetFloat("[Singleton] multiple instances of '", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600325F RID: 12895 RVA: 0x00107665 File Offset: 0x00105865
	private void OFIMMFHFHDD()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003260 RID: 12896 RVA: 0x00108168 File Offset: 0x00106368
	private void FMNPFCHBLJF()
	{
		this.SCShader = Shader.Find("_Value3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003261 RID: 12897 RVA: 0x0002523B File Offset: 0x0002343B
	private void LJIHHJOAJCN()
	{
	}

	// Token: 0x06003262 RID: 12898 RVA: 0x001082E4 File Offset: 0x001064E4
	private void CIPKEPDELJB()
	{
		this.SCShader = Shader.Find("player.ice");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003263 RID: 12899 RVA: 0x0002523B File Offset: 0x0002343B
	private void LLDHEJIEDHO()
	{
	}

	// Token: 0x06003264 RID: 12900 RVA: 0x0002523B File Offset: 0x0002343B
	private void AIJGAJIOJDJ()
	{
	}

	// Token: 0x06003265 RID: 12901 RVA: 0x00108308 File Offset: 0x00106508
	private Material MFHPKGICPIO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)81;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003266 RID: 12902 RVA: 0x0010833F File Offset: 0x0010653F
	private void CNGAJDBOCLJ()
	{
		this.SCShader = Shader.Find("_SSAO");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003267 RID: 12903 RVA: 0x0002523B File Offset: 0x0002343B
	private void COMNAPAAPDO()
	{
	}

	// Token: 0x06003268 RID: 12904 RVA: 0x00107665 File Offset: 0x00105865
	private void OnDisable()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003269 RID: 12905 RVA: 0x0002523B File Offset: 0x0002343B
	private void DEEPMOLMGED()
	{
	}

	// Token: 0x0600326A RID: 12906 RVA: 0x00108363 File Offset: 0x00106563
	private Material ECCPAOBFDKP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)103;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600326B RID: 12907 RVA: 0x0002523B File Offset: 0x0002343B
	private void MKKJICPMPHK()
	{
	}

	// Token: 0x0600326C RID: 12908 RVA: 0x0010839A File Offset: 0x0010659A
	private Material CFCPHFMKHII()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-95);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600326D RID: 12909 RVA: 0x001083D1 File Offset: 0x001065D1
	private Material NLFJGMBCICG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)99;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600326E RID: 12910 RVA: 0x0002523B File Offset: 0x0002343B
	private void HCIPECAOGIA()
	{
	}

	// Token: 0x0600326F RID: 12911 RVA: 0x00108408 File Offset: 0x00106608
	private void FHPFJBFCOOF()
	{
		this.SCShader = Shader.Find("PenaltyScoreText");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003270 RID: 12912 RVA: 0x0010842C File Offset: 0x0010662C
	private Material CEKJODEAMGB()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.DontSaveInEditor | HideFlags.NotEditable | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003271 RID: 12913 RVA: 0x00108463 File Offset: 0x00106663
	private void Start()
	{
		this.SCShader = Shader.Find("CameraFilterPack/Drawing_Manga3");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003272 RID: 12914 RVA: 0x00108487 File Offset: 0x00106687
	private Material MHBAIEKFBIJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInInspector | HideFlags.DontSaveInEditor);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003273 RID: 12915 RVA: 0x001084BE File Offset: 0x001066BE
	private void ODBNMPGBCGO()
	{
		this.SCShader = Shader.Find("Operation failed: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003274 RID: 12916 RVA: 0x001084E4 File Offset: 0x001066E4
	private void PJKAGNNNFGK(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 765f)
			{
				this.HBJJOCHGOPH = 217f;
			}
			this.OJMHIMIPKME().SetFloat("itemdefid[0]", this.HBJJOCHGOPH);
			this.BLMPMOIDGMG().SetFloat("HitVariationSlider", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.EFMCNLELMDO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003275 RID: 12917 RVA: 0x00108574 File Offset: 0x00106774
	private void FANADGBGCPI()
	{
		this.SCShader = Shader.Find("1332644700");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003276 RID: 12918 RVA: 0x0002523B File Offset: 0x0002343B
	private void LPMINJJPDCH()
	{
	}

	// Token: 0x06003277 RID: 12919 RVA: 0x00107665 File Offset: 0x00105865
	private void OFMNDBNFBDJ()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003278 RID: 12920 RVA: 0x00108598 File Offset: 0x00106798
	private void PACLEGDKKPI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 897f)
			{
				this.HBJJOCHGOPH = 300f;
			}
			this.MFHPKGICPIO().SetFloat("No Name", this.HBJJOCHGOPH);
			this.EPBAAGMGPAP().SetFloat("STICKRVER", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MFHPKGICPIO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003279 RID: 12921 RVA: 0x00108628 File Offset: 0x00106828
	private void CGIMPFJPEKD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 893f)
			{
				this.HBJJOCHGOPH = 1379f;
			}
			this.LPDOGGFOBDH().SetFloat("EditMenu", this.HBJJOCHGOPH);
			this.DOMEEFLPEPJ().SetFloat("menu.playedsolo", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ALABBJPHCNG());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600327A RID: 12922 RVA: 0x0002523B File Offset: 0x0002343B
	private void JBMBNKOOENB()
	{
	}

	// Token: 0x0600327B RID: 12923 RVA: 0x001086B8 File Offset: 0x001068B8
	private Material BLMPMOIDGMG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x0600327C RID: 12924 RVA: 0x001086F0 File Offset: 0x001068F0
	private void IFMHIDNCFFH(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1981f)
			{
				this.HBJJOCHGOPH = 1926f;
			}
			this.LPDOGGFOBDH().SetFloat("BitsData", this.HBJJOCHGOPH);
			this.NBPKMLMCHFN.SetFloat("_AdaptationMax", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600327D RID: 12925 RVA: 0x00108780 File Offset: 0x00106980
	private void MKIMDFLBFOM()
	{
		this.SCShader = Shader.Find("Fade");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600327E RID: 12926 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKHPNHBEKHA()
	{
	}

	// Token: 0x0600327F RID: 12927 RVA: 0x001087A4 File Offset: 0x001069A4
	private Material EFMCNLELMDO()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003280 RID: 12928 RVA: 0x001087DB File Offset: 0x001069DB
	private Material FLGPDBBKAIP()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)96;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003281 RID: 12929 RVA: 0x0002523B File Offset: 0x0002343B
	private void OCMKCBBCEFG()
	{
	}

	// Token: 0x06003282 RID: 12930 RVA: 0x00107665 File Offset: 0x00105865
	private void FDMAEPOHDMK()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003283 RID: 12931 RVA: 0x0002523B File Offset: 0x0002343B
	private void PKGJJFIFLII()
	{
	}

	// Token: 0x06003284 RID: 12932 RVA: 0x00108814 File Offset: 0x00106A14
	private void KKHCDAPLABD(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 523f)
			{
				this.HBJJOCHGOPH = 1232f;
			}
			this.LPDOGGFOBDH().SetFloat("#", this.HBJJOCHGOPH);
			this.HHIAIGCAHDA().SetFloat("You need to have a child LayoutGroup content set for the list: ", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003285 RID: 12933 RVA: 0x001088A4 File Offset: 0x00106AA4
	private void LKBOEPPBLIF(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 906f)
			{
				this.HBJJOCHGOPH = 29f;
			}
			this.ILKALHDJBFE().SetFloat("Yes", this.HBJJOCHGOPH);
			this.CFCPHFMKHII().SetFloat("_Value", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.FGENHBKMPDA());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003286 RID: 12934 RVA: 0x00108934 File Offset: 0x00106B34
	private Material HEHKGPKLAKK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags.HideInInspector | HideFlags.DontSaveInEditor | HideFlags.DontSaveInBuild);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003287 RID: 12935 RVA: 0x0010896C File Offset: 0x00106B6C
	private void FIKNBPAIFBI(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1521f)
			{
				this.HBJJOCHGOPH = 588f;
			}
			this.HHIAIGCAHDA().SetFloat("gameVolume", this.HBJJOCHGOPH);
			this.DCCHGBHLAAF().SetFloat("_Value2", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.MHBAIEKFBIJ());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003288 RID: 12936 RVA: 0x001089FC File Offset: 0x00106BFC
	private void PMPKMGKAAJH()
	{
		this.SCShader = Shader.Find("_MatrixColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003289 RID: 12937 RVA: 0x00108A20 File Offset: 0x00106C20
	private void AMKFLDKCIJO(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 87f)
			{
				this.HBJJOCHGOPH = 1231f;
			}
			this.OJMHIMIPKME().SetFloat("ViewMenu", this.HBJJOCHGOPH);
			this.DCCHGBHLAAF().SetFloat("workshop.", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.HNFFHCLNBDN());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x0600328A RID: 12938 RVA: 0x00107665 File Offset: 0x00105865
	private void PKBENONAOOL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600328B RID: 12939 RVA: 0x00108AB0 File Offset: 0x00106CB0
	private void AEDDNDHCLNN()
	{
		this.SCShader = Shader.Find("itemdefid[0]");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600328C RID: 12940 RVA: 0x00108AD4 File Offset: 0x00106CD4
	private void PCHCFIOHIKK()
	{
		this.SCShader = Shader.Find("https://bitbucket.org/khb-soft/intralismarcsviewer/");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600328D RID: 12941 RVA: 0x00107665 File Offset: 0x00105865
	private void MKFLBEGJJDC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600328E RID: 12942 RVA: 0x0002523B File Offset: 0x0002343B
	private void KKLMPKLKAEM()
	{
	}

	// Token: 0x0600328F RID: 12943 RVA: 0x00108AF8 File Offset: 0x00106CF8
	private void GIGMHPHPCHJ()
	{
		this.SCShader = Shader.Find("RecordButton");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = true;
			return;
		}
	}

	// Token: 0x06003290 RID: 12944 RVA: 0x00108B1C File Offset: 0x00106D1C
	private void JABNHMIHBHC()
	{
		this.SCShader = Shader.Find("_DiffuseColor");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003291 RID: 12945 RVA: 0x00107665 File Offset: 0x00105865
	private void PGMMBADJIKH()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003292 RID: 12946 RVA: 0x00108B40 File Offset: 0x00106D40
	private Material INOBFNCKFGK()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = ~(HideFlags.HideInHierarchy | HideFlags.HideInInspector | HideFlags.NotEditable | HideFlags.DontSaveInBuild | HideFlags.DontUnloadUnusedAsset);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003293 RID: 12947 RVA: 0x00108B77 File Offset: 0x00106D77
	private Material ALABBJPHCNG()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-89);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x06003294 RID: 12948 RVA: 0x00107665 File Offset: 0x00105865
	private void EDCMIPNCPLB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003295 RID: 12949 RVA: 0x00108BB0 File Offset: 0x00106DB0
	private void NEIOOEKEOPC(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 925f)
			{
				this.HBJJOCHGOPH = 1868f;
			}
			this.IIJMIPBMMBF().SetFloat("_Value", this.HBJJOCHGOPH);
			this.ILKALHDJBFE().SetFloat("_ScreenResolution", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.DIOAAHJDMLK());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003296 RID: 12950 RVA: 0x00108C40 File Offset: 0x00106E40
	private void HAIAHJPCPAG()
	{
		this.SCShader = Shader.Find("white");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x06003297 RID: 12951 RVA: 0x00108C64 File Offset: 0x00106E64
	private void OPKNFOGMGII(RenderTexture AAACLELCPML, RenderTexture BGIKADHFKNF)
	{
		if (this.SCShader != null)
		{
			this.HBJJOCHGOPH += Time.deltaTime;
			if (this.HBJJOCHGOPH > 1101f)
			{
				this.HBJJOCHGOPH = 1316f;
			}
			this.FGENHBKMPDA().SetFloat("settings.enablehitsoundsinnormal", this.HBJJOCHGOPH);
			this.ALABBJPHCNG().SetFloat("maps.", this.DotSize);
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF, this.ADBKPGFMNKO());
		}
		else
		{
			Graphics.Blit(AAACLELCPML, BGIKADHFKNF);
		}
	}

	// Token: 0x06003298 RID: 12952 RVA: 0x00107665 File Offset: 0x00105865
	private void IFJDKDFLGBG()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x06003299 RID: 12953 RVA: 0x00108CF4 File Offset: 0x00106EF4
	private void DIPDEHOOBPG()
	{
		this.SCShader = Shader.Find("1177138211");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600329A RID: 12954 RVA: 0x0002523B File Offset: 0x0002343B
	private void LCJHDLKJEOM()
	{
	}

	// Token: 0x0600329B RID: 12955 RVA: 0x00108D18 File Offset: 0x00106F18
	private void NNFMIAFHMJM()
	{
		this.SCShader = Shader.Find("UnityEngine.MonoBehaviour");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x0600329C RID: 12956 RVA: 0x00107665 File Offset: 0x00105865
	private void EJJEDJIOFAB()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600329D RID: 12957 RVA: 0x0002523B File Offset: 0x0002343B
	private void PBEPCAPAKLG()
	{
	}

	// Token: 0x0600329E RID: 12958 RVA: 0x00107665 File Offset: 0x00105865
	private void GBGAMCPNBCC()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x0600329F RID: 12959 RVA: 0x00108D3C File Offset: 0x00106F3C
	private Material IIJMIPBMMBF()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)64;
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060032A0 RID: 12960 RVA: 0x00107665 File Offset: 0x00105865
	private void ELDMKIAPNGP()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060032A1 RID: 12961 RVA: 0x0002523B File Offset: 0x0002343B
	private void JFMIDILENDO()
	{
	}

	// Token: 0x060032A2 RID: 12962 RVA: 0x00108D73 File Offset: 0x00106F73
	private Material DOMEEFLPEPJ()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-107);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060032A3 RID: 12963 RVA: 0x00108DAA File Offset: 0x00106FAA
	private Material FNAFGEMJBDA()
	{
		if (this.BJFKDHHMLJH == null)
		{
			this.BJFKDHHMLJH = new Material(this.SCShader);
			this.BJFKDHHMLJH.hideFlags = (HideFlags)(-117);
		}
		return this.BJFKDHHMLJH;
	}

	// Token: 0x060032A4 RID: 12964 RVA: 0x00108DE1 File Offset: 0x00106FE1
	private void GPNAOAKCMHC()
	{
		this.SCShader = Shader.Find("\" error: ");
		if (!SystemInfo.supportsImageEffects)
		{
			base.enabled = false;
			return;
		}
	}

	// Token: 0x060032A5 RID: 12965 RVA: 0x00107665 File Offset: 0x00105865
	private void PHJLHCMCCKE()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060032A6 RID: 12966 RVA: 0x00107665 File Offset: 0x00105865
	private void CMIBEOJGAIL()
	{
		if (this.BJFKDHHMLJH)
		{
			UnityEngine.Object.DestroyImmediate(this.BJFKDHHMLJH);
		}
	}

	// Token: 0x060032A7 RID: 12967 RVA: 0x0002523B File Offset: 0x0002343B
	private void BMODOIJGIOO()
	{
	}

	// Token: 0x040005B1 RID: 1457
	public Shader SCShader;

	// Token: 0x040005B2 RID: 1458
	private float HBJJOCHGOPH = 1f;

	// Token: 0x040005B3 RID: 1459
	private Material BJFKDHHMLJH;

	// Token: 0x040005B4 RID: 1460
	[Range(1f, 8f)]
	public float DotSize = 4.72f;
}
